namespace InheritanceTask.Models
{
    public class EncapsulationExample
    {
        private int original_Price;
        public  static int id = 40;
       

        public EncapsulationExample()
        {
            original_Price = 1500;  
        }
        public int OriginalPrice { get => original_Price;  }


    }
}