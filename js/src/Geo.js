"use strict";

var nombre = "marco";

function initMap() {

    var User_Location = new UserLocation(function () {
        var  mapOptions;
        var map = new google.maps.Map(document.getElementById('map'), {
            center: { lat: User_Location.latitude, lng: User_Location.longitude },
            scrollwheel: false,
            zoom: 8

        });
        const myLatlng = new google.maps.Map(parseFloat(map.center));
        var mapa_element = (document.getElementById('map'), mapOptions);
        
        //var map = new google.maps.Map(mapa_element.mapOptions);
    });
}
