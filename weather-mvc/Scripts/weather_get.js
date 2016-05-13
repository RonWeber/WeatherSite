/// <reference path="./jquery.d.ts" />
var responseIsDaily;
function weatherIsReady(data, textStatus, jqXHR) {
    if (data && data.city) {
        var table = "<b>" + data.city.name + "</b><br/>";
        table += "<table id=\"weatherTable\">";
        table += "";
        if (responseIsDaily) {
            table += "<tr><th>Day</th><th>Weather</th><th>Temperature Low</th><th>Temperature High</th><th>Humidity</th>";
        }
        else {
            table += "<tr><th>Time</th><th>Weather</th><th>Temperature</th><th>Humidity</th>";
        }
        table += "</tr>";
        for (var i = 0; i < data.list.length; i++) {
            table += "<tr>";
            if (responseIsDaily) {
                table += "<td>" + new Date(data.list[i].dt * 1000).toDateString() + "</td>";
            }
            else {
                table += "<td>" + data.list[i].dt_txt + "</td>";
            }
            table += "<td>" + '<img class="weather_icon" src="http://openweathermap.org/img/w/' + data.list[i].weather[0].icon + '.png" />';
            table += data.list[i].weather[0].description + "</td>";
            if (responseIsDaily) {
                table += "<td>" + data.list[i].temp.min + "</td>";
                table += "<td>" + data.list[i].temp.max + "</td>";
                if (data.list[i].humidity)
                    table += "<td>" + data.list[i].humidity + "%</td>";
            }
            else {
                table += "<td>" + data.list[i].main.temp + "</td>";
                table += "<td>" + data.list[i].main.humidity + "%</td>";
            }
            table += "</tr>";
        }
        table += "</table>";
        $('#divWeather').html(table);
    }
    else {
        $('#divWeather').html("Come on, that's not a real city");
    }
}
$(function () {
    //Document is ready.
    $("#weatherGet").click(function () {
        $('#divWeather').html('');
        responseIsDaily = $("#dailyWeather").is(":checked");
        var cityText = document.getElementById("cityText");
        var city = cityText.value;
        var url = "http://api.openweathermap.org/data/2.5/forecast";
        if (responseIsDaily) {
            url += "/daily";
        }
        url += "?q=" + city + ",us&units=imperial&APPID=973750fb2a9176013240a683b5f49e59";
        jQuery.get(url, undefined, weatherIsReady, "json");
    });
    $("#body").keydown(function (event) {
        if (event.keyCode == 13) {
            $("#weatherGet").trigger('click');
        }
    });
});
