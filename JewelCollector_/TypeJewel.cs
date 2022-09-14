namespace JewelCollector_
{
    /// <summary>
    /// Para facilitar a manipulacao dos tipos de joias disponiveis neste jogo
    /// </summary>
    public enum TypeJewel
    {
        RED = 100,
        GREEN = 50,
        BLUE = 10,
    }

    public class TypeJ
    {
        public TypeJewel type_j; 
        
        public TypeJ(TypeJewel type_j)
        {
            this.type_j = type_j;
        }
    }
}