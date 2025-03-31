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
            lenghtOfPower4: 7,
            heightOfPower4: 6,

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

            this.play(y);
        },
        checkWinner(x, y) {
            let counter = 0;

            console.log(this.matrix[x][y], this.getCurrentPlayer, x, y, counter);

            // for (let i = 1; i <= 4; i++) {
            //     let xPlayer = x * i;
            //     let yPlayer = y * i;
            //     // this.checkDirection(x, y, counter, i);
            //     // this.checkDirection(x, y, counter, -i);

            //     if (xPlayer >= 0 && xPlayer < this.lenghtOfPower4 && this.matrix[xPlayer][y] === this.getCurrentPlayer) {
            //         counter++;
            //         console.log(xPlayer, x, y, counter);

            //         // if (counter === 4) {
            //         //     this.gameOver = true;
            //         //     this.winner = this.getCurrentPlayer;
            //         //     console.log('if', this.winner);
            //         // return this.winner;
            //         console.log(xPlayer, x, y, counter);
            //         // }

            //         xPlayer++;
            //     }
            //     else { i = 4; }
            // }


            // if (this.matrix[x][y] === null)
            //     return this.winner = null;
        },
        // checkDirection(x, y, counter, i) {

        //     if (x >= 0 && x < this.lenghtOfPower4 && y >= 0 && y < this.heightOfPower4 && this.matrix[x][y] === this.getCurrentPlayer) {
        //         counter++;
        //         x + i;
        //         console.log('cD', counter);
        //     }
        // },
        changePlayer() {
            this.currentPlayer = this.getCurrentPlayer === this.player1.color ? this.player2.color : this.player1.color;
        },
        resetGame() {
            this.startGame();
        },
        play(y) {


            const currentColumn = this.matrix.map(row => row[y]);
            const x = currentColumn.lastIndexOf(null);
            this.matrix[x][y] = this.getCurrentPlayer;
            this.checkWinner(x, y);

            if (y !== -1) {
                this.changePlayer();
            }
        }
    }
}
Vue.createApp(appPuissanceQuatre).mount('#app');