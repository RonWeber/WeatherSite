var Weather = {};

Weather.Marine = (function () {
    function init() {
        alert('init');
    };

    


//Any functions declared in this 'return' function act like public functions 
    return {
        init: init
    }
})();