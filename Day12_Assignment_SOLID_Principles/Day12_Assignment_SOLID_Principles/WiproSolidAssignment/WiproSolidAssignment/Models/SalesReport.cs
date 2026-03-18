using System;
using System.Collections.Generic;
using System.Text;

namespace WiproSolidAssignment.Models
{
    public class SalesReport : Report
    {
        public override string Generate()
        {
            return "Sales Report Created";
        }
    }
}