Console.WriteLine($"Bem Vindo ao programa do Edu");

int idade = -1;

do
{

    try
    {
        Console.WriteLine("Digite sua idade:");
        idade = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Idade: {idade}");
    }
    catch (System.Exception)
    {

        Console.WriteLine($"É necessário digitar números!");

    }

} while (idade < 0);