<?php
include_once 'vrijeme.php';
require_once '../skripte/prijavaOdjava.php';
if (isset($_POST['pkorime'])) {
    $pO = new prijavaOdjava();

    if (isset($_POST['potvrda'])) {
        $pO->kreiranjeKolacica($_POST['pkorime'], 'pkorime');
    } else {
        $pO->brisanjeKolacica('pkorime');
    }
    $pO->autentikacija($_POST['pkorime'], $_POST['lozinka1']);
}


if(isset($_SESSION['id_korisnik'])) {
  echo "Your session is running " . $_SESSION['id_korisnik'];
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
                <li><a href="../dokumentacija.html">Dokumentacija</a></li>
            </ul>
            </section>
        </nav>
        
        <section id="sadrzaj">
            <form name="prijava" id="prijava" class="center"
                      enctype="multipart/form-data"
                      action="prijava.php" 
                      method="POST">
                    
                    <fieldset>
                        <legend>Prijava</legend>
                        
                        <div class="row">
                        <div class="large-12 columns">
                            <label>Korisničko ime
                                <input type="text" id="pkorime" name="pkorime" <?php if(isset($_COOKIE['pkorime'])) { echo 'value="'.$_COOKIE['pkorime'].'"'; } ?> size="15" maxlength="15"  placeholder="korisničko ime"  />
                            </label>
                            <label for="pkorime" id="pgreska_korime" class="Greska" ></label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="large-12 columns">
                            <label>Lozinka
                                <input type="password" id="lozinka1" name="lozinka1" size="35" maxlength="35"  placeholder="lozinka" />
                            </label>
                            <label for="lozinka1" id="greska_lozinka1" class="Greska" ></label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="large-12 columns">
                            <label>
                                <input type="checkbox" id="potvrda" <?php if(isset($_COOKIE['pkorime'])) { echo 'checked="checked"'; } ?> name="potvrda" value="1">Zapamti<br>
                            </label>
                            
                        </div>
                    </div>
                    <div class="row">
                        <div class="large-12 columns">
                            <label>
                                <input type="submit" value="PRIJAVA" class="button"><br><br><br>
                            </label>
                            
                        </div>
                    </div>
                    
                    </filedset>
            </form>
            
            <a href="#" data-reveal-id="myModal">Zaboravljena lozinka?</a>

                            <div id="myModal" class="reveal-modal" data-reveal>
                              <h2>Unesite korisničko ime ili email.</h2>
                              <form name="prijava" id="prijava" 
                                    enctype="multipart/form-data"
                                    action="../skripte/zaboravljenaLozinka.php" 
                                    method="POST"
                                    class="center">
                                <div class="row">
                                    <div class="large-12 columns">
                                        <label>
                                            <input type="text" id="unos" name="unos" placeholder="korisnički podatak"  />
                                        </label>
                                        
                                    </div>
                                </div>
                                  <div class="row">
                                    <div class="large-12 columns">
                                        <label>
                                            <input type="submit" name="zaboravljenaLozinka" class="button">
                                        </label>

                                    </div>
                                </div>
                              </form>
                              <a class="close-reveal-modal">&#215;</a>
                            </div>
        </section>
        <footer id="podnozje">
         <br/><br/>
           Copyright Luka Klancir ©2014
           <br/><br/><br/><br/><br/> 
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


