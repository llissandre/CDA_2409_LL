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
            // player1: 'red',
            // player2: 'yellow',
            currentPlayer: 'red',
            winner: null,
            gameOver: false,
            matrix: [...Array(6)].map(() => Array(7).fill(null)),
        }
    },
    computed: {
        getCurrentPlayer() {
            return this.currentPlayer === this.player1.color ? this.player1.color : this.player2.color;
        }
    },
    methods: {
        startGame() {
            this.currentPlayer = this.player1.color;
            this.winner = null;
            this.gameOver = false;
        },
        changePlayer() {
            this.currentPlayer = this.getCurrentPlayer === this.player1.color ? this.player2.color : this.player1.color;
        },
        checkWinner(x, y) {
            let counter = 0;
            let xPlayer = x;
            let yPlayer = y;

            console.log(x, y);
            console.log(this.matrix[x][y]);
            

            for (i = 0; i >= 0 && i < this.matrix.length && this.matrix[x][y] === this.getCurrentPlayer; i++) {
                counter++;
                console.log(x, y, i, counter);

                if (counter === 4) {
                    this.gameOver = true;
                    this.winner = this.getCurrentPlayer;
                }

                x++;
            }
        },
        resetGame() {
            this.startGame();
        },
        play(y) {
            const currentColumn = this.matrix.map(row => row[y]);
            const x = currentColumn.lastIndexOf(null);

            if (x !== -1) {
                this.matrix[x][y] = this.getCurrentPlayer;
                this.changePlayer();
                this.checkWinner(x, y);
            }
        }
    }
}
Vue.createApp(appPuissanceQuatre).mount('#app');