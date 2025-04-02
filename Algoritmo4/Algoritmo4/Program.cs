using System.Globalization;

//Variaveis
double largura;
double comprimento, area, valorMetro, valorTerreno;

//Entrada
largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
valorMetro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//Calculo
area = largura * comprimento;
valorTerreno = area * valorMetro;

//Saida
Console.WriteLine("AREA - " + area.ToString("F2",CultureInfo.InvariantCulture));
Console.WriteLine("PREÇO = " + valorTerreno.ToString("F2" ,CultureInfo.InvariantCulture));