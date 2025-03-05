double metro, km, cm, pol, medidaFinal;
int opcao;

Console.WriteLine("\nEscreva aqui a distância que deseja ser convertida (EM METROS): "); metro = Convert.ToDouble(Console.ReadLine());


do


{
    Console.WriteLine("\n---- MENU ----\n");
    Console.WriteLine("1 - Metros p/ KM\n");
    Console.WriteLine("2 - Metros p/ CM\n");
    Console.WriteLine("3 - Metros p/ Polegadas\n");
    Console.WriteLine("0 - Sair\n\n");

    Console.Write("Opção que deseja executar: "); opcao= Convert.ToInt32(Console.ReadLine());


    if (opcao == 1)
    {
        medidaFinal = metro / 1000;
        Console.WriteLine($"O resultado da conversão de metros para quilómetro deu: {medidaFinal:F3}km\n\n");
    }

    if (opcao == 2)
    {
        medidaFinal = metro * 100;
        Console.WriteLine($"O resultado da conversão de metros para centímetros deu: {medidaFinal:F1}cm\n\n");
    }


    if (opcao == 3)
    {
        medidaFinal = metro * 39.37;
        Console.WriteLine($"O resultado da conversão de metros para polegadas deu: {medidaFinal:F1}pol\n\n");
    }


}
while(opcao != 0);