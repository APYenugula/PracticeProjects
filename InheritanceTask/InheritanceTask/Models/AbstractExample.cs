namespace InheritanceTask.Models
{
    public interface IParentClass
    {
        public int ParentProp1 { get; set; }
        public int ParentProp2 { get; set; }
        public int ParentProp3 { get; set; }
        string ParentMethod(int p1, int p2);
    }
    public class ParentClass:IParentClass
    {
        public int ParentProp1 { get; set; }
        public int ParentProp2 { get; set; }
        public int ParentProp3 { get; set; }
        
        public string ParentMethod(int p1,int p2)
        {
            return (p1 + p2).ToString();
        }
    }
    public class ChildClass : ParentClass
    {

    }
    public abstract class AbstractClass
    {
        public void AbstractMethod()
        {
            Console.WriteLine("hello");
        }
        public abstract void Ab();
        
    }
    public class childOfAbstractClass: AbstractClass
    {
        public override void Ab()
        {
            throw new NotImplementedException();
        }

        public void h()
        {
            
        }

    }

    public class ExecuteClass
    {
        public void DraftMethod()
        {
            ChildClass childobj= new ChildClass();
        }
    }
}
