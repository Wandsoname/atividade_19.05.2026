// atividade dia 19/05/2026
// Sistema de Menu no Console
//Crie um programa que mostre: (1 - Cadastrar usuário / 2 - Listar usuários / 3 - Excluir usuário / 4 - Sair
//Regras ( • O usuário escolhe uma opção • O sistema deve usar switch • Exibir uma mensagem para cada opção • Caso inválido → mostrar erro

// abaixo apresentação e descrição das opções que se pede
Console.WriteLine(" ");
Console.WriteLine(new string('-',80));
Console.WriteLine("SELECIONE A OPÇÃO");
Console.WriteLine(new string('-',80));
Console.WriteLine(" ");

Console.WriteLine("1 - Cadastrar usuário");
Console.WriteLine("2 - Listar usuários");
Console.WriteLine("3 - Excluir usuário");
Console.WriteLine("4 - Sair");
Console.WriteLine(" ");

int opcao = int.Parse(Console.ReadLine()!);

string usuario = "";

switch (opcao)
{
    case 1:
        Console.WriteLine("digite o nome do usuário");
        usuario = (Console.ReadLine()!); // como a variável ja foi informada á cima, então não procisa dizer oq ela é
        string select = opcao == 1 ? "Cadastrado com Sucesso" : "Erro";
        Console.WriteLine($"usuário {usuario}  {select}");
        break;

    case 2:
        Console.WriteLine("Segue Usuarios cadastrados");
        string select2 = opcao == 2 ? "Segue Usuarios cadastrados" : "Erro"; // corrigir
        Console.WriteLine("Usuários cadastrados");
        Console.WriteLine(usuario);
        break;

    case 3:
        Console.WriteLine("3 - Excluir usuário");
        break;

    case 4:
        Console.WriteLine("4 - Sair");
        break;

    default:
        Console.WriteLine("Erro");
        break;
}