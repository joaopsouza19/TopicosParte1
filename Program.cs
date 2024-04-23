    // Questao 2
    Pessoa pessoa = new Pessoa { Cpf = "111.059.601-095", Nome = "João" };
    Livro livro1 = new Livro { Titulo = "Como programar", Autor = "John Wick" };
    Livro livro2 = new Livro { Titulo = "Data Base", Autor = "Albert" };
    pessoa.AdicionarLivro(livro1);
    pessoa.AdicionarLivro(livro2);

    foreach (var livro in pessoa.Livros)
    {
        Console.WriteLine("Título: " + livro.Titulo);
        Console.WriteLine("Autor: " + livro.Autor);
    }

    // Questao 3
    
    // Console.WriteLine();

    Estudante estudante = new Estudante("34341153", "João", 18);
    Console.WriteLine("Matricula: " + estudante.Matricula);
    Console.WriteLine("Nome: " + estudante.Nome);
    Console.WriteLine("Idade: " + estudante.Idade);

    // Console.WriteLine();

    //Questao 4

    Cliente cliente = new Cliente ("111.059.601-095", "João" );
    Pedido pedido = new Pedido("23/04/2024", cliente);
    Console.WriteLine("Data do Pedido: " + pedido.Data);
    Console.WriteLine("Cliente: " + pedido.Cliente.Nome);
    Console.WriteLine("CPF do Cliente: " + pedido.Cliente.CPF);

    // Desafio
    Cliente cliente = new Cliente ("111.059.069-095", "João");
    Vendedor vendedor = new Vendedor("095.069.059.111", "Pedro");
    Pedido pedido = new Pedido("23/04/2024", cliente, vendedor);
    Produto produto1 = new Produto("Camiseta Nike", 99.90);
    Produto produto2 = new Produto("Calça Nike", 89.90);
    Produto produto3 = new Produto("Meia Nike", 29.90);
    Produto produto4 = new Produto("Tenis Nike", 459.90);
    pedido.AdicionarProduto(produto1);
    pedido.AdicionarProduto(produto2);
    pedido.AdicionarProduto(produto3);
    pedido.AdicionarProduto(produto4);

    Console.WriteLine("Data do pedido: " + pedido.Data);
    Console.WriteLine("Cliente: " + cliente.Nome);
    Console.WriteLine("Vendedor: " + vendedor.Nome);
    Console.WriteLine();
    Console.WriteLine("Produtos: ");
    foreach (var produto in pedido.Produtos){
        Console.WriteLine(" " + produto.Nome + " Preço: " + produto.Preco);
    }


    


