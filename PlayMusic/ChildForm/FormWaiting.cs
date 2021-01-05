using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayMusic.ChildForm
{
    public partial class FormWaiting : Form
    {
        public Action Worker { get; set; }

        public FormWaiting(Action worker)
        {
            InitializeComponent();
            
            BackColor = Color.FromArgb(0,144,255);
            TransparencyKey = Color.FromArgb(0, 144, 255);
            if (worker == null)
            {
                throw new ArgumentException();
            }
            Worker = worker;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
