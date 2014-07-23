<?php
session_start();
if (!isset($_SESSION['id_korisnik'])) {
    header('Location:greske.php?idGreske=9');
    exit();
}
include_once 'vrijeme.php';
include_once '../class/baza.class.php';


$baza = new baza();

// ID DOSJE
$upit= "SELECT id_dosje from dosje_osobe where korisnici_idkorisnici={$_SESSION['id_korisnik']};";
$rezultat = $baza->selectDB($upit);
$id_dosje= mysqli_fetch_row($rezultat);

//PREKRSAJI
$upit = "SELECT korisnici.ime, korisnici.prezime, dosje_osobe.datum_kreacije, mjesto.mNaziv, prekrsaji.policajac_idZnacke, kategorije_prek.naziv, prekrsaji.opis_prekrsaja, prekrsaji.datumVrijeme, kategorije_prek.zastara, prekrsaji.idprekrsaji, kategorije_prek.datumZastare, kategorije_prek.zastara
FROM  `dosje_osobe` 
INNER JOIN korisnici ON dosje_osobe.korisnici_idkorisnici = korisnici.idkorisnici
INNER JOIN prekrsaji ON prekrsaji.dosje_osobe_id_dosje = dosje_osobe.id_dosje
INNER JOIN mjesto ON prekrsaji.mjesto_idmjesto = mjesto.idmjesto
INNER JOIN kategorije_prek ON prekrsaji.kategorije_prek_idkategorije_prek=kategorije_prek.idkategorije_prek
WHERE dosje_osobe.korisnici_idkorisnici = {$_SESSION['id_korisnik']}";

$rezultat = $baza->selectDB($upit);
$users = array();
while ($red = mysqli_fetch_assoc($rezultat)){
    $users[]=$red;
}
//TABLICA PREKRSAJI

$tablica = "<table id='korisnici'><thead><tr><th>Ime</th><th>Prezime</th><th>Prekršaj počinjen</th><th>Mjesto prekršaja</th><th>Policajac</th><th>ID prekršaja</th><th>Vrsta prekršaja</th><th>Opis prekršaja</th><th>Godina zastare</th><th>Podnesi žalbu</th></tr></thead><tbody>";
foreach ($users as $user){
    if ($user[zastara] == "DA"){
        $zastara = $user[datumZastare];
    } else {
        $zastara = "NEMA ZASTARU";
    }
    $tablica .= "<tr><td>{$user[ime]}</td>"
    . "<td>{$user[prezime]}</td>"
    . "<td>{$user[datumVrijeme]}</td>" 
    . "<td>{$user[mNaziv]}</td>"
    . "<td>{$user[policajac_idZnacke]}</td>"
    . "<td>{$user[idprekrsaji]}</td>"
    . "<td>{$user[naziv]}</td>"
    . "<td>{$user[opis_prekrsaja]}</td>"
    . "<td>{$zastara}</td>"
    . "<td><a href='registriraniZalbe.php?idPrekrsaja={$user[idprekrsaji]}'>Uredi</a></td></tr>";
    
}
$tablica .= "</tbody></table>";
//ZALBE

if ($id_dosje != null){
    $upit = "SELECT z.idZalbe, z.opisZalbe, z.status_zalbe, z.datumZalbe, p.idprekrsaji
FROM zalbe z
INNER JOIN prekrsaji p on z.prekrsaji_idprekrsaji = p.idprekrsaji
WHERE p.dosje_osobe_id_dosje = {$id_dosje[0]}";




$rezultat = $baza->selectDB($upit);
$users = array();

    
while ($red = mysqli_fetch_assoc($rezultat)){
    $users[]=$red;
}

//TABLICA ZALBE

$tablica2 = "<table id='korisnici2'><thead><tr><th>ID žalbe</th><th>Opis žalbe</th><th>Status žalbe</th><th>Datum podnesene žalbe</th><th>ID prekršaja</th></tr></thead><tbody>";

foreach ($users as $user){
    switch ($user[status_zalbe]){
        case 1 : $statusZalbe = "Zaprimljena"; break;
        case 2 : $statusZalbe = "Odobrena"; break;
        case 3 : $statusZalbe = "Odbijena"; break;
    }
    $tablica2 .= "<tr><td>{$user[idZalbe]}</td>"
    . "<td>{$user[opisZalbe]}</td>"
    . "<td>{$statusZalbe}</td>" 
    . "<td>{$user[datumZalbe]}</td>" 
    . "<td>{$user[idprekrsaji]}</td></tr>";

}
$tablica2 .= "</tbody></table>";
}




?>
<!DOCTYPE html>
<!--
To change this license header, choose License Headers in Project Properties.
To change this template file, choose Tools | Templates
and open the template in the editor.
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
      
        
        <html dir="ltr" lang="hr">
    <head>
        <title>Početna</title>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width; initial-scale=1.0; maximum-scale=10.0; user-scalable=1;">
        <link rel="stylesheet" type="text/css" href="../css/foundation.css"/>
        <link href="http://datatables.net/download/build/nightly/jquery.dataTables.css" rel="stylesheet" type="text/css" />
        <link rel="stylesheet" type="text/css" href="../css/main.css"/>
        
    </head>
    <body>
        <header id="zaglavlje">
             
           

        </header>
        <nav class="top-bar" data-topbar>
            <ul class="title-area">
                <li class="name">
                    <h1><a href="../index.php">ePrekršaji</a></h1>
                </li>
     
               
            </ul>

            <section class="top-bar-section">
   
            <ul class="right">
                <li class="name">
                    <?php include_once 'sat.php' ; ?>
                </li>
                
                <?php
                    require_once './prijavaOdjavaView.php';
                ?>
                <li><a href="registracija.php">Registracija</a></li>
                
            </ul>

   
            <ul class="left">
                <li><a href="popis.php">Popis</a></li>
                <li class="has-dropdown">
                    <a href="registrirani.php">Profil</a>
                        <ul class="dropdown">
                            <li><a href="registriraniStatistika.php">Statistika</a></li>
                        </ul>
                </li>
            </ul>
            </section>
        </nav>
        <section id="sadrzaj">
            
            <h1>Dobrodošao <?php echo $_SESSION['ime']; ?> </h1>
            <fieldset class="center">
                <legend>Dosje</legend>
                 <?php echo $tablica; ?>
            </fieldset>
            <fieldset class="center">
                <legend>Pregled žalbi</legend>
                 <?php echo $tablica2; ?>
            </fieldset>
           
        </section>
        <footer id="podnozje">
           
        </footer>
        <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
        <script src="http://code.jquery.com/ui/1.10.4/jquery-ui.js"></script>
        <script src="http://datatables.net/download/build/nightly/jquery.dataTables.js"></script>
        <script src="../js/lklancir_jquery.js"></script>
        <script src="../js/lklancir.js"></script>
        <script src="../js/foundation.min.js"></script>
        <script>$(document).foundation();</script>
    </body>
</html>



