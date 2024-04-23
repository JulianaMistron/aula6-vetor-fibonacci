//faça um programa que leia um numero inteiro e imprima até esta posição da sequencia fibonacci.
//nao precisa gravar a sequencia fibonaci, só imprimir


int primeiroNumero = 1;
int proximoNumero = 0;

Console.Write("Digite a posição: ");
int posicao = int.Parse(Console.ReadLine());

for (int i = 0; i < posicao; i++)
{
    Console.Write(primeiroNumero + " ");
    primeiroNumero = primeiroNumero + proximoNumero;
    proximoNumero = primeiroNumero - proximoNumero;
}
