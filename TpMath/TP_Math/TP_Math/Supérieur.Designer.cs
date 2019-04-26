namespace TP_Math
{
    partial class Supérieur
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
            this.BTN_Return = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBX_Reponse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Error_Moyenne = new System.Windows.Forms.Label();
            this.Error_Ecart = new System.Windows.Forms.Label();
            this.BTN_Calculer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TBX_ET = new System.Windows.Forms.TextBox();
            this.TBX_Moyenne = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Return)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Return
            // 
            this.BTN_Return.Image = global::TP_Math.Properties.Resources._61449_return_button;
            this.BTN_Return.Location = new System.Drawing.Point(11, 188);
            this.BTN_Return.Name = "BTN_Return";
            this.BTN_Return.Size = new System.Drawing.Size(26, 23);
            this.BTN_Return.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BTN_Return.TabIndex = 23;
            this.BTN_Return.TabStop = false;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(275, 152);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(218, 67);
            this.label4.TabIndex = 22;
            this.label4.Text = "Ce programme calcule la probabilité avec les valeurs exactes.";
            // 
            // TBX_Reponse
            // 
            this.TBX_Reponse.Enabled = false;
            this.TBX_Reponse.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Reponse.Location = new System.Drawing.Point(98, 153);
            this.TBX_Reponse.Name = "TBX_Reponse";
            this.TBX_Reponse.Size = new System.Drawing.Size(149, 24);
            this.TBX_Reponse.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Réponse:";
            // 
            // Error_Moyenne
            // 
            this.Error_Moyenne.AutoSize = true;
            this.Error_Moyenne.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_Moyenne.ForeColor = System.Drawing.Color.Red;
            this.Error_Moyenne.Location = new System.Drawing.Point(102, 39);
            this.Error_Moyenne.Name = "Error_Moyenne";
            this.Error_Moyenne.Size = new System.Drawing.Size(110, 17);
            this.Error_Moyenne.TabIndex = 19;
            this.Error_Moyenne.Text = "Champ non valide";
            this.Error_Moyenne.Visible = false;
            // 
            // Error_Ecart
            // 
            this.Error_Ecart.AutoSize = true;
            this.Error_Ecart.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_Ecart.ForeColor = System.Drawing.Color.Red;
            this.Error_Ecart.Location = new System.Drawing.Point(102, 86);
            this.Error_Ecart.Name = "Error_Ecart";
            this.Error_Ecart.Size = new System.Drawing.Size(110, 17);
            this.Error_Ecart.TabIndex = 18;
            this.Error_Ecart.Text = "Champ non valide";
            this.Error_Ecart.Visible = false;
            // 
            // BTN_Calculer
            // 
            this.BTN_Calculer.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Calculer.Location = new System.Drawing.Point(153, 113);
            this.BTN_Calculer.Name = "BTN_Calculer";
            this.BTN_Calculer.Size = new System.Drawing.Size(101, 26);
            this.BTN_Calculer.TabIndex = 17;
            this.BTN_Calculer.Text = "Calculer";
            this.BTN_Calculer.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP_Math.Properties.Resources.probability_density_function;
            this.pictureBox1.Location = new System.Drawing.Point(279, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // TBX_ET
            // 
            this.TBX_ET.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_ET.Location = new System.Drawing.Point(105, 59);
            this.TBX_ET.Name = "TBX_ET";
            this.TBX_ET.Size = new System.Drawing.Size(149, 24);
            this.TBX_ET.TabIndex = 15;
            // 
            // TBX_Moyenne
            // 
            this.TBX_Moyenne.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBX_Moyenne.Location = new System.Drawing.Point(105, 10);
            this.TBX_Moyenne.Name = "TBX_Moyenne";
            this.TBX_Moyenne.Size = new System.Drawing.Size(149, 24);
            this.TBX_Moyenne.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Écart type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Moyenne:";
            // 
            // Supérieur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 228);
            this.Controls.Add(this.BTN_Return);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBX_Reponse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Error_Moyenne);
            this.Controls.Add(this.Error_Ecart);
            this.Controls.Add(this.BTN_Calculer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TBX_ET);
            this.Controls.Add(this.TBX_Moyenne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Supérieur";
            this.Text = "Supérieur";
            ((System.ComponentModel.ISupportInitialize)(this.BTN_Return)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BTN_Return;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBX_Reponse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Error_Moyenne;
        private System.Windows.Forms.Label Error_Ecart;
        private System.Windows.Forms.Button BTN_Calculer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TBX_ET;
        private System.Windows.Forms.TextBox TBX_Moyenne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}