namespace Jurassic_World_Alive
{
    partial class DinoInfoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DinoNameTB = new System.Windows.Forms.TextBox();
            this.DinoAgeTb = new System.Windows.Forms.TextBox();
            this.FinishBn = new System.Windows.Forms.Button();
            this.DinoSexCb = new System.Windows.Forms.ComboBox();
            this.DinoSizeCb = new System.Windows.Forms.ComboBox();
            this.DinoClassCb = new System.Windows.Forms.ComboBox();
            this.DinoPeriodTB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dinosaur Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dinosaur Sex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dinosaur Size";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dinosaur Age";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dinosaur Period";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dinosaur classification";
            // 
            // DinoNameTB
            // 
            this.DinoNameTB.Location = new System.Drawing.Point(169, 39);
            this.DinoNameTB.Name = "DinoNameTB";
            this.DinoNameTB.Size = new System.Drawing.Size(318, 20);
            this.DinoNameTB.TabIndex = 6;
            // 
            // DinoAgeTb
            // 
            this.DinoAgeTb.Location = new System.Drawing.Point(169, 132);
            this.DinoAgeTb.Name = "DinoAgeTb";
            this.DinoAgeTb.Size = new System.Drawing.Size(120, 20);
            this.DinoAgeTb.TabIndex = 11;
            // 
            // FinishBn
            // 
            this.FinishBn.Location = new System.Drawing.Point(31, 279);
            this.FinishBn.Name = "FinishBn";
            this.FinishBn.Size = new System.Drawing.Size(75, 23);
            this.FinishBn.TabIndex = 13;
            this.FinishBn.Text = "Finish";
            this.FinishBn.UseVisualStyleBackColor = true;
            this.FinishBn.Click += new System.EventHandler(this.FinishBn_Click);
            // 
            // DinoSexCb
            // 
            this.DinoSexCb.FormattingEnabled = true;
            this.DinoSexCb.Items.AddRange(new object[] {
            " ",
            "Male",
            "Female"});
            this.DinoSexCb.Location = new System.Drawing.Point(170, 72);
            this.DinoSexCb.Name = "DinoSexCb";
            this.DinoSexCb.Size = new System.Drawing.Size(121, 21);
            this.DinoSexCb.TabIndex = 14;
            // 
            // DinoSizeCb
            // 
            this.DinoSizeCb.FormattingEnabled = true;
            this.DinoSizeCb.Items.AddRange(new object[] {
            " ",
            "Small",
            "Meduim",
            "Large"});
            this.DinoSizeCb.Location = new System.Drawing.Point(170, 99);
            this.DinoSizeCb.Name = "DinoSizeCb";
            this.DinoSizeCb.Size = new System.Drawing.Size(121, 21);
            this.DinoSizeCb.TabIndex = 15;
            // 
            // DinoClassCb
            // 
            this.DinoClassCb.FormattingEnabled = true;
            this.DinoClassCb.Items.AddRange(new object[] {
            " ",
            "Saurischia",
            "Ornithischia"});
            this.DinoClassCb.Location = new System.Drawing.Point(170, 200);
            this.DinoClassCb.Name = "DinoClassCb";
            this.DinoClassCb.Size = new System.Drawing.Size(121, 21);
            this.DinoClassCb.TabIndex = 16;
            // 
            // DinoPeriodTB
            // 
            this.DinoPeriodTB.FormattingEnabled = true;
            this.DinoPeriodTB.Items.AddRange(new object[] {
            " ",
            "Triassic",
            "Jurassic",
            "Cretaceous"});
            this.DinoPeriodTB.Location = new System.Drawing.Point(169, 165);
            this.DinoPeriodTB.Name = "DinoPeriodTB";
            this.DinoPeriodTB.Size = new System.Drawing.Size(197, 21);
            this.DinoPeriodTB.TabIndex = 17;
            // 
            // DinoInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DinoPeriodTB);
            this.Controls.Add(this.DinoClassCb);
            this.Controls.Add(this.DinoSizeCb);
            this.Controls.Add(this.DinoSexCb);
            this.Controls.Add(this.FinishBn);
            this.Controls.Add(this.DinoAgeTb);
            this.Controls.Add(this.DinoNameTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DinoInfoForm";
            this.Text = "DinoInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DinoNameTB;
        private System.Windows.Forms.TextBox DinoAgeTb;
        private System.Windows.Forms.Button FinishBn;
        private System.Windows.Forms.ComboBox DinoSexCb;
        private System.Windows.Forms.ComboBox DinoSizeCb;
        private System.Windows.Forms.ComboBox DinoClassCb;
        private System.Windows.Forms.ComboBox DinoPeriodTB;
    }
}