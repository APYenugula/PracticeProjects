namespace InheritanceTask.Models
{
    public class Parent
    {
        public virtual string Method1()
        {
            return "I am from Parent class";
        }
    }
    public class Child:Parent
    {
        public override string Method1()
        {
            return "I am from Child class";
        }
    }
}
//without using virtual we can't override MEthod1 in child class
