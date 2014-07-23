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

$upit = "SELECT po.idZnacke, k.ime, k.prezime, po.vrstapolicajca, pu.naziv, pu.zupanije_idzupanije, pu.idpolUprave, z.nazivZup 
FROM policajac po
INNER JOIN korisnici k ON po.korisnici_idkorisnici = k.idkorisnici
INNER JOIN pol_uprave pu ON pu.idpolUprave = po.polUprave_idpolUprave
INNER JOIN zupanije z ON z.idzupanije = pu.zupanije_idzupanije";


$rezultat = $baza->selectDB($upit);
    $users = array();
    while ($red = mysqli_fetch_assoc($rezultat)){
        $users[]=$red;
    }
$tablica = "<fieldset class='center'><legend>Policajci</legend><table id='korisnici' class='center2'><thead><tr><th>Broj značke</th><th>Ime</th><th>Prezime</th><th>Vrsta</th><th>Policijska uprava</th><th>Županija</th><th>Akcija</th></tr></thead><tbody>";    
foreach ($users as $user){
    $tablica .= "<tr><td>{$user[idZnacke]}</td>"
    . "<td>{$user[ime]}</td>"
    . "<td>{$user[prezime]}</td>"
    . "<td>{$user[vrstapolicajca]}</td>"
    . "<td>{$user[naziv]}</td>"
    . "<td>{$user[nazivZup]}</td>"
    . "<td><a href='administratorPolicajci.php?idZnacke={$user[idZnacke]}&vrsta=2'>Azuriraj</a></td></tr>";
}
$tablica .= "</tbody></table></filedset>";



if ($vrsta==1){
    
    $upit = "SELECT * FROM korisnici where tipKorisnika_idtipKorisnika=2";
    $rezultat = $baza->selectDB($upit);
    $users = array();
    while ($red = mysqli_fetch_assoc($rezultat)){
        $users[]=$red;
    }
    $selectkorisnici;
    foreach ($users as $user){
    $selectkorisnici .= "<option value='{$user[idkorisnici]}'>{$user[ime]} {$user[prezime]}";

    }

    $upit = "SELECT * from pol_uprave";
    $rezultat = $baza->selectDB($upit);
    $users = array();
    while ($red = mysqli_fetch_assoc($rezultat)){
        $users[]=$red;
    }
    $selectUprave;
    foreach ($users as $user){
    $selectUprave .= "<option value='{$user[idpolUprave]}'>{$user[naziv]}";
    }
    
    $kategorijeHTML="<form name='policajac1' id='policajac1' class='center'
                      enctype='multipart/form-data'
                      action='administratorPolicajci.php?vrsta=1' 
                      method='POST'>
                    
                    <fieldset>
                        <legend>Dodaj novo policajca</legend>
                    <div class='row'>
                        <div class='large-12 columns'>
                            <label>Korisnik
                                <select name='korisnik'>
                                   $selectkorisnici
                                </select>
                            </label>
                        </div>
                    </div>
                    <div class='row'>
                        <div class='large-12 columns'>
                            <label>Policijska uprava
                                <select name='polUprava'>
                                   $selectUprave
                                </select>
                            </label>
                        </div>
                    </div>
                    <div class='row'>
                        <div class='large-12 columns'>
                            <label>Znacka
                                <input type='text' id='znacka' name='znacka' size='10' maxlength='10' placeholder='Znacka' />
                            </label>
                        </div>
                    </div>
                    </div>
                    <div class='row'>
                        <div class='large-12 columns'>
                            <label>Vrsta
                                <input type='text' id='vrsta' name='vrsta' placeholder='Vrsta' />
                            </label>
                        </div>
                    </div>
                    
                    <div class='text-center'>
                          <input id='submit1' name='submit1' class='button' type='submit' value='Dodaj'>
                          <input id='submit4' name='submit4' class='button' type='submit' value='Odustani'>
                        </div>
                    </fieldset>
                </form>";
}

if ($vrsta==2){
    $idZnacke = $_GET['idZnacke'];
    
    $upit = "SELECT * from pol_uprave";
    $rezultat = $baza->selectDB($upit);
    $users = array();
    while ($red = mysqli_fetch_assoc($rezultat)){
        $users[]=$red;
    }
    $selectUprave;
    foreach ($users as $user){
    $selectUprave .= "<option value='{$user[idpolUprave]}'>{$user[naziv]}";
    }
    
    //UPIT ZA POPUNJAVANJE POLJA - isti ko početni upit za tablicu
    $upit = "SELECT po.idZnacke, k.ime, k.prezime, po.vrstapolicajca, pu.naziv, pu.zupanije_idzupanije, pu.idpolUprave, z.nazivZup 
    FROM policajac po
    INNER JOIN korisnici k ON po.korisnici_idkorisnici = k.idkorisnici
    INNER JOIN pol_uprave pu ON pu.idpolUprave = po.polUprave_idpolUprave
    INNER JOIN zupanije z ON z.idzupanije = pu.zupanije_idzupanije
    WHERE po.idZnacke={$idZnacke}";
    $rezultat = $baza->selectDB($upit);
    $users = array();
    while ($red = mysqli_fetch_assoc($rezultat)){
        $users[]=$red;
    }
    foreach ($users as $user){
        
    $kategorijeHTML="<form name='policajac2' id='policajac2' class='center'
                      enctype='multipart/form-data'
                      action='administratorPolicajci.php?idZnacke={$user[idZnacke]}&vrsta=1' 
                      method='POST'>
                    
                    <fieldset>
                        <legend>Ažuririraj policajca</legend>
                    <div class='row'>
                        <div class='large-12 columns'>
                            <label>Korisnik
                                <input type='text' id='korisnik' value='{$user[ime]} {$user[prezime]}' readonly name='korisnik' size='10' maxlength='10' placeholder='Znacka' />
                            </label>
                        </div>
                    </div>
                    <div class='row'>
                        <div class='large-12 columns'>
                            <label>Policijska uprava
                                <select name='polUprava'>
                                   $selectUprave
                                </select>
                            </label>
                        </div>
                    </div>
                    <div class='row'>
                        <div class='large-12 columns'>
                            <label>Znacka
                                <input type='text' id='znacka' name='znacka' value='{$user[idZnacke]}' readonly size='10' maxlength='10' placeholder='Znacka' />
                            </label>
                        </div>
                    </div>
                    </div>
                    <div class='row'>
                        <div class='large-12 columns'>
                            <label>Vrsta
                                <input type='text' id='vrsta' name='vrsta' value='{$user[vrstapolicajca]}' placeholder='Vrsta' />
                            </label>
                        </div>
                    </div>
                    
                    <div class='text-center'>
                          <input id='submit2' name='submit2' class='button' type='submit' value='Izmjeni'>
                          <input id='submit3' name='submit3' class='button' type='submit' value='Izbriši'>
                          <input id='submit4' name='submit4' class='button' type='submit' value='Odustani'>
                        </div>
                    </fieldset>
                </form>";
    }
}

if (isset($_POST['submit1'])){
    $korisnik = $_POST['korisnik'];
    $polUprava = $_POST['polUprava'];
    $znacka = $_POST['znacka'];
    $vrsta = $_POST['vrsta'];
    
    $upit = "INSERT into policajac (idZnacke,vrstapolicajca,polUprave_idpolUprave,korisnici_idkorisnici)"
            . "VALUES('$znacka','$vrsta','$polUprava','$korisnik')";
    $baza->updateDB($upit);
    
    $upit = "UPDATE korisnici SET tipKorisnika_idtipKorisnika='3'WHERE idkorisnici='$korisnik'";
    $baza->updateDB($upit);
    
    header("Location: administratorPolicajci.php");

}

if (isset($_POST['submit2'])){
    $korisnik = $_POST['korisnik'];
    $polUprava = $_POST['polUprava'];
    
    $idZnacke = $_GET['idZnacke'];
    $vrsta = $_POST['vrsta'];
    
    $upit = "UPDATE policajac SET vrstapolicajca='$vrsta', polUprave_idpolUprave='$polUprava'"
            . "WHERE idZnacke='$idZnacke'";
    $baza->updateDB($upit);
    header("Location: administratorPolicajci.php");
}
if (isset($_POST['submit3'])){
     $idZnacke = $_GET['idZnacke'];
    
     $upit = "DELETE FROM policajac WHERE idZnacke={$idZnacke}";
     $baza->updateDB($upit);
     header("Location: administratorPolicajci.php");
}

if (isset($_POST['submit4'])){
     header("Location: administratorPolicajci.php");
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
                <li><a href="views/popis.php">Popis</a></li>
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
               <input type="submit" value="Dodaj novog policajca" class="button" onclick="window.location='http://arka.foi.hr/WebDiP/2013_projekti/WebDiP2013_031/views/administratorPolicajci?vrsta=1';" />  

            </div>
           
            <?php
            if ($vrsta == 2 || $vrsta == 1){
                echo $kategorijeHTML;
            }else{
                
                echo $tablica;
                 
            }
            ?>
           
            
            
            
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
