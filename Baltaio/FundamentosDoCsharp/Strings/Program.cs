using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Guid: Global Unique Identifier
            // Para transformar ele em uma string, podemos usar o método .ToString(), já que o Guid é parte do System e tem todos os métodos associados
            var id = Guid.NewGuid();
            //id.ToString();

            //id = new Guid("ef5e7b86-ba25-4f78-98ed-d82dd7918c61");
            Console.WriteLine(id.ToString().Substring(0,8)); // Console.WriteLine já converte pra string antes de imprimir o valor
            
            // podemos usar o método Substring pra retornar um valor com um número menor de caracteres, nesse caso 8, pra simplificar o uso do Guid

            // Essencialmente é como uma forma muito muito simples e eficaz de gerar um número randômico com 8 caracteres

            // Pra gerar sempre um novo id, é necessário usar id = Guid.NewGuid(); usando somente id = new Guid(); é gerado uma string somente com zeros, porque ele apenas inicializa o identificador

            // E quando usamos id = new Guid("ef5e7b86-ba25-4f78-98ed-d82dd7918c61")
            // com um valor e formatação exatos, ele gera esse Guid e atribui o valor informado entre parênteses
        }
    }
}