const nombre = "marco";

google.maps.event.addDomListener(window, "load", () => {

    const User_Location = new UserLocation(() => {
        // esto se ejecuta cuando el mapa esta listo
        const mapOptions = {
            zoom: 5,
            center: {
                lat: User_Location.latitude,
                lng: User_Location.longitude
            }
        };
const mapa_element = (document.getElementById('map'),mapOptions);
//const myLatlng = new google.maps.Map(parseFloat(mapOptions.center.lat), parseFloat(mapOptions.center.lng),(mapa_element, mapOptions));
const map = new google.maps.Map(mapa_element.mapOptions);
});
})