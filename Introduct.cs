public class Introduct
{
    public static void Main(string[] args)
    {
        Info user = new Info();

        Console.Write("Please input Name : ");
        user.Name = inputt();
        Console.Write("Please input Number : ");
        user.Number = StoL(inputt());
        Console.Write("Please input Owner Name : ");
        user.Owner_name = inputt();
        Console.Write("Please input Registered Value : ");
        user.Registered_Value = StoL(inputt());
        Info.InfoMe_Print(user);
        Console.Write("Please input money: ");
        string Cashtrue = inputt();
        double SToDxChange = StoD(Cashtrue);
        CashCal neno = new CashCal();
        neno.Mod(SToDxChange);
        
   
    }
   public static long StoL(string Input)
    {
        if(long.TryParse(Input,out long result))
        {
            return result;
        }
        throw new Exception("Pls Input again");
    }
    public static double StoD(string Input)
    {
        if(double.TryParse(Input,out double result))
        {
            return result;
        }
        throw new Exception("Pls Input again");
    }
    
    public static string inputt()
    {
        return Console.ReadLine();
    }
}