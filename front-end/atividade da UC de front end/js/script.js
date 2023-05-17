//efeito do botão voltar ao Topo
const topo = () => {
  window.scrollTo({ top: 0, left: 0, behavior: "smooth" });
}
//Validação de Login
const login = () => {
  let logged = false;
  let user = document.getElementById('usuario').value;
  let password = document.getElementById('senha').value;

  if (user === 'admin' && password === '1234') {
    window.location ='index.html';
    logged = true;
  }

  if (logged === false) {
    alert('Acesso Negado. Dados incorretos!!!')
  }
}

//Ativar alert no botão cadastrar

const cadastro = () => {
  alert('Cadastrado com sucesso');
  window.location.href = 'index.html';
}
