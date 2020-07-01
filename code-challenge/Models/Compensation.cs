using System;
namespace challenge.Models
{
    public class Compensation
    {
        public Employee Employee { get; set; }
        public int Salary { get; set; }
        public String EffectiveDate { get; set; }
    }
}
