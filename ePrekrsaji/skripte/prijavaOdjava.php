<?php

session_start();
include_once '../class/baza.class.php';

class prijavaOdjava {

    public function autentikacija($username, $password) {
        $baza = new baza();
        
        
        
        
       $upit2 = "SELECT * FROM korisnici WHERE korIme='{$username}';";
       $rezultat2 = $baza->selectDB($upit2);
       $users2 = array();
       while ($red = mysqli_fetch_assoc($rezultat2)){
            $users2[]=$red;
        }
       if ($users2[0][tipKorisnika_idtipKorisnika]==1){
            header('Location:greske.php?idGreske=14');
            exit();
       }
        
       if ($users2[0][statusRacuna]>=3){
            header('Location:greske.php?idGreske=11');
            exit();
       }
       
       if (($users2[0][lozinka])!=($password)){
            $statusRacuna = $users2[0][statusRacuna]+1;
            $upit3 = "UPDATE korisnici set statusRacuna='{$statusRacuna}' WHERE korIme='{$username}';";
            $baza->updateDB($upit3);
            header('Location:greske.php?idGreske=10');
            exit();
        }
        
        
        $upit = "SELECT * FROM korisnici WHERE korIme='{$username}' AND lozinka='{$password}'";
        $rezultat = $baza->selectDB($upit);
        
        if ($rezultat->num_rows == 0) {
            header('Location:greske.php?idGreske=8');
            exit();
        }
        
        $upit4 = "UPDATE korisnici SET statusRacuna='0' WHERE korIme='{$username}' AND lozinka='{$password}'; ";
        $baza->updateDB($upit4);
        
        $this->kreiranjeSesijskihPodataka($rezultat);
        
        $log = new Log();
        $log->logiranje($_SERVER['HTTP_USER_AGENT'],$_SERVER['REMOTE_ADDR'],$_SESSION['id_korisnik'], "login", "korisnik {$_SESSION['ime']} {$_SESSION['prezime']} se prijavio u sustav" );
       
        switch($_SESSION['tip_korisnika_id']){
            case 2: header('Location:registrirani.php'); break;
            case 3: header('Location:moderator.php'); break;
            case 4: header('Location:administrator.php'); break;
        }
        
    }

    public function kreiranjeSesijskihPodataka($rezultat) {
        while ($row = mysqli_fetch_array($rezultat)) {
            $_SESSION['tip_korisnika_id'] = $row['tipKorisnika_idtipKorisnika'];
            $_SESSION['id_korisnik'] = $row['idkorisnici'];
            $_SESSION['ime'] = $row['ime'];
            $_SESSION['prezime'] = $row['prezime'];
            $_SESSION['email'] = $row['email'];



        }
    }

    public function brisanjeSesijskihPodataka() {
        unset($_SESSION['tip_korisnika_id']);
        unset($_SESSION['id_korisnik']);
        unset($_SESSION['ime']);
        unset($_SESSION['prezime']);
        unset($_SESSION['email']);


                
    }

    public function kreiranjeKolacica($korime, $nazivKolacica) {
        setcookie($nazivKolacica, $korime, time() + 60 * 60 * 24 * 30);
    }

    public function brisanjeKolacica($nazivKolacica) {
        setcookie($nazivKolacica, '', time() - 60);
    }

}

?>
