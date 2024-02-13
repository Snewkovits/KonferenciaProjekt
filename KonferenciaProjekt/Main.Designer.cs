namespace KonferenciaProjekt
{
    partial class Main
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
            this.kep = new System.Windows.Forms.PictureBox();
            this.balra = new System.Windows.Forms.PictureBox();
            this.jobbra = new System.Windows.Forms.PictureBox();
            this.mentes = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobbra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // kep
            // 
            this.kep.BackColor = System.Drawing.SystemColors.Control;
            this.kep.Location = new System.Drawing.Point(70, 30);
            this.kep.Name = "kep";
            this.kep.Size = new System.Drawing.Size(125, 190);
            this.kep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.kep.TabIndex = 2;
            this.kep.TabStop = false;
            // 
            // balra
            // 
            this.balra.BackColor = System.Drawing.SystemColors.Control;
            this.balra.Location = new System.Drawing.Point(14, 100);
            this.balra.Name = "balra";
            this.balra.Size = new System.Drawing.Size(50, 50);
            this.balra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.balra.TabIndex = 3;
            this.balra.TabStop = false;
            this.balra.Click += new System.EventHandler(this.balra_Click);
            // 
            // jobbra
            // 
            this.jobbra.BackColor = System.Drawing.SystemColors.Control;
            this.jobbra.Location = new System.Drawing.Point(201, 100);
            this.jobbra.Name = "jobbra";
            this.jobbra.Size = new System.Drawing.Size(50, 50);
            this.jobbra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.jobbra.TabIndex = 4;
            this.jobbra.TabStop = false;
            this.jobbra.Click += new System.EventHandler(this.jobbra_Click);
            // 
            // mentes
            // 
            this.mentes.BackColor = System.Drawing.SystemColors.Control;
            this.mentes.Location = new System.Drawing.Point(109, 226);
            this.mentes.Name = "mentes";
            this.mentes.Size = new System.Drawing.Size(50, 50);
            this.mentes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mentes.TabIndex = 5;
            this.mentes.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox5.Location = new System.Drawing.Point(280, 30);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 6;
            this.pictureBox5.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.mentes);
            this.Controls.Add(this.jobbra);
            this.Controls.Add(this.balra);
            this.Controls.Add(this.kep);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobbra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox kep;
        private System.Windows.Forms.PictureBox balra;
        private System.Windows.Forms.PictureBox jobbra;
        private System.Windows.Forms.PictureBox mentes;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

