$(function () {

    $(document).on('click', '#getTotalPrice', function () {
        var products = [];

        $('.productRow').each(function () {
            var input = $(this).find('.productQuantity');

            var product = {
                'Id': $(input).attr('data-id'),
                'Quantity' : $(input).val()
            }

            products.push(product);
        });

        if (products.length > 0) {
            getTotalPrice(products);
        }
    });

    function getTotalPrice(products) {
        var token = $('input[name="__RequestVerificationToken"]').val();
        $.ajax({
            url: "/Home/GetPrice",
            type: "POST",
            datatype: "json",
            data: {
                'Products': products,
                '__RequestVerificationToken': token
            },
            success: function (result) {
                if (result.msg != null) {
                    $(document).find('.totalPriceDiv').html(result.msg);
                }
            },
            error: function (message) {
                debugger;
                if (message != null) {
                  
                }
            }
        })
    }
});