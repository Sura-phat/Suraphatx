public class Info
{
    public string Name = "";
    public long  Number ;
    public string Owner_name = "";
    public long Registered_Value; 
    public static void InfoMe_Print(Info user)
    {
        Console.WriteLine("----- Shop Information -----");
        Console.WriteLine("Name : {0}", user.Name);
        Console.WriteLine("Number : {0}", user.Number);
        Console.WriteLine("Owner Name : {0}", user.Owner_name);
        Console.WriteLine("Registered Value : {0}", user.Registered_Value);
        Console.WriteLine("----------------------------");
    }
}