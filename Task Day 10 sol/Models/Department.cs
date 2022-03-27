using System.Collections.Generic;

namespace Task_Day_10_sol.Models
{
    public class Department : BaseModel { 
        public string Name { get; set; }
        public virtual List<Student> students { get; set; }
    }
}
