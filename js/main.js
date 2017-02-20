function asignarValores(idAnimal, rut) {
    document.getElementById('ContentPlaceHolder1_idAnimal').value = idAnimal;
    document.getElementById('ContentPlaceHolder1_rut').value = rut;
    $('#form').submit();
}