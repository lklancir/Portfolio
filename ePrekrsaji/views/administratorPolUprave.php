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

$upit = "SELECT pu.idpolUprave, pu.adresa, pu.kontakt, pu.naziv, z.nazivZup
FROM pol_uprave pu
INNER JOIN zupanije z ON pu.zupanije_idzupanije = z.idzupanije";

$rezultat = $baza->selectDB($upit);
    $users = array();
    while ($red = mysqli_fetch_assoc($rezultat)){
        $users[]=$red;
    }
$tablica = "<fieldset class='center'>
                <legend>Policijske uprave</legend><table id='korisnici' class='center2'><thead><tr><th>ID uprave</th><th>Naziv</th><th>Adresa</th><th>Kontakt</th><th>Županija</th><th>Akcija</th></tr></thead><tbody>";

foreach ($users as $user){
    $tablica .= "<tr><td>{$user[idpolUprave]}</td>"
    . "<td>{$user[naziv]}</td>"
    . "<td>{$user[adresa]}</td>"
    . "<td>{$user[kontakt]}</td>"
    . "<td>{$user[nazivZup]}</td>"
    . "<td><a href='administratorPolUprave.php?idpolUprave={$user[idpolUprave]}&vrsta=2' >Azuriraj</a></td></tr>";
}
$tablica .= "</tbody></table></fieldset>";

//UPIT GLOBALNO POLICAJAC
$upit = "SELECT po.idZnacke, k.ime, k.prezime
             FROM policajac po
             INNER JOIN korisnici k ON po.korisnici_idkorisnici = k.idkorisnici";
    $rezultat = $baza->selectDB($upit);
    $users = array();
    while ($red = mysqli_fetch_assoc($rezultat)){
        $users[]=$red;
    }
    $checkpolicajac;
    foreach ($users as $user){
    $checkpolicajac .= "<input id='{$user[idZnacke]}' value='{$user[idZnacke]}' name='policajci[]' type='checkbox'><label for='{$user[idznacke]}'>{$user[ime]} {$user[prezime]}</label></br>" ;
    } // BILE SU TU NEKE VITIČASTE
if ($vrsta==1){
    $upit = "SELECT * FROM zupanije";
    $rezultat = $baza->selectDB($upit);
    $users = array();
    while ($red = mysqli_fetch_assoc($rezultat)){
        $users[]=$red;
    }
    
    // SELECT ŽUPANIJE
    $selectzupanije;
    foreach ($users as $user){
    $selectzupanije .= "<option value='{$user[idzupanije]}'>{$user[nazivZup]}";
    }
    
    
    
    $kategorijeHTML="<form name='polUprave1' id='polUprave1' class='center'
                      enctype='multipart/form-data'
                      action='administratorPolUprave.php?vrsta=1' 
                      method='POST'>
                    
                    <fieldset>
                        <legend>Policijska uprava</legend>
                    <div class='row'>
                        <div class='large-12 columns'>
                            <label>Naziv policijske uprave
                                <input type='text' id='naziv' name='naziv' placeholder='Naziv policijske uprave' />
                            </label>
                        </div>
                    </div>
                    <div class='row'>
                        <div class='large-12 columns'>
                            <label>Županija
                                <select name='zupanija'>
                                   $selectzupanije
                                </select>
                            </label>
                        </div>
                    </div>
                    <div class='row'>
                        <div class='large-12 columns'>
                            <label>Adresa
                                <input type='text' id='adresa' name='adresa' placeholder='Adresa' />
                            </label>
                        </div>
                    </div>
                    </div>
                    <div class='row'>
                        <div class='large-12 columns'>
                            <label>Kontakt
                                <input type='text' id='kontakt' name='kontakt' placeholder='Kontakt' />
                            </label>
                        </div>
                    </div>
                    <div class='row'>
                        <div class='large-12 columns'>
                            <label>Dodaj policajce </br></br>
                                $checkpolicajac;
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
    
    
    
    //POPUNJAVANJE ŽUPANIJE
    $upit = "SELECT * FROM zupanije";
    $rezultat = $baza->selectDB($upit);
    $users = array();
    while ($red = mysqli_fetch_assoc($rezultat)){
        $users[]=$red;
    }
    $selectzupanije;
    foreach ($users as $user){
    $selectzupanije .= "<option value='{$user[idzupanije]}'>{$user[nazivZup]}";
    }
    
    //UPIT ZA POPUNJAVANJE POLJA
    $idpolUprave = $_GET['idpolUprave'];
    $upit = "SELECT * FROM pol_uprave pu 
    WHERE pu.idpolUprave='$idpolUprave';";
    
    $rezultat = $baza->selectDB($upit);
    $users = array();
    while ($red = mysqli_fetch_assoc($rezultat)){
        $users[]=$red;
    }
    
    //UPIT ZA POLICAJCE
    $upit2 = "SELECT po.idZnacke, k.ime, k.prezime
             FROM policajac po
             INNER JOIN korisnici k ON po.korisnici_idkorisnici = k.idkorisnici";
    $rezultat2 = $baza->selectDB($upit2);
    $users2 = array();
    while ($red = mysqli_fetch_assoc($rezultat2)){
        $users2[]=$red;
    }
   
    $upit3= "SELECT pu.idpolUprave, pu.adresa, pu.kontakt, pu.naziv, p.idZnacke, p.polUprave_idpolUprave
    FROM pol_uprave pu
    INNER JOIN policajac p ON pu.idpolUprave = p.polUprave_idpolUprave 
    WHERE pu.idpolUprave={$idpolUprave}";
    $rezultat3 = $baza->selectDB($upit3);
    $users3 = array();
    while ($red = mysqli_fetch_assoc($rezultat3)){
        $users3[]=$red;
    }
    
//    $checkpolicajac;
//    foreach ($users2 as $user2){
//        if ((array_key_exists($user2[idZnacke], $users))){
//            $checkpolicajac .= "<input id='{$user2[idZnacke]}' checked value='{$user2[idZnacke]}' name='policajci[]' type='checkbox'><label for='{$user2[idznacke]}'>{$user2[ime]} {$user2[prezime]}</label></br>" ;
//        }else{
//            $checkpolicajac .= "<input id='{$user2[idZnacke]}'  value='{$user2[idZnacke]}' name='policajci[]' type='checkbox'><label for='{$user2[idznacke]}'>{$user2[ime]} {$user2[prezime]}</label></br>" ;
//        }
//    }
    
    foreach ($users as $user){
        foreach ($users3 as $user3){
        foreach ($users2 as $user2){
            if(($user3[idZnacke])==($user2[idZnacke]))
             $checkpolicajac .= "<input id='{$user2[idZnacke]}' onclick='return false' checked value='{$user2[idZnacke]}' name='policajci[]' type='checkbox'><label for='{$user2[idznacke]}'>{$user2[ime]} {$user2[prezime]}</label></br>" ;
        }
        }
        
    $kategorijeHTML="<form name='polUprave2' id='polUprave2' class='center'
                      enctype='multipart/form-data'
                      action='administratorPolUprave.php?idpolUprave={$idpolUprave}&vrsta=2' 
                      method='POST'>
                    
                    <fieldset>
                        <legend>Policijska uprava</legend>
                    <div class='row'>
                        <div class='large-12 columns'>
                            <label>Naziv policijske uprave
                                <input type='text' id='naziv' name='naziv' value='{$user[naziv]}' placeholder='Naziv policijske uprave' />
                            </label>
                        </div>
                    </div>
                    <div class='row'>
                        <div class='large-12 columns'>
                            <label>Županija
                                <select name='zupanija'>
                                   $selectzupanije
                                </select>
                            </label>
                        </div>
                    </div>
                    <div class='row'>
                        <div class='large-12 columns'>
                            <label>Adresa
                                <input type='text' id='adresa' value='{$user[adresa]}' name='adresa' placeholder='Adresa' />
                            </label>
                        </div>
                    </div>
                    </div>
                    <div class='row'>
                        <div class='large-12 columns'>
                            <label>Kontakt
                                <input type='text' id='kontakt' value='{$user[kontakt]}' name='kontakt' placeholder='Kontakt' />
                            </label>
                        </div>
                    </div>
                    <div class='row'>
                        <div class='large-12 columns'>
                            <label>Dodaj policajce </br></br>
                                $checkpolicajac;
                            </label>
                        </div>
                    </div>
                    <div class='text-center'>
                          <input id='submit2' name='submit2' class='button' type='submit' value='Dodaj'>
                          <input id='submit3' name='submit3' class='button' type='submit' value='Izbriši'>
                          <input id='submit4' name='submit4' class='button' type='submit' value='Odustani'>
                        </div>
                    </fieldset>
                </form>";
    }
}

if (isset($_POST['submit1'])){
    $naziv = $_POST['naziv'];
    $zupanija = $_POST['zupanija'];
    $adresa = $_POST['adresa'];
    $kontakt = $_POST['kontakt'];
    $policajci = $_POST['policajci'];
    $upit = "INSERT into pol_uprave (adresa,kontakt,zupanije_idzupanije,naziv) VALUES ('$adresa','$kontakt','$zupanija','$naziv')";
    $baza->updateDB($upit);
    
    $meduupit = "SELECT idpolUprave FROM pol_uprave WHERE naziv='{$naziv}'";
    $rezultat = $baza->selectDB($meduupit);
    
    $idpolUprave= mysqli_fetch_row($rezultat);
        
    
    foreach($_POST['policajci'] as $check) {
           
        $upit = "UPDATE policajac SET polUprave_idpolUprave={$idpolUprave[0]} WHERE idZnacke={$check}";
        $baza->updateDB($upit);
    }
    
    
}
// UPADTE
if (isset($_POST['submit2'])){
    $naziv = $_POST['naziv'];
    $zupanija = $_POST['zupanija'];
    $adresa = $_POST['adresa'];
    $kontakt = $_POST['kontakt'];
    $policajci = $_POST['policajci'];
    $upit = "UPDATE pol_uprave SET adresa='$adresa',kontakt='$kontakt',zupanije_idzupanije='$zupanija',naziv='$naziv' WHERE idpolUprave='$idpolUprave' ";
    $baza->updateDB($upit);
    
    foreach($_POST['policajci'] as $check) {
           
        $upit = "UPDATE policajac SET polUprave_idpolUprave={$idpolUprave} WHERE idZnacke={$check}";
        $baza->updateDB($upit);
    }
    header("Location: administratorPolUprave.php");
}
//IZBRISI
if (isset($_POST['submit3'])){
    
    
    foreach($_POST['policajci'] as $check) {
          
        $upit = "UPDATE  `WebDiP2013_031`.`policajac` SET  `polUprave_idpolUprave` =  '62' WHERE  `policajac`.`idZnacke` =  '{$check}';";
        $baza->updateDB($upit);
    }
    
    $upit = "DELETE FROM pol_uprave WHERE idpolUprave='{$idpolUprave}' ";
    $baza->updateDB($upit);
    header("Location: administratorPolUprave.php");
}

if (isset($_POST['submit4'])){
     header("Location: administratorPolUprave.php");
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
               <input type="submit" value="Dodaj novu" class="button" onclick="window.location='http://arka.foi.hr/WebDiP/2013_projekti/WebDiP2013_031/views/administratorPolUprave?vrsta=1';" />  

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

