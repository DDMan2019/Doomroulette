using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doomroulette.Models
{
    class WadHistoryList
    {
        public int range = 15;
        
        private int start = 0;
        private int end = 15;

        public WadInfo[] currentShownItems { get; set; }
        public WadInfo[] wads { get; set; }

        public List<List<WadInfo>> wadPages { get; private set; }

        public int pages { get; set; }

        public int currentPage { get; private set; }
        public WadHistoryList(WadInfo[] wads)
        {
            this.wads = wads;
            setPages();
        }

        private void setPages()
        {
            start = 0;
            end = range;
            
            WadInfo[] wads;
            wadPages = new List<List<WadInfo>>();

            int nPages = this.wads.Length / range + (this.wads.Length % range > 0 ? 1 : 0);

            for (int i = 0; i < nPages; i++)
            {
                int myrange = (start + range) >= this.wads.Length ? this.wads.Length - start : range;
                wads = new WadInfo[myrange];
                Array.Copy(this.wads, start, wads, 0, myrange);
                wadPages.Add(wads.ToList());

                start += range;
                end += myrange;
            }
            currentPage = wadPages.Count > 0 ? 1 : 0;
        }

        public void setWads(WadInfo[] wads)
        {
            this.wads = wads;
            setPages();
        }

        public WadInfo[] next()
        {
            if (currentPage + 1 <= wadPages.Count)
            {
                currentPage++;
            }
            return null;
        }

        public WadInfo[] previous()
        {
            if (currentPage - 1 > 0)
            {
                currentPage--;
            }
            return null;
        }
        
    }
}

