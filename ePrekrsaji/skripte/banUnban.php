<?php
session_start();
if (!isset($_SESSION['id_korisnik'])) {
    header('Location:greske.php?idGreske=9');
    exit();
}

include_once '../class/baza.class.php';
$baza = new baza();

$idKorisnik = $_GET['idKorisnik'];
$vrsta = $_GET['vrsta'];

if ($vrsta == 1){
    $upit = "UPDATE korisnici SET statusRacuna=3 WHERE idkorisnici={$idKorisnik}";
    $baza->updateDB($upit);
    
    $log = new Log();
    $log->logiranje($_SERVER['HTTP_USER_AGENT'],$_SERVER['REMOTE_ADDR'],$_SESSION['id_korisnik'], 
    "Deaktivacija računa", "korisnik {$_SESSION['ime']} {$_SESSION['prezime']} je deaktivirao račun korisnika pod ID={$idKorisnik}" );
    header('Location: ../views/administrator.php');
}else{
    $upit = "UPDATE korisnici SET statusRacuna=0 WHERE idkorisnici={$idKorisnik}";
    $baza->updateDB($upit);
    
    $log = new Log();
    $log->logiranje($_SERVER['HTTP_USER_AGENT'],$_SERVER['REMOTE_ADDR'],$_SESSION['id_korisnik'], 
    "Aktivacija računa", "korisnik {$_SESSION['ime']} {$_SESSION['prezime']} je aktivirao račun korisnika pod ID={$idKorisnik}" );
    header('Location: ../views/administrator.php');
}
?>
