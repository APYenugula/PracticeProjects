namespace InheritanceTask.Models
{
    public class AccessingPrivateVariable
    {
        
        private int id = 6;
        

        public int Id { get => id; set => id = value; }
    }
}
//here both id and Id will contain same value
