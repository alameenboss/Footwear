$(function () {
    $('.scroll-pane').jScrollPane();

    $('#page-select').change(function () {
        window.location.href = "/Home/Shop?page=1&pagesize=" + $(this).val();
    });
});