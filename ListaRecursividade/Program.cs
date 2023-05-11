using ListaRecursividade;

Exercicio1 ex1 = new Exercicio1();
var result = ex1.CalcularPotencia(3, 4);
Console.WriteLine(result);

Exercicio2 ex2 = new Exercicio2();
double[] arr = { 1, 3, 5, 2, 3 };
var result2 = ex2.CalcularArray(arr, 7);
Console.WriteLine(result2);

Exercicio3 ex3 = new Exercicio3();
int[] arr2 = { 1, 3, 5 };
ex3.Inverter(arr2, 0, 2);

Exercicio4 ex4 = new Exercicio4();
ex4.Conversor(4);