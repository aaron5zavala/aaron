function libros()
{
	$("#contenedorprincipal").load('libros.php');
}

function cine()
{
		$("#contenedorprincipal").load('cine.php');
}


function deportes()
{
		$("#contenedorprincipal").load('deportes.php');
}


function salud()
{
		$("#contenedorprincipal").load('salud.php');
}

function tecnologia()
{
		$("#contenedorprincipal").load('tecnologia.php');
}
function cultura()
{
		$("#contenedorprincipal").load('cultura.php');
}
 function rss(nombre)
      {

        var nom=nombre;
        $("#contenedorprincipal").load("rss.php",{nombre:nom});
      }

function ConvertirValor()
{
		var costoTotal;

		var valD = $("#valD").val();
		var valT = $("#valT").val();

		costoTotal = valD*valT;

		$("#valP").val(costoTotal);
}