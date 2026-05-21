// atividade dia 19/05/2026
// Sistema de Menu no Console
//Crie um programa que mostre: (1 - Cadastrar usuário / 2 - Listar usuários / 3 - Excluir usuário / 4 - Sair
//Regras ( • O usuário escolhe uma opção • O sistema deve usar switch • Exibir uma mensagem para cada opção • Caso inválido → mostrar erro

// abaixo apresentação e descrição das opções que se pede
using System.Diagnostics.Contracts;

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
string[] nomes = new string[10];
int contador =0;
while (opcao != 5)
{
    
    switch (opcao)
    {
        case 1:
            Console.WriteLine(" ");
            Console.WriteLine("1 - opção de cadastro de usuário selecionado.");
            Console.WriteLine("digite o nome do usuário");
            usuario = (Console.ReadLine()!); // como a variável ja foi informada á cima, então não procisa dizer oq ela é
            nomes[contador] = usuario;
            contador++;
            string select = opcao == 1 ? "Cadastrado com Sucesso" : "Erro";
            Console.WriteLine(" ");
            Console.WriteLine($"usuário {usuario}  {select}");
            Console.WriteLine(" ");
            Console.WriteLine("1 - Cadastrar usuário");
            Console.WriteLine("2 - Listar usuários");
            Console.WriteLine("3 - Excluir usuário");
            Console.WriteLine("4 - Sair");
            Console.WriteLine(" ");
            Console.WriteLine("digite uma nova opção");
            opcao = int.Parse(Console.ReadLine()!);
            break;

        case 2:
            Console.WriteLine(" ");
            Console.WriteLine("2 - opção de listagem de usuários selecionada");
            string select2 = opcao == 2 ? "Segue Usuarios cadastrados" : "Erro";
            Console.WriteLine(select2);
            Console.WriteLine(" ");
            Console.WriteLine(nomes[0]);
            Console.WriteLine(nomes[1]);
            Console.WriteLine(nomes[3]);
            Console.WriteLine(nomes[4]);
            Console.WriteLine(" ");
            Console.WriteLine("1 - Cadastrar usuário");
            Console.WriteLine("2 - Listar usuários");
            Console.WriteLine("3 - Excluir usuário");
            Console.WriteLine("4 - Sair");
            Console.WriteLine(" ");
            Console.WriteLine("digite uma nova opção");
            opcao = int.Parse(Console.ReadLine()!);
            break;

        case 3:
            Console.WriteLine(" ");
            Console.WriteLine("3 - opção de exclusão de usuários selecionada");
            string select3 = opcao == 3 ? "Excluido" : "Erro";
            Console.WriteLine($"usuário {usuario}  {select3}");
            usuario = "sem usuario";
            Console.WriteLine(" ");
            Console.WriteLine("1 - Cadastrar usuário");
            Console.WriteLine("2 - Listar usuários");
            Console.WriteLine("3 - Excluir usuário");
            Console.WriteLine("4 - Sair");
            Console.WriteLine(" ");
            Console.WriteLine("digite uma nova opção");
            opcao = int.Parse(Console.ReadLine()!);
            break;

        case 4:
            Console.WriteLine(" ");
            Console.WriteLine("4 - opção de sair selecionada");
            string select4 = opcao == 4 ? "obrigado por interagir" : "Erro";
            Console.WriteLine(select4);
            opcao++;
            break;

        default:
            Console.WriteLine("Erro");
            break;
    }
}