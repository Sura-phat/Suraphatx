namespace Test;

public class UnitTest1
{
    [Fact]
    public void IncorectConvertStingToDouble()
    {
        Assert.Throws<Exception>(()=>Introduct.StoD("Suraphat"));
    }
    
    [Fact]
    public void IncorectConvertStringtoLong()
    {
        Assert.Throws<Exception>(()=>Introduct.StoL("YoungF"));
    }
    
    [Fact]
    public void CheckStringToDouble()
    {
        double number = Introduct.StoD("23");
        Assert.Equal(number,23);
    }
    
    [Fact]
    public void  CheckStingToLong()
    {
        long number = Introduct.StoL("46");
        Assert.Equal(number,46);
    } 
}