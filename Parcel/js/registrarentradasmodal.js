function mostrarModalAgregarEntradas(id,idProducto,cantidad,costoPagado,fechaEntrada,idMoneda)
{   
    $("#titulo").html('<h4 class="modal-title">Agregar Entrada</h4>');
    $("#ContenidoModal").load("modalagregar.php");
    $("#btnaceptar").attr("onclick","agregar($('#idEntrada').val(),$('#idProducto').val(),$('#cantidad').val(),$('#costoPagado').val(),$('#fechaEntrada').val(),$('#idMoneda').val());");
    $("#ModalMensajes").modal('show');
}

function agregar(id,idProducto,cantidad,costoPagado,fechaEntrada,idMoneda)
{
    
	$("#Log").load("addEntrada.php",{idEntrada:id,idProducto:idProducto,cantidad:cantidad,costoPagado:costoPagado,fechaEntrada:fechaEntrada,idMoneda:idMoneda});
	alert(0);
	$("#consulta").load("registarentradas.php");
    $("#ModalMensajes").modal('hide');//acultar modal.

}