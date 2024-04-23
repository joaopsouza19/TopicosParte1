public class Estudante {
    public string Matricula {get; set; }
    public string Nome {get; set; }
    public int Idade {get; set; }

    public Estudante (string matricula, string nome, int idade){
        this.Matricula = matricula;
        this.Nome = nome;
        this.Idade = idade;

    }
}