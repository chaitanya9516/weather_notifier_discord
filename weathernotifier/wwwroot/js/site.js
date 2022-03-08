
var url = 'https://api.weatherapi.com/v1/current.json?key=1df94f076a6d400293225723220803&q=windsor&aqi=yes';


var temperature =
    fetch(url)
    .then(response => response.json())
        .then((data) => {
            var temp = data.current.temp_c;
            console.log(temp)
            $.ajax({
                url: "/home/index",
                type: "POST",
                data: {temperature:temp},
                success: function (data) {
                    console.log(data);

                },
                error: function (err) {
                    console.log(err)
                }
            });
        });




