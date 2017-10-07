using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Sahaj.UserControls
{
    public partial class uc_UnderConstruction : UserControl
    {
        public uc_UnderConstruction()
        {
            InitializeComponent();
        }

        private void uc_UnderConstruction_Load(object sender, EventArgs e)
        {
            //ThreadStart myThreadStart = new ThreadStart(MyThreadRoutine);
            //Thread myThread = new Thread(myThreadStart);
            //myThread.Start();
            panel1.Dock = DockStyle.Fill;
            PictureBox pb = new PictureBox();
            pictureBox1.Image = Image.FromFile(@"C:\Users\punee\Downloads\akshat\underconstruction-main.gif");
            pb.Dock = DockStyle.Fill;            
            //pb.im = ImageLayout.Stretch;
            //pb.BringToFront();
            pb.Anchor = AnchorStyles.Top;
            //pb.Show();
            panel1.Controls.Add(pb);
        }

        private void MyThreadRoutine()
        {
            //this.Invoke(this.ShowProgressGifDelegate);
            //your long running process
            //System.Threading.Thread.Sleep(1000);
            //this.Invoke(this.HideProgressGifDelegate);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
