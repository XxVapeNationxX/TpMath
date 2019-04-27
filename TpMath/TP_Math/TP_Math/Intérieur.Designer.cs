namespace TP_Math
{
    partial class Intérieur
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
            this.TBX_ET = new System.Windows.Forms.TextBox();
            this.BTN_Calculer = new System.Windows.Forms.Button();
            this.Error_Ecart = new System.Windows.Forms.Label();
            this.Error_Moyenne = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBX_Reponse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BTN_Return = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ERror_A = new System.Windows.Forms.Label();
            this.TBX_B = new System.Windows.Forms.TextBox();
            this.Error_B = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TBX_Moyenne = new System.Windows.Forms.TextBox();
            this.TBX_A = new System.Windows.Forms.TextBox();
            this.DGV_Table = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Moyenne:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Écart type:";
            // 
            // TBX_ET
            // 
            this.TBX_ET.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_ET.Location = new System.Drawing.Point(102, 68);
            this.TBX_ET.Name = "TBX_ET";
            this.TBX_ET.Size = new System.Drawing.Size(149, 24);
            this.TBX_ET.TabIndex = 3;
            this.TBX_ET.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBX_ET_KeyPress);
            // 
            // BTN_Calculer
            // 
            this.BTN_Calculer.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Calculer.Location = new System.Drawing.Point(150, 224);
            this.BTN_Calculer.Name = "BTN_Calculer";
            this.BTN_Calculer.Size = new System.Drawing.Size(101, 26);
            this.BTN_Calculer.TabIndex = 5;
            this.BTN_Calculer.Text = "Calculer";
            this.BTN_Calculer.UseVisualStyleBackColor = true;
            this.BTN_Calculer.Click += new System.EventHandler(this.BTN_Calculer_Click);
            // 
            // Error_Ecart
            // 
            this.Error_Ecart.AutoSize = true;
            this.Error_Ecart.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_Ecart.ForeColor = System.Drawing.Color.Red;
            this.Error_Ecart.Location = new System.Drawing.Point(99, 95);
            this.Error_Ecart.Name = "Error_Ecart";
            this.Error_Ecart.Size = new System.Drawing.Size(110, 17);
            this.Error_Ecart.TabIndex = 6;
            this.Error_Ecart.Text = "Champ non valide";
            this.Error_Ecart.Visible = false;
            // 
            // Error_Moyenne
            // 
            this.Error_Moyenne.AutoSize = true;
            this.Error_Moyenne.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_Moyenne.ForeColor = System.Drawing.Color.Red;
            this.Error_Moyenne.Location = new System.Drawing.Point(99, 48);
            this.Error_Moyenne.Name = "Error_Moyenne";
            this.Error_Moyenne.Size = new System.Drawing.Size(110, 17);
            this.Error_Moyenne.TabIndex = 7;
            this.Error_Moyenne.Text = "Champ non valide";
            this.Error_Moyenne.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Réponse:";
            // 
            // TBX_Reponse
            // 
            this.TBX_Reponse.Enabled = false;
            this.TBX_Reponse.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Reponse.Location = new System.Drawing.Point(102, 272);
            this.TBX_Reponse.Name = "TBX_Reponse";
            this.TBX_Reponse.Size = new System.Drawing.Size(149, 24);
            this.TBX_Reponse.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(272, 224);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(218, 67);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ce programme calcule la probabilité avec les valeurs exactes.";
            // 
            // BTN_Return
            // 
            this.BTN_Return.Image = global::TP_Math.Properties.Resources._61449_return_button;
            this.BTN_Return.Location = new System.Drawing.Point(11, 310);
            this.BTN_Return.Name = "BTN_Return";
            this.BTN_Return.Size = new System.Drawing.Size(26, 23);
            this.BTN_Return.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTN_Return.TabIndex = 11;
            this.BTN_Return.TabStop = false;
            this.BTN_Return.Click += new System.EventHandler(this.BTN_Return_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP_Math.Properties.Resources.probability_density_function;
            this.pictureBox1.Location = new System.Drawing.Point(276, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ERror_A
            // 
            this.ERror_A.AutoSize = true;
            this.ERror_A.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ERror_A.ForeColor = System.Drawing.Color.Red;
            this.ERror_A.Location = new System.Drawing.Point(99, 142);
            this.ERror_A.Name = "ERror_A";
            this.ERror_A.Size = new System.Drawing.Size(110, 17);
            this.ERror_A.TabIndex = 13;
            this.ERror_A.Text = "Champ non valide";
            this.ERror_A.Visible = false;
            // 
            // TBX_B
            // 
            this.TBX_B.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_B.Location = new System.Drawing.Point(102, 162);
            this.TBX_B.Name = "TBX_B";
            this.TBX_B.Size = new System.Drawing.Size(149, 24);
            this.TBX_B.TabIndex = 14;
            this.TBX_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // Error_B
            // 
            this.Error_B.AutoSize = true;
            this.Error_B.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_B.ForeColor = System.Drawing.Color.Red;
            this.Error_B.Location = new System.Drawing.Point(99, 189);
            this.Error_B.Name = "Error_B";
            this.Error_B.Size = new System.Drawing.Size(110, 17);
            this.Error_B.TabIndex = 15;
            this.Error_B.Text = "Champ non valide";
            this.Error_B.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "A:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 22);
            this.label8.TabIndex = 17;
            this.label8.Text = "B:";
            // 
            // TBX_Moyenne
            // 
            this.TBX_Moyenne.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Moyenne.Location = new System.Drawing.Point(102, 19);
            this.TBX_Moyenne.Name = "TBX_Moyenne";
            this.TBX_Moyenne.Size = new System.Drawing.Size(149, 24);
            this.TBX_Moyenne.TabIndex = 18;
            this.TBX_Moyenne.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBX_Moyenne_KeyPress);
            // 
            // TBX_A
            // 
            this.TBX_A.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_A.Location = new System.Drawing.Point(102, 115);
            this.TBX_A.Name = "TBX_A";
            this.TBX_A.Size = new System.Drawing.Size(149, 24);
            this.TBX_A.TabIndex = 19;
            this.TBX_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBX_A_KeyPress);
            // 
            // DGV_Table
            // 
            this.DGV_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Table.Location = new System.Drawing.Point(33, 195);
            this.DGV_Table.Name = "DGV_Table";
            this.DGV_Table.Size = new System.Drawing.Size(10, 10);
            this.DGV_Table.TabIndex = 20;
            // 
            // Intérieur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 345);
            this.Controls.Add(this.DGV_Table);
            this.Controls.Add(this.TBX_A);
            this.Controls.Add(this.TBX_Moyenne);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Error_B);
            this.Controls.Add(this.TBX_B);
            this.Controls.Add(this.ERror_A);
            this.Controls.Add(this.BTN_Return);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBX_Reponse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Error_Moyenne);
            this.Controls.Add(this.Error_Ecart);
            this.Controls.Add(this.BTN_Calculer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TBX_ET);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Intérieur";
            this.Text = "Interieur";
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TBX_ET;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_Calculer;
        private System.Windows.Forms.Label Error_Ecart;
        private System.Windows.Forms.Label Error_Moyenne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBX_Reponse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox BTN_Return;
        private System.Windows.Forms.Label ERror_A;
        private System.Windows.Forms.TextBox TBX_B;
        private System.Windows.Forms.Label Error_B;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBX_Moyenne;
        private System.Windows.Forms.TextBox TBX_A;
        private System.Windows.Forms.DataGridView DGV_Table;
    }
}