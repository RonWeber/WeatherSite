var Weather = {};

Weather.Marine = (function () {
    function init() {
        $('#tree').treeview({ data: locations });
        $('#tree').on('nodeSelected', function (event, node) {
            if (node.url)
            {
                setForecastScreen(node);
            }
        });
    };

    function setForecastScreen(forecast) {
       getForecast(forecast);

        $('#tree').treeview('collapseAll', { silent: true });
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

    function getForecast(forecast) {

        $.ajax({
            url: 'MarineForecast?url=' + forecast.url,
            success: function (response) {
                var words = response;

                        var _belowMainContainer = $("#belowMainContainer");
                        _belowMainContainer.empty();
                        _belowMainContainer.append("<label class='words_med' >" + forecast.text + "</label><br/><br/>");
                        _belowMainContainer.append( words);
            },
            error: function (response) { alert(response) }
        });
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