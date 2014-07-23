<?php
session_start();
if (!isset($_SESSION['id_korisnik'])) {
    header('Location:greske.php?idGreske=9');
    exit();
}
include_once 'vrijeme.php';
include_once '../class/baza.class.php';
$baza = new baza();

$upit = "SELECT k.ime, k.prezime, k.OIB, k.idkorisnici
FROM korisnici k
WHERE k.tipKorisnika_idtipKorisnika=2";

$rezultat = $baza->selectDB($upit);
$users = array();
while ($red = mysqli_fetch_assoc($rezultat)){
    $users[]=$red;
}
$tablica = "<table><thead><tr><th>OIB</th><th>Ime</th><th>Prezime</th><th>Unesi prekršaj</th></tr></thead><tbody>";

foreach ($users as $user){

    $tablica .= "<tr><td>{$user[OIB]}</td>"
        . "<td>{$user[ime]}</td>"
        . "<td>{$user[prezime]}</td>"
        . "<td><a href='http://arka.foi.hr/WebDiP/2013_projekti/WebDiP2013_031/views/moderatorUnesiPrekrsajForma.php?idKorisnici={$user[idkorisnici]}'>Unesi</a></td></tr>";
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
                <li><a href="views/popis.php">Popis</a></li>
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
                <legend>Korisnici</legend>
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




