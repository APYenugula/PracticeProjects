namespace InheritanceTask.Models
{
    public class MultipleInheritance
    {
        public class A
        {
            public int Id { get; set; }
        }
        public interface B {
            public void GB()
            {

            }
        }
        public interface D
        {
            public int Id { get; set; }
        }
        public class C : A,B,D
        {

        }


    }
}
