<?php
include_once '../class/baza.class.php';
$baza = new baza();

$upit = "SELECT * FROM zupanije;";
$rezultat = $baza->selectDB($upit);

while($obj = mysqli_fetch_object($rezultat)) {
$array[] = $obj;
}

$my_file = '../JSON/zupanije.json';

$handle = fopen($my_file, 'w') or die('Cannot open file:  '.$my_file);
$data = json_encode($array);
fwrite($handle, $data);
fclose($handle);



$upit = "SELECT * FROM pol_uprave;";
$rezultat = $baza->selectDB($upit);

while($obj = mysqli_fetch_object($rezultat)) {
$array2[] = $obj;
}

$my_file = '../JSON/pol_uprave.json';

$handle = fopen($my_file, 'w') or die('Cannot open file:  '.$my_file);
$data = json_encode($array2);
fwrite($handle, $data);
fclose($handle);


$upit = "SELECT p.idZnacke, k.ime, k.prezime, p.vrstapolicajca, pu.naziv
FROM policajac p
INNER JOIN korisnici k ON p.korisnici_idkorisnici = k.idkorisnici
INNER JOIN pol_uprave pu ON p.polUprave_idpolUprave = pu.idpolUprave;";
$rezultat = $baza->selectDB($upit);

while($obj = mysqli_fetch_object($rezultat)) {
$array3[] = $obj;
}

$my_file = '../JSON/policajac.json';

$handle = fopen($my_file, 'w') or die('Cannot open file:  '.$my_file);
$data3 = json_encode($array3);
fwrite($handle, $data3);
fclose($handle);

echo "sve oke";
        
?>
