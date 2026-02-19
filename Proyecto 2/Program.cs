static string CheckNumber(int numero)
{
    if (numero > 0)
    {
        return "El número es positivo";
    }
    else if (numero < 0)
    {
        return "El número es negativo";
    }
    else
    {
        return "El número es cero";
    }
}
Console.WriteLine("Ingrese un número:");
int numeroIngresado = int.Parse(Console.ReadLine());
Console.WriteLine(CheckNumber(numeroIngresado));