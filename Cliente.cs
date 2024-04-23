using System.Security.Cryptography;

public class Cliente {

    public string CPF { get; set;}
    public string Nome { get; set;}

    public Cliente (string CPF, string Nome){
        this.CPF = CPF;
        this.Nome = Nome;
    }
}