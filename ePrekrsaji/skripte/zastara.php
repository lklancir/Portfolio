<?php
session_start();
if (!isset($_SESSION['id_korisnik'])) {
    header('Location:greske.php?idGreske=9');
    exit();
}
include_once '../views/vrijeme.php';
include_once '../class/baza.class.php';
$baza = new baza();


$upit = "SELECT korisnici.email, korisnici.ime, korisnici.prezime, dosje_osobe.datum_kreacije, mjesto.mNaziv, prekrsaji.policajac_idZnacke, kategorije_prek.naziv, prekrsaji.opis_prekrsaja, prekrsaji.datumVrijeme, kategorije_prek.zastara, prekrsaji.idprekrsaji, kategorije_prek.datumZastare, kategorije_prek.zastara
FROM  `dosje_osobe` 
INNER JOIN korisnici ON dosje_osobe.korisnici_idkorisnici = korisnici.idkorisnici
INNER JOIN prekrsaji ON prekrsaji.dosje_osobe_id_dosje = dosje_osobe.id_dosje
INNER JOIN mjesto ON prekrsaji.mjesto_idmjesto = mjesto.idmjesto
INNER JOIN kategorije_prek ON prekrsaji.kategorije_prek_idkategorije_prek=kategorije_prek.idkategorije_prek";

$rezultat = $baza->selectDB($upit);
$users = array();
while ($red = mysqli_fetch_assoc($rezultat)){
    $users[]=$red;
}

foreach ($users as $user){
    
    if ($user[zastara] == "DA"){
        
        $pomak = $user[datumZastare]; //POMAK U GODINAMA ZA ZASTARU KATEGORIJE PREKRŠAJA
        $istjeceVrijeme = strtotime($user[datumVrijeme])+($pomak * 356 * 24 * 60 * 60); //DATUM PREKRŠAJA + POMAK = DATUM U future
        
        $danasVrijeme = strtotime($datum);
        
        $ulaziZastaru = date('Y-m-d',$istjeceVrijeme);
        
        if ($istjeceVrijeme <= $danasVrijeme ){
            $primatelj = $user[email];
            $naslov = "Prekrsaj u zastari";
            $poruka = "Postovani, Vas prekrsaj pod rednim brojem {$user[idprekrsaji]} je dana {$ulaziZastaru} otisao u zastaru. "
            . "Detalje mozete pronaci na http://arka.foi.hr/WebDiP/2013_projekti/WebDiP2013_031/views/registrirani.php";
            mail($primatelj, $naslov, $poruka);
            
        
        }
    }
     
   
}
header("Location: ../views/administrator.php");

?>
