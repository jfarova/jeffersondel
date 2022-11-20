internal class Program
{
    private static void Main(string[] args)
    {
        int n1,n2,n3;
        Console.WriteLine("intrudusca 3 numeros: ");
        n1= int.Parse(Console.ReadLine());
        Console.WriteLine("intrudusca 3 numeros: ");
        n2= int.Parse(Console.ReadLine());
        Console.WriteLine("intrudusca 3 numeros: ");
        n3= int.Parse(Console.ReadLine());
             if(n1>n2 && n1>n3){
                
                Console.WriteLine("el numero mayor es: " +n1);
            
            
            }
            else if(n2>n1 && n2>n3){
                
                Console.WriteLine("el numero mayor es: " +n2);
            
            
            }
           else  if(n3>n1 && n3>n2){
                
                Console.WriteLine("el numero mayor es: " +n3);
            
            
            }

           
        }
    }

