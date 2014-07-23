<?php
session_start();
if (!isset($_SESSION['id_korisnik'])) {
    header('Location:greske.php?idGreske=9');
    exit();
}
include_once 'vrijeme.php';
include_once '../class/baza.class.php';
$baza = new baza();
$idPrekrsaja = $_GET['idPrekrsaja'];



if (isset($_POST['submit'])){
    $opisZalbe = $_POST['opisZalbe'];
    
    $upit = "INSERT into zalbe (opisZalbe,status_zalbe,datumZalbe,prekrsaji_idprekrsaji,korisnici_idkorisnici) "
            . "VALUES ('$opisZalbe','1','$datum','$idPrekrsaja','{$_SESSION['id_korisnik']}')";
            
    $baza->updateDB($upit);
    header("Location: registrirani.php");
    
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
                
                <li class="has-dropdown">
                    <a href="views/popis.php">Popis</a>
                        <ul class="dropdown">
                            <li><a href="#">First link in dropdown</a></li>
                        </ul>
                </li>
                
                <?php
                 require_once './prijavaOdjavaView.php';
                ?>
                <li><a href="views/registracija.php">Registracija</a></li>
                
            </ul>

   
            <ul class="left">
                <li><a href="#">Left Nav Button</a></li>
            </ul>
            </section>
        </nav>
        <section id="sadrzaj">
            <h3>Žalba na prekršaj vođen pod brojem <?php echo $idPrekrsaja; echo " korisnika "; echo $_SESSION['ime']; echo " ".$_SESSION['prezime']; ?> </h3>
            
            <form name="zalbe" id="zalbe" class="center"
                      enctype="multipart/form-data"
                      action="registriraniZalbe.php?idPrekrsaja=<?php echo $idPrekrsaja; ?>" 
                      method="POST">
                    
                    <fieldset>
                       
                        <legend>Žalba</legend>
                    <div class="row">
                        <div class="large-12 columns">
                            <label>Opis žalbe
                                <input type="text" id="opisZalbe" name="opisZalbe" placeholder="Opis žalbe" />
                            </label>
                            <label for="ime" id="greska_opisZalbe" class="greska_opisZalbe" ></label>
                        </div>
                    </div>
                    <div class="text-center">
                          <input id="submit" name="submit" class="button" type="submit" value=" Podnesi žalbu ">
                     
                        </div>
                    </fieldset>
                </form>
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



