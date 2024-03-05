using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace CChavezDepreciationForm
{
    internal class DepreciationStraightLine
    {
        //  DepreciationStraightLine will have properties for a string title for the item,
        //      the DateTime values for the date the item goes into and out of inventory,
        //      decimal values for the start value and end of life value, an int for
        //      the number of years of lifetime.
        //  The set part of properties should call a calc method that calculates the
        //      salvage value using straight line depreciation methodology.
        //  There should also be a ToString that date returns a nicely formatted string
        //      that has the title, start value, end value and lifetime.
        
        //  Feilds
        private int dateAddedToInventroy;
        private int dateRemovedFromInventroy;
        private int endValue;
        private int lifetime;
        private int startValue;

        //  Constructors
        public DepreciationStraightLine()
        { 

        }

        //  Properties
        public void DateAddedToClass()
        {

        }
        public void DateRemovedFromClass() 
        {

        }
        public void EndValue() 
        { 
        }
        public void LifeTime()
        {

        }
        public void SalvageValue()
        {

        }
        public void StartValue()
        {

        }

        // Methods 
        public void Calc()
        {

        }
        public void StraightLineDepreciation()
        {

        }
        public void To_String() 
        { 

        }
    }
}
