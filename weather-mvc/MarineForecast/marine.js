var Weather = {};

Weather.Marine = (function () {
    var currentLocation = {};
    var currentZone = {};
    currentSubZone = {};

    function init() {
        setMainScreen();
    };

    function setMainScreen() {
        //Reset any previous browses
        currentLocation = {};
        currentZone = {};
        currentSubZone = {};

        //locations is passed in the locations.js file (which needs to be loaded before we get here)
        var _mainContainer = $("#mainContainer");
        _mainContainer.empty();
        _mainContainer.append("<label class='words_big' >Please Select an Area</label><hr/>");
        for (var i = 0; i < locations.length; i++) {
            //var loc = locations[i];
            var loc = jQuery.extend(true, {}, locations[i]);
            var _locationButton = $('<button/>', {
                type: 'button',
                name: 'locationButton',
                text: loc.title,
                index: i,
                value: i,
                on: {
                    click: function () {
                        locationButtonClicked(this.value);
                    }
                }
            });
            _mainContainer.append(_locationButton);
            _mainContainer.append("<br/>");
        };
    };

    function setLocationScreen(location) {
        var _mainContainer = $("#mainContainer");
        _mainContainer.empty();
        _mainContainer.append(makeBackButton());
        _mainContainer.append("<label class='words_med' >" + location.title + "</label><hr/>");
        for (var i = 0; i < location.zones.length; i++) {
            var zone = location.zones[i];
            var _zoneButton = $('<button/>', {
                type: 'button',
                name: 'zoneButton',
                text: zone.title,
                value: i,
                on: {
                    click: function () {
                        zoneButtonClicked(this.value);
                    }
                }
            });
            _mainContainer.append(_zoneButton);
            _mainContainer.append("<br/>");
        }
    }

    function setZoneScreen(zone) {
        var _mainContainer = $("#mainContainer");
        _mainContainer.empty();
        _mainContainer.append(makeBackButton());
        _mainContainer.append("<label class='words_med' >" + currentLocation.title + "->" + zone.title + "</label><hr/>");
        for (var i = 0; i < zone.subZones.length; i++) {
            var subZone = zone.subZones[i];
            var _subZoneButton = $('<button/>', {
                type: 'button',
                name: 'subZoneButton',
                text: subZone.title,
                value: i,
                on: {
                    click: function () {
                        subZoneButtonClicked(this.value);
                    }
                }
            });
            _mainContainer.append(_subZoneButton);
            _mainContainer.append("<br/>");
        }
    }

    function setSubZoneScreen(subZone) {
        var _mainContainer = $("#mainContainer");
        _mainContainer.empty();
        _mainContainer.append(makeBackButton());
        _mainContainer.append("<label class='words_med' >" + currentLocation.title + "->" + currentZone.title + "->" + subZone.title + "</label><hr/>");
        for (var i = 0; i < subZone.forecasts.length; i++) {
            var forecast = subZone.forecasts[i];
            var _forecastButton = $('<button/>', {
                type: 'button',
                name: 'foreButton',
                text: forecast.Description,
                value: i,
                on: {
                    click: function () {
                        forecastButtonClicked(this.value);
                    }
                }
            });
            _mainContainer.append(_forecastButton);
            _mainContainer.append("<br/>");
        }
    }


    function setForecastScreen(forecast) {
        var _mainContainer = $("#mainContainer");
        _mainContainer.empty();
        _mainContainer.append(makeBackButton());
        _mainContainer.append("<label class='words_med' >" + forecast.Description + "</label><hr/>");

        _mainContainer.append(forecast.url);

        var words = getForecast(forecast.url);
        _mainContainer.append(words);
    }

    function makeBackButton() {
        var backButton = $('<button/>', {
            type: 'button',
            id: 'backButton',
            text: 'Start Over',
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