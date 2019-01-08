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

        public void setWads(WadInfo[] wads)
        {
            this.wads = wads;
            
            int myrange = (start + range) >= wads.Length ? wads.Length - start : range;
            if(myrange == 0)
            {
                previous();
                myrange = (start + range) >= wads.Length ? wads.Length - start : range;
            }
            else {
            }
            this.currentShownItems = new WadInfo[myrange];
            Array.Copy(this.wads, start, this.currentShownItems, 0, myrange);
        }

        public WadHistoryList(WadInfo[] wads)
        {
            this.wads = wads;
            int myrange = (start + range) >= wads.Length ? wads.Length - start : range;
            this.currentShownItems = new WadInfo[myrange];

            Array.Copy(this.wads, start, this.currentShownItems, 0, myrange);
        }

        public WadInfo[] next()
        {
            if (start + range >= wads.Length) return null;

            start += range;
            int myrange = (start + range) >= wads.Length ? wads.Length - start: range;
            end += myrange;
            this.currentShownItems = new WadInfo[myrange];

            Array.Copy(this.wads, start, this.currentShownItems, 0, myrange);
            return null;
        }

        public WadInfo[] previous()
        {
            if (start - range < 0) return null;

            start -= range;
            this.currentShownItems = new WadInfo[range];

            Array.Copy(this.wads, start, this.currentShownItems, 0, range);
            return null;
        }

        public bool empty()
        {
            return wads.Length == 0;
        }
        
    }
}

