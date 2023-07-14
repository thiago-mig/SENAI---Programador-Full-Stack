using System;

namespace Projeto
{
  class Program
  {
    static void Main(string[] args)
    {
      float valor_pagamento;
      Console.WriteLine("Informar Nome");
      string var_nome = Console.ReadLine();
      Console.WriteLine("Informar Endereço");
      string var_endereco = Console.ReadLine();
      Console.WriteLine("Pessoa Física (f) ou Jurídica (j)");
      string var_tipo = Console.ReadLine();

      if(var_tipo == "f")
      {
        Pessoa_Fisica tmp_pessoa_fisica = new Pessoa_Fisica();
        tmp_pessoa_fisica.nome = var_nome;
        tmp_pessoa_fisica.endereco = var_endereco;
        Console.WriteLine("Informar CPF");
        tmp_pessoa_fisica.cpf = Console.ReadLine();
        Console.WriteLine("informar RG");
        tmp_pessoa_fisica.rg = Console.ReadLine();
        Console.WriteLine("Informar Valor de Compra");
        valor_pagamento = float.Parse(Console.ReadLine());
        tmp_pessoa_fisica.pagar_imposto(valor_pagamento);
        Console.WriteLine("-------- Pessoa Física --------");
        Console.WriteLine("Nome.........." + tmp_pessoa_fisica.nome);
        Console.WriteLine("Endereço......" + tmp_pessoa_fisica.endereco);
        Console.WriteLine("CPF..........." + tmp_pessoa_fisica.cpf);
        Console.WriteLine("RG............" + tmp_pessoa_fisica.rg);
        Console.WriteLine("Valor de Compra" + tmp_pessoa_fisica.valor.ToString("C"));
        Console.WriteLine("Valor do Imposto" + tmp_pessoa_fisica.valor_imposto.ToString("C"));
        Console.WriteLine("Valor de Compra" + tmp_pessoa_fisica.total.ToString("C"));
      };
      if(var_tipo == "j")
      {
        Pessoa_Juridica tmp_pessoa_juridica = new Pessoa_Juridica();
        tmp_pessoa_juridica.nome = var_nome;
        tmp_pessoa_juridica.endereco = var_endereco;
        Console.WriteLine("Informar CNPJ:");
        tmp_pessoa_juridica.cnpj = Console.ReadLine();
        Console.WriteLine("Informar IE:");
        tmp_pessoa_juridica.ie = Console.ReadLine();
        Console.WriteLine("Informar Valor de Compra:");
        valor_pagamento = float.Parse(Console.ReadLine());
        tmp_pessoa_juridica.pagar_imposto(valor_pagamento);
        Console.WriteLine("-------- Pessoa Jurídica ---------");
        Console.WriteLine("Nome ..........: " + tmp_pessoa_juridica.nome);
        Console.WriteLine("Endereço ......: " + tmp_pessoa_juridica.endereco);
        Console.WriteLine("CNPJ ..........: " + tmp_pessoa_juridica.cnpj);
        Console.WriteLine("IE ............: " + tmp_pessoa_juridica.ie);
        Console.WriteLine("Valor de Compra: " +
        tmp_pessoa_juridica.valor.ToString("C"));
        Console.WriteLine("Imposto .......: " +
        tmp_pessoa_juridica.valor_imposto.ToString("C"));
        Console.WriteLine("Total a Pagar : " +
        tmp_pessoa_juridica.total.ToString("C"));
      }
    }
  }
}
