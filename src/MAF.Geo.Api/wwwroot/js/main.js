//When document ready
document.addEventListener('DOMContentLoaded', function () {
    loadAutoComplete();
    document.getElementById("codePostal").onchange = searchByCodePostal;
  //  document.getElementById("codeInsee").onchange = searchByCodeInsee;
}, false);

function loadAutoComplete() {
    var pays = document.getElementById("pays");
    var villeInput = document.getElementById("villeForAutocomplete");
    var codePostalInput = document.getElementById("codePostal");
    var codeInseeInput = document.getElementById("codeInsee");
    //Load Autocomplete for Ville
    autocomplete({
        input: villeInput,
        fetch: function (text, update) {
            text = text.toLowerCase();
            // use AJAX requests
            fetch('/api/v1/pays/' + pays.value + '/Villes/autoComplete?filter=' + text)
                .then(function (response) { return response.json() })
                .then(function (json) {
                    console.log(json);
                    var suggestions = json.map(function (ville) {
                        var suggestion = {
                            label: ville.codePostal + " - " + ville.nomVille,
                            ville: ville.nomVille,
                            codePostal: ville.codePostal,
                            codeInsee : ville.codeInsee
                        };//mapping
                        return suggestion;
                    })
                    update(suggestions);
                })
        },
        onSelect: function (item) {
            villeInput.value = item.ville;
            codePostalInput.value = item.codePostal;
            codeInseeInput.value = item.codeInsee
        }
    });
}

function searchByCodePostal(event) {
    var pays = document.getElementById("pays");
    console.log(event.target.value);

    fetch('/api/v1/pays/' + pays.value + '/Villes?codePostal=' + event.target.value)
        .then(function (response) { return response.json() })
        .then(function (json) {
            console.log(json);
           
        })
}