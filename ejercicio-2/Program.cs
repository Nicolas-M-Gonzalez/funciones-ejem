using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
           int n1, con= 0 ;

           for (int x = 0; x < 5; x++)
           {
            Console.WriteLine( " escriba un numero:");
            n1 = int.Parse(Console.ReadLine ());
            
            if ( par(n1)){
                con ++;
            }
           }
          
          Console.WriteLine(" los numeros pares son:" + con++);
             
        }

    
         static bool par ( int a)
         {
          

          if ( a % 2 == 0)
          {
            
            return true;
            
          }
          else
          {
            return false;
          }

         }     
    }

}
