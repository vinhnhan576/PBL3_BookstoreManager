using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    internal class DiscountRank
    {
        string Rank_Name { get; set; }
        DateTime StartingDate { get; set; }
        DateTime EndingDate { get; set; }
        int duration { get; set; }
        double discount_amount { get; set; }
        DiscountRank(DateTime startingdate)
        {
            StartingDate = startingdate;
        }

    }
}
