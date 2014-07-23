<?php

if(isset($_SESSION['id_korisnik'])){
                                        echo '<li><a href="odjava.php"> Odjava </a></li>';
                            }
                            else{
                                echo '<li><a href="prijava.php"> Prijava </a></li>';
                            }
                            
                            
?>