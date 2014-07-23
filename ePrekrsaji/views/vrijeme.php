<?php

if (isset($_POST['submitVrijeme'])){
    $satiNovo = $_POST['vrijeme'];
            
            
            $my_file = "../JSON/pomak.xml";
            $handle = fopen($my_file, 'r') or die('Cannot open file:  '.$my_file);


            $xml = new DOMDocument();
            $xml->load($my_file);

            // get list of all shift elements
            $nodes = $xml->getElementsByTagName('pomak');
            // get first shift element
            $xmlShift = $nodes->item(0);
            // set attribute "hours"
            $xmlShift->setAttribute("brojSati", $satiNovo);

            $xml->save($my_file);
}

$url = "http://arka.foi.hr/WebDiP/2013_projekti/WebDiP2013_031/JSON/pomak.xml";

if (!($fp = fopen($url, 'r'))) {
    echo "Problem: nije moguće otvoriti url: " . $url;
    exit;
}

$xml_string = fread($fp, 10000);
fclose($fp);

// create a DOM object from the XML data
$domdoc = new DOMDocument;
$domdoc->loadXML($xml_string);

$params = $domdoc->getElementsByTagName('pomak');
$sati = 0;

foreach ($params as $param) {
    $attributes = $param->attributes;
    foreach ($attributes as $attr => $val) {
        if ($attr == "brojSati") {
            $sati = $val->value;
        }
    }
}
$vrijeme_servera = time();
$vrijeme_sustava = $vrijeme_servera + ($sati * 60 * 60);
//echo "Stvarno vrijeme servera: " . date('d.m.Y H:i:s', $vrijeme_servera) . "<br>";
//echo "Virtualno vrijeme sustava: " . date('d.m.Y H:i:s', $vrijeme_sustava) . "<br>";

$vrijeme_sustava_final = date('H:i:s', $vrijeme_sustava);
$datum = date('Y-m-d',$vrijeme_sustava);
$sati = date('H',$vrijeme_sustava);
$minute = date('i',$vrijeme_sustava);
$sekunde = date('s',$vrijeme_sustava);


if (isset($_POST['submitVrijeme'])){
    header('Location: administratorPostavke.php');
}

?>
