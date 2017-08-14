<?php

    //para permitir el traspaso de información se manera segura
    if (isset($_SERVER['HTTP_ORIGIN'])) {
        header("Access-Control-Allow-Origin: {$_SERVER['HTTP_ORIGIN']}");
        header('Access-Control-Allow-Credentials: true');
        header('Access-Control-Max-Age: 86400'); // cache for 1 day
    }
    
    //Para establecer que trabajaremos por método POST
	//Receiving JSON POST Data Via PHP.
    if(strcasecmp($_SERVER['REQUEST_METHOD'], 'POST') != 0){
        throw new Exception('El método debería ser POST!');
    }
    
    //Establece que el formato de entrada será application/json
    $contentType = isset($_SERVER["CONTENT_TYPE"]) ? trim($_SERVER["CONTENT_TYPE"]) : '';
    if(strcasecmp($contentType, 'application/json') != 0){
        throw new Exception('Content type must be: application/json');
    }

    //Recibe el RAW 
    $content = trim(file_get_contents("php://input"));

    //transforma el RAW JSON a PHP
    $decoded = json_decode($content, true); //guarda la petición
    
    $message = array(); //para guardar la respuesta
    
    require 'config/Conexion.php';
    require 'api/apiTest.php';
    
    $miAPI = new Consultas();
    
 switch ($decoded['action']) {
	case "selectandinsert":
      if(is_array($data = $miAPI->login($decoded['email'], $decoded['password']))) {
			$message = $data;
      } else {
           $message["message"] = "Error";
      }        

       break;
	   
	case "insertUsuario":
		if(empty($decoded['name']) || empty($decoded['lastname']) || empty($decoded['password']) || empty($decoded['email'])){
			$message["message"] = "Error";
		}else{
			$data = $miAPI->registroUsuario($decoded['name'], $decoded['lastname'], $decoded['password'], $decoded['email']);
			$message["message"] = $data;
		}
	   break;
	   
	/*case "trackingNumber":
		if(is_array($data = $miAPI->trackingNumber($decoded['tracking_num'])))
		{
			$message = $data;
		}else if(empty($decoded['tracking_num'])){
			$message["message"] = "Error";
		}
	   break;*/
	   
	case "showData":
		if(is_array($data = $miAPI->showInfo($decoded['track_num'])))
		{
			$message =  $data;
		}else{
			$message["message"] = "Error";
		}
		break;
		
	case "altProduct":
	if(empty($decoded['Contenido_del_packete']) || empty($decoded['Peso_en_libras']) || empty($decoded['Valor_del_producto_enviado']) || empty($decoded['tracking_num'])){
			$message["message"] = "Error";
		}else{
		$data = $miAPI->insertProduct($decoded['Contenido_del_packete'], $decoded['Peso_en_libras'], $decoded['Valor_del_producto_enviado'], $decoded['tracking_num']);
		
			$message["message"] = $data;
		}		
		break;
		
    default:
         $message["message"] = "Acción NO válida";
        break;
		
}

//Codificar a JSON y mostrarlo en pantalla
header('Content-type: application/json; charset=utf-8');
$miJSON = json_encode($message, JSON_PRETTY_PRINT);
print $miJSON;