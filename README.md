**MAF.Geo**
----
 Description ....

* **Methods:**

  `GET`
  /api/v1/pays/{paysId}/Villes
*  **URL Params**

   **Required:**
 
   `paysId=[integer]`

   **Optional : **
   `codePostal=[string]`
   `codeInsee=[string]`

* **Success Response:**

  * **Code:** 200 <br />
    **Content:** `[
  {
    "villeId": 1,
    "paysId": 1,
    "regionAdministrativeId": null,
    "departementId": null,
    "risqueId": 1,
    "niveauSismiciteId": 1,
    "codeInsee": "01053",
    "codePostal": "01000",
    "nomVille": "Bourg-en-Bresse",
    "simpleVille": "BOURG-EN-BRESSE",
    "latitude": 46.2,
    "longitude": 5.216667
  },
  {
    "villeId": 2,
    "paysId": 1,
    "regionAdministrativeId": null,
    "departementId": null,
    "risqueId": 1,
    "niveauSismiciteId": 1,
    "codeInsee": "01344",
    "codePostal": "01000",
    "nomVille": "Saint-Denis-lès-Bourg",
    "simpleVille": "SAINT-DENIS-LES-BOURG",
    "latitude": 46.202056,
    "longitude": 5.190635
  }
]`
 
* **Error Response:**

  * **Code:** 404 NOT FOUND <br />
    **Content:** `Items not found`


* **Sample Call:**

  ```javascript
    fetch('/api/v1/pays/1/Villes?codePostal=01000')
        .then(function (response) { return response.json() })
        .then(function (json) {
            console.log(json);           
        })
  ```