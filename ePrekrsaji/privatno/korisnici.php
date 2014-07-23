<?php

include_once '../class/baza.class.php';

$baza = new baza();
$upit = "SELECT * FROM korisnici ";
$rezultat = $baza->selectDB($upit);

$users = array();

while ($red = mysqli_fetch_assoc($rezultat)){
    $users[]=$red;
}
$tablica = "<table border=1><thead><tr><th>ID</th><th>Ime</th><th>Prezime</th><th>Email</th><th>Status</th><th>Kor ime</th><th>lozinka</th><th>OIB</th></tr></thead><tbody>";

foreach ($users as $user){
    $tablica .= "<tr><td>{$user[idkorisnici]}</td>"
    . "<td>{$user[ime]}</td>"
    . "<td>{$user[prezime]}</td>"
    . "<td>{$user[email]}</td>"
    . "<td>{$user[statusRacuna]}</td>"
    . "<td>{$user[korIme]}</td>"
    . "<td>{$user[lozinka]}</td>"
    . "<td>{$user[OIB]}</td>"
    . "<td>{$user[tipKorisnika_idtipKorisnika]}</td></tr>";
}

$tablica .= "</tbody></table>";

echo $tablica;

?>