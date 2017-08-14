<?php
/**
 * Description of Conexion
 * @author YavahTech <Twitter: @YavahTech>
 */

require 'constantes.php';

class Conexion {
    public $mysqli;
    
    public function __construct() {
        $this->mysqli = new mysqli(SERVER, USER, PASS, BD);
        $this->mysqli->query("SET NAMES 'utf8'");
  
    }
    
    public function conectado(){
        if ($this->mysqli->connect_errno) 
            print "Error al conectarse ".$this->mysqli->connect_error;
        else 
            print "Conectado correctamente";
    }
}

//$prueba = new Conexion();
//$prueba->conectado();