const isimElement = document.getElementById("name");
const mailElement = document.getElementById("email");
const messageElement = document.getElementById("message");

function ekranaYazdir()
{
    let isim = isimElement.value;
    let mail = mailElement.value;
    let message = messageElement.value;

    alert("İsim : " + isim + "\n" + "Mail : " + mail + "\n" + "Mesaj : " + message);
}