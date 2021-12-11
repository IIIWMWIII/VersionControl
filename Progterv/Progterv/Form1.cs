using Progterv.Abstractions;
using Progterv.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progterv
{
    public partial class Form1 : Form
    {
        List<Toy> _toys = new List<Toy>();
        Toy _nexttoy;
        private IToyFactory toyfactory;

        public IToyFactory Factory
        {
            get { return toyfactory; }
            set 
            { toyfactory = value;
                DisplayNext();
            }
        }

        private void DisplayNext()
        {
            if (_nexttoy != null)
            {
                Controls.Remove(_nexttoy);
            }
            _nexttoy = Factory.CreateNew();
            _nexttoy.Top = ComingNext.Top + ComingNext.Height + 20;
            _nexttoy.Left = ComingNext.Left;
            Controls.Add(_nexttoy);
        }

        public Form1()
        {
            InitializeComponent();
            Factory = new CarFactory();
        }

        private void createtimer_Tick(object sender, EventArgs e)
        {
            Toy b = Factory.CreateNew();
            _toys.Add(b);
            b.Left = -b.Width;
            Mainpanel.Controls.Add(b);
        }

        private void conveyortimer_Tick(object sender, EventArgs e)
        {
            if (_toys.Count == 0) return;
            Toy lasttoy = _toys[0];            
            foreach (Toy item in _toys)
            {
                item.MoveToy();
                if (item.Left > lasttoy.Left) lasttoy = item;
            }

            if(lasttoy.Left>1000)
            {
                _toys.Remove(lasttoy);
                Mainpanel.Controls.Remove(lasttoy);
            }
        }

        private void Ballbutton_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory() {  BallColor = Ballcolorbutton.BackColor};
        }

        private void Carbutton_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();
        }

        private void Ballcolorbutton_Click(object sender, EventArgs e)
        {
            Button kattintott = (Button)sender;
            ColorDialog cd = new ColorDialog();
            cd.Color = kattintott.BackColor;
            if (cd.ShowDialog() != DialogResult.OK) return;
            kattintott.BackColor = cd.Color;
        }

        private void boxcolorbutton_Click(object sender, EventArgs e)
        {
            Button katt = (Button)sender;
            ColorDialog cd = new ColorDialog();
            cd.Color = katt.BackColor;
            if (cd.ShowDialog() != DialogResult.OK) return;
            katt.BackColor = cd.Color;
        }

        private void ribboncolorbutton_Click(object sender, EventArgs e)
        {
            Button kattint = (Button)sender;
            ColorDialog cd = new ColorDialog();
            cd.Color = kattint.BackColor;
            if (cd.ShowDialog() != DialogResult.OK) return;
            kattint.BackColor = cd.Color;
        }

        private void presentbutton_Click(object sender, EventArgs e)
        {
            Factory = new PresentFactory() { BoxColor = boxcolorbutton.BackColor, RibbonColor = ribboncolorbutton.BackColor };            
        }
    }
}
