<?php
session_start();
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
        <link rel="stylesheet" type="text/css" href="css/foundation.css"/>
        <link rel="stylesheet" type="text/css" href="css/main.css"/>
        
        
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
                
                <?php
                    if(isset($_SESSION['id_korisnik'])){
                                        echo '<li><a href="views/odjava.php"> Odjava </a></li>';
                            }
                            else{
                                echo '<li><a href="views/prijava.php"> Prijava </a></li>';
                            }
                ?>
                <li><a href="views/registracija.php">Registracija</a></li>
                
            </ul>

   
            <ul class="left">
                
                <li><a href="views/popis.php">Popis</a></li>
                <li><a href="dokumentacija.html">Dokumentacija</a></li>
            </ul>
            </section>
        </nav>
        <section id="sadrzaj">
            <h1 id="animacija" >Dobrodošli na stranice ePrekršaja</h1>     
            
        </section>
        <footer id="podnozje">
           <br/><br/>
           Copyright Luka Klancir ©2014
           <br/><br/><br/><br/><br/>
        </footer>
     
        <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.0/jquery.min.js"></script>
        <script src="http://code.jquery.com/ui/1.10.4/jquery-ui.js"></script>
        <script src="http://datatables.net/download/build/nightly/jquery.dataTables.js"></script>
        <script src="js/lklancir_jquery.js"></script>
        <script src="js/lklancir.js"></script>
        <script src="js/foundation.min.js"></script>
        <script>$(document).foundation();</script>
    </body>
</html>