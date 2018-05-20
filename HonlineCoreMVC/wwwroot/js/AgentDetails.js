
$(document).ready(function () {

    $('#userDTOTable tr').click(function () {
        var id = $(this).find('td:first-child').text();

        $.ajax({
            type: 'GET',
            data: { userId: id },
            url: "Agent/GetCustomerDetails",
            success: function (data) {
                $("#customerDetailsDiv").html(data);
            },
            error: function (request, status, erro) {
                alert(request.responseText);
            }
        });

    })
})
