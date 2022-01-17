using System;
namespace CadastroAlunos
{
 class Aluno 
 {
   public string nome;
   public string? status;
   public double media;
   public Aluno(string nome, double n1, double n2) {
      this.nome = nome;
      this.media = (n1 + n2) / 2;
      this.status = this.media >= 6? "APROVADO(A)":"REPROVADO(A)";
   }
 }
}