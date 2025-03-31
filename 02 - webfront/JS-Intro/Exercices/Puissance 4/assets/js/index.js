const appPuissanceQuatre = {
    data() {
        return {
            player1: 'Rouge',
            player2: 'Jaune',
            currentPlayer: 'Rouge',
            winner: null,
            gameOver: false,
        }
    },
    computed: {
        getCurrentPlayer() {
            return this.currentPlayer === 'Rouge' ? 'Rouge' : 'Jaune';
        }
    },
    methods: {
        startGame() {
            this.currentPlayer = 'Rouge';
            this.winner = null;
            this.gameOver = false;
        },
        changePlayer() {
            this.currentPlayer = this.currentPlayer === 'Rouge' ? 'Jaune' : 'Rouge';
        },
        checkWinner(player) {
            if (this.$refs.grid.checkWin(player)) {
                this.winner = player;
                this.gameOver = true;
            }
        },
        resetGame() {
            this.startGame();
        },
        test(){
            console.log(event);

        }
    }
}
Vue.createApp(appPuissanceQuatre).mount('#app');