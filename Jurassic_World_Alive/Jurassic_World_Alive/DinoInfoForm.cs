using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jurassic_World_Alive
{
    public partial class DinoInfoForm : Form
    {
        public DinoInfoForm()
        {
            InitializeComponent();
        }

        //adds a new dinosaur into the list
        private void FinishBn_Click(object sender, EventArgs e)
        {
            Dinosaur.dinolist.Add(new Dinosaur(DinoNameTB.Text, DinoSexCb.Text, DinoSizeCb.Text, DinoClassCb.Text, DinoPeriodTB.Text, Convert.ToInt32(DinoAgeTb.Text)));
            this.Close();
        }
    }
}
