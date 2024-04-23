public class Pedido {

    public string Data { get; set; }
    public Cliente Cliente { get; set;}
    public Vendedor Vendedor { get; set; }
    public List<Produto> Produtos {get; set;}

    public Pedido (string Data, Cliente Cliente, Vendedor Vendedor){
        this.Data = Data;
        this.Cliente = Cliente;
        this.Vendedor = Vendedor;
        this.Produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        Produtos.Add(produto);
    }
}
