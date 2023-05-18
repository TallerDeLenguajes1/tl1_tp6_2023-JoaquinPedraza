int intNum1 = 0;
bool anda = false;
string? numString = "";

while (!anda)
{
  Console.WriteLine("Ingrese un número válido");
  numString = Console.ReadLine();
  anda = int.TryParse(numString, out intNum1);
  if (!anda)
  {
    Console.WriteLine(numString + " no es número válido.");
  }
}

if (intNum1 > 0)
{
  double numInvertido = 0;

  while (intNum1 / 10 > 0)
  {
    numInvertido = numInvertido * 10 + intNum1 % 10;
    intNum1 = intNum1 / 10;
  }
  numInvertido = numInvertido * 10 + intNum1 % 10;

  Console.WriteLine("El numero invertido es: " + numInvertido);
}