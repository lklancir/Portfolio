<?php
session_start();
if (!isset($_SESSION['id_korisnik'])) {
    header('Location:greske.php?idGreske=9');
    exit();
}

include_once '../class/baza.class.php';
include_once '../fpdf/fpdf.php';
include_once '../fpdf/font/helvetica.php';

$pdf = new FPDF('L','mm','A4');
$pdf->AddPage();
$pdf->SetFont('Helvetica', '', 12);

$baza = new baza();
$upit = "SELECT * FROM dnevnik_sustava";
$rezultat = $baza->selectDB($upit);

$users = array();


while ($red = mysqli_fetch_assoc($rezultat)){
    $users[]=$red;
}
$naslov = "Dnevnik sustava";
$pdf->SetTitle($naslov);
$pdf->Multicell(0,10,'ID                        User Agent                                                            IP            Vrsta               Vrijeme');

foreach ($users as $user){
    $ID = $user[idDnevnikSustava];
    $UA = $user[user_agent];
    $IP = $user[IP_adresa];
    $vrsta = $user[vrsta];
    $logtime = $user[logTime];
    
    $pdf->Multicell(0,10,"$ID | $UA  |   $IP | $vrsta | $logtime      \n");
}

$pdf->Output();
?>

