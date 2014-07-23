<?php
session_start();
include_once '../class/baza.class.php';
$baza = new baza();




if (isset($_POST['submit'])) {
    
    require_once('../recaptcha/recaptchalib.php');
  $privatekey = "6LfhQPMSAAAAAOw3o7Nv2uyThabJMXuMlxxwTZwL";
  $resp = recaptcha_check_answer ($privatekey,
                                $_SERVER["REMOTE_ADDR"],
                                $_POST["recaptcha_challenge_field"],
                                $_POST["recaptcha_response_field"]);

  if (!$resp->is_valid){
      header("Location: greske.php?idGreske=6");
  }
   
  else{
    $ime = $_POST['ime'];
    $prezime  = $_POST['prez'];
    $grad = $_POST['grad'];
    $adresa = $_POST['adresa'];
    $email = $_POST['email'];
    $korime = $_POST['korime'];
    $lozinka1  = $_POST['lozinka1'];
    $lozinka2  = $_POST['lozinka2'];
    $OIB = $_POST['OIB'];
    
    
    
    $upit = "SELECT * FROM korisnici where email='$email'";
    $rezultat = $baza->selectDB($upit);
    if ($rezultat->num_rows != 0) {
        $greske.="Zauzeta email adresa!<br/>"; $greske = "email";
        header("Location: greske.php?idGreske=1");
    }
    $upit = "SELECT * FROM korisnici where korIme='$korime'";
    $rezultat = $baza->selectDB($upit);
    if ($rezultat->num_rows != 0) {
        $greske.="Zauzeta korisnicko ime!<br/>"; $greske = "email";
        header("Location: greske.php?idGreske=1");
    }
    
    $upit = "SELECT * FROM korisnici where OIB='$OIB'";
    $rezultat = $baza->selectDB($upit);
    if ($rezultat->num_rows != 0) {
        $greske.="OIB postoji<br/>"; $greske = "email";
        header("Location: greske.php?idGreske=15");
    }
    
    #PRAZNA POLJA
    if($ime == "" or $prezime== "" or $grad == "" or $adresa == "" or $email == "" or $korime == "" or $lozinka1 == "" or $OIB== "" ){
        $greske .="Niste popunili polja<br/>";
        header("Location: greske.php?idGreske=2");
    }
    
    #VELIKA SLOVA
    $slova = array("Č","Ć","Ž","Š","Đ");
    $Vime = true;
    for ($x=0; $x<5; $x++) {
        if ($ime[0]==$slova[x]){
            $Vime= false;
        }
    } 
    $Vprez = false;
    for ($x=0; $x<5; $x++) {
        if ($prezime[0]==$slova[x]){
            $Vprez = true;
        }
    } 
    
    
    
    if ((!ctype_upper($ime[0]) and $Vime) or (!ctype_upper($prezime[0]) and $Vprez) ) {
            $pogreske .= "Ime i prezime moraju počinjati sa velikim slovom.<br>";
            header("Location: greske.php?idGreske=3");
    }
    #EMAIL
    if(!filter_var($email, FILTER_VALIDATE_EMAIL)){ 
        $greske .= "Netocno strukturirana email adresa.<br />";
        header("Location: greske.php?idGreske=4");
    } 
   
    
    
    #LOZINKE JEDNAKE
    if(strcmp($lozinka1, $lozinka2) != 0){
        $greske .= "Lozinke nisu jednake. <br />";
        header("Location: greske.php?idGreske=5");
    }
    
    #LOZINNA BROJ ZNAKOVA
    if(strlen($lozinka1)< 3){
        $greske .= "Lozinke ima manje od 3 znaka. <br />";
        header("Location: greske.php?idGreske=13");
    }
    
    
    
    
    if (empty($greske)) {
        $date = date('Y-m-d');
        $time = time();
        
        $upit = "insert into korisnici(ime,prezime,email,statusRacuna,korIme,lozinka,OIB,tipKorisnika_idtipKorisnika) VALUES('$ime','$prezime','$email','0','$korime','$lozinka1','$OIB','1');";
        $upit2 = "insert into aktivacija(email,time) VALUES('$email','$time');";
       
        if ($baza->updateDB($upit)) {
            $baza->updateDB($upit2);
            $primatelj = $email;
            $naslov = "Aktivacija korisničkog računa";
            $poruka = "Poštovani, molimo vas da aktivirate vaš korisnički račun klikom na http://arka.foi.hr/WebDiP/2013_projekti/WebDiP2013_031/skripte/aktivacija.php?idKorisnika={$email}";
            mail($primatelj, $naslov, $poruka);
            header("Location: prijava.php");
        } else {
            $greske.="Greška pri radu baze podatka.<br/>";
        }
    }
    
  } 
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
                    <h1><a href="index.php">ePrekršaji</a></h1>
                </li>
            </ul>
            <section class="top-bar-section">
            <ul class="right">
                
                <li class="has-dropdown">
                    <a href="#">Popis</a>
                        <ul class="dropdown">
                            <li><a href="#">First link in dropdown</a></li>
                        </ul>
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
        
        
        <section id="sadrzaj" class="center">
                <form name="registracija" id="registracija" 
                      enctype="multipart/form-data"
                      action="<?PHP echo $_SERVER['PHP_SELF'] ?>" 
                      method="POST">
                    
                    <fieldset>
                        <legend>Registracija</legend>
                    <div class="row">
                        <div class="large-12 columns">
                            <label>Ime
                                <input type="text" id="ime" name="ime" size="15" maxlength="15" placeholder="Ime" />
                            </label>
                            <label for="ime" id="greska_ime" class="Greska" ></label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="large-12 columns">
                            <label>Prezime
                                <input type="text" id="prez" name="prez" size="25" maxlength="25" placeholder="Prezime" />
                            </label>
                            <label for="prez" id="greska_prez" class="Greska" ></label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="large-12 columns">
                            <label>Grad
                                <input type="text" id="grad" name="grad" size="15" maxlength="15" placeholder="Grad" />
                            </label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="large-12 columns">
                            <label>Adresa
                                <input type="text" id="adresa" name="adresa" size="25" maxlength="25" placeholder="Adresa" />
                            </label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="large-12 columns">
                            <label>OIB
                                <input type="text" id="OIB" name="OIB" size="11" maxlength="11" placeholder="OIB" />
                            </label>
                            <label for="OIB" id="greska_OIB" class="Greska" ></label>
                        </div>
                    </div>
                     <div class="row">
                        <div class="large-12 columns">
                            <label>Email
                                <input type="email" id="email" name="email" size="35" maxlength="35" placeholder="ime.prezime@foi.hr" />
                            </label>
                            <label for="email" id="greska_email" class="Greska" ></label>
                        </div>
                    </div>
                     <div class="row">
                        <div class="large-12 columns">
                            <label>Korisničko ime
                                <input type="text" id="korime" name="korime" size="15" maxlength="15"  placeholder="korisničko ime"  />
                            </label>
                            <label for="korime" id="greska_korime" class="Greska" ></label>
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
                            <label>Ponovljena lozinka
                                <input type="password" id="lozinka2" name="lozinka2" size="35" maxlength="35"  placeholder="Ponovljena lozinka" />
                            </label>
                            <label for="lozinka2" id="greska_lozinka2" class="Greska" ></label>
                        </div>
                    </div>
                        <?php
                require_once('../recaptcha/recaptchalib.php');
                $publickey = "6LfhQPMSAAAAAP_bSltlLLPPh98KhQHTu4tCjRDh"; // you got this from the signup page
                echo recaptcha_get_html($publickey);
                ?>
                        <div class="text-center">
                          <input id="submit" name="submit" class="button" type="submit" value=" Registriraj se ">
                     
                        </div>
                   
                    </fieldset>
                </form>
                
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
