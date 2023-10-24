namespace FunctionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PrintName("Zeeshan", 5);
            Console.WriteLine( CheckIsEvenNo(8));


            int[,] matrix = new int[3, 3];//mulit dimentsional

            foreach(string name in GetDevelopers())
            {

                Console.WriteLine(name);
            }

            foreach (string[] developerNames in GetJaggedDevelopers()) { 
            
                foreach(string name in developerNames)
                {
                    Console.WriteLine(name);

                }
            
            }



            Console.ReadLine();
            
        }

        private static string CheckIsEvenNo(int no)
        {
            string result= (no % 2 == 0) ? "Input value is even"
                : "input value is odd";

            return result;
        }

        static  void PrintName(string name,int iterations)
        {
            for(int i = 0; i < iterations; i++)
            {

                Console.WriteLine(name.ToUpper());
            }

        }

        static string[] GetDevelopers() {

            string[] names = { 
              "Kannan", "Zeeshan","Koenig"
            };

            return names;
        }

        static string[][] GetJaggedDevelopers() {

            string[][] names = {
              new string[] { "kannan1","Zeeshan1" },
              new string[] { "kannan2","Zeeshan2" ,"zeeshan3"},
            };

            return names;
        }

       

    }
}