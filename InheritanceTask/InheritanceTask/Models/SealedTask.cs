namespace InheritanceTask.Models
{
    //public class Cl1
    //{
    //    public sealed int Me1(int a, int b)
    //    {
    //        return a + b;
    //    }
    //}
    //cannot seal a method which is not overrided
    public  abstract class SealedTask
    {
        public abstract int Aj(int a,int b);
        

    }
    public  class C1:SealedTask
    {

        public  sealed override int Aj(int a, int b)
        {
            return a + b;
        }
    }
    public class C2 : C1
    {
       
    }
    
}
