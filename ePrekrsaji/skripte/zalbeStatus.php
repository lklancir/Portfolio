<?php
session_start();
if (!isset($_SESSION['id_korisnik'])) {
    header('Location:greske.php?idGreske=9');
    exit();
}

include_once '../class/baza.class.php';
$baza = new baza();

$idZalbe = $_GET['idZalbe'];
$vrsta = $_GET['vrsta'];

if ($vrsta == 1){
    $upit = "UPDATE zalbe SET status_zalbe=2 WHERE idzalbe={$idZalbe}";
    $baza->updateDB($upit);
    header('Location: ../views/moderator.php');
}else{
    $upit = "UPDATE zalbe SET status_zalbe=3 WHERE idzalbe={$idZalbe}";
    $baza->updateDB($upit);
    header('Location: ../views/moderator.php');
}
?>

