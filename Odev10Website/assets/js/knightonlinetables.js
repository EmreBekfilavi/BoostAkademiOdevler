document.addEventListener("DOMContentLoaded",function(){

    /* Table Data */
    const knightPremiumJSon = `[
        {"ad":"Bronze Premium", "fiyat":"272.50 TL"},
        {"ad":"Gold Premium", "fiyat":"775.00 TL"},
        {"ad":"Platinum Premium", "fiyat":"1090.00 TL"},
        {"ad":"Disc Premium", "fiyat":"912.00 TL"},
        {"ad":"Exp Premium", "fiyat":"1216.00 TL"},
        {"ad":"War Premium", "fiyat":"1216.00 TL"},
        {"ad":"Switching Premium", "fiyat":"2770.00 TL"}
    ]`;

    // JSON veriyi JS objesine cevirme
    const knightPremiumData = JSON.parse(knightPremiumJSon);

    const knightGoldJSon = `[
        {"serverAdi":"Zero", "fiyat":"3.45 TL", "satis":"2.90 TL"},
        {"serverAdi":"Pandora", "fiyat":"3.00 TL", "satis":"2.40 TL"},
        {"serverAdi":"Agartha", "fiyat":"2.75 TL", "satis":"2.15 TL"},
        {"serverAdi":"Felis", "fiyat":"2.15 TL", "satis":"1.65 TL"},
        {"serverAdi":"Dryads", "fiyat":"2.75 TL", "satis":"2.00 TL"},
        {"serverAdi":"Destan", "fiyat":"3.25 TL", "satis":"2.75 TL"},
        {"serverAdi":"Oreads", "fiyat":"3.15 TL", "satis":"2.72 TL"},
        {"serverAdi":"Minark", "fiyat":"2.375 TL", "satis":"2.10 TL"},
        {"serverAdi":"Zion", "fiyat":"3.40 TL", "satis":"3.00 TL"}
    ]`;

    // JSON veriyi JS objesine cevirme
    const knightGoldData = JSON.parse(knightGoldJSon);

    // Tabloya dinamik veri ekleme
    const premiumTable = document.getElementById("premium").getElementsByTagName("tbody")[0];
    const goldTable = document.getElementById("gold").getElementsByTagName("tbody")[0];

    knightPremiumData.forEach(item => {
        const premiumRow = premiumTable.insertRow();

        Object.values(item).forEach(val => {
            const premiumCell = premiumRow.insertCell();
            premiumCell.textContent = val;
        });
    });

    knightGoldData.forEach(item => {
        const goldRow = goldTable.insertRow();

        Object.values(item).forEach(val => {
            const goldCell = goldRow.insertCell();
            goldCell.textContent = val;

        });
    });
});