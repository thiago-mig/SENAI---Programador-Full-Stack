//efeito de esconder formulário de cadastro
$(document).ready(() => {
  $('#botao-cadastrar').click(() => {
    $('#form-cadastrar').slideToggle('slow');
    $('#section-login').slideToggle('slow');
    $('#botao-cadastrar').hide();
  });
});
