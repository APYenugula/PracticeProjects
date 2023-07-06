namespace InheritanceTask.Models
{
    public   abstract  class AbstractTask
    {
        public  virtual int Add(int x, int y)
        {
            return x + y;
        }
        public  int Subt(int a, int b)
        {
            return a - b;
        }
        public static int mul(int a,int b)
        {
            return a * b;
        }
        public abstract int M1(int a, int b);
        public abstract int M2(int a, int b);
        public  abstract int M3(int a, int b);


    }
    public class childA : AbstractTask
    {
        public override int Add(int x, int y)
        {
            throw new NotImplementedException();
        }


        public override int M1(int a, int b)
        {
            throw new NotImplementedException();
        }

        public override int M2(int a, int b)
        {
            throw new NotImplementedException();
        }
        public override int M3(int a, int b)
        {
            throw new NotImplementedException();
        }
    }

}
