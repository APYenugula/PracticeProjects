namespace InheritanceTask.Models
{
    public class WriteOnlyExample
    {
      
        private int id1 { get; set; }
        public int id2 { set => id1 = value; }
        public int r;
        public void M1()
        {
            r = id1;
        }
    }
}

//we can't access private variable anyway.Whenever there is a need to assign value to private variable-
//we used line7 and also id2 can't be accessed anyway(even in this class) as there is no get property
