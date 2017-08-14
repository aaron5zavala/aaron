function mostrarModalAgregar(id,idProductos,fechaSalida,cantidadSalida,costoSalida)
{   
    $("#titulo").html('<h4 class="modal-title">Agregar Salida</h4>');
    $("#ContenidoModal").load("modalagregarSalida.php");
    $("#btnaceptar").attr("onclick","agregar($('#idSalida').val(),$('#idProductos').val(),$('#fechaSalida').val(),$('#cantidadSalida').val(),$('#costoSalida').val())");
    $("#ModalMensajes").modal('show');
}

function agregar(id,idProductos,fechaSalida,cantidadSalida,costoSalida)
{
    
	$("#Log").load("addSalidasphp.php",{idSalida:id,idProductos:idProductos,fechaSalida:fechaSalida,cantidadSalida:cantidadSalida,costoSalida:costoSalida});
	$("#consulta").load("registroSalidas.php");
    $("#ModalMensajes").modal('hide');//acultar modal.

}