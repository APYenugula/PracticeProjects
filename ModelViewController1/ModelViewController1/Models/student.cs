namespace ModelViewController1.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class student
    {

        public int stu_id { get; set; }
        public string stu_name { get; set; }
        public int marks { get; set; }
    }
    /// <summary>
    /// 
    /// </summary>
    public class UGstudent:student
    {

        public int regdno { get; set; }
        
    }

    public class PGStudent:student
        {
            public int regdno { get; set; }
            
        }
  



}

