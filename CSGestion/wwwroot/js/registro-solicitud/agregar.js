
$(document).ready(function () {

    $("#formAgregar").submit(function (e) {
        console.log("formAgregar");

        e.preventDefault();

        var form = $('#formAgregar');
        $.validator.unobtrusive.parse('#formAgregar');

        if (form.valid()) {

            var url = "RegistroSolicitud/Agregar";
            var data = $('#formAgregar').serialize();

            $.ajax({
                type: 'POST',
                url: url,
                data: data,
                beforeSend: function () { },
                complete: function () { },
                success: function (response) {

                    $('#myModal').html(response);
                },
                error: function (xhr, status) {

                    alert("error");
                }
            });
        }

    });
});