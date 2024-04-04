using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class PalindromeTool
    {
        private IIOHelper ioHelper;

        public PalindromeTool(IIOHelper helper)
        {
            ioHelper = helper;
        }

        public bool IsPalindrome()
        {
            string text = ioHelper.GetUserInput();
            text = text.ToLower().Replace(" ", string.Empty);
            for (int i = 0; i < text.Length / 2; i++)
            {
                if (!text[i].Equals(text[text.Length - 1 - i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
