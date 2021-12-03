/* SEALED - Classes e Metodos Selados:
	- SEALED impossibilita a heranca por subclasses;
	- Ainda podemos extender a funcionalidade de uma classe Selada, usando
	  "extension methods";
	- Exemplo de Classe Selada:
			namespace Aula129_Sealed
			{
				sealed class SavingsAccount
				{

     - METODOS SELADOS - Regra somente pode ser imposta para Metodos Sobrepostos.

    >>> POR QUE DEVEMOS SELAR CLASSES E METODOS?
            - Seguranca: Dependendo das Regras de Negocio, devemos garantir que uma classe nao seja herdada, ou que um
              metodo nao seja sobreposto;
            - Evitar Inconsistencias: Sobreposicoes multiplas podem ser uma porta de entrada para inconsistencias;
            - Performance: atributos de tipo de uma classe selada sao analisados de forma mais rapida em tempo de execucao:
                > Exemplo: string.

*/

/* >>> CLASSE PRINCIPAL <<< */
using System;
using Aula129_Sealed.Entities;
namespace Aula129_Sealed
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Vinicius", 100000.00);
            Account acc2 = new SavingsAccount(1002, "Juliane", 500000.00, 0.02); // Upcasting

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
