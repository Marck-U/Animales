class UserLocation {
    constructor(callback) {
        // SE ejecuta cuando se crea un nuevo usuario
        if (navigator.geolocation) {
            // ACEPTA la geolocalizacion
            navigator.geolocation.getCurrentPosition((localizacion)=>{
                /* esto se ejecuta cuando ya se tiene la geolocalizacion */
            this.latitude = localizacion.coords.latitude;
            this.latitude = localizacion.coords.longitude;
            callback()
        })
        } else {
            alert("Tu navegador no soporta geolocalizacion");
    }
  }
}