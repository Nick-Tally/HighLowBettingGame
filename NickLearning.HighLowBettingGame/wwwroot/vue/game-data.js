Vue.component("game-data",
    {
        props: {
            value: {
                gameNum: Number,
                winLose: Boolean,
                amount: Number,
            }
        },
        computed: {
            gameResult: function () {
                return this.value.winLose == true ? "Won" : "Lost";
            },
            backColor: function () {
                return this.value.winLose == true ? "bg-success" : "bg-danger";
            }

        },
        mounted: function () {
        },
    });