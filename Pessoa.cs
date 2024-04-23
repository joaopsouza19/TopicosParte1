public class Pessoa
{
    public string Cpf { get; set; }
    public string Nome { get; set; }
    public List<Livro> Livros { get; set; }

    public Pessoa()
    {
        Livros = new List<Livro>();
    }

    public void AdicionarLivro(Livro livro)
    {
        Livros.Add(livro);
    }
}
