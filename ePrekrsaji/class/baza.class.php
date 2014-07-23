<?php



class baza {
    
    const server = "localhost";
    const baza = "WebDiP2013_031";
    const korisnik = "WebDiP2013_031";
    const psswd = "admin_aeUr"; 
    
    
    private function spojiDB() {
        $mysqli = new mysqli(self::server, self::korisnik, self::psswd, self::baza);
        if ($mysqli->connect_errno) {
            echo "Neuspješno spajanje na bazu: " . $mysqli->connect_errno . ", " . $mysqli->connect_error;
        }
        $mysqli->query("SET NAMES utf8");  
        return $mysqli;
    }

    function selectDB($upit) {
        
        $veza = $this->spojiDB();
        $rezultat = $veza->query($upit) or trigger_error("Greška kod upita {$upit} - "
                        . "Greška: " . $veza->error . " " . E_USER_ERROR);
        if (!$rezultat) {
            $rezultat = null;
        }
        $veza->close();
        return $rezultat;
    }
    
    

    function updateDB($upit) {
        
        $veza = self::spojiDB();
        
        if($rezultat = $veza->query($upit)){
        } else {
            echo "Pogreška: ".$veza->error;
        }
//        closeDB($veza);
        $veza->close();
        return $rezultat;
        
    }
    
        function closeDB($veza){
            mysqli_close($veza);
        }  
      
}



class Log extends baza {
    
    public $user_agent;
    public $IP;
    public $korisnik;
    public $vrsta;
    public $opis;

    function logiranje($ua, $ip, $k, $v, $o) {
        $this->user_agent = $ua;
        $this->IP = $ip;
        $this->korisnik = $k;
        $this->vrsta = $v;
        $this->opis = $o;
        
        $upit = "INSERT INTO dnevnik_sustava (user_agent,IP_adresa,idkorinsika,vrsta,opis,logTime)"
                . "VALUES('$this->user_agent','$this->IP','$this->korisnik','$this->vrsta','$this->opis',CURRENT_TIMESTAMP);";
                
     
        
        parent::updateDB($upit);
        
        
    }

    

}
?>