<?php
session_start();
if (!isset($_SESSION['id_korisnik'])) {
    header('Location:greske.php?idGreske=9');
    exit();
}
include_once 'vrijeme.php';
include_once '../class/baza.class.php';
$baza = new baza();
$vrsta = $_GET['vrsta'];

if ($vrsta==1){
    $kategorijeHTML="<form name='kategorijePrekrsaja1' id='kategorijePrekrsaja1' class='center'
                      enctype='multipart/form-data'
                      action='administratorKategorijePrekrsaja?vrsta=1' 
                      method='POST'>
                    
                    <fieldset>
                        <legend>Kategorije prekršaja</legend>
                    <div class='row'>
                        <div class='large-12 columns'>
                            <label>Naziv kategorije
                                <input type='text' id='naziv' name='naziv' placeholder='naziv kategorije' />
                            </label>
                            <label for='ime' id='greska_naziv' class='greska_naziv' ></label>
                        </div>
                    </div>
                    <div class='row'>
                        <div class='large-12 columns'>
                            <label>Zastara</label>
                        <input type='radio' name='Zastara' value='DA' id='ZastaraDA'><label for='ZastaraDA'>DA</label>
                        <input type='radio' name='Zastara' value='NE' id='ZastaraNE'><label for='ZastaraNE'>NE</label>
                        </div>
                    </div>
                    <div class='row'>
                        <div class='large-6 columns'>
                            <label>Godina zastare
                                <input type='text' id='datum' name='datum' placeholder='Broj godina' />
                            </label>
                        </div>
                   </div>
                    <div class='text-center'>
                          <input id='submit1' name='submit1' class='button' type='submit' value='Dodaj'>
                     
                        </div>
                    </fieldset>
                </form>";
}
if ($vrsta==2){
    $upit = "SELECT * FROM kategorije_prek";
    $rezultat = $baza->selectDB($upit);
    $users = array();
    while ($red = mysqli_fetch_assoc($rezultat)){
        $users[]=$red;
    }
    $select;
    foreach ($users as $user){
    $select .= "<option value='{$user[idkategorije_prek]}'>{$user[naziv]}";
    }
    $kategorijeHTML="<form name='kategorijePrekrsaja2' id='kategorijePrekrsaja2' class='center'
                      enctype='multipart/form-data'
                      action='administratorKategorijePrekrsaja?vrsta=2' 
                      method='POST'>
                    
                    <fieldset>
                        <legend>Kategorije prekršaja</legend>
                    <div class='row'>
                        <div class='large-12 columns'>
                            <label>Kategorija prekršaja
                            <select name='kategorijaPrek'>
                                
                                echo $select
                                
                            </select>
                        </div>
                    </div>
                    <div class='row'>
                        <div class='large-12 columns'>
                            <label>Zastara</label>
                        <input type='radio' name='Zastara' value='DA' id='ZastaraDA'><label for='ZastaraDA'>DA</label>
                        <input type='radio' name='Zastara' value='NE' id='ZastaraNE'><label for='ZastaraNE'>NE</label>
                        </div>
                    </div>
                    <div class='row'>
                        <div class='large-6 columns'>
                            <label>Godina zastare
                                <input type='text' id='datum' name='datum' placeholder='Broj godina' />
                            </label>
                        </div>
                   </div>
                    <div class='text-center'>
                          <input id='submit2' name='submit2' class='button' type='submit' value='Dodaj'>
                          <input id='submit3' name='submit3' class='button' type='submit' value='Izbriši'>
                        </div>
                    </fieldset>
                </form>";
}

if (isset($_POST['submit1'])){
    $naziv = $_POST['naziv'];
    $zastara = $_POST['Zastara'];
    $datum = $_POST['datum'];
    
    $upit = "INSERT into kategorije_prek (zastara,datumZastare,naziv) VALUES ('$zastara','$datum','$naziv')";
    $baza->updateDB($upit);
}
if (isset($_POST['submit2'])){
    $id = $_POST['kategorijaPrek'];
    $zastara = $_POST['Zastara'];
    $datum = $_POST['datum'];
    
    
    $upit = "UPDATE kategorije_prek SET zastara='{$zastara}',datumZastare='{$datum}' WHERE idkategorije_prek='{$id}' ";
    $baza->updateDB($upit);
}

if (isset($_POST['submit3'])){
    $id = $_POST['kategorijaPrek'];
       
    $upit = "DELETE FROM kategorije_prek WHERE idkategorije_prek='{$id}' ";
    $baza->updateDB($upit);
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
            <div class="center">
               <input type="submit" value="Dodaj novi" class="button" onclick="window.location='http://arka.foi.hr/WebDiP/2013_projekti/WebDiP2013_031/views/administratorKategorijePrekrsaja?vrsta=1';" />  
               <input type="submit" value="Azuriraj" class="button" onclick="window.location='http://arka.foi.hr/WebDiP/2013_projekti/WebDiP2013_031/views/administratorKategorijePrekrsaja?vrsta=2';" />  

            </div>
            
            <?php echo $kategorijeHTML; ?>
            
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