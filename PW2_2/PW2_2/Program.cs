using System.Reflection.Metadata.Ecma335;

namespace PW2_2
{
    
    class programm {
        

        static void Main()
        {
            
            example numer = new example();
            for (int i=0; i <numer.Getn();i++)
            {
                numer.SetNumber(Convert.ToInt32(Console.ReadLine()));
                
            }
          
        }
    }
    class example
    {
        private int n = 0;
        public void SetNumber(int number)
        {
            if (number == n + 1)
            {
                Console.WriteLine(Convert.ToInt32(Getn()));
                n = number;
                

            }
            else
            {
                Console.WriteLine(Convert.ToInt32(Getn()));
                Console.WriteLine("error");
                n = 0;
                
            }
        }
        public bool ret( )
        {
            return ret();
        }
        public int Getn()
        {
            return n+1;
        }
    }

}