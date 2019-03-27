namespace Jurassic_World_Alive
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameTb = new System.Windows.Forms.TextBox();
            this.AgeTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.PlayerCollectionTB = new System.Windows.Forms.TextBox();
            this.SaveDinoBn = new System.Windows.Forms.Button();
            this.LoadDinoBn = new System.Windows.Forms.Button();
            this.ClearBn = new System.Windows.Forms.Button();
            this.PrintPlayer = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.DescriptionTb = new System.Windows.Forms.TextBox();
            this.PlayerCollectionBn = new System.Windows.Forms.Button();
            this.genderCmb = new System.Windows.Forms.ComboBox();
            this.PlayerShowCollectionBn = new System.Windows.Forms.Button();
            this.endGameBn = new System.Windows.Forms.Button();
            this.SavePlayerBn = new System.Windows.Forms.Button();
            this.LoadPlayerBn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameTb
            // 
            this.NameTb.Location = new System.Drawing.Point(199, 60);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(100, 20);
            this.NameTb.TabIndex = 0;
            // 
            // AgeTb
            // 
            this.AgeTb.Location = new System.Drawing.Point(199, 101);
            this.AgeTb.Name = "AgeTb";
            this.AgeTb.Size = new System.Drawing.Size(100, 20);
            this.AgeTb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Gender";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(433, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(148, 160);
            this.listBox1.TabIndex = 6;
            // 
            // PlayerCollectionTB
            // 
            this.PlayerCollectionTB.Location = new System.Drawing.Point(433, 247);
            this.PlayerCollectionTB.Multiline = true;
            this.PlayerCollectionTB.Name = "PlayerCollectionTB";
            this.PlayerCollectionTB.Size = new System.Drawing.Size(675, 367);
            this.PlayerCollectionTB.TabIndex = 7;
            // 
            // SaveDinoBn
            // 
            this.SaveDinoBn.Location = new System.Drawing.Point(312, 420);
            this.SaveDinoBn.Name = "SaveDinoBn";
            this.SaveDinoBn.Size = new System.Drawing.Size(102, 27);
            this.SaveDinoBn.TabIndex = 8;
            this.SaveDinoBn.Text = "Save";
            this.SaveDinoBn.UseVisualStyleBackColor = true;
            this.SaveDinoBn.Click += new System.EventHandler(this.Savebn_Click);
            // 
            // LoadDinoBn
            // 
            this.LoadDinoBn.Location = new System.Drawing.Point(312, 453);
            this.LoadDinoBn.Name = "LoadDinoBn";
            this.LoadDinoBn.Size = new System.Drawing.Size(102, 27);
            this.LoadDinoBn.TabIndex = 9;
            this.LoadDinoBn.Text = "load";
            this.LoadDinoBn.UseVisualStyleBackColor = true;
            this.LoadDinoBn.Click += new System.EventHandler(this.LoadBn_Click);
            // 
            // ClearBn
            // 
            this.ClearBn.Location = new System.Drawing.Point(80, 247);
            this.ClearBn.Name = "ClearBn";
            this.ClearBn.Size = new System.Drawing.Size(75, 23);
            this.ClearBn.TabIndex = 10;
            this.ClearBn.Text = "Clear";
            this.ClearBn.UseVisualStyleBackColor = true;
            this.ClearBn.Click += new System.EventHandler(this.ClearBn_Click);
            // 
            // PrintPlayer
            // 
            this.PrintPlayer.Location = new System.Drawing.Point(341, 60);
            this.PrintPlayer.Name = "PrintPlayer";
            this.PrintPlayer.Size = new System.Drawing.Size(75, 23);
            this.PrintPlayer.TabIndex = 11;
            this.PrintPlayer.Text = "PlayerInfo";
            this.PrintPlayer.UseVisualStyleBackColor = true;
            this.PrintPlayer.Click += new System.EventHandler(this.PrintPlayer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Description";
            // 
            // DescriptionTb
            // 
            this.DescriptionTb.Location = new System.Drawing.Point(199, 186);
            this.DescriptionTb.Multiline = true;
            this.DescriptionTb.Name = "DescriptionTb";
            this.DescriptionTb.Size = new System.Drawing.Size(100, 84);
            this.DescriptionTb.TabIndex = 13;
            // 
            // PlayerCollectionBn
            // 
            this.PlayerCollectionBn.Location = new System.Drawing.Point(329, 261);
            this.PlayerCollectionBn.Name = "PlayerCollectionBn";
            this.PlayerCollectionBn.Size = new System.Drawing.Size(98, 45);
            this.PlayerCollectionBn.TabIndex = 15;
            this.PlayerCollectionBn.Text = "Add Dinosaur to Collection";
            this.PlayerCollectionBn.UseVisualStyleBackColor = true;
            this.PlayerCollectionBn.Click += new System.EventHandler(this.PlayerCollectionBn_Click_1);
            // 
            // genderCmb
            // 
            this.genderCmb.FormattingEnabled = true;
            this.genderCmb.Items.AddRange(new object[] {
            " ",
            "Male",
            "Female"});
            this.genderCmb.Location = new System.Drawing.Point(199, 141);
            this.genderCmb.Name = "genderCmb";
            this.genderCmb.Size = new System.Drawing.Size(121, 21);
            this.genderCmb.TabIndex = 16;
            // 
            // PlayerShowCollectionBn
            // 
            this.PlayerShowCollectionBn.Location = new System.Drawing.Point(329, 313);
            this.PlayerShowCollectionBn.Name = "PlayerShowCollectionBn";
            this.PlayerShowCollectionBn.Size = new System.Drawing.Size(98, 42);
            this.PlayerShowCollectionBn.TabIndex = 17;
            this.PlayerShowCollectionBn.Text = "Show Dinosaur collection";
            this.PlayerShowCollectionBn.UseVisualStyleBackColor = true;
            this.PlayerShowCollectionBn.Click += new System.EventHandler(this.PlayerShowCollectionBn_Click);
            // 
            // endGameBn
            // 
            this.endGameBn.Location = new System.Drawing.Point(312, 487);
            this.endGameBn.Name = "endGameBn";
            this.endGameBn.Size = new System.Drawing.Size(102, 27);
            this.endGameBn.TabIndex = 18;
            this.endGameBn.Text = "End Game";
            this.endGameBn.UseVisualStyleBackColor = true;
            this.endGameBn.Click += new System.EventHandler(this.endGameBn_Click);
            // 
            // SavePlayerBn
            // 
            this.SavePlayerBn.Location = new System.Drawing.Point(341, 90);
            this.SavePlayerBn.Name = "SavePlayerBn";
            this.SavePlayerBn.Size = new System.Drawing.Size(75, 23);
            this.SavePlayerBn.TabIndex = 19;
            this.SavePlayerBn.Text = "Save Player";
            this.SavePlayerBn.UseVisualStyleBackColor = true;
            this.SavePlayerBn.Click += new System.EventHandler(this.SavePlayerBn_Click);
            // 
            // LoadPlayerBn
            // 
            this.LoadPlayerBn.Location = new System.Drawing.Point(341, 120);
            this.LoadPlayerBn.Name = "LoadPlayerBn";
            this.LoadPlayerBn.Size = new System.Drawing.Size(75, 23);
            this.LoadPlayerBn.TabIndex = 20;
            this.LoadPlayerBn.Text = "Load Player";
            this.LoadPlayerBn.UseVisualStyleBackColor = true;
            this.LoadPlayerBn.Click += new System.EventHandler(this.LoadPlayerBn_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1134, 626);
            this.Controls.Add(this.LoadPlayerBn);
            this.Controls.Add(this.SavePlayerBn);
            this.Controls.Add(this.endGameBn);
            this.Controls.Add(this.PlayerShowCollectionBn);
            this.Controls.Add(this.genderCmb);
            this.Controls.Add(this.PlayerCollectionBn);
            this.Controls.Add(this.DescriptionTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PrintPlayer);
            this.Controls.Add(this.ClearBn);
            this.Controls.Add(this.LoadDinoBn);
            this.Controls.Add(this.SaveDinoBn);
            this.Controls.Add(this.PlayerCollectionTB);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AgeTb);
            this.Controls.Add(this.NameTb);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button playerCreationbtn;
        private System.Windows.Forms.Button loadbtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button printbtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.TextBox AgeTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox PlayerCollectionTB;
        private System.Windows.Forms.Button SaveDinoBn;
        private System.Windows.Forms.Button LoadDinoBn;
        private System.Windows.Forms.Button ClearBn;
        private System.Windows.Forms.Button PrintPlayer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DescriptionTb;
        private System.Windows.Forms.Button PlayerCollectionBn;
        private System.Windows.Forms.ComboBox genderCmb;
        private System.Windows.Forms.Button PlayerShowCollectionBn;
        private System.Windows.Forms.Button endGameBn;
        private System.Windows.Forms.Button SavePlayerBn;
        private System.Windows.Forms.Button LoadPlayerBn;
    }
}

