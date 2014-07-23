<?php
include_once '../views/vrijeme.php';
include_once '../class/baza.class.php';
$baza = new baza();

$idKorisnika = $_GET['idKorisnika'];

$upit = "SELECT * from aktivacija where email='$idKorisnika'";
$rezultat = $baza->selectDB($upit);



while ($red = $rezultat->fetch_array()){
    $baza_vrijeme = "{$red[1]}";
}



if (((int)$vrijeme_sustava - (int)$baza_vrijeme) > 86400){
    header("Location: ../views/greske.php?idGreske=7");
}
else{
    $upit = "UPDATE korisnici set tipKorisnika_idtipKorisnika=2 WHERE email='{$idKorisnika}'";
    $rezultat = $baza->selectDB($upit);
    
    if ($rezultat) {
        header("Location: ../views/prijava.php");
    } else {
        header("Location: ../views/greske.php?idGreske=8"); 
    }
}

?>

     