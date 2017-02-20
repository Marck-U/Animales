"use strict";

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

var UserLocation = function UserLocation(callback) {
    var _this = this;

    _classCallCheck(this, UserLocation);

    // SE ejecuta cuando se crea un nuevo usuario
    if (navigator.geolocation) {
        // ACEPTA la geolocalizacion
        navigator.geolocation.getCurrentPosition(function (localizacion) {
            /* esto se ejecuta cuando ya se tiene la geolocalizacion */
            _this.latitude = localizacion.coords.latitude;
            _this.latitude = localizacion.coords.longitude;
            callback();
        });
    } else {
        alert("Tu navegador no soporta geolocalizacion");
    }
};
