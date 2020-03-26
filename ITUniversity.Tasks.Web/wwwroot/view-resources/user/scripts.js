var user = user || {};

user.block = function (id, invoker) {
    $.ajax({
        url: "/api/services/user/block",
        dataType: "json",
        method: "POST",
        data: { id: id },
        success: function () {
            invoker.closest('tr').remove();
        }
    });
}