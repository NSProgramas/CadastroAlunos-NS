// See https://aka.ms/new-console-template for more information
using System;
using CadastroAlunos;
void MostraLinha(string str) {
   Console.ForegroundColor = ConsoleColor.Blue;
   Console.WriteLine("=====================");
   Console.ForegroundColor = ConsoleColor.Yellow;
   Console.WriteLine(str);
   Console.ForegroundColor = ConsoleColor.Blue;
   Console.WriteLine("=====================");
   Console.ForegroundColor = ConsoleColor.White;
}
MostraLinha("CADASTRO DE ALUNOS");
Console.WriteLine("Quer usar nosso programa?\n[1]Sim\n[2]Não");
Console.Write("Insira sua escolha aqui: ");
string resp = Console.ReadLine();
Cadastro c = new Cadastro();
while (!resp.Equals("2"))
{
  Console.ForegroundColor = ConsoleColor.Green;
  Console.WriteLine("Escolha:\n[1]Cadastrar Novos Alunos\n[2]Ver alunos cadastrados\n[3]Fazer média geral da turma");
  Console.ForegroundColor = ConsoleColor.White;
  Console.Write("Insira sua escolha aqui: ");
  string escolha = Console.ReadLine();
  switch (escolha) 
  {
    case "1":
      c.Cadastrar();
      break;
    case "2":
      c.VerAlunos();
      break;
    case "3":
      c.MediaGeral();
      break;
    default:
      Console.WriteLine("Insira um número válido!");
      break;
  }
  Console.WriteLine("Quer continuar?\n[1]Sim\n[2]Não\n");
  Console.Write("Insira sua escolha aqui: ");
  resp = Console.ReadLine();
  if (resp.Equals("2")) 
  {
     break;
  }
}
