
namespace sakk
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.jatekos1TBOX = new System.Windows.Forms.TextBox();
            this.jatekos2TBOX = new System.Windows.Forms.TextBox();
            this.babuk = new System.Windows.Forms.ImageList(this.components);
            this.title = new System.Windows.Forms.PictureBox();
            this.inditas = new System.Windows.Forms.PictureBox();
            this.jatekos1 = new System.Windows.Forms.PictureBox();
            this.jatekos2 = new System.Windows.Forms.PictureBox();
            this.szabalyok = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.játékToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újraindításToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kep = new System.Windows.Forms.PictureBox();
            this.whtsurrenderBTN = new System.Windows.Forms.PictureBox();
            this.blcksurrenderBTN = new System.Windows.Forms.PictureBox();
            this.credits = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inditas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jatekos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jatekos2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.szabalyok)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.whtsurrenderBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blcksurrenderBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.credits)).BeginInit();
            this.SuspendLayout();
            // 
            // jatekos1TBOX
            // 
            this.jatekos1TBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jatekos1TBOX.Location = new System.Drawing.Point(165, 216);
            this.jatekos1TBOX.Name = "jatekos1TBOX";
            this.jatekos1TBOX.Size = new System.Drawing.Size(127, 26);
            this.jatekos1TBOX.TabIndex = 0;
            // 
            // jatekos2TBOX
            // 
            this.jatekos2TBOX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.jatekos2TBOX.Location = new System.Drawing.Point(165, 268);
            this.jatekos2TBOX.Name = "jatekos2TBOX";
            this.jatekos2TBOX.Size = new System.Drawing.Size(127, 26);
            this.jatekos2TBOX.TabIndex = 2;
            // 
            // babuk
            // 
            this.babuk.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("babuk.ImageStream")));
            this.babuk.TransparentColor = System.Drawing.Color.Transparent;
            this.babuk.Images.SetKeyName(0, "feher_bastya.png");
            this.babuk.Images.SetKeyName(1, "feher_lo.png");
            this.babuk.Images.SetKeyName(2, "feher_futo.png");
            this.babuk.Images.SetKeyName(3, "feher_kiraly.png");
            this.babuk.Images.SetKeyName(4, "feher_kiralyno.png");
            this.babuk.Images.SetKeyName(5, "feher_paraszt.png");
            this.babuk.Images.SetKeyName(6, "fekete_bastya.png");
            this.babuk.Images.SetKeyName(7, "fekete_lo.png");
            this.babuk.Images.SetKeyName(8, "fekete_futo.png");
            this.babuk.Images.SetKeyName(9, "fekete_kiraly.png");
            this.babuk.Images.SetKeyName(10, "fekete_kiralyno.png");
            this.babuk.Images.SetKeyName(11, "fekete_paraszt.png");
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.BackgroundImage = global::sakk.Properties.Resources.TITLE;
            this.title.Location = new System.Drawing.Point(268, 36);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(300, 100);
            this.title.TabIndex = 6;
            this.title.TabStop = false;
            // 
            // inditas
            // 
            this.inditas.BackColor = System.Drawing.Color.Transparent;
            this.inditas.BackgroundImage = global::sakk.Properties.Resources.inditas;
            this.inditas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inditas.Location = new System.Drawing.Point(604, 377);
            this.inditas.Name = "inditas";
            this.inditas.Size = new System.Drawing.Size(184, 61);
            this.inditas.TabIndex = 7;
            this.inditas.TabStop = false;
            this.inditas.Click += new System.EventHandler(this.inditas_Click);
            // 
            // jatekos1
            // 
            this.jatekos1.BackColor = System.Drawing.Color.Transparent;
            this.jatekos1.BackgroundImage = global::sakk.Properties.Resources.JATEKOS1;
            this.jatekos1.Location = new System.Drawing.Point(12, 201);
            this.jatekos1.Name = "jatekos1";
            this.jatekos1.Size = new System.Drawing.Size(147, 50);
            this.jatekos1.TabIndex = 8;
            this.jatekos1.TabStop = false;
            // 
            // jatekos2
            // 
            this.jatekos2.BackColor = System.Drawing.Color.Transparent;
            this.jatekos2.BackgroundImage = global::sakk.Properties.Resources.JATEKOS2;
            this.jatekos2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.jatekos2.Location = new System.Drawing.Point(12, 257);
            this.jatekos2.Name = "jatekos2";
            this.jatekos2.Size = new System.Drawing.Size(147, 50);
            this.jatekos2.TabIndex = 9;
            this.jatekos2.TabStop = false;
            // 
            // szabalyok
            // 
            this.szabalyok.BackColor = System.Drawing.Color.Transparent;
            this.szabalyok.BackgroundImage = global::sakk.Properties.Resources.SZABALYOK;
            this.szabalyok.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.szabalyok.Location = new System.Drawing.Point(404, 377);
            this.szabalyok.Name = "szabalyok";
            this.szabalyok.Size = new System.Drawing.Size(184, 61);
            this.szabalyok.TabIndex = 10;
            this.szabalyok.TabStop = false;
            this.szabalyok.Click += new System.EventHandler(this.szabalyok_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.játékToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // játékToolStripMenuItem
            // 
            this.játékToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újraindításToolStripMenuItem});
            this.játékToolStripMenuItem.Name = "játékToolStripMenuItem";
            this.játékToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.játékToolStripMenuItem.Text = "Játék";
            // 
            // újraindításToolStripMenuItem
            // 
            this.újraindításToolStripMenuItem.Name = "újraindításToolStripMenuItem";
            this.újraindításToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.újraindításToolStripMenuItem.Text = "Újraindítás";
            this.újraindításToolStripMenuItem.Click += new System.EventHandler(this.újraindításToolStripMenuItem_Click);
            // 
            // kep
            // 
            this.kep.BackColor = System.Drawing.Color.Transparent;
            this.kep.BackgroundImage = global::sakk.Properties.Resources.nemtom;
            this.kep.Location = new System.Drawing.Point(442, 160);
            this.kep.Name = "kep";
            this.kep.Size = new System.Drawing.Size(300, 200);
            this.kep.TabIndex = 12;
            this.kep.TabStop = false;
            // 
            // whtsurrenderBTN
            // 
            this.whtsurrenderBTN.BackColor = System.Drawing.Color.Transparent;
            this.whtsurrenderBTN.BackgroundImage = global::sakk.Properties.Resources.feladasfeherfifazgattal;
            this.whtsurrenderBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.whtsurrenderBTN.Location = new System.Drawing.Point(52, 60);
            this.whtsurrenderBTN.Name = "whtsurrenderBTN";
            this.whtsurrenderBTN.Size = new System.Drawing.Size(140, 35);
            this.whtsurrenderBTN.TabIndex = 15;
            this.whtsurrenderBTN.TabStop = false;
            this.whtsurrenderBTN.Visible = false;
            this.whtsurrenderBTN.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // blcksurrenderBTN
            // 
            this.blcksurrenderBTN.BackColor = System.Drawing.Color.Transparent;
            this.blcksurrenderBTN.BackgroundImage = global::sakk.Properties.Resources.feketefeladas;
            this.blcksurrenderBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.blcksurrenderBTN.Location = new System.Drawing.Point(52, 101);
            this.blcksurrenderBTN.Name = "blcksurrenderBTN";
            this.blcksurrenderBTN.Size = new System.Drawing.Size(140, 35);
            this.blcksurrenderBTN.TabIndex = 16;
            this.blcksurrenderBTN.TabStop = false;
            this.blcksurrenderBTN.Visible = false;
            this.blcksurrenderBTN.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // credits
            // 
            this.credits.BackColor = System.Drawing.Color.Transparent;
            this.credits.BackgroundImage = global::sakk.Properties.Resources.credits;
            this.credits.Location = new System.Drawing.Point(12, 366);
            this.credits.Name = "credits";
            this.credits.Size = new System.Drawing.Size(159, 119);
            this.credits.TabIndex = 17;
            this.credits.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sakk.Properties.Resources.hatter;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.credits);
            this.Controls.Add(this.blcksurrenderBTN);
            this.Controls.Add(this.whtsurrenderBTN);
            this.Controls.Add(this.kep);
            this.Controls.Add(this.szabalyok);
            this.Controls.Add(this.jatekos2);
            this.Controls.Add(this.jatekos1);
            this.Controls.Add(this.inditas);
            this.Controls.Add(this.title);
            this.Controls.Add(this.jatekos2TBOX);
            this.Controls.Add(this.jatekos1TBOX);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sakk";
            ((System.ComponentModel.ISupportInitialize)(this.title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inditas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jatekos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jatekos2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.szabalyok)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.whtsurrenderBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blcksurrenderBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.credits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox jatekos1TBOX;
        private System.Windows.Forms.TextBox jatekos2TBOX;
        private System.Windows.Forms.ImageList babuk;
        private System.Windows.Forms.PictureBox title;
        private System.Windows.Forms.PictureBox inditas;
        private System.Windows.Forms.PictureBox jatekos1;
        private System.Windows.Forms.PictureBox jatekos2;
        private System.Windows.Forms.PictureBox szabalyok;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem játékToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újraindításToolStripMenuItem;
        private System.Windows.Forms.PictureBox kep;
        private System.Windows.Forms.PictureBox whtsurrenderBTN;
        private System.Windows.Forms.PictureBox blcksurrenderBTN;
        private System.Windows.Forms.PictureBox credits;
    }
}

