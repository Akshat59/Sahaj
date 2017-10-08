using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Resources;
using m1.Sahaj.Properties;
using System.Collections;

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
            panel1.Dock = DockStyle.Fill;
            //pictureBox1.Image = Image.FromFile(@"C:\Users\punee\Downloads\akshat\underconstruction-main.gif");

            ArrayList imglst = new ArrayList();
            ResourceManager rm = Resources.ResourceManager;

            Bitmap img = (Bitmap)rm.GetObject("img_underConstr1");
            imglst.Add(img);
            img = (Bitmap)rm.GetObject("img_underConstr2");
            imglst.Add(img);
            img = (Bitmap)rm.GetObject("img_underConstr3");
            imglst.Add(img);
            img = (Bitmap)rm.GetObject("img_underConstr4");
            imglst.Add(img);
            img = (Bitmap)rm.GetObject("img_underConstr5");
            imglst.Add(img);
            img = (Bitmap)rm.GetObject("img_underConstr6");
            imglst.Add(img);

            Random rndm = new Random();
            int _i = rndm.Next(0, imglst.Count);
            pictureBox1.Image = (Bitmap)imglst[_i];
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
