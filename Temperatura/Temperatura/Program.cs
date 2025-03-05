// Declaração e VARS
int opt;
double entrada, faren, kelvin, KelvinToFaren, FarenToKelvin;

// Inserir a temperatura (EM CELSIUS)
Console.Write("Insira a sua temperatura (EM CÉLSIUS): ");
// Converte a entrada de string para um valor double (Exemplo: 56,2)
entrada = Convert.ToDouble(Console.ReadLine());

do
{

    //Demosntração visual do menu no console:
    Console.WriteLine("\n\n--- MENU ---");
    Console.WriteLine("1 - Converter para Fahrenheit");
    Console.WriteLine("2 - Converter para Kelvin");
    Console.WriteLine("3 - Converter de Kelvin para Farenheit");
    Console.WriteLine("4 - Converter de Farenheit para Kelvin");
    Console.WriteLine("0 - Sair\n\n");

    //Pergunta ao usuário qual opção ele deseja executar e após, guarda o valor
    Console.Write("Opção que deseja executar: "); opt = Convert.ToInt32(Console.ReadLine());

    if (opt == 1)
    {
        //AQUI ELE PEGA O VALOR DA ENTRADA E FAZ A CONVERSÃO PARA FARENHEIT
        faren = entrada * 1.8 + 32;
        Console.WriteLine($"\nSua temperatura em Celsius para Fahrenheit deu: {faren:F1}\n\n");
    }

    // Opção 2: Transforma CELSIUS PARA KELVIN
    else if (opt == 2)
    {
        //AQUI ELE BASICAMENTE PEGA OS DADOS DE ENTRADA E SOMA COM "273.15"
        kelvin = entrada + 273.15;
        Console.WriteLine($"\nSua temperatura em Celsius para Kelvin deu: {kelvin:F1}\n\n");
    }

    else if (opt == 3)
    {
        kelvin = entrada + 273.15;
        KelvinToFaren = kelvin * 1.8 - 459.67;
        Console.WriteLine($"\nSua temperatura de Kelvin para Farenheit deu: {KelvinToFaren:F2}");
    }

    else if (opt == 4)
    {
        faren = entrada * 1.8 + 32;
        FarenToKelvin =  (faren + 459.67)/2;
        Console.WriteLine($"\nSua temperatura de Farenheit para Kelvin deu: {FarenToKelvin:F2}");
    }


    Console.WriteLi
    //Enquanto a opção for diferente de 0, ele continuará mostrando o menu
} while (opt != 0);
