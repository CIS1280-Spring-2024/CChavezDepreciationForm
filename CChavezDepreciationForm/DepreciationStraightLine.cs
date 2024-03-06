using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace CChavezDepreciationForm
{
    internal class DepreciationStraightLine
    {

        //  DepreciationStraightLine will have properties for a string title for the item,
        //      the DateTime values for the date the item goes into and out of inventory,
        //      decimal values for the start value and end of life value, an int for
        //      the number of years of lifetime
        //  Feilds
        private string title;
        //  I made these public so te inheritate class could see them and work with
        //  them as I get a Compiler Error CS0266 otherwise
        public DateTime intoInventory;
        public DateTime outOfInventory;
        public double startValue;
        public double endValue;
        public double lifetime;
        
        //  Constructors
        public DepreciationStraightLine()
        { 

        }
        public DepreciationStraightLine(string Title,DateTime IntoInventory, DateTime OutOfInventory, double StartValue, double EndValue, int Lifetime)
        {
            title = Title;
            intoInventory = IntoInventory;
            outOfInventory = OutOfInventory;
            startValue = StartValue;
            endValue = EndValue;
            lifetime = Lifetime;
            Calc();
    }
        //  Properties
        //  The set part of properties should call a calc method that calculates the
        //      salvage value using straight line depreciation methodology.
        public string Title 
        { 
            get
            { 
                return title;
            }
            set
            {
                Title = title;
                Calc();
            }
        }

        public DateTime IntoInventory
        {
            get
            {
                return intoInventory;
            }
            set
            {
                IntoInventory = intoInventory;
                Calc();
            }
        }
        public DateTime OutOfInventory
        {
            get
            {
                return outOfInventory;
            }
            set
            {
                OutOfInventory = outOfInventory;
                Calc();
            }
        }
        public double StartValue
        {
            get
            {
                return startValue;
            }
            set
            {
                StartValue = startValue;
                Calc();
            }
        }
        public double EndValue
        {
            get
            {
                return endValue;
            }
            set
            {
                EndValue = endValue;
                Calc();
            }
        }
        public double Lifetime
        {
            get
            {
                return lifetime;
            }
            set
            {
                Lifetime = lifetime;
                Calc();
            }
        }
        // Methods 
        public virtual double Calc()
        {
            //  Straight line depreciation is the default method used to recognize the carrying
            //  amount of a fixed asset evenly over its useful life. It is employed when there
            //  is no particular pattern to the manner in which an asset is to be utilized
            //  over time.Use of the straight-line method is highly recommended, since it is
            //  the easiest depreciation method to calculate, and so results in few calculation
            //  errors.
          
            //  The straight-line calculation steps are:
            //      1.  Determine the initial cost of the asset that has been recognized as a
            //          fixed asset.
            //      2.  Subtract the estimated salvage value of the asset from the amount at
            //          which it is recorded on the books.
            double lifetimeValue = startValue - endValue;
            //      3.  Determine the estimated useful life of the asset.It is easiest to use
            //          a standard useful life for each class of assets.
            //      4.	Divide the estimated useful life(in years) into 1 to arrive at the
            //          straight-line depreciation rate.
            double depreciationRate = 1 / lifetime;
            //      5.	Multiply the depreciation rate by the asset cost(less salvage value).

            //  Once calculated, depreciation expense is recorded in the accounting records as
            //  a debit to the depreciation expense account and a credit to the accumulated
            //  depreciation account.Accumulated depreciation is a contra asset account,
            //  which means that it is paired with and reduces the fixed asset account.
            return lifetimeValue * depreciationRate;

        }
        public void StraightLineDepreciation()
        {

        }
        public virtual void To_String() 
        {
            //  There should also be a ToString that date returns a nicely formatted string
            //      that has the title, start value, end value and lifetime.
        }
    }
}
