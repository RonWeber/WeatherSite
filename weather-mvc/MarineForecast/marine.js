var Weather = {};

Weather.Marine = (function () {
    function init() {
        $('#mainContainer').treeview({ data: locations });
        $('#mainContainer').on('nodeSelected', function (event, node) {
            if (node.url)
            {
                setForecastScreen(node);
            }
        });
    };

    function setForecastScreen(forecast) {
        var _mainContainer = $("#mainContainer");
        _mainContainer.empty();
        _mainContainer.append(makeBackButton());
        _mainContainer.append("<label class='words_med' >" + forecast.text + "</label><hr/>");

        _mainContainer.append(forecast.url);

        var words = getForecast(forecast.url);

        var _belowMainContainer = $("#belowMainContainer");
        _belowMainContainer.empty();
        _belowMainContainer.append(words);
    }

    function makeBackButton() {
        var backButton = $('<button/>', {
            type: 'button',
            id: 'backButton',
            text: 'Start Over',
            class: 'btn btn-default',
            click: function () {
                setMainScreen();
            }
        });
        return backButton;
    }

    function getForecast(url) {
        var _fullUrl = "http://weather.noaa.gov/cgi-bin/fmtbltn.pl?file=forecasts/marine" + url;

        var _iframe = $('<iframe>', {
            src: _fullUrl,
            width: '90%',
            height: '100%'
        });
        return _iframe;
    }


    //Events
    function backButtonClicked() {
        this.init();
    }

    function locationButtonClicked(index) {
        currentLocation = locations[index];
        currentZone = {};
        currentSubZone = {};
        setLocationScreen(currentLocation);
    }

    function zoneButtonClicked(index) {
        currentZone = currentLocation.zones[index];
        currentSubZone = {};
        setZoneScreen(currentZone);
    }

    function subZoneButtonClicked(index) {
        currentSubZone = currentZone.subZones[index];
        setSubZoneScreen(currentSubZone);
    }

    function forecastButtonClicked(index) {        
        setForecastScreen(currentSubZone.forecasts[index]);
    }

//Any functions declared in this 'return' function act like public functions (all other functions are private)
    return {
        init: init
    }
})();