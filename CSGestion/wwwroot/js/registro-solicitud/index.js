
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
});
