using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayMusic.ChildForm
{
    public partial class OnlineSource : Form
    {
        public OnlineSource()
        {
            InitializeComponent();
            LoadLanguage();
        }

        private void OnlineSource_Load(object sender, EventArgs e)
        {

        }
        public void LoadLanguage()
        {
            var rm = Program.rm;
            var culture = Program.culture;
            label1.Text = rm.GetString("you1", culture);
            label2.Text = rm.GetString("you2", culture);
            label3.Text = rm.GetString("zing1", culture);
            label4.Text = rm.GetString("zing2", culture);
            label5.Text = rm.GetString("zing3", culture);
        }
    }
}
