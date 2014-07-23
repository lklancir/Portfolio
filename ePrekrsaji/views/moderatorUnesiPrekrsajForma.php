<?php
session_start();
if (!isset($_SESSION['id_korisnik'])) {
    header('Location:greske.php?idGreske=9');
    exit();
}
include_once 'vrijeme.php';
include_once '../class/baza.class.php';
$baza = new baza();

$idKorisnici = $_GET['idKorisnici'];
$date = date('Y-m-d');
//ŽUPANIJE PREMA POLICAJCU
$upit = "SELECT policajac.idZnacke, pol_uprave.idpolUprave, korisnici.idkorisnici, zupanije.nazivZup, zupanije.idzupanije
FROM policajac
INNER JOIN pol_uprave ON policajac.polUprave_idpolUprave = pol_uprave.idpolUprave
INNER JOIN korisnici ON policajac.korisnici_idkorisnici = korisnici.idkorisnici
INNER JOIN zupanije ON pol_uprave.zupanije_idzupanije = zupanije.idzupanije
WHERE korisnici.idkorisnici ={$_SESSION['id_korisnik']}";

$rezultat = $baza->selectDB($upit);
$users = array();
while ($red = mysqli_fetch_assoc($rezultat)){
    $users[]=$red;
}

foreach ($users as $user){
    $idZnacke = $user[idZnacke];
    $nazivZupanije = $user[nazivZup];
}


//KATEGORIJE PREKRŠAJA
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


$upit = "SELECT * FROM dosje_osobe WHERE korisnici_idkorisnici={$idKorisnici}";
$rezultat = $baza->selectDB($upit);
if ($rezultat->num_rows == 0){
    $upit = "INSERT into dosje_osobe(datum_kreacije,korisnici_idkorisnici) VALUES('$date','$idKorisnici')";
    $baza->updateDB($upit);
}

if (isset($_POST['submit'])){
   $mjesto = $_POST['Mjesto'];   
   $opisPrekrsaja = $_POST['opisPrekrsaja'];
   $kategorijaPrek = $_POST['kategorijaPrek'];
   $datum = $_POST['datum'];
   $vrijeme = $_POST['vrijeme'];
   $datumVrijeme = $datum ." ". $vrijeme .":00";
   
   $upit = "INSERT INTO mjesto (mNaziv) VALUES('$mjesto')";
   $baza->updateDB($upit);
   $upit = "SELECT idmjesto FROM mjesto WHERE mNaziv='$mjesto'";
   $rezultat = $baza->selectDB($upit);
   $id_mjesto= mysqli_fetch_row($rezultat);
   $upit = "SELECT id_dosje FROM dosje_osobe WHERE korisnici_idkorisnici='$idKorisnici'";
   $rezultat = $baza->selectDB($upit);
   $id_dosje= mysqli_fetch_row($rezultat);
  
   $upit = "INSERT INTO prekrsaji(opis_prekrsaja,mjesto_idmjesto,datumVrijeme,dosje_osobe_id_dosje,policajac_idZnacke,kategorije_prek_idkategorije_prek)"
           . "VALUES('$opisPrekrsaja','$id_mjesto[0]','$datumVrijeme','$id_dosje[0]','$idZnacke','$kategorijaPrek')";
   $baza->updateDB($upit);
   header("Location: moderatorUnesiPrekrsaj.php");
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
          <form name="prekrsaji" id="prekrsaji" class="center"
                      enctype="multipart/form-data"
                      action="moderatorUnesiPrekrsajForma.php?idKorisnici=<?php echo $idKorisnici; ?>" 
                      method="POST">
                    
                    <fieldset>
                       
                        <legend>Prekršaj</legend>
                     <div class="row">
                        <div class="large-12 columns">
                            <label>Županija
                                <input type="text" id="Mjesto" name="Mjesto" placeholder="<?php echo $nazivZupanije ?>" readonly="readonly" />
                            </label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="large-12 columns">
                            <label>Mjesto
                                <input type="text" id="Mjesto" name="Mjesto" placeholder="Mjesto" />
                            </label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="large-6 columns">
                            <label>Datum prekršaja
                                <input type="date" id="datum" name="datum" placeholder="Mjesto" />
                            </label>
                        </div>
                    
                   
                        <div class="large-6 columns">
                            <label>Vrijeme prekršaja
                                <input type="time" id="vrijeme" name="vrijeme" placeholder="Mjesto" />
                            </label>
                        </div>
                    </div>
                    <div class="row">
                        <div class="large-12 columns">
                            <label>Opis prekršaja
                                <input type="text" id="opisPrekrsaja" name="opisPrekrsaja" placeholder="Opis Prekrsaja" />
                            </label>
                        </div>
                    </div>
                    <div class="row">
                    <div class="large-12 columns">
                        <label>Kategorija prekršaja
                            <select name="kategorijaPrek">
                                <?php
                                echo $select;
                                ?>
                            </select>
                        </label>
                     </div>
                     </div>
                    <div class="text-center">
                          <input id="submit" name="submit" class="button" type="submit" value="Unesi prekršaj">
                     
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


