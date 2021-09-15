function validaExemplo()
{
    var bValidado = true;

    // Limpar todos os spans de validação
    $("#vTexto").text("");
    $("#vEscolha1").text("");
    $("#vEscolha2").text("");
    $("#vSelecao3").text("");

    // Como validar input type=text (TextBox)
    if ( $("#txtTexto").val() == "")
    {
        $("#vTexto").text("Informe o texto");
        bValidado = false;
    }

    // Como validar RadioButton
    if ($("#rbEscolha1").prop("checked") == false && $("#rbEscolha2").prop("checked") == false)
    {
        $("#vEscolha1").text("Selecione escolha 1 ou escolha 2");
        bValidado = false;
    }

    // Como validar checkBox
    if ($("#chkEscolha2").prop("checked") == false) {
        $("#vEscolha2").text("Selecione ação e-mail");
        bValidado = false;
    }

    // Como validar select/option (dropDownList)
    if ($("#ddlSelecao3").val() == "selecione") {
        $("#vSelecao3").text("Selecione opção");
        bValidado = false;
    }

    return bValidado;
}

function formatar(mascara, documento) {
    var i = documento.value.length;
    var saida = mascara.substring(0, 1);
    var texto = mascara.substring(i)

    if (texto.substring(0, 1) != saida) {
        documento.value += texto.substring(0, 1);
    }

}