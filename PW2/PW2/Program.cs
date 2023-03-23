namespace PW2
{
    class Program
    {
        static void Main(string[] args)
        {
            urav uravnenie = new urav();
            Console.WriteLine(uravnenie.Geta());
            Console.WriteLine(uravnenie.Getb());
            Console.WriteLine(uravnenie.Getc());
            uravnenie.CalculateRoots();
        }
    }
    public class urav
    {
        private double a = -1;// число a
        private double b=7;// число b
        private double c=8;// число c


        public double Geta()
        {
            return a;
        }
        public double Getb()
        {
            return b;
        }
        public double Getc()
        {
            return c;
        }


        public void Seta(double a)
        {
            this.a = a;
        }
        public void Setb(double b)
        {
            this.b = b;
        }
        public void Setc(double c)
        {
            this.c = c;
        }


        private double discrim()
        {
            return (Getb() * Getb()) - 4 * Geta() * Getc();

        }
        public void CalculateRoots()
        {
            if (discrim() > 0 || discrim() == 0)
            {
                double x1 = (-Getb() + Math.Sqrt(Convert.ToInt32(discrim()))) / (2 * Geta());
                double x2 = (-Getb() - Math.Sqrt(Convert.ToInt32(discrim()))) / (2 * Geta());
                Console.WriteLine("x1= {0}\n x2= {1}", x1, x2);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Действительных корней нет");
                Console.ReadKey();
            }
        }

    }

}
