// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(start());
function Test(id) {
    $.ajax({
        url: 'test/Test',
        type: 'GET',
        dataType: 'html',
        data: {
            id
        }
    }).done(function (ketqua) {
        $('#cart').html(ketqua);
    });
}
function start() {
    $.ajax({
        url: '/Cart/CartQuality',
        type: 'POST',
        dataType: 'html',
        data: {
        }
    }).done(function (ketqua) {
        $('#cart').html(ketqua);
    });
}
function AddItem(id, name) {
    $.ajax({
        url: 'Cart/AddItem',
        type: 'POST',
        dataType: 'html',
        data: {
            id
        }
    }).done(function (result) {
        if (result == null) {
            if (confirm("Vui lòng đăng nhập để mua hàng"))
                window.location = "/Account/Login";
            return;
        }
        if (result == "") {
            alert('Vật phẩm đã có trong giỏ hàng');
            return;
        }
        $('#cart').html(result);
        alert("Đã thêm '" + name + "' vào giỏ hàng");
    });
}

//function ChangeQuantity(id, value, price) {  
//    document.getElementById(id).innerHTML = value * price;
//}
function ChangeQuantity(id, value) {
    $.ajax({
        url: '/Cart/ChangeQuantity',
        type: 'POST',
        dataType: 'html',
        data: {
        id, value
        }
    }).always(function () {
        location.reload();
    })
}