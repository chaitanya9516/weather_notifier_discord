var url = 'https://api.openweathermap.org/data/2.5/weather?q=Windsor&appid=8214442dc93453b08f8531fbe4875c84';

var temp =
    fetch(url)
    .then(response => response.json())
        .then((data) => {
            var temp2 = data.main.temp;
            console.log(temp2)
            $.ajax({
                url: "/home/index",
                type: "POST",
                data: {temp:temp2},
                success: function (data) {
                    console.log(data);

                },
                error: function (err) {
                    console.log(err)
                }
            });
        });




