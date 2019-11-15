using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   class Teacher
{
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher("Tom", 350f);
            // teacher work for 20Hr/month
            Console.WriteLine("{0} charge = {1}", teacher.TypeName(),
                teacher.CalculateCharge(20f));
            Console.ReadLine();
        }
        // figure out the charge based on teacher's rate
        public float CalculateCharge(float hours)
    {
        return (hours * billingRate);
    }
    // return the name of this type
    public string TypeName()
    {
        return ("Teacher");
    }
    private string name;
    protected float billingRate;
}


}
    

