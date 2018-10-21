using Doomroulette.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doomroulette
{
    public partial class RateWad : Form
    {

        public enum RatingTypes { Liked = 1, Disliked = 0, Unrated = -1 };

        public RatingTypes rating = RatingTypes.Unrated;
        public int wadId;

        public RateWad(WadInfo wadinfo)
        {
            InitializeComponent();
            wadId = wadinfo.content.id;
            printWadInfo(wadinfo);
        }

        private void printWadInfo(WadInfo wadinfo)
        {
            string info = string.Format("You have played:\n{0}\nMade by {1}.\nCreated {2}\n\nDo you like this wad?", wadinfo.content.title, wadinfo.content.author, wadinfo.content.date);
            lblWadInfo.Text = info;
        }

        public RateWad()
        {
            InitializeComponent();
        }

        private void btnLike_Click(object sender, EventArgs e)
        {
            rating = RatingTypes.Liked;
            Close();
        }

        private void btnDislike_Click(object sender, EventArgs e)
        {
            rating = RatingTypes.Disliked;
            Close();
        }
    }
}
