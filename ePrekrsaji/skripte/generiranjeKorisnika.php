<?php
include_once '../class/baza.class.php';
$baza = new baza();

$upit = "SELECT * FROM korisnici;";
$rezultat = $baza->selectDB($upit);

while($obj = mysqli_fetch_object($rezultat)) {
$array[] = $obj;
}

$my_file = '../JSON/korisnici.json';

$handle = fopen($my_file, 'w') or die('Cannot open file:  '.$my_file);
$data = json_encode($array);
fwrite($handle, $data);
fclose($handle);







if (isset($_SERVER['HTTP_ORIGIN'])) {
        header("Access-Control-Allow-Origin: {$_SERVER['HTTP_ORIGIN']}");
        header('Access-Control-Allow-Credentials: true');
        header('Access-Control-Max-Age: 86400');    // cache for 1 day
    }

    // Access-Control headers are received during OPTIONS requests
    if ($_SERVER['REQUEST_METHOD'] == 'OPTIONS') {

        if (isset($_SERVER['HTTP_ACCESS_CONTROL_REQUEST_METHOD']))
            header("Access-Control-Allow-Methods: GET, POST, OPTIONS");         

        if (isset($_SERVER['HTTP_ACCESS_CONTROL_REQUEST_HEADERS']))
            header("Access-Control-Allow-Headers: {$_SERVER['HTTP_ACCESS_CONTROL_REQUEST_HEADERS']}");

        exit(0);
    }


	header("Content-Type:application/xml");
	echo '<?xml version="1.0" encoding="utf-8"?><korisnici>';

	$korisnik = $_GET['korisnik'];
        $korisnikEmail = $_GET['korisnikEmail'];
        
        if ($korisnikEmail!=""){
	$korisnici = json_decode(file_get_contents('../JSON/korisnici.json'));
	$found = 0;
	foreach($korisnici as $k) {
		if ($k->email == $korisnikEmail) {
			$found = 1;
		} 
	}
        }
        
        if ($korisnik!=""){
	$korisnici = json_decode(file_get_contents('../JSON/korisnici.json'));
	$found = 0;
	foreach($korisnici as $k) {
		if ($k->korIme == $korisnik) {
			$found = 1;
		} 
	}
        }
        
        
	echo "<korisnik>$found</korisnik>";
	echo "</korisnici>";
?>
