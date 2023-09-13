using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
           int n, con= 0, acuprimo=0,promedio;

           Console.WriteLine("escriba un numero:");
           n = int.Parse(Console.ReadLine());

           while (n != 0)
           {
             if ( primo(n))
             {
                con ++;
                acuprimo += n; 
             }

            
             Console.WriteLine("escriba otro:");
             n = int.Parse(Console.ReadLine());
            
            }
           promedio = acuprimo / con;

           Console.WriteLine( " el promedio es:" + promedio);
        
        
        }
        
        static bool primo (  int a )
        {
        int con = 0;
           for (int x = 1; x <= a; x++)
           {
            if ( a % x == 0)
                con ++;
           }
            
            if ( con == 2)
                return true;
            else 
                return false;
            }
            
        }     
    
    
    }


