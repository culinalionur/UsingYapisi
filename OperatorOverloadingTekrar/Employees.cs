using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadingTekrar
{
    public class Employees
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public int Sales { get; set; }
        public string ContactNumber { get; set; }
        public string Department { get; set; }

        public static bool operator ==(Employees e1, Employees e2)
        {
            if (e1.Sales == e2.Sales && e1.Department == e2.Department)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Employees e1, Employees e2)
        {
            if (e1.Sales != e2.Sales && e1.Department != e2.Department)
            {
                return true;
            }
            return false;
        }
            
        public static int operator -(Employees e1, Employees e2)
        {
            if (e1.Sales>e2.Sales)
            {
                return e1.Sales - e2.Sales;
            }
            else if (e1.Sales==e2.Sales)
            {
                return 0;
            }
            return e2.Sales - e1.Sales;
        }
        
    }
}
