<?php

class Consultas{
    private $conexion;
    private $results;
    private $mysqli;
	private $resone;
	
	//private $email;
	//private $password;
    
    public function __construct() {
        $this->conexion = new Conexion();
        $this->mysqli = $this->conexion->mysqli;
		
		//$this->email = mysqli_real_escape_string($post['email']);
		//$this->password = mysqli_real_escape_string($post['password']);
    }
	
	public function close()
	{
		$this->conexion->close();
	}
	//function Log in...
	public function login($email, $password)
	{
		$query = "SELECT password, email FROM login WHERE email = '".$email."' and password = '".$password."' ";
		$consulta = $this->mysqli->query($query);
			//session_start();
			$this->results = $consulta->fetch_all(MYSQLI_ASSOC);
		return $this->results;
	}
	//function registrUsusario...
	public function registroUsuario($name, $lastname, $password, $email)
	{
		$query = "INSERT INTO login(name, lastname, password, email) VALUES ('".$name."', '".$lastname."', '".$password."', '".$email."') ";
		if($consulta = $this->mysqli->query($query))
		{
			$this->results = "Dato Insertado";
		}else{
			$this->results = "Error Al Insertar";
		}
		return $this->results;
	}
	//functiontrackin' number...
	/*public function trackingNumber($tracking_num)
	{
		$query = "SELECT tracking_num FROM envios WHERE tracking_num = '".$tracking_num."' ";
		$consulta = $this->mysqli->query($query);
		$this->results = $consulta->fetch_all(MYSQLI_ASSOC);
		return $this->results;
	}*/
	
	public function showInfo($track_num)
	{
		$query = "SELECT Contenido_del_packete, Peso_en_libras, Valor_del_producto_enviado, tracking_num FROM envios WHERE tracking_num = '".$track_num."' ";
		$consulta = $this->mysqli->query($query);
		$this->results = $consulta->fetch_all(MYSQLI_ASSOC);
		return $this->results;
	}
	
	public function insertProduct($Contenido_del_packete, $Peso_en_libras, $Valor_del_producto_enviado, $tracking_num)
	{
		$query = "INSERT INTO envios ( Contenido_del_packete, Peso_en_libras, Valor_del_producto_enviado, tracking_num) VALUES ('".$Contenido_del_packete."', '".$Peso_en_libras."', '".$Valor_del_producto_enviado."', '".$tracking_num."') ";
		if($consulta = $this->mysqli->query($query))
		{
			$this->results = "Producto Insertado";
		}else{
			$this->results = "Error Al Insertar El Producto";
		}
		return $this->results;
	}
}

//$miConsulta = new Consultas();
//$miConsulta->consultar();