﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $('.table').DataTable();
});


$('.close-alert').click(() => {
    $('.alert').hide('hide');  // Seleciona a classe close alert usa o evento de click e executa a funçao hide para fechar a notificaçao 
})

