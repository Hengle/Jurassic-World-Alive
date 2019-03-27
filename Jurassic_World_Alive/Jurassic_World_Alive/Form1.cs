using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.IO;

namespace Jurassic_World_Alive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        //print player customization option 
        private void PrintPlayer_Click(object sender, EventArgs e)
        {

            Player player1 = new Player(NameTb.Text, Convert.ToInt32(AgeTb.Text), genderCmb.Text, DescriptionTb.Text);

            listBox1.Items.Add("Name:"+ " "+ NameTb.Text);
            listBox1.Items.Add("Age:" +  " "+ Convert.ToInt32(AgeTb.Text));
            listBox1.Items.Add("Gender:" + " " + genderCmb.Text);
            listBox1.Items.Add("Description:" +" " + DescriptionTb.Text);

            
        }

        //clears all text boxes
        private void ClearBn_Click(object sender, EventArgs e)
        {
            NameTb.Text = string.Empty;
            AgeTb.Text = string.Empty;
            genderCmb.Text = string.Empty;
            DescriptionTb.Text = string.Empty;

            listBox1.Items.Clear();
            PlayerCollectionTB.Text = string.Empty;

        }

        //open a new form which allows the player to create a new dinosaur 
        private void PlayerCollectionBn_Click_1(object sender, EventArgs e)
        {
            DinoInfoForm DinoForm = new DinoInfoForm();
            DinoForm.ShowDialog(this);
        }
        
        //prints the player dinosaur collection
        private void PlayerShowCollectionBn_Click(object sender, EventArgs e)
        {
            foreach (Dinosaur dinosaur in Dinosaur.dinolist)
            {
                PlayerCollectionTB.Text += dinosaur.ToString()+ " " +"\n" + System.Environment.NewLine;
            }
        }
        //save buttons for the dinosaurs
        private void Savebn_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));

                write.Write(PlayerCollectionTB.Text);
                write.Dispose();
            }

        }
        //load button for the dinosaurs
        private void LoadBn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader read = new StreamReader(File.OpenRead(open.FileName));

                PlayerCollectionTB.Text = read.ReadToEnd();

                read.Dispose();
            }
        }
        //ends the game
        private void endGameBn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //save button for the player
        private void SavePlayerBn_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(File.Create(save.FileName));

                write.Write(listBox1.Text);
                write.Dispose();
            }
        }
        //load button for the player
        private void LoadPlayerBn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            

            if (open.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();
                List<string> lines = new List<string>();

                using (StreamReader read = new StreamReader(File.OpenRead(open.FileName)))
                {
                    string line;
                    while ((line = read.ReadLine()) != null) 
                        {
                        lines.Add(line);
                        }
                    
                    read.Dispose();
                }
            }
            
        }
    }
}
