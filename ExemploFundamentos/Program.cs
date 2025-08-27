using ExemploFundamentos.Common.Models;

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Batista";
pessoa1.Idade = 53;
pessoa1.Apresentar();


















// string opcao;
// bool exbirMenu = true;

// while (exbirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;

//         case "2":
//             Console.WriteLine("Busca de cliente");
//             break;

//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;

//         case "4":
//             Console.WriteLine("Encerrar");
//             exbirMenu = false;
//             // Environment.Exit(0);
//             break;

//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }
// }

// Console.WriteLine("O programa se encerrou");




// int soma = 0, numero = 0;


// do
// {
//     Console.WriteLine("Digite um numero (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while (numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma} ");




// int numero = 5;
// int contador = 1;

// while (contador <= 10)
// {
//     Console.WriteLine($"{contador}° Execução: {numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 6)
//     {
//         break;
//     }
// }


// int numero = 5;

// for (int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }
























// int numeroIncremento = 10;
// Console.WriteLine("número incremento:" + numeroIncremento);
// Console.WriteLine("Incrementando o 10");
// // numero = numero + 1;
// numeroIncremento++;
// Console.WriteLine(numeroIncremento);

// int numeroDecremento = 20;
// Console.WriteLine("\nnúmero decremento:" + numeroDecremento);
// Console.WriteLine("Decrementando o 20");
// numeroDecremento--;
// Console.WriteLine(numeroDecremento);


// Calculadora calc = new Calculadora();

// calc.Somar(10, 30);
// calc.Subtrair(10, 50);
// calc.Multipicart(15, 45);
// calc.Dividir(2, 2);
// calc.Potencia(3, 3);
// calc.Seno(30);
// calc.Coseno(30);
// calc.Tangente(30);
// calc.RaizQuadrada(9);




// bool choveu = false;
// bool estaTarde = false;

// if (!choveu && !estaTarde)
// {
//     Console.WriteLine("Vou pedalar");
// }
// else
// {
//     Console.WriteLine("Vou pedalar um outro dia.");
// }


// bool possuiPresencaMinima = true;
// double media = 5.5;

// if (possuiPresencaMinima && media >= 7)
// {
//     Console.WriteLine("Aprovado!");
// }
// else
// {
//     Console.WriteLine("Reprovado!");
// }



// verifica se é maior de 18 anos ou se for menor, deve possuir autorização do responsável
// não aceita numeros negativos (uint)

// uint idade = 0;
// bool possuiAutorizacaoDoResponsavel = false;

// Console.WriteLine("Digite a idade:");
// while (!uint.TryParse(Console.ReadLine(), out idade))
// {
//     Console.WriteLine("Entrada inválida. Por favor, digite um número válido:");
// }
// bool ehMaiorDeIdade = idade >= 18;

// if (ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)
// {
//     Console.WriteLine("Entrada liberada!");
// }
// else
// {
//     Console.WriteLine("Possui autorização do responsável? (s/n)");

//     // Lê a resposta do usuário e converte para minúsculas para facilitar a comparação
//     string resposta = Console.ReadLine();
//     resposta = resposta == null ? "" : resposta.Trim().ToLower();

//     // O loop continua enquanto a resposta NÃO for "s" E NÃO for "n"
//     while (resposta != "s" && resposta != "n")
//     {
//     Console.WriteLine("Digite uma resposta válida (s/n)!");
//     resposta = Console.ReadLine().Trim().ToLower();
//     }

//     // Quando o loop termina, a resposta só pode ser "s" ou "n"
//     if (resposta == "s")
//     {
//     Console.WriteLine("Entrada liberada!");
//     }
//     else
//     {
//     Console.WriteLine("Entrada não liberada.");
//     }
// }






// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();


// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;
//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;        
// }


// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();


// if (letra == "a" ||
//     letra == "e" ||
//     letra == "i" ||
//     letra == "o" ||
//     letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal");    
// }



// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// if (letra == "a")
// {
//     Console.WriteLine("vogal");
// }
// else if (letra == "e")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "i")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "o")
// {
//     Console.WriteLine("Vogal");
// }
// else if (letra == "u")
// {
//     Console.WriteLine("Vogal");
// }
// else
// {
//     Console.WriteLine("Não é uma vogal");
// }



// int quantidadeEmEstoque = 13;
// int quantidadeCompra = 4;
// bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;


// Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
// Console.WriteLine($"Quantidade compra: {quantidadeCompra}");
// Console.WriteLine($"É possível realizar a venda? {possivelVenda}");

// if (quantidadeCompra == 0)
// {
//     Console.WriteLine("Venda inválida");
// }
// else if (possivelVenda)
// {
//     Console.WriteLine("Venda realizada.");
// }
// else
// {
//     Console.WriteLine("Desculpe. Não temos a quantidade desejada em estoque.");
// }

































// string a = "15-";

// // int b = 0;

// int.TryParse(a, out int b);


// Console.WriteLine(b);
// Console.WriteLine("Conversao realizada com sucesso!");









// double a = 4 / 2 + 2;
// double a = 4 / (2 + 2);

// Console.WriteLine(a);















// int a = 5;
// double b = a;

// long a = long.MaxValue;
// int b = Convert.ToInt32(a);

// int a = int.MaxValue;
// int b = a;

// Console.WriteLine(b);















// int inteiro = 5;
// string a = inteiro.ToString();


// Console.WriteLine(a);













// Cast - Casting
// int a = Convert.ToInt32(null);
// int a = Convert.ToInt32("5");
// int a = int.Parse("5c");
// int a = int.Parse(null);


// Console.WriteLine(a);


















// int a = 10;
// int b = 20;

// int c = a + b;

//c = c + 5; // 30 + 5

//c += 5;

// c = c - 5;
// c *= 5;


// Console.WriteLine(c);














// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));




// string apresentacao = "Olá, seja bem-vindo";


// int quantidade = 1;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);

// quantidade = 10;
// Console.WriteLine("Valor da variável quantidade: " + quantidade);

// double altura = 1.80;

// decimal preco = 1.80M;

// bool condicao = true;


// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
// Console.WriteLine("Valor da variável preço: " + preco);
// Console.WriteLine("Valor da variável condição: " + condicao);


// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Batista";
// pessoa1.Idade = 53;
// pessoa1.Apresentar();

// Pessoa pessoa_FisicaRepresentacao = new Pessoa();