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
            //         console.log(counter, i);
            //     }
            // }
            
            // if (counter === 4) {
            //     alert('Victoire en vertical de ' + this.getCurrentPlayer + ', avec ' + counter + ' points.');
            // }
            
            // counter = 1;
            // rowPlayer = row;
            // columnPlayer = column;
            
            for (let i = 1; i < 4; i++) {
                columnPlayer++;
                rowPlayer++;
                
                if (columnPlayer <= this.nbColumnOfP4 && rowPlayer <= nbRowOfP4 && this.matrix[rowPlayer][columnPlayer] === this.getCurrentPlayer && counter < 4) {
                    counter++;
                }
                else {
                    i = 4;
                    console.log(counter, i);

                    // let rowPlayer = row;
                    // let columnPlayer = column;

                    // for (let j = 0; j < 4; j++) {
                    //     columnPlayer--;

                    //     if (columnPlayer >= 0 && this.matrix[rowPlayer][columnPlayer] === this.getCurrentPlayer && counter < 4) {
                    //         counter++;

                    //     }
                    //     else {
                    //         j = 4;
                    //     }
                    // }
                }
            }

            if (counter === 4) {
                alert('Victoire en horizontal de ' + this.getCurrentPlayer + ', avec ' + counter + ' points.');
            }

            // console.log('column : ' + column, 'columnPlayer : ' + columnPlayer, ' counter : ' + counter, this.matrix[row][column], this.getCurrentPlayer, ' nb : ' + this.nbColumnOfP4);
            // console.log('counter : ' + counter);

            // if (columnPlayer >= 0 && columnPlayer < this.nbColumnOfP4 && this.matrix[columnPlayer][column] === this.getCurrentPlayer) {
            //     counter++;
            //     console.log('column : ' + column, 'columnPlayer : ' + columnPlayer, ' column : ' + column, ' column : ' + counter);

            //     if (counter === 4) {
            //         this.gameOver = true;
            //         this.winner = this.getCurrentPlayer;
            //         console.log('if', this.winner);
            //         return this.winner;
            //         console.log(columnPlayer, column, column, counter);
            //     }

            //     columnPlayer++;
            // }
            // else { i = 4; }
            // }


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
            this.matrix[row][column] = this.getCurrentPlayer;
            this.checkWinner(row, column);
            console.log(row, column);
            

            if (column !== -1) {
                this.changePlayer();
            }
        }
    }
}
Vue.createApp(appPuissanceQuatre).mount('#app');