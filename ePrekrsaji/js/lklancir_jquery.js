

// TABLICA / PAGINATION

$(document).ready(function (){
    $('#korisnici').dataTable({
        //"aaSorting":[[0, "desc"],[1, "asc"]]
        "bPaginate":true,
        "bSort": true,
        "bAutoWidth": false,
        "bFilter":true
    });
});

$(document).ready(function (){
    $('#korisnici2').dataTable({
        //"aaSorting":[[0, "desc"],[1, "asc"]]
        "bPaginate":true,
        "bSort": true,
        "bAutoWidth": false,
        "bFilter":true
    });
});

// TABLICA / PAGINATION


// GRADOVI AUTCOMPLETE

$(document).ready(function (){
    
    var gradovi = new Array();
    
    $.getJSON("http://arka.foi.hr/WebDiP/2013/materijali/dz3_dio2/gradovi.json", function (data){
        $.each( data, function(key, value){
            gradovi.push(value);
        });
    });
    
    $('#grad').autocomplete({
       source:gradovi 
    });
});


// IME VALIDACIJA


$(document).ready(function (){
    $('#ime').focusout(function (event){
       var ime = $('#ime').val();
       var broj = parseInt(ime);
       var patt = /\d+\.?\d*/g;
       var result = ime.match(patt);
       result = parseInt(result);
       
       if ( (ime[0] !== ime[0].toUpperCase()) || (!isNaN(broj)) || (!isNaN(result)) ){
           $('#ime').css("border-color","red");
           $("#ime").effect( "highlight", {color:"red"}, 1000 );
           $('#greska_ime').text("Ime mora počinjati sa velikim slovom / bez brojeva");           
       }else {
                	$("#ime").effect( "highlight", {color:"green"}, 1000 );
                	$('#greska_ime').text("");
                        $('#ime').css("border-color","");
                    }
    });
});

   // PREZIME VALIDACIJA 
    $(document).ready(function (){
    $('#prez').focusout(function (event){
       var prezime = $('#prez').val();
       var broj = parseInt(prezime);
       var patt = /\d+\.?\d*/g;
       var result = prezime.match(patt);
       result = parseInt(result);
       
       if ( (prezime[0] !== prezime[0].toUpperCase()) || (!isNaN(broj)) || (!isNaN(result)) ){
           $('#prez').css("border-color","red");
           $("#prez").effect( "highlight", {color:"red"}, 1000 );
           $('#greska_prez').text("Prezime mora počinjati sa velikim slovom / bez brojeva");    
       }else {
                	$("#prez").effect( "highlight", {color:"green"}, 1000 );
                	$('#greska_prez').text("");
                        $('#prez').css("border-color","");
                    }
    });
 });
       
 // PROVJERA KORISNICKO IME   


$(document).ready(function(){
    $('#korime').focusout(function (event){
        var korIme = $('#korime').val();
        console.log("Prihvaćen parametar iz formulara");
        $.ajax({
            type: "GET",
            url: "http://arka.foi.hr/WebDiP/2013_projekti/WebDiP2013_031/skripte/generiranjeKorisnika.php",
            dataType: 'XML',
            data: {
                'korisnik':korIme
            },
            success: function(data) {
                var zauzeto = "";
                $(data).find('korisnici').each(function (){
                    zauzeto = $(this).find('korisnik').text();
                });
                
                if(zauzeto == 1){
                    $('#korime').css("border-color","red");
                    $("#korime").effect( "highlight", {color:"red"}, 1000 );
                    $('#greska_korime').text("Zauzeto_korisničko_ime");
                    
                    
                } else {
                	$("#korime").effect( "highlight", {color:"green"}, 1000 );
                	$('#greska_korime').text("");
                        $('#korime').css("border-color","");

                    
                }
            },
            error: function(jqXHR, textStatus, errorThrown) {
                console.log("Greška kod slanja i primanja podataka");
            }
        });
        
        
    });
});

// PROVJERA KORISNICKO IME

// PROVJERA EMAIL

$(document).ready(function(){
    $('#email').focusout(function (event){
        var email= $('#email').val();
        var patt = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;


        if(patt.test(email) == false){
        	$('#email').css("border-color","red");
			$("#email").effect( "highlight", {color:"red"}, 1000 );
			$('#greska_email').text("Neispravan_mail");
			
			}

		else {
        $('#greska_email').text("");
        $('#email').css("border-color","");
        $.ajax({
            type: "GET",
            url: "http://arka.foi.hr/WebDiP/2013_projekti/WebDiP2013_031/skripte/generiranjeKorisnika.php",
            dataType: 'XML',
            data: {
                'korisnikEmail':email
            },
            success: function(data) {
                var zauzeto = "";
                $(data).find('korisnici').each(function (){
                    zauzeto = $(this).find('korisnik').text();
                });
                
                if(zauzeto == 1){
                    $('#email').css("border-color","red");
                    $('#greska_email').text("Zauzet_mail");
                    
                    
                } else {
                    $("#email").effect( "highlight", {color:"green"}, 1000 );
                    $('#greska_email').text("");
                    $('#email').css("border-color","");
                    
                }
            },
            error: function(jqXHR, textStatus, errorThrown) {
                e.preventDefault();
            }
        });
        
        }
    });
});


//LOZINKA

$(document).ready(function(){
   $('#lozinka2').keyup(function (event){
       var lozinka1= $('#lozinka1').val();
       var lozinka2= $('#lozinka2').val();
       if(lozinka1 !== lozinka2){
           $('#greska_lozinka2').text("Lozinke se ne podudaraju");
       }else{
           $('#greska_lozinka2').text("");
       }
   }); 
});








// POPIS ŽUPANIJA


$('#zupanije').click(function(event) {
        var tablica = $('<table id="tablica">');
        tablica.append('<thead><tr><th>ID</th><th>Ime</th></tr></thead>');
        $.ajax({
           type: "GET",
           url: "http://arka.foi.hr/WebDiP/2013_projekti/WebDiP2013_031/JSON/zupanije.json",
           dataType: "json",
         
           success: function(data){
              var tbody = $("<tbody>");
              for (i = 0; i < data.length; i++) {
                var red = "<tr>";
                red += "<td>" + data[i].idzupanije + "</td>";
                red += "<td>" + data[i].nazivZup + "</td>";
                red += "</tr>";
                tbody.append(red);
              } 

            tbody.append("</tbody>");            
            tablica.append(tbody);
              $('#sadrzaj').html(tablica);
              $("#tablica").dataTable({
                "bPaginate":true,
                "bSort": true,
                "bAutoWidth": false,
                "bFilter":true
                });
        } 
       });
});

// POPIS POL UPRAVA


$('#uprave').click(function(event) {
        var tablica = $('<table id="tablica">');
        tablica.append('<thead><tr><th>ID</th><th>Adresa</th><th>Kontakt</th><th>ID zupanije</th><th>Naziv</th></tr></thead>');
        $.ajax({
           type: "GET",
           url: "http://arka.foi.hr/WebDiP/2013_projekti/WebDiP2013_031/JSON/pol_uprave.json",
           dataType: "json",
         
           success: function(data){
              var tbody = $("<tbody>");
              for (i = 0; i < data.length; i++) {
                var red = "<tr>";
                red += "<td>" + data[i].idpolUprave + "</td>";
                red += "<td>" + data[i].adresa + "</td>";
                red += "<td>" + data[i].kontakt + "</td>";
                red += "<td>" + data[i].zupanije_idzupanije + "</td>";
                red += "<td>" + data[i].naziv + "</td>";
                red += "</tr>";
                tbody.append(red);
              } 

            tbody.append("</tbody>");            
            tablica.append(tbody);
              $('#sadrzaj').html(tablica);
              $("#tablica").dataTable({
                "bPaginate":true,
                "bSort": true,
                "bAutoWidth": false,
                "bFilter":true
                });
        } 
       });
});

// POPIS DJELATNIKA


$('#djelatnici').click(function(event) {
        var tablica = $('<table id="tablica">');
        tablica.append('<thead><tr><th>Značka</th><th>Ime</th><th>Prezime</th><th>Vrsta Policajca</th><th>Pol uprava</th></tr></thead>');
        $.ajax({
           type: "GET",
           url: "http://arka.foi.hr/WebDiP/2013_projekti/WebDiP2013_031/JSON/policajac.json",
           dataType: "json",
         
           success: function(data){
              var tbody = $("<tbody>");
              for (i = 0; i < data.length; i++) {
                var red = "<tr>";
                red += "<td>" + data[i].idZnacke + "</td>";
                red += "<td>" + data[i].ime + "</td>";
                red += "<td>" + data[i].prezime + "</td>";
                red += "<td>" + data[i].vrstapolicajca + "</td>";
                red += "<td>" + data[i].naziv + "</td>";
                
                red += "</tr>";
                tbody.append(red);
              } 

            tbody.append("</tbody>");            
            tablica.append(tbody);
              $('#sadrzaj').html(tablica);
              $("#tablica").dataTable({
                "bPaginate":true,
                "bSort": true,
                "bAutoWidth": false,
                "bFilter":true
                });
        } 
       });
});
        
$("#xml").click(function () {
            $.ajax({
                url: "http://arka.foi.hr/WebDiP/2013/materijali/dz3_dio2/korisnici.xml",
                type: "GET",
                dataType: "xml",
                success: OnSuccess
            });
        });
        function OnSuccess(xml) {
        var tablica = $('<table id="tablica">');
        tablica.append('<thead><tr><th>ID</th><th>Ime</th><th>Prezime</th><th>Korisnicko ime</th><th>Lozinka</th><th>Aktivacijski kod</th><th>Email</th><</tr></thead>');
        var tbody = $("<tbody>");
        $(xml).find('korisnik').each(function () {
            var red = "<tr>";

            red += "<td>" + $(this).attr('id_korisnik') + "</td>";
            red += "<td>" + $(this).attr("ime") + "</td>";
            red += "<td>" + $(this).attr("prezime") + "</td>";
            red += "<td>" + $(this).attr("korisnicko_ime") + "</td>";
            red += "<td>" + $(this).attr("lozinka") + "</td>";
            red += "<td>" + $(this).attr("aktivacijski_kod") + "</td>";
            red += "<td>" + $(this).attr("email") + "</td>";

            red += "</tr>";
            tbody.append(red);
            });

            tablica.append(tbody);
            $('#sadrzaj').html(tablica);
            $("#tablica").dataTable({
                "bPaginate":true,
                "bSort": true,
                "bAutoWidth": false,
                "bFilter":true
     });
            
   } 

$(function() {
    $( "#accordion" ).accordion();
  });