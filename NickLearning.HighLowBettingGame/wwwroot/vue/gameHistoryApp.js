var gameHistoryApp = new Vue({
    el: '#gameHistoryApp',
    data: {
        gameData:
            [
                {
                    gameNum: 1,
                    winLose: true,
                    amount: 100,
                },
                {
                    gameNum: 2,
                    winLose: false,
                    amount: 350,
                },
                {
                    gameNum: 3,
                    winLose: true,
                    amount: 570,
                },
            ]
    },
    mounted: function () {
    }
})