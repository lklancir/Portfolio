<?php
session_start();
include_once 'vrijeme.php';

include_once '../class/baza.class.php';


$baza = new baza();
$upit = "SELECT * FROM dnevnik_sustava ";
$rezultat = $baza->selectDB($upit);

$users = array();

while ($red = mysqli_fetch_assoc($rezultat)){
    $users[]=$red;
}
$tablica = "<fieldset class='center2'><legend>Dnevnik sustava</legend><table id='korisnici'><thead><tr><th>ID</th><th>User Agent</th><th>IP</th><th>ID korisnika</th><th>Vrsta</th><th>Opis</th><th>Vrijeme</th></tr></thead><tbody>";
foreach ($users as $user){
    $tablica .= "<tr><td>{$user[idDnevnikSustava]}</td>"
    . "<td>{$user[user_agent]}</td>"
    . "<td>{$user[IP_adresa]}</td>"
    . "<td>{$user[idkorinsika]}</td>"
    . "<td>{$user[vrsta]}</td>"
    . "<td>{$user[opis]}</td>"
    . "<td>{$user[logTime]}</td></tr>";
}
$tablica .= "</tbody></table></fieldset>";

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
                    <h1><a href="index.php">ePrekršaji</a></h1>
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
                    <a href="administrator.php">Profil</a>
                        <ul class="dropdown">
                            <li><a href="administratorKategorijePrekrsaja.php">Kategorije prekršaja</a></li>
                            <li><a href="administratorPolUprave.php">Policijske uprave</a></li>
                            <li><a href="administratorPolicajci.php">Policijaci</a></li>
                        </ul>
                <li><a href="administratorPostavke.php">Postavke</a></li>
                </li>
            </section>
        </nav>
        <section id="sadrzaj">
            
            <form name="vrijemeForma" id="vrijemeForma" class="center"
                      enctype="multipart/form-data"
                      action="vrijeme.php" 
                      method="POST">
            <div class="row">
                <div class="large-12 columns">
                    <label>Virtualno vrijeme
                        <input type="text" id="vrijeme" name="vrijeme" placeholder="Postavi virtualno vrijeme" />
                    </label>
                </div>
            </div>
            </div>
            <div class="text-center">
                  <input id="submitVrijeme" name="submitVrijeme" class="button" type="submit" value="Virutalno vrijeme">
                     
            </div>    
            </form>
          <?php
                    echo $tablica;
                ?>
            <div class="center">
               <a href='http://arka.foi.hr/WebDiP/2013_projekti/WebDiP2013_031/skripte/pdfGen'><button class="button [secondary success alert]">PDF</button></a>
            </div>
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
