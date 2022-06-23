using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterclassLibrary.Exercise_Classes.Section_11
{
    public class DateTimeCustom
    {
        public DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        public DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
