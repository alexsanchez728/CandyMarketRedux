using Humanizer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyMarket2
{
    class DatabaseContext
    {

        internal CandyType ConvertOptionToType(char SelectedCandyMenuOption)
        {
            var candyOption = int.Parse(SelectedCandyMenuOption.ToString());

            var forRealTheCandy = (CandyType)candyOption;
            return forRealTheCandy;
        }

        internal List<string> GetCandyTypes()
        {
            return Enum
                .GetNames(typeof(CandyType))
                .Select(candyType =>
                    candyType.Humanize(LetterCasing.Title))
                .ToList();
        }
    }
}
