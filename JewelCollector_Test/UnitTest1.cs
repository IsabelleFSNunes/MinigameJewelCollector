using Xunit;
using JewelCollector_;

namespace JewelCollector_Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Jewel j = new Jewel(1,2, TypeJewel.BLUE);
        // Console.WriteLine("Joia adicionada: ");
        // string output = JsonConvert.SerializeObject(j,Formatting.Indented);
        Assert.True(j.x == 1);
        Assert.True(j.y == 2);
        Assert.True(j.tj.type_j == TypeJewel.BLUE);

        // Console.WriteLine(output);
    }


    [Fact]
    public void Test2()
    {
        Robot r = new Robot(1,2);
        // Console.WriteLine("Joia adicionada: ");
        // string output = JsonConvert.SerializeObject(j,Formatting.Indented);
        Assert.True(r.x == 1);
        Assert.True(r.y == 2);
        
        Jewel j = new Jewel(1,2, TypeJewel.BLUE);
        r.bag.Add(j);
        Assert.True(r.bag[0] == j);
        // Console.WriteLine(output);
    }
}