<?php

include_once '../class/baza.class.php';
$baza = new baza();

if (isset($_POST['zaboravljenaLozinka'])){
    
    
    $unos= $_POST['unos'];
    $upit = "SELECT * from korisnici where korIme='{$unos}' OR email='{$unos}'"; 
    $rezultat = $baza->selectDB($upit);
    

    $users = array();
    while ($red = mysqli_fetch_assoc($rezultat)){
        $users[]=$red;
}
    
    if ($rezultat->num_rows == 0) {
        header('Location: ../views/greske.php?idGreske=12');
            exit();
    }else{
        function randomPassword() {
            $alphabet = "abcdefghijklmnopqrstuwxyzABCDEFGHIJKLMNOPQRSTUWXYZ0123456789";
            $pass = array(); //remember to declare $pass as an array
            $alphaLength = strlen($alphabet) - 1; //put the length -1 in cache
            for ($i = 0; $i < 8; $i++) {
                $n = rand(0, $alphaLength);
                $pass[] = $alphabet[$n];
            }
            return implode($pass); //turn the array into a string
           }
        $genPass = randomPassword();
        
        
        
        $upit2 = "UPDATE korisnici set lozinka='$genPass' WHERE korIme='{$unos}'";
        $baza->updateDB($upit2);
        
        $primatelj = $users[0][email];
        $naslov = "Nova lozinka - ePrekršaji";
        $poruka = "Poštovani, Vaša nova lozinka je {$genPass} "
        . "ePrekršaji http://arka.foi.hr/WebDiP/2013_projekti/WebDiP2013_031/views/prijava.php";
        mail($primatelj, $naslov, $poruka);
        
        header('Location: ../views/uspjesi.php?idUspjeh=1');
            exit();
        
    }
    
}

?>