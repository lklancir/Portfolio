<!DOCTYPE html>
<!--
To change this license header, choose License Headers in Project Properties.
To change this template file, choose Tools | Templates
and open the template in the editor.
-->
<html dir="ltr" lang="hr">
    <head>
    	<!--[if IE]>
		<meta http-equiv="X-UA-Compatible" content="IE=edge;chrome=1">
		<![endif]-->
        <title>Registracija</title>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width; initial-scale=1.0; maximum-scale=10.0; user-scalable=1;">
        <link rel="stylesheet" type="text/css" href="css/foundation.css.css"/>


       
    </head>
    <body>
        <header id="zaglavlje">
        </header>
    </body>
</html>

<?php

if (isset($_GET['idGreske'])) {

    $idGreske = $_GET['idGreske'];
    
   
    if ($idGreske == 1){
        echo "Zauzeti mail<br/>";
    }
    if ($idGreske == 2){
        echo "Niste popunili sva polja<br/>";
    }
    if ($idGreske == 3){
        echo "Ime i prezime moraju pocinjati sa velikim slovom.<br>";
    }
    if ($idGreske == 4){
        echo "Netocno strukturirana email adresa.<br />";
    }
    if ($idGreske == 5){
        echo "Lozinke nisu jednake. <br />";
    }
    
    if ($idGreske == 6){
        echo "Krivo unesena CAPTCHA <br />";
    }
    if ($idGreske == 7){
        echo "Rok za aktivaciju je bio 24h <br />";
    }
    if ($idGreske == 8){
        echo "Greška kod zapisa u bazu <br />";
    }
    if ($idGreske == 9){
        echo "Niste prijavljeni u sustav <br />";
    }
    if ($idGreske == 10){
        echo "Lozinka se ne podudara <br />";
    }
    if ($idGreske == 11){
        echo "3 neuspješne prijave za redom odnosno/ili račun blokiran <br />";
    }
    if ($idGreske == 12){
        echo "Ne postoji korisnik sa tim korisničkim imenom/emailom <br />";
    }
    
    if ($idGreske == 13){
        echo "Lozinka ima premalo znakova ";
    }
    
    if ($idGreske == 14){
        echo "Niste aktivirali račun";
    }
    
    if ($idGreske == 15){
        echo "OIB postoji";
    }
    
    
    }




?>
