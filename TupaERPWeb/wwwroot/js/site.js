function maiuscula(z) {
    v = z.value.toUpperCase();
    z.value = v;
}

function limparInputs() {
    // Obtém todos os elementos de entrada (inputs) usando document.querySelectorAll
    var inputs = document.querySelectorAll('input');

    //Objem o nome do titulo, que serve como o nome do controller
    var controller = document.getElementById("titulo").innerHTML;

    // Itera sobre os elementos e define o valor de cada input como uma string vazia
    inputs.forEach(function (input) {
        input.value = '';
    });
    //variavel auxiliar valor que recebe vazia
    var valor = "";

    ////se o controller não for do Usuário, ele deve ter a busca pelo estado, logo faz sentido limpar esse valor
    ////caso contrário, se for cadastro de Usuário, esse elemnto nao existe
    //if (controller != 'Usuario') {
    //    //aplica o valor vazio, da variavel enterior, ao elemento, limpando da tela
    //    document.getElementById('estado').value = valor;
    //}

    //chama a index novamente para carregar as listas e atualizar a página, de acordo com seu controller
    //que é justamente o titulo da pagina
    window.location.href = '/' + controller + '/Index';
}

//mascaras
//mascaras

$(function () {
    $('.date').mask('99/99/9999');
    $('.time').mask('00:00:00');
    $('#cep').mask('99.999-999');
    $('#Cep').mask('99.999-999');
    $('.phone').mask('9999-9999');
    $('.telefone').mask('(99)9999-9999');
    $('.celular').mask("(99)99999-9999");
    $('#cnpj').mask('99.999.999/9999-99');
    $('#Cnpj').mask('99.999.999/9999-99');
    $('.cnpj').mask('99.999.999/9999-99');
    $('#telefone').mask('(99)99999-9999');
    $(".senha").mask("xxxxxxxxx");
    $("#cest").mask("99.999.99");
    $("#ProcuraNCM").mask("9999.99.99");
    $("#ncm").mask("9999.99.99");
    $(".decimal").mask("9999,999");
    $(".pr-aliq").mask("9999.999");
});
jQuery(function ($) {
    $("#campoData").mask("99/99/9999");
    $("#campoTelefone").mask("(999) 999-9999");
});