using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Test
    {
        public void Test1()
        {
            List<string> shufflecards = new List<string>();
            Pack.ShuffleCardPack(1, ref shufflecards);
            Pack.Deal(shufflecards);
            Pack.dealCard(10, shufflecards);
        }
    }
}
