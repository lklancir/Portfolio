
$(document).ready(function(){
$('#json').click(function(event) {
        var tablica = $('<table id="tablica">');
        tablica.append('<thead><tr><th>ID</th><th>Ime</th></tr></thead>');
        $.ajax({
           type: "GET",
           url: "http://arka.foi.hr/WebDiP/2013_projekti/WebDiP2013_031/js/zupanije.json",
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

});