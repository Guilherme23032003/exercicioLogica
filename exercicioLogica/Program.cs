/* Dado n numeros, ordene em ordem crescente, e decrescente e mostre na tela os dois resultados, dps com os dois arrays
 * some o primeiro número do primeiro array com o último número do último array, o segundo do primeiro array 
 * com o penúltimo do segundo array e assim por diante, pegue o resultado e faça a sequência de Fibonacci até esses números
 */

using System.Security.Cryptography;

Console.Write("quantidade de numeros que ira digitar: ");
Console.WriteLine();
int n = int.Parse(Console.ReadLine());
int aux, soma = 0;
int[] vet = new int[n];
int[] crescente = new int[n];
int[] decrescente = new int[n];


for (int i = 0; i < n; i++)

{
    vet[i] = int.Parse(Console.ReadLine());

}
//ordenando em forma crescente
for (int i = 0; i < vet.Length; i++)
{

    for (int j = 0; j < vet.Length; j++)
    {
        if (vet[i] < vet[j])
        {
            aux = vet[i];
            vet[i] = vet[j];
            vet[j] = aux;
        }
    }
}
for (int i = 0; i < n; i++)
{
    crescente[i] = vet[i];
}


Console.WriteLine();
Console.WriteLine();
Console.WriteLine("ordem decrescente");
for (int k = 0; k < n; k++)

{
    Console.Write(+crescente[k] + " ");

}
Console.WriteLine();
Console.WriteLine();

// ordenando de forma decrrescente

for (int i = 0; i < vet.Length; i++)
{

    for (int j = 0; j < vet.Length; j++)
    {
        if (vet[i] > vet[j])
        {
            aux = vet[i];
            vet[i] = vet[j];
            vet[j] = aux;
        }
    }
}
for (int i = 0; i < n; i++)
{
    decrescente[i] = vet[i];
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("ordem decrescente");
for (int k = 0; k < n; k++)

{

    Console.Write(decrescente[k] + " ");

}
//somando os arrays (primeiro com ultimo
for (int i = 0; i < n; i++)
{
    for (int j = n - 1; j >= 0; j--)
    {

        soma = soma + decrescente[j] + crescente[i];
        i++;
    }
}
Console.WriteLine("\n\n\n soma " + soma);

int numeroAnterior = 0;
int numeroAtual = 1;
int fibo=0;
Console.WriteLine();
Console.WriteLine(  );
Console.WriteLine("sequencia fibonacci ate o valor da soma");
for (int i = 0; i <= soma; i++)
{
    if (fibo<soma)
    {
        fibo = numeroAnterior + numeroAtual;
        Console.WriteLine(fibo);
        numeroAnterior = numeroAtual;
        numeroAtual = fibo;
    }
    
}


