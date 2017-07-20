using System.Collections.Generic;

namespace BagOLoot
{
    public class SantaHelper
    {
        public int AddToyToBag(string toy, int child)
        {
            return 4;
        }

         public int RemoveToyFromBag(string toy, int child)
        {
            return 3;
        }

        public List<int> GetChildsToys(int toy)
        {
            return new List<int>() {4, 6,7,8};
        }
    }
}