var datatable;

$(document).ready(function () {
    loadDataTable();

});

function loadDataTable() {
    
    datatable = $("#tblData").DataTable({
       "ajax": { url: '/admin/product/getall'},

       "columns": [
           { data: 'title' , "width": "15%"},
           { data: 'price', "width": "15%" },
           { data: 'isbn', "width": "15%" },
           { data: 'author', "width": "15%" },
           { data: 'category.name', "width": "10%" },
           {
               data: 'id',
               "render": function (data) {
                   return `<div class="w-75 btn-group" role="group">
                     <a href="/admin/product/upsert?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit</a>               
                     <a onClick=Delete('/admin/product/delete/${data}')  class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i> Delete</a>
                    </div>`
               },
               "width": "25%"
           }

       ]
    });

}

function Delete(url) {

    const swalWithBootstrapButtons = Swal.mixin({
        customClass: {
            confirmButton: "btn btn-success",
            cancelButton: "btn btn-danger"
        },
        buttonsStyling: false
    });
    swalWithBootstrapButtons.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonText: "Yes, delete it!",
        cancelButtonText: "No, cancel!",
        reverseButtons: true
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url,
                type: 'DELETE',
                success: function (data) {
                    datatable.ajax.reload();
                    toastr.info(data.message);

                }
            });
            
        } else if (
            /* Read more about handling dismissals below */
            result.dismiss === Swal.DismissReason.cancel
        ) {
            swalWithBootstrapButtons.fire({
                title: "Cancelled",
                text: "Your imaginary file is safe :)",
                icon: "error"
            });
        }
    });
}