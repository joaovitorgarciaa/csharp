//Author: João Garcia 2025.02.21

//Console: Terminal visto assim que se executa
// WriteLine: "Print de um texto ou número"
Console.WriteLine("Olá! Pessoal");

//Declaração e vars
int num1, num2, opt;
Console.WriteLine("Calculadora");

// Inserir dados em 2 vars
//Após inserirmos um valor, temos que dar o Console.ReadLine() na mesma linha, para ele ler o que foi escrito.
Console.Write("Insira o número 1: "); num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Insira o número 2: "); num2 = Convert.ToInt32(Console.ReadLine());

// Ciclo de repetições (Sair quando OPT = 0)

do
{

    //Menu
    Console.WriteLine("1 - Somar");
    Console.WriteLine("2 - Subtrair");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("0 - Sair");
    Console.Write("Qual a opção desejada? "); opt = Convert.ToInt32(Console.ReadLine());

    //Declaração ao valor final da operação
    int operacao;

    //Condição se o usuário quiser somar
    if (opt == 1)
    {
        operacao = num1 + num2;
        Console.WriteLine($"A soma deu: {operacao}");
    }

    //Condição se o usuário quiser subtrair
    else if (opt == 2)
    {
        operacao = num1 - num2;
        Console.WriteLine($"A subtração deu: {operacao}");
    }

    //Condição se o usuário quiser multiplicar
    else if (opt == 3)
    {
        operacao = num1 * num2;
        Console.WriteLine($"A multiplicação deu: {operacao}");
    }

    //Condição se o usuário quiser dividir
    else if (opt == 4)
    {
        operacao = num1 / num2;
        Console.WriteLine($"A divisão deu: {operacao}");
    }

    //Enquanto a opção for diferente de 0, ele repetirá o ciclo
} while (opt != 0);

    

