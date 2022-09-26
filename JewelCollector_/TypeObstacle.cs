namespace JewelCollector_
{
    public enum TypeObstacle
    {
        WATER = 0,          // 0
        TREE = 1,           // 1
    }

    public class TypeO
    {
        public TypeObstacle type_o; 
        
        public TypeO(TypeObstacle type_o)
        {
            this.type_o = type_o;
        }

        public static bool isObstacle(string obs){
            bool ret = false;
            string[] options = {"tree", "water"}; 
            foreach (var op in options){
                if(obs.ToLower().Equals(op))
                    ret = true;
            }

            return ret;
        }
    }
}