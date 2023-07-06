namespace InheritanceTask.Models
{
    public class FunctionExample
    {
        public int Subtrac(int x,int y,ref int sub)
        {
            sub = x - y;
            return x + y;
        }
    }
  
}
//for ref even if we didn't assign x-y to sub,it is ok
//but for out we need to assign otherwise it will throw an error
