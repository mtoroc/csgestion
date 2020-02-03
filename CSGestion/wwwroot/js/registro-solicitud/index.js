
$(document).ready(function () {

    $('#miTabla').DataTable({
        "language": {
            "lengthMenu": "Mostrando _MENU_ registros por página",
            "zeroRecords": "Sin información",
            "info": "Página _PAGE_ de _PAGES_",
            "infoEmpty": "Sin información",
            "infoFiltered": "(búsqueda de un total de _MAX_ registros)",
            "sSearch": "Buscar:",
            "oPaginate": {
                "sFirst": "Primero",
                "sLast": "Último",
                "sNext": "Siguiente",
                "sPrevious": "Anterior"
            },
            /*
             * TODO: mtoroc, se puede analizar en un futuro la recomendacion de utilizar algunas de estas configuraciones
            "sProcessing":    "Procesando...",
            "sInfoPostFix":   "",
            "sUrl":           "",
            "sInfoThousands":  ",",
            "sLoadingRecords": "Cargando...",
            "oAria": {
                        "sSortAscending":  ": Activar para ordenar la columna de manera ascendente",
                        "sSortDescending": ": Activar para ordenar la columna de manera descendente"
                    }
            */
        }
    });

    $(function () {

        $('.input-group.date').datepicker({
            clearBtn: true,
            language: "es",
            orientation: "bottom left",
            startDate: '-3d',
            todayHighlight: true,
            daysOfWeekHighlighted: "0,6",
        });

    });

    $(function () {

        $('.form-reset').click(function () {
            $(this).resetValidation();
        });

    });


    $('#btnAgregarSolicitud').click(function () {

        var url = "RegistroSolicitud/Agregar";

        $.ajax({
            type: 'GET',
            url: url,
            beforeSend: function () { },
            complete: function () { },
            success: function (response) {

                $('#innerModal').html(response);
                $("#myModal").modal('show');  
            },
            error: function (xhr, status) {

                alert("error");
            }
        });
    });

    $("#formAgregar").submit(function (e) {

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

                    $('#modalContent').html(response);
                },
                error: function (xhr, status) {

                    alert("error");
                }
            });
        }

    });

});