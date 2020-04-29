function GetCookie(cname) {
    var name = cname + "=";
    var decodedCookie = decodeURIComponent(document.cookie);
    var ca = decodedCookie.split(';');
    for (var i = 0; i < ca.length; i++) {
        var c = ca[i];
        while (c.charAt(0) == ' ') {
            c = c.substring(1);
        }
        if (c.indexOf(name) == 0) {
            return c.substring(name.length, c.length);
        }
    }
    return "";
}


function ShowForm(value) {
    if (value == false) {
        document.getElementById('id01').style.display = 'none';
        document.getElementById('id02').style.display = 'none';
    } else if (value) {
        document.getElementById('id01').style.display = 'block';
        document.getElementById('id02').style.display = 'block';
    }

}

function ShowButton(value) {
    if (value == false) {
        document.getElementById('id011').style.display = 'none';
        document.getElementById('id012').style.display = 'none';
        document.getElementById('id03').style.display = 'block';
        document.getElementById('basket').style.display = 'block';
    } else if (value) {
        document.getElementById('id011').style.display = 'block';
        document.getElementById('id012').style.display = 'block';
        document.getElementById('id03').style.display = 'none';
        document.getElementById('basket').style.display = 'none';
    }
}

window.onload = function () {
    GetCookie("connected_user") != "unregistered" ? ShowButton(false) : ShowButton(true);
    let innerContent = document.getElementsByTagName("main")[0];
    let link = document.title == "Basket"
        ? "shop_basket"
        : "home_products";

    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            innerContent.innerHTML = this.responseText;
        }

    };
    xhttp.open("GET", "php/creating_elements.php?what_create=" + link, true);
    xhttp.send();
};

function Exit() {
    ShowButton(true);
    document.cookie = "connected_user=" + "unregistered";
    document.location.href = 'index.html';
}

function QuantityChange(event) {

    // $quantity_in_stock;$cost;$index;+or-
    let obj = event.alt.value.split(';');
    let quantityOut = document.getElementById('quantity-product-' + obj[2]);
    let totalPrice = document.getElementById('total_price');

    let lastPrice = parseInt(totalPrice.textContent) - (parseInt(obj[1]) * parseInt(quantityOut.value));


    if (quantityOut.value <= obj[0] & parseInt(quantityOut.value) >= 1) {
        if (obj[3] == '+') {
            quantityOut.value = obj[0] == parseInt(quantityOut.value)
                ? parseInt(quantityOut.value)
                : parseInt(quantityOut.value) + 1;

        } else if (obj[3] == '-') {
            quantityOut.value = 1 == parseInt(quantityOut.value)
                ? parseInt(quantityOut.value)
                : parseInt(quantityOut.value) - 1;

        }
        totalPrice.textContent = lastPrice + (parseInt(obj[1]) * parseInt(quantityOut.value));
    }
}

function Connection(elements) {

    let output = {
        login: elements.login.value,
        password: elements.password.value,
        email: elements.email == null ? null : elements.email.value
    };

    var xhttp = new XMLHttpRequest();

    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200) {
            if (this.responseText) {
                ShowForm(false);
                ShowButton(false);
                document.cookie = "connected_user=" + output.login;
                location.reload();
            } else {
                alert("Ошибочка");
            }
        } else {
            ShowButton(false);
        }

    };

    xhttp.open(
        "GET",
        "php/script.php?connection=" + JSON.stringify(output) + ",dtes=sdf",
        true
    );
    xhttp.send();

}


function ChangesInCart(value) {
    console.log(value);
    let output = {"checked_click": value[0] == true ? 1 : 0, "index_item": value[1]};

    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.status == 404) {
            alert("Что-то пошло не так")
        }

    };
    xhttp.open(
        "GET",
        "php/script.php?cart_info=" + JSON.stringify(output),
        true
    );
    xhttp.send();
}


function CancelProductBasket(index) {

    let itemBasket = document.getElementById('item_basket-' + index);
    let quantity = parseInt(itemBasket.childNodes[3].childNodes[1].value);
    let basketPrice = parseInt(itemBasket.childNodes[4].childNodes[0].textContent);
    let totalPrice = document.getElementById('total_price');

    totalPrice.textContent = parseInt(totalPrice.textContent) - (quantity * basketPrice);

    itemBasket.parentNode.removeChild(itemBasket);

    ChangesInCart([false, index]);

}
