    $(document).ready(function() {
            /* DataTables start here. */
            $('#yerleskesTable').DataTable({
        dom:
                    "<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>" +
                        "<'row'<'col-sm-12'tr>>" +
                        "<'row'<'col-sm-5'i><'col-sm-7'p>>",
                buttons: [
                    {
        text: 'Ekle',
                        attr: {
        id: "btnAdd",
                        },
                        className: 'btn btn-success',
                        action: function(e, dt, node, config) {

    }
                    },
                    {
        text: 'Yenile',
                        className: 'btn btn-warning',
                        action: function(e, dt, node, config) {
        alert('Yenile butonuna basıldı.');
                        }
                    }
                ],
                language: {
        "sDecimal": ",",
                    "sEmptyTable": "Tabloda herhangi bir veri mevcut değil",
                    "sInfo": "_TOTAL_ kayıttan _START_ - _END_ arasındaki kayıtlar gösteriliyor",
                    "sInfoEmpty": "Kayıt yok",
                    "sInfoFiltered": "(_MAX_ kayıt içerisinden bulunan)",
                    "sInfoPostFix": "",
                    "sInfoThousands": ".",
                    "sLengthMenu": "Sayfada _MENU_ kayıt göster",
                    "sLoadingRecords": "Yükleniyor...",
                    "sProcessing": "İşleniyor...",
                    "sSearch": "Ara:",
                    "sZeroRecords": "Eşleşen kayıt bulunamadı",
                    "oPaginate": {
        "sFirst": "İlk",
                        "sLast": "Son",
                        "sNext": "Sonraki",
                        "sPrevious": "Önceki"
                    },
                    "oAria": {
        "sSortAscending": ": artan sütun sıralamasını aktifleştir",
                        "sSortDescending": ": azalan sütun sıralamasını aktifleştir"
                    },
                    "select": {
        "rows": {
        "_": "%d kayıt seçildi",
                            "0": "",
                            "1": "1 kayıt seçildi"
                        }
                    }
                }
            });

                        /* DataTables end here */
            /* Ajax GET / Getting the _CategoryAddPartial as Modal Form starts from here. */
            $(function() {
                const url = '/Admin/Yerleske/Add/';
                const placeHolderDiv = $('#modalPlaceHolder');
                $('#btnAdd').click(function() {
        $.get(url).done(function (data) {
            placeHolderDiv.html(data);
            placeHolderDiv.find(".modal").modal('show');
        });
                });
             });
        });