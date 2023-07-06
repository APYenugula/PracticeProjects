namespace InheritanceTask.Models
{
    public class ConstructorExample
    {
        

        public int Id { get; set; }
        public string Name { get; set; }
        public string CreatedTime { get; set; }
        public ConstructorExample()
        {
            CreatedTime=DateTime.Now.ToString();
        }
        public ConstructorExample(int id):this()
        {
            this.Id = id;
        }
        public ConstructorExample(int id,string name):this(id)
        {
            this.Name = name;
        }

    }

}
