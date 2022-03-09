var url = 'https://api.weatherapi.com/v1/current.json?key=1df94f076a6d400293225723220803&q=windsor&aqi=yes';

/// fetch time and day according to that send the info
//var d = Date.now();
//d.getHours();
//d.getMinutes();
//var date = d.toISOString().substr(11, 8);
//console.log(date);

var today = new Date();
var time = today.getHours() + ":" + today.getMinutes();
var date = time.toString();
//console.log("Time:" + time);

var temperature =
    fetch(url)
    .then(response => response.json())
        .then((data) => {
            var temp = data.current.temp_c;
            console.log("Temperature" + temp)
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




