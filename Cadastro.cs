using System;
using System.Collections.Generic;
namespace CadastroAlunos {
    class Cadastro 
    {
    List<Aluno> alunos = new List<Aluno>();
    void MostraLinha(string str)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("=====================");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(str);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("=====================");
        Console.ForegroundColor = ConsoleColor.White;
    }
    public void Cadastrar() 
    {
      int quantalunos = 0;
      try {
      Console.Write("Quantos alunos quer cadastrar?");
      quantalunos = Convert.ToInt32(Console.ReadLine());
      } catch (FormatException e) {
          quantalunos = 0;
      }
      double n1 = 0, n2 = 0;
      for (int c = 0; c < quantalunos; c++) 
      {
         MostraLinha($"ALUNO(A) {c + 1}");
         Console.Write("Nome: ");
         string nome = Console.ReadLine();
         try {
         Console.Write("Primeira nota: ");
         n1 = Convert.ToDouble(Console.ReadLine());
         } catch (FormatException e){
             n1 = 0;
         }
         try {
         Console.Write("Segunda nota: ");
         n2 = Convert.ToDouble(Console.ReadLine());
         } catch (FormatException e) {
             n2 = 0;
         } finally {
         Aluno aluno = new Aluno(nome, n1, n2);
         alunos.Add(aluno);
         }
         }
      }
    
    public void VerAlunos() 
    {
        if (alunos.Count <= 0)
        {
           Console.WriteLine("Nenhum aluno cadastrado");
        } else 
        {
            for (int c = 0; c < alunos.Count; c++) 
            {
                MostraLinha($"ALUNO(A) {c}");
                Console.WriteLine($"Nome: {alunos[c].nome}");
                Console.WriteLine($"Média:{alunos[c].media}");
                Console.WriteLine($"Status: {alunos[c].status}");
            }
        }
    }
    public void MediaGeral() {
       double soma = 0, geral = 0;
       for (int d = 0; d < alunos.Count - 1; d++)
       {
           soma += alunos[d].media;
       }
       geral = soma / alunos.Count;
       Console.WriteLine($"A média geral da turma é {geral}");
    }
  }
}