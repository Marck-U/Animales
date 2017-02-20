function Inicializa() {
    // Initialize collapse button
    $(".button-collapse").sideNav();
    // Initialize collapsible (uncomment the line below if you use the dropdown variation)
    //$('.collapsible').collapsible();
    $(document).ready(function () {
        $('.carousel').carousel();
    });
    $(document).ready(function () {
        $('select').material_select();
    });
    $('.datepicker').pickadate({
        selectYears: false,
        selectMonths: true, // Creates a dropdown to control month
        monthsFull: ['Enero', 'Febreo', 'Marzo', 'Abril', 'Mayo', 'Junio', 'Julio', 'Agosto', 'Septiembre', 'Octubre', 'Noviembre', 'Diciembre'],
        monthsShort: ['En', 'Feb', 'Mar', 'Abr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dic'],
        weekdaysFull: ['Domingo', 'Lunes', 'Martes', 'Miercoles', 'Jueves', 'Viernes', 'Sabado'],
        weekdaysShort: ['Dom', 'Lunn', 'Mar', 'Mier', 'Jue', 'Vier', 'Sab'],
        format: 'dd-mm-yyyy',
        today: 'Hoy',
        clear: 'Limpiar',
        close: 'Cerrar',
        min: +1
    });
}
$(document).ready(function () {
    $('select').material_select();
});