using Xunit;
using JewelCollector_;

namespace JewelCollector_Test;

public class ConstrutorsTest
{
    [Fact]
    public void testConstrutorJewel()
    {
        Jewel j = new Jewel(1,2, TypeJewel.BLUE);
        Assert.True(j.x == 1);
        Assert.True(j.y == 2);
        Assert.True(j.tj.type_j == TypeJewel.BLUE);
    }


    [Fact]
    public void testConstrutorRobot()
    {
        Robot r = new Robot(1,2);
        Assert.True(r.x == 1);
        Assert.True(r.y == 2);
        
        Jewel j = new Jewel(1,2, TypeJewel.BLUE);
        r.bag.Add(j);
        Assert.True(r.bag[0] == j);
    }



}