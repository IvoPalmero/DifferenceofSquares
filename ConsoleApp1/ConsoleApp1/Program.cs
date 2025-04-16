// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese el numero que desee calcular");

int numero = int.Parse(Console.ReadLine());
int CuadradoDeLaSuma = 0;
int SumaDeLosCuadrados = 0;

for (int i = numero;  i != 0; i--)
{
    int resultado = (int)Math.Pow(i, 2);
    SumaDeLosCuadrados += resultado;

}
for (int i = numero; i != 0; i--)
{
    CuadradoDeLaSuma += i;

}
CuadradoDeLaSuma = (int)Math.Pow(CuadradoDeLaSuma, 2);

Console.WriteLine("la diferencia entre el cuadrado de la suma " + (numero) + " y la suma de los cuadrados del mismo es: " + (CuadradoDeLaSuma - SumaDeLosCuadrados));