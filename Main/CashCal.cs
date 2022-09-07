public class CashCal
{ 
    public void Mod(double gun)
    {
        double[] calculate =  { 1000, 500, 100, 50, 20, 10, 5,2,1, 0.50, 0.25 };
        int [] outpput = new int[11];
        
        for (int i = 0; i < calculate.Length; i++)
        {
            while (gun >= calculate[i])
            {
                gun -= calculate[i];
                outpput[i]++;
            }
        }
        for (int i = 0; i<calculate.Length;i++)      
        {
            Console.WriteLine("{0} : {1}", calculate[i], outpput[i]);
        }
    }
}