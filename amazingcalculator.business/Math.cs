namespace amazingcalculator.business
{
    public class Math
    {
        public int Add(int x, int y) { return x + y; }
        public int Sub(int x, int y) {return x - y; }

        public int Mul(int x, int y) {return (x * y); }

        public int Div(int x, int y) 
        {
            int z = 0;
            try
            {
                z = x / y;
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }

            return z;
        }
    }
}
