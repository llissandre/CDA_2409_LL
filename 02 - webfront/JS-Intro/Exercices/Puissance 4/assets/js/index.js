const appPuissanceQuatre = {
    data() {
        return {
            player1: {
                name: 'Player 1',
                color: 'red',
                score: 0
            },
            player2: {
                name: 'Player 2',
                color: 'yellow',
                score: 0
            },
            nbColumnOfP4: 6,
            nbRowOfP4: 5,

            currentPlayerColor: 'red',
            winningTokens: [],
            winner: null,
            gameOver: false,
            matrix: [],
            hoveredColumn: null
        }
    },
    computed: {
        getCurrentPlayer() {
            return this.currentPlayerColor === this.player1.color ? this.player1 : this.player2;
        },
        isEmpty() {
            return this.matrix.every(row => row.every(column => column === null));
        },
        manageStateMessage() {
            if (this.winner) {
                return this.winner.name + ' a gagné cette manche !';
            } else if (this.gameOver) {
                return "Match nul!";
            } else if (this.isEmpty) {
                return "Plateau de jeu vide";
            } else {
                return 'Partie en cours, au tour de ' + this.getCurrentPlayer.name + '('
                    + this.getCurrentPlayer.color + ')' + " de jouer";
            }
        }
    },
    mounted() {
        this.initMatrix(),
        this.loadScores()
    },
    methods: {
        initMatrix() {
            this.matrix = [...Array(this.nbRowOfP4 + 1)].map(() => Array(this.nbColumnOfP4 + 1).fill(null));
        },
        getPreviewToken(row, column) {
            if (this.hoveredColumn !== column || this.matrix[row][column] !== null ||
                this.gameOver || this.winner) return '';
            const columnTokens = this.matrix.map(row => row[column]);
            return columnTokens.lastIndexOf(null) === row ? 'preview-' + this.getCurrentPlayer.color : '';
        },
        resetGame() {
            this.currentPlayerColor = this.player1.color;
            this.winner = null;
            this.gameOver = false;
            this.winningTokens = []; // Reset les contours gold
            this.initMatrix();
        },
        resetScore() {
            this.player1.score = 0;
            this.player2.score = 0;
            this.saveScores();
        },
        play(column) {
            if (this.gameOver || this.winner) return;
            const currentColumn = this.matrix.map(row => row[column]);
            const row = currentColumn.lastIndexOf(null);

            if (row !== -1) {
                this.matrix[row][column] = this.currentPlayerColor;

                if (this.checkWinner(row, column)) {
                    this.winner = this.getCurrentPlayer;
                    this.winner.score++;
                    this.saveScores();
                    this.gameOver = true;
                }
                else if (this.isFull()) {
                    //Match nul
                    this.gameOver = true;
                }
                else {
                    this.changePlayer();
                }
            }
        },
        changePlayer() {
            this.currentPlayerColor = this.getCurrentPlayer.color === this.player1.color ? this.player2.color : this.player1.color;
        },
        isFull() {
            return this.matrix.every(row => row.every(column => column !== null));
        },

        isWinningToken(row, column) {
            return this.winningTokens.some(token => token.row === row && token.column === column);
        },
        checkWinner(row, column) {
            const directions = [
                { rowDir: 0, columnDir: 1 },   // Horizontal --
                { rowDir: 1, columnDir: 0 },   // Vertical |
                { rowDir: 1, columnDir: 1 },   // Diagonale \
                { rowDir: -1, columnDir: 1 },  // Diagonale /
            ];

            for (const { rowDir, columnDir } of directions) {
                const line = [{ row, column }];

                // Avant
                let r = row - rowDir;
                let c = column - columnDir;
                while (
                    r >= 0 && r <= this.nbRowOfP4 &&
                    c >= 0 && c <= this.nbColumnOfP4 &&
                    this.matrix[r][c] === this.currentPlayerColor
                ) {
                    line.unshift({ row: r, column: c });
                    r -= rowDir;
                    c -= columnDir;
                }

                // Après
                r = row + rowDir;
                c = column + columnDir;
                while (
                    r >= 0 && r <= this.nbRowOfP4 &&
                    c >= 0 && c <= this.nbColumnOfP4 &&
                    this.matrix[r][c] === this.currentPlayerColor
                ) {
                    line.push({ row: r, column: c });
                    r += rowDir;
                    c += columnDir;
                }

                if (line.length >= 4) {
                    this.winningTokens = line;
                    return true;
                }
            }

            return false;
        },
        saveScores() {
            const scores = {
                player1: this.player1.score,
                player2: this.player2.score
            };
            localStorage.setItem('p4-scores', JSON.stringify(scores));
        },

        loadScores() {
            const saved = localStorage.getItem('p4-scores');
            if (saved) {
                const scores = JSON.parse(saved);
                this.player1.score = scores.player1;
                this.player2.score = scores.player2;
            }
        }
    }
}
Vue.createApp(appPuissanceQuatre).mount('#app');