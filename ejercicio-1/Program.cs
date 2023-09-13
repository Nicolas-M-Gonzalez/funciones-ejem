using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
          int n1,n2,resultado;
          

          Console.WriteLine( " escriba un numero:");
          n1 = int.Parse ( Console.ReadLine());
          Console.WriteLine( " escriba el otro:");
          n2 = int.Parse ( Console.ReadLine());
        
          resultado = producto ( n1,n2 );
             
          Console.WriteLine( " el producto es :" + resultado);

          
          
         
        }
       static int producto ( int a , int b)
       {
        int r;

        r= a*b;

        return r;
       }
 
      
    
    }

    
}         

  

