namespace TP_Math
{
    partial class Menu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Intérieur = new System.Windows.Forms.Button();
            this.BTN_Inférieur = new System.Windows.Forms.Button();
            this.BTN_Supérieur = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Normal distribution";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Calculator 2019";
            // 
            // BTN_Intérieur
            // 
            this.BTN_Intérieur.BackColor = System.Drawing.Color.Brown;
            this.BTN_Intérieur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Intérieur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Intérieur.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Intérieur.ForeColor = System.Drawing.Color.Black;
            this.BTN_Intérieur.Location = new System.Drawing.Point(122, 132);
            this.BTN_Intérieur.Name = "BTN_Intérieur";
            this.BTN_Intérieur.Size = new System.Drawing.Size(246, 44);
            this.BTN_Intérieur.TabIndex = 3;
            this.BTN_Intérieur.Text = "Probablité à l\'intérieur les intervalles P( a < X < b)";
            this.BTN_Intérieur.UseVisualStyleBackColor = false;
            this.BTN_Intérieur.Click += new System.EventHandler(this.BTN_Intérieur_Click);
            // 
            // BTN_Inférieur
            // 
            this.BTN_Inférieur.BackColor = System.Drawing.Color.Brown;
            this.BTN_Inférieur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Inférieur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Inférieur.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Inférieur.ForeColor = System.Drawing.Color.Black;
            this.BTN_Inférieur.Location = new System.Drawing.Point(122, 201);
            this.BTN_Inférieur.Name = "BTN_Inférieur";
            this.BTN_Inférieur.Size = new System.Drawing.Size(246, 44);
            this.BTN_Inférieur.TabIndex = 4;
            this.BTN_Inférieur.Text = "Probablité inférieur P( X < a)";
            this.BTN_Inférieur.UseVisualStyleBackColor = false;
            this.BTN_Inférieur.Click += new System.EventHandler(this.BTN_Inférieur_Click);
            // 
            // BTN_Supérieur
            // 
            this.BTN_Supérieur.BackColor = System.Drawing.Color.Brown;
            this.BTN_Supérieur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Supérieur.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Supérieur.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Supérieur.ForeColor = System.Drawing.Color.Black;
            this.BTN_Supérieur.Location = new System.Drawing.Point(122, 270);
            this.BTN_Supérieur.Name = "BTN_Supérieur";
            this.BTN_Supérieur.Size = new System.Drawing.Size(246, 44);
            this.BTN_Supérieur.TabIndex = 5;
            this.BTN_Supérieur.Text = "Probablité supérieur P( X > a)";
            this.BTN_Supérieur.UseVisualStyleBackColor = false;
            this.BTN_Supérieur.Click += new System.EventHandler(this.BTN_Supérieur_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP_Math.Properties.Resources.normal_distribution_histogram;
            this.pictureBox1.Location = new System.Drawing.Point(344, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(489, 337);
            this.Controls.Add(this.BTN_Supérieur);
            this.Controls.Add(this.BTN_Inférieur);
            this.Controls.Add(this.BTN_Intérieur);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Menu";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTN_Intérieur;
        private System.Windows.Forms.Button BTN_Inférieur;
        private System.Windows.Forms.Button BTN_Supérieur;
    }
}

