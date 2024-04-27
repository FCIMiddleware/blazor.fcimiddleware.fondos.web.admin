window.ShowToastr = (type, message, tittle) => {
    if (type === "success") {
        toastr.success(message, tittle, { timeOut: 10000 });
    }
    if (type === "error") {
        toastr.error(message, tittle, { timeOut: 10000 });
    }
}

window.ShowSwal = (type, message, tittle) => {
    if (type === "success") {
        Swal.fire(
            tittle,
            message,
            'success'
        );
    }
    if (type === "error") {
        Swal.fire(
            tittle,
            message,
            'error'
        );
    }
}

function MostrarModalConfirmacionBorrado() {
    $('#modalConfirmacionBorrado').modal('show');
}

function OcultarModalConfirmacionBorrado() {
    $('#modalConfirmacionBorrado').modal('hide');
}