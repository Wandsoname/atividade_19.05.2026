// atividade dia 19/05/2026
// Sistema de Menu no Console
//Crie um programa que mostre: (1 - Cadastrar usuário / 2 - Listar usuários / 3 - Excluir usuário / 4 - Sair
//Regras ( • O usuário escolhe uma opção • O sistema deve usar switch • Exibir uma mensagem para cada opção • Caso inválido → mostrar erro

// abaixo apresentação e descrição das opções que se pede
using System.Diagnostics.Contracts;
using System.Xml.XPath;

//apresentação do Menu de seleção
Console.WriteLine(" ");
Console.WriteLine(new string('-',80));
Console.WriteLine("SELECIONE A OPÇÃO");
Console.WriteLine(new string('-',80));
Console.WriteLine(" ");
//menu de seleção (será repetido diversas vezes)
Console.WriteLine("1 - Cadastrar usuário");
Console.WriteLine("2 - Listar usuários");
Console.WriteLine("3 - Excluir usuário");
Console.WriteLine("4 - Sair");
Console.WriteLine(" ");
//seleção da opção (switch case)
int opcao = int.Parse(Console.ReadLine()!);
//variáves de usuario e contagem (utilizadas para identificar ou atribuir seleção)
string usuario = ""; //variavel de usuário, atribuido um valor vazio (posteriormente é incluso os usuarios)
string[] nomes = new string[10]; // lista com limite de 10 usuarioas a serem cadastrados
int contador =0; // contador que vai ajudar na seleção de qual espaço da lista vai ser atribuido
// enquanto a opçao for menor de 5 ela ativa o switch case, (ja que temos apenas 4 opções)
while (opcao < 5)
{
    //abaixo as opções dentro do switch case
    switch (opcao)
    {
        case 1:
            Console.WriteLine(" ");
            Console.WriteLine("1 - opção de cadastro de usuário selecionado.");
            Console.WriteLine("digite o nome do usuário");
            usuario = (Console.ReadLine()!); // atribuimos um usuario a variavel, como a variável ja foi informada á cima, então não procisa dizer oq ela é
            nomes[contador] = usuario; // o usuario é atribuido a lista, o contador vira o índice da lista
            contador++; // contador ganha +1 a cada vez que essa opção é selecionada
            string select = opcao == 1 ? "Cadastrado com Sucesso" : "Erro"; // confirma que se a seleção for um manda msg, caso não, manda outra msg
            Console.WriteLine(" ");
            Console.WriteLine($"usuário {usuario}  {select}"); // informa usuario e a mensagem da seleção
            Console.WriteLine(" ");
            // repete o menu abaixo
            Console.WriteLine("1 - Cadastrar usuário");
            Console.WriteLine("2 - Listar usuários");
            Console.WriteLine("3 - Excluir usuário");
            Console.WriteLine("4 - Sair");
            Console.WriteLine(" ");
            //dá a opção de uma mesma ou nova escolha das 4 opções
            Console.WriteLine("digite uma nova opção");
            // a variavel recebe uma nova opção e o while roda novamente as opções com base nessa escolha
            opcao = int.Parse(Console.ReadLine()!);
            break;

        case 2:
            Console.WriteLine(" ");
            Console.WriteLine("2 - opção de listagem de usuários selecionada");
            string select2 = opcao == 2 ? "Segue Usuarios cadastrados" : "Erro"; // confirma que se a seleção for um manda msg, caso não, manda outra msg
            Console.WriteLine(select2); // mostra a opção selecionada
            Console.WriteLine(" ");
            // enquanto o "i" for menor que o "contador" o "i" recebe +1
            // esse "contador" vai estar com os valores de acordo com os cadastros feitos
            for (int i = 0; i < contador; i++)
            {
                if (nomes[i] != "") // se o "i" for diferente de vazio "" então vai imprimir o indice da lista de nomes (nesse caso o "i" vai ser o Indice da lista)
                {
                    Console.WriteLine(nomes[i]); // vai imprimindo os usuariso até o "i" do for for igual ao valor do "contador"
                }
            }
            //repetição do menu
            Console.WriteLine(" ");
            Console.WriteLine("1 - Cadastrar usuário");
            Console.WriteLine("2 - Listar usuários");
            Console.WriteLine("3 - Excluir usuário");
            Console.WriteLine("4 - Sair");
            Console.WriteLine(" ");
            Console.WriteLine("digite uma nova opção");
            // a variavel recebe uma nova opção e o while roda novamente as opções com base nessa escolha
            opcao = int.Parse(Console.ReadLine()!);
            break;

        case 3:
            Console.WriteLine(" ");
            Console.WriteLine("3 - opção de exclusão de usuários selecionada");

            // esse "contador" vai estar com os valores de acordo com os cadastros feitos
            for (int i = 0; i < contador; i++)
            {
            // aqui mostra na tela tanto o indice (nesse caso o "i") quanto os nomes dentro da lista
            Console.WriteLine($"{i} - {nomes[i]}");
            }

            Console.WriteLine("Digite o número do usuário que deseja excluir:");
            // nova variavel, recebe o valor que vai representar o indice na lista onde está o usuário que vai ser excluido
            int excluir = int.Parse(Console.ReadLine()!);

            // confirmação( se a variave excluir for maior ou igual que 0 "e" menor que o contador, então faça)
            if (excluir >= 0 && excluir < contador)
            {
            // vai mostrar a seleção do nome que sera excluido de acordo com o indice selecionado
            Console.WriteLine($"Usuário {nomes[excluir]} excluído com sucesso!");

            // essa parte é para subir os valores e organizar na lista, para não ficar vazio quando o usuario for apagado
            // ex: se cadastramos 3 usuarios nosso "contador" será 3
            // se "excluir" recebe 1, então "i" vai receber 1, enquanto "i" for menor que "contador -1"; "i" recebe +1
            // nesse caso se 1 for menor que (contador == 3 ) - 1 no caso 2 o "i" vai recebendo +1 e executando oque tem embaixo.
            // até ele ser igual ao contador.
            for (int i = excluir; i < contador - 1; i++)
            {
                //aqui o usuario que será excluido, na verdade ele vai ser "substituido"
                // o usuario acima dele vai sobreescrever o usuario excluido
                //isso será feito com todos usuarios cadastrados posteriores para não ficar um buraco na lista.
                nomes[i] = nomes[i + 1];
            }

                // a umtima opção que ficaria vazia "" (com um espaço) vai ser apagada
                nomes[contador - 1] = null!;
                // diminui o contador em 1
                // se tinha 4 opções no Indice da lista, ela passa a ter 3
                contador--;
            }
            else // caso contrario...
            {
                Console.WriteLine("Usuário inválido!"); // mostre a informação
            }

            Console.WriteLine(" ");
            // repete o menu
            Console.WriteLine("1 - Cadastrar usuário");
            Console.WriteLine("2 - Listar usuários");
            Console.WriteLine("3 - Excluir usuário");
            Console.WriteLine("4 - Sair");
            Console.WriteLine(" ");
            Console.WriteLine("digite uma nova opção");
            // a variavel recebe uma nova opção e o while roda novamente as opções com base nessa escolha
            opcao = int.Parse(Console.ReadLine()!);

            break;

        case 4:
            Console.WriteLine(" ");
            Console.WriteLine("4 - opção de sair selecionada");
            string select4 = opcao == 4 ? "obrigado por interagir" : "Erro";
            Console.WriteLine(select4);
            //quando a opção recebe 4, ela dá a msg a cima e recebe mais 1, saindo do while e encerrando o programa
            opcao++;
            break;

        default:
            Console.WriteLine("Erro"); 
            break;
    }
}