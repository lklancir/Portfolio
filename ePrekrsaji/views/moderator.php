<?php
session_start();
if (!isset($_SESSION['id_korisnik'])) {
    header('Location:greske.php?idGreske=9');
    exit();
}
include_once 'vrijeme.php';
include_once '../class/baza.class.php';
$baza = new baza();

//ZNACKA
$upit= "SELECT idZnacke FROM policajac WHERE korisnici_idkorisnici={$_SESSION['id_korisnik']}";
$rezultat = $baza->selectDB($upit);
$znacka= mysqli_fetch_row($rezultat);

$upit = "SELECT z.idZalbe, z.opisZalbe, z.status_zalbe, z.datumZalbe, p.idprekrsaji, do.id_dosje, k.ime, k.prezime, p.opis_prekrsaja, kp.naziv
FROM zalbe z
INNER JOIN prekrsaji p ON z.prekrsaji_idprekrsaji = p.idprekrsaji
INNER JOIN dosje_osobe
do ON p.dosje_osobe_id_dosje = do.id_dosje
INNER JOIN korisnici k ON do.korisnici_idkorisnici = k.idkorisnici
INNER JOIN kategorije_prek kp ON p.kategorije_prek_idkategorije_prek = kp.idkategorije_prek
WHERE policajac_idZnacke ={$znacka[0]}";

$rezultat = $baza->selectDB($upit);
$users = array();
while ($red = mysqli_fetch_assoc($rezultat)){
    $users[]=$red;
}
$tablica = "<table id='korisnici'><thead><tr>"
        . "<th>ID Žalbe</th>"
        . "<th>Ime</th>"
        . "<th>Prezime</th>"
        . "<th>Kategorija prekršaja</th>"
        . "<th>Opis prekršaja</th>"
        . "<th>Datum podnesene žalbe</th>"
        . "<th>Opis žalbe</th>"
        . "<th>Status žalbe</th>"
        . "<th>Akcija</th></tr></thead><tbody>";
foreach ($users as $user){
    
    switch ($user[status_zalbe]){
        case 1 : $statusZalbe = "Zaprimljena"; break;
        case 2 : $statusZalbe = "Odobrena"; break;
        case 3 : $statusZalbe = "Odbijena"; break;
    }
    $tablica .= "<tr><td>{$user[idZalbe]}</td>"
        . "<td>{$user[ime]}</td>"
        . "<td>{$user[prezime]}</td>"
        . "<td>{$user[naziv]}</td>"
        . "<td>{$user[opis_prekrsaja]}</td>"
        . "<td>{$user[datumZalbe]}</td>"
        . "<td>{$user[opisZalbe]}</td>"
        . "<td>{$statusZalbe}</td>"
        . "<td><a href='../skripte/zalbeStatus.php?idZalbe={$user[idZalbe]}&vrsta=1'>1 |</a><a href='../skripte/zalbeStatus.php?idZalbe={$user[idZalbe]}&vrsta=2'> 2 </a></td></tr>";
}

$tablica .= "</tbody></table>";
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
                <li><a href="views/registracija.php">Registracija</a></li>
                
            </ul>

   
            <ul class="left">
                <li><a href="popis.php">Popis</a></li>
                <li class="has-dropdown">
                    <a href="moderator.php">Profil</a>
                        <ul class="dropdown">
                            <li><a href="moderatorUnesiPrekrsaj.php">Unesi prekršaj</a></li>
                        </ul>
                </li>
            </ul>
            </section>
        </nav>
        <section id="sadrzaj">
        <h1>Dobrodošao <?php echo $_SESSION['ime']; ?> </h1>
        
        <fieldset class="center">
                <legend>Žalbe za moderiranje</legend>
                 <?php echo $tablica; ?>
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




