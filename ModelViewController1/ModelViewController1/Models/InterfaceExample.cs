namespace ModelViewController1.Models
{
    
    public interface IStudent
    {
        string DisplayDetails(string name, decimal salary);
        int AddTwoNumbers(int a,int b);

    }
    public class ExUGStudent : IStudent
    {
        public int AddTwoNumbers(int a, int b)
        {
            return a + b;

        }
        public string DisplayDetails(string name, decimal salary)
        {
            return "Welcome" + name + "Salary" + salary;
        }
    }

    


}
