using System;
using System.Linq;
using System.Threading.Tasks;

namespace Task_Day_10_sol.Models
{
    public class Student :BaseModel
    {
        public string Name { get; set; }
        public virtual Department department { get; set; }
    }
}
