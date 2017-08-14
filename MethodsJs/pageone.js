<script>
	function abrirEnPestana(url) {
		$("<a>").attr("href", url).attr("target", "_blank")[0].click();
	}
 
	var url="http://localhost/Parcel/Parcel/pageone.html";
 
	window.onload=function(){
		abrirEnPestana(url);
	}
	</script>