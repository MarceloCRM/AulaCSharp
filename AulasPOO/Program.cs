// See https://aka.ms/new-console-template for more information
using AulasPOO.uteis;

int opcao = 0, num1, num2;
var lista = new List<string> {};
var listaNova = new List<string> { };
do
{
    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("1) Somar");
    Console.WriteLine("2) Multiplicar");
    Console.WriteLine("3) Fatorial");
    Console.WriteLine("4) Sorteador");
    Console.WriteLine("0) Sair");

    opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 0:
            Console.WriteLine("Fim do Programa");
            break;
        case 1:
            LerDoisNumerosInteiros();
            var calc = new Calculadora();
            int resultado = calc.Soma(num1, num2);
            Console.WriteLine($"O resultado da soma de {num1} com {num2} é {resultado}");
            break;
        case 2:
            LerDoisNumerosInteiros();
            Console.WriteLine($"O resultado da multiplicação de {num1} por {num2} é {Calculadora.Multiplica(num1, num2)}");
            break;
        case 3:
            Console.WriteLine("Informe o valor desejado: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine($"O fatorial de {numero} é {Calculadora.Fatorial(numero)}");
            break;
        case 4:
            Console.WriteLine("Deseja adicionar nomes a lista?(S/N)");
            string pergunta = Console.ReadLine();
            if (pergunta.ToLower() == "s")
            {
                CriaLista();
            }
            
            if (lista.Count > 0)
            {
                Calculadora.Sorteador(lista, listaNova);
                string resultadoLista = string.Join(", ", lista);
                string resultadoSort = string.Join(", ", listaNova);
                Console.WriteLine($"Lista: {resultadoLista}");
                Console.WriteLine($"Lista de sorteados: {resultadoSort}");
                break;
            }
            else
            {
                Console.WriteLine("A lista está vazia.");
                break;
            }

        default:
            Console.WriteLine("Opção Inválida");
            break;
    }
} while (opcao != 0);

void LerDoisNumerosInteiros()
{
    Console.WriteLine("Informe o primeiro número: ");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o segundo número: ");
    num2 = int.Parse(Console.ReadLine());
}

void CriaLista()
{
    string valor;
    do
    {
        Console.WriteLine("Insira um nome que deseja adicionar na lista ou '0' para sair: ");
        valor = Console.ReadLine();
        if (valor != "0")
        {
            lista.Add(valor);
        }
    } while (valor != "0");
}