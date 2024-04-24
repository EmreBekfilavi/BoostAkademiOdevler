document.addEventListener("DOMContentLoaded",function(){

    /* Table Data */
    const risePremiumDataJSon = `[
        {"ad":"Elite Premium", "fiyat":"130 TL"},
        {"ad":"Farm Premium", "fiyat":"550 TL"},
        {"ad":"XP Premium", "fiyat":"600 TL"},
        {"ad":"Battle Premium", "fiyat":"650 TL"},
        {"ad":"Complete Premium", "fiyat":"850 TL"}
    ]`;

    // JSON Veriyi JS objesine cevirme
    const risePremiumData = JSON.parse(risePremiumDataJSon);

    const riseGoldDataJSon = `[
        {"serverAdi":"Galia", "fiyat":"7.50 TL","satis":"6.00 TL"},
        {"serverAdi":"Mantis", "fiyat":"6.75 TL","satis":"6.00 TL"},
        {"serverAdi":"Aarvad", "fiyat":"2.75 TL", "satis":"2.40 TL"}
    ]`;

    // JSON veriyi JS objesine cevirme
    const riseGoldData = JSON.parse(riseGoldDataJSon);

    // Tabloya dinamik veri ekleme
    const premiumTable = document.getElementById("premium").getElementsByTagName("tbody")[0];
    const goldTable = document.getElementById("gold").getElementsByTagName("tbody")[0];

    risePremiumData.forEach(item => {
        const premiumRow = premiumTable.insertRow();

        Object.values(item).forEach(val => {
            const premiumCell = premiumRow.insertCell();
            premiumCell.textContent = val;
        });
    });

    riseGoldData.forEach(item => {
        const goldRow = goldTable.insertRow();

        Object.values(item).forEach(val => {
            const goldCell = goldRow.insertCell();
            goldCell.textContent = val;

        });
    });
});