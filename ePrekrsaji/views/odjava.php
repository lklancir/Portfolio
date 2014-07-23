<?php

session_start();
require_once '../skripte/prijavaOdjava.php';
$pO = new prijavaOdjava();
$log = new Log();
$log->logiranje($_SERVER['HTTP_USER_AGENT'],$_SERVER['REMOTE_ADDR'],$_SESSION['id_korisnik'], "logout", "korisnik {$_SESSION['ime']} {$_SESSION['prezime']} se odjavio iz sustava" );
$pO->brisanjeSesijskihPodataka();
header('Location:prijava.php');
?>
