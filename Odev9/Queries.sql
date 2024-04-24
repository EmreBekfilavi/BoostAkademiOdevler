-- Rehberlerinizin bu zamana kadar ilgilendikleri tüm turistleri ülke ve uyruk bilgileri ile getirme
SELECT DISTINCT Guide.Name + ' ' + Guide.Surname AS GuideName,
	   Tourist.Name + ' ' + Tourist.Surname AS TouristName,
	   Tourist.CountryCode,
	   Tourist.Nationality
FROM Guide
INNER JOIN OrderDetail ON (OrderDetail.GuideId = Guide.Id)
INNER JOIN Tourist ON (OrderDetail.TouristId = Tourist.Id)
ORDER BY Guide.Name + ' ' + Guide.Surname



-- Her bir tur için indirimli, tam, yarým fiyatýný listeleyen sorgu
SELECT TouristArea.Name AS TouristAreaName, 
	   PriceType.Name, 
	   CAST(Price AS nvarchar) + ' ' + Currency.Name AS Price
FROM TouristArea
INNER JOIN PriceType ON (PriceType.Id = TouristArea.PriceTypeId)
INNER JOIN Currency ON (Currency.Id = TouristArea.CurrencyId)


-- Þu zamana kadar yapýlan en pahalý tura hangi turistim dahil olmuþ, bu turun ödemesini kim yapmýþ ve bu turiste hangi tur rehberi atanmýþ
SELECT TOP 1 t.Name AS TouristName, 
            t.Surname AS TouristSurname, 
            t.CountryCode, 
            t.Nationality, 
            o.WhoPaid, 
            o.TotalPrice, 
            g.Name AS GuideName, 
            g.Surname AS GuideSurname
FROM [Order] o
INNER JOIN Tourist t ON o.WhoPaid = t.Id
INNER JOIN OrderDetail od ON o.Id = od.OrderId
INNER JOIN Guide g ON od.GuideId = g.Id
ORDER BY o.TotalPrice DESC;



-- Almanya uyruklu turistlerden tam bilet ile tura katýlan turistlerin nereleri hangi tur rehberi ile ziyaret ettiði:
SELECT t.Name AS TouristName, 
       t.Surname AS TouristSurname, 
       ta.Name AS TouristAreaName, 
       g.Name AS GuideName, 
       g.Surname AS GuideSurname
FROM Tourist t
INNER JOIN OrderDetail od ON t.Id = od.TouristId
INNER JOIN TouristArea ta ON od.TouristAreaId = ta.Id
INNER JOIN Guide g ON od.GuideId = g.Id
WHERE t.CountryCode = 'GR' AND ta.PriceTypeId = 1;

-- Listemde olduðu halde rehberlerimin bildiði diller arasýnda yer almayan diller:
SELECT l.Name AS LanguageName
FROM Language l
LEFT JOIN GuideLanguage gl ON l.Code = gl.LanguageCode
WHERE gl.LanguageCode IS NULL;

-- Ýngilizce bildiði halde ülkesi de uyruðu da Ýngiltere olmayan turistlere rehberlik eden tur rehberleri:
SELECT DISTINCT Guide.Name + '' + Guide.Surname AS GuideName
FROM Guide
INNER JOIN GuideLanguage ON (GuideLanguage.GuideId = Guide.Id)
INNER JOIN OrderDetail ON (Guide.Id = OrderDetail.GuideId)
INNER JOIN Tourist ON (OrderDetail.TouristId = Tourist.Id AND Tourist.Nationality != 'English' AND Tourist.CountryCode != 'UK')
WHERE LanguageCode = 'UK'

-- Nakit ödeme yapmamayý tercih eden müþterileriniz hangi ülkelerden:
SELECT t.Name AS TouristName, 
       t.Surname AS TouristSurname, 
       t.CountryCode, 
       t.Nationality
FROM Tourist t
WHERE NOT EXISTS (
    SELECT 1
    FROM [Order] o
    INNER JOIN PaymentType pt ON o.PaymentTypeId = pt.Id
    WHERE o.WhoPaid = t.Id AND pt.Name = 'Nakit'
);


-- Ülkesi Japonya olan müþterilerinizin fatura ödemelerini hangi para biriminde yaptýðý:
SELECT t.Name AS TouristName, 
       t.Surname AS TouristSurname, 
       t.CountryCode, 
       t.Nationality, 
       o.WhoPaid, 
       pt.Name AS PaymentTypeName, 
       c.Name AS CurrencyName
FROM [Order] o
INNER JOIN Tourist t ON o.WhoPaid = t.Id
INNER JOIN PaymentType pt ON o.PaymentTypeId = pt.Id
INNER JOIN Currency c ON o.PaymentTypeId = c.Id
WHERE t.CountryCode = 'JA';