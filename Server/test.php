<?php

/* 
 * Test de manejo de datos en formato JSON con PHP
 */

$arreglo[0]['nombre']   = "Yanai";
$arreglo[0]['carrera']  = "ISW";
$arreglo[0]['materias'] = 6;
$arreglo[1]['nombre']   = "Hugo";
$arreglo[1]['carrera']  = "ISW";
$arreglo[1]['materias'] = 7;

//Codificar a JSON y mostrarlo en pantalla
header('Content-type: application/json; charset=utf-8');
$miJSON = json_encode($arreglo, JSON_UNESCAPED_UNICODE| JSON_UNESCAPED_SLASHED | JSON_PRETTY_PRINT);
print $miJSON;

/*
 * Convertir de JSON a un Array PHP
$miArreglo = json_decode($miJSON);
print_r($miArreglo);
*/
