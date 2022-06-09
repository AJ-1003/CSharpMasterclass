using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Exercise_Classes.Section_10
{
    // M3 is a BMW
    public class M3 : BMW
    {
        public M3(string model, int hP, string color) : base(model, hP, color)
        {
            Model = model;
        }

        // cannot override a sealed method
        /*
        public override void Repair()
        {
            base.Repair();
        }
        */

        public void Repair()
        {
            base.Repair();
        }
    }
}
