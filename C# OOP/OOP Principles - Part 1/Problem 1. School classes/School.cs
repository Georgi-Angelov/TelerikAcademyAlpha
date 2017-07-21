using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.School_classes
{
    class School
    {
        private List<Classes> schoolClasses;
        
        public School()
        {
            this.schoolClasses = new List<Classes>();
        }

        
        public void AddClass(Classes addClass)
        {
            this.schoolClasses.Add(addClass);
        }
    }
}
