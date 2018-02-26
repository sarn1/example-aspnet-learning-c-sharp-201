using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLegacy_Click(object sender, EventArgs e)
        {
            LegacyDownloadString();
        }

        private async void btnNewAsync_Click(object sender, EventArgs e)
        {
            var task =  NewDownloadStringAsync();

            // do that here

            var result = await task;

            // do something result
        }

        
    }
}
