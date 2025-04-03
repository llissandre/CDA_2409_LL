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

            this.play(column);
        },
        checkWinner(row, column) {
            let counter = 1;
            let rowPlayer = row;
            let columnPlayer = column;

            // for (let i = 1; i < 4; i++) {
            //     columnPlayer++;

            //     if (columnPlayer <= this.nbColumnOfP4 && this.matrix[rowPlayer][columnPlayer] === this.getCurrentPlayer && counter < 4) {
            //         counter++;
            //     }
            //     else {
            //         i = 4;

            //         let rowPlayer = row;
            //         let columnPlayer = column;

            //         for (let j = 0; j < 4; j++) {
            //             columnPlayer--;

            //             if (columnPlayer >= 0 && this.matrix[rowPlayer][columnPlayer] === this.getCurrentPlayer && counter < 4) {
            //                 counter++;
            //             }
            //             else {
            //                 j = 4;
            //             }
            //         }
            //     }
            // }

            // if (counter === 4) {
            //     alert('Victoire en horizontal de ' + this.getCurrentPlayer + ', avec ' + counter + ' points.');
            // }

            // counter = 1;
            // rowPlayer = row;
            // columnPlayer = column;

            // for (let i = 1; i < 4; i++) {
            //     rowPlayer++;

            //     if (rowPlayer <= this.nbRowOfP4 && this.matrix[rowPlayer][columnPlayer] === this.getCurrentPlayer && counter < 4) {
            //         counter++;
            //     }
            //     else {
            //         i = 4;

            //         let rowPlayer = row;
            //         let columnPlayer = column;

            //         for (let j = 0; j < 4; j++) {
            //             rowPlayer--;

            //             if (rowPlayer > 0 && this.matrix[rowPlayer][columnPlayer] === this.getCurrentPlayer && counter < 4) {
            //                 counter++;
            //             }
            //             else {
            //                 j = 4;
            //             }
            //         }
            //     }
            // }

            // if (counter === 4) {
            //     alert('Victoire en vertical de ' + this.getCurrentPlayer + ', avec ' + counter + ' points.');
            // }

            // counter = 1;
            // rowPlayer = row;
            // columnPlayer = column;

            for (let i = 1; i < 4; i++) {
                console.log(counter, i, this.matrix[rowPlayer][columnPlayer], this.getCurrentPlayer);
                console.log(rowPlayer, columnPlayer);
                columnPlayer++;
                rowPlayer++;

                if (columnPlayer <= this.nbColumnOfP4 && rowPlayer <= this.nbRowOfP4) {

                    if (this.matrix[rowPlayer][columnPlayer] === this.getCurrentPlayer && counter < 4) {
                        counter++;
                        console.log(counter);

                    }
                }
                else {
                    i = 4;
                    console.log(i);


                    let rowPlayer = row;
                    let columnPlayer = column;

                    for (let j = 0; j < 4; j++) {
                        columnPlayer--;

                        if (columnPlayer >= 0 && this.matrix[rowPlayer][columnPlayer] === this.getCurrentPlayer && counter < 4) {
                            counter++;
                        }
                        else {
                            j = 4;
                        }
                    }
                }
            }

            if (counter === 4) {
                alert('Victoire en diagonale de ' + this.getCurrentPlayer + ', avec ' + counter + ' points.');
            }
        },
        checkDirection(row, column, counter, i) {

        },
        changePlayer() {
            this.currentPlayer = this.getCurrentPlayer === this.player1.color ? this.player2.color : this.player1.color;
        },
        resetGame() {
            this.startGame();
        },
        play(column) {
            const currentColumn = this.matrix.map(row => row[column]);
            const row = currentColumn.lastIndexOf(null);

            console.log(column, row);

            if (row !== -1) {
                this.matrix[row][column] = this.getCurrentPlayer;
                this.checkWinner(row, column);
                this.changePlayer();
            }
        }
    }
}
Vue.createApp(appPuissanceQuatre).mount('#app');