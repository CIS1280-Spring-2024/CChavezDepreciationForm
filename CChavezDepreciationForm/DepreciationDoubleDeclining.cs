using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.LinkLabel;

namespace CChavezDepreciationForm
{
    internal class DepreciationDoubleDeclining : DepreciationStraightLine
    {
        //  The DepreciationDoubleDeclining will inherit from DepreciationStraightLine
        //  so you don’t have to repeat creating properties common to both classes.
        //  DepreciationDoubleDeclining will need to override the Calc method to use
        //  the Double Declining Depreciation methodology.The ToString for
        //  DepreciationDoubleDeclining should return the same text as StrightLine
        //  but also add the fact that this item uses double declining depreciation.
        public override double Calc()
        {
            //  The DepreciationDoubleDeclining will implement the following logic:
            //  The double declining balance method is an accelerated form of depreciation
            //      under which most of the depreciation associated with a fixed asset is
            //      recognized during the first few years of its useful life. This approach
            //      is reasonable under either of the following two circumstances:

            //      When the utility of an asset is being consumed at a more rapid rate
            //          during the early part of its useful life; or
            //      When the intent is to recognize more expense now, thereby shifting
            //          profit recognition further into the future(which may be of use
            //          for deferring income taxes).
            //  However, this method is more difficult to calculate than the more
            //      traditional straight - line method of depreciation.Also, most assets
            //      are utilized at a consistent rate over their useful lives, which does
            //      not reflect the rapid rate of depreciation resulting from this method.
            //      Further, this approach results in the skewing of profitability results
            //      into future periods, which makes it more difficult to ascertain the
            //      true operational profitability of asset-intensive businesses.
            //  To calculate depreciation under the double declining method, multiply the
            //      asset book value at the beginning of the fiscal year by a multiple of
            //      the straight-line rate of depreciation.The double declining balance
            //      formula is:
            //      Double - declining balance(ceases when the book value = the estimated
            //          salvage value)
            double lifetimeValue = startValue - endValue;
            //      2  ×  Straight - line depreciation rate  ×  Book value at the beginning
            //          of the year
            //      A variation on this method is the 150 % declining balance method, which
            //          substitutes 1.5 for the 2.0 figure used in the calculation.The 150%
            //          method does not result in as rapid a rate of depreciation at the
            //          double declining method.

            double depreciationRate = 1 / lifetime;
            //      5.	Multiply the depreciation rate by the asset cost(less salvage value).
            return lifetimeValue * depreciationRate;
        }
        public override void To_String()
        {
            //  There should also be a ToString that date returns a nicely formatted string
            //      that has the title, start value, end value and lifetime.
        }
    }
}
