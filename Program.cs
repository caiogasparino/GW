// //  Questao 1

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;

// namespace MaiorNumero
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             List<int> numeros = new List<int>();
//              
//             for (int i = 0; i < 10; i++)
//             {
//                 Console.WriteLine("Digite o "+ (i+1).ToString() + "º número: ");
//                  
//                 int value  = 0;
//  
//                 int.TryParse(Console.ReadLine(), out value);
//  
//                 numeros.Add(value);
//             }
//  
//             numeros = numeros.OrderBy(c => c).ToList();
//  
//             Console.WriteLine("Maior número: " + numeros.LastOrDefault());
//  
//             Console.ReadLine();
//         }
//     }
// }

// Questao 2

// using System;
// using System.IO;

// class ReadFromFile
// {
//     static void Main()
//     {
//         string[] lines = System.IO.File.ReadAllLines(@"C:\Users\user\Projeto\GW\teste2.txt");

//         System.Console.WriteLine("Contents of teste2.txt = ");
//         foreach (string line in lines)
//         {
//             Console.WriteLine("\t" + line);
//         }

//         Console.WriteLine("Press any key to exit.");
//         System.Console.ReadKey();
//     }
// }

// Questao 3

using System;
using System.IO;

class Test 
{
    public static void Main() 
    {
        // Specify the directory you want to manipulate.
        string path = @"C:\Users\user\Projeto\GW\Teste3";

        try 
        {
            // Determine whether the directory exists.
            if (Directory.Exists(path)) 
            {
                Console.WriteLine("That path exists already.");
                return;
            }

            // Try to create the directory.
            DirectoryInfo di = Directory.CreateDirectory(path);
            Console.WriteLine("The directory was created successfully at {0}.", Directory.GetCreationTime(path));
            

        } 
        catch (Exception e) 
        {
            Console.WriteLine("The process failed: {0}", e.ToString());
        } 
        finally {}
    }
    
}
