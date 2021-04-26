
namespace Aplikacja_MEMS.Forms
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.Title = new System.Windows.Forms.Label();
            this.pBoxUnicleo = new System.Windows.Forms.PictureBox();
            this.pBoxStm = new System.Windows.Forms.PictureBox();
            this.pBoxWEL = new System.Windows.Forms.PictureBox();
            this.rTBoxAbout = new System.Windows.Forms.RichTextBox();
            this.rTBoxAboutData = new System.Windows.Forms.RichTextBox();
            this.labBottom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUnicleo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxStm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxWEL)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Title.Location = new System.Drawing.Point(188, 23);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(318, 25);
            this.Title.TabIndex = 0;
            this.Title.Text = "Aplikacja MEMS czujnika IKS01A2";
            // 
            // pBoxUnicleo
            // 
            this.pBoxUnicleo.BackgroundImage = global::Aplikacja_MEMS.Properties.Resources.image_PF264299_en_feature_description_include_personalized_no_cpn_medium;
            this.pBoxUnicleo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxUnicleo.Location = new System.Drawing.Point(602, 317);
            this.pBoxUnicleo.Name = "pBoxUnicleo";
            this.pBoxUnicleo.Size = new System.Drawing.Size(120, 81);
            this.pBoxUnicleo.TabIndex = 3;
            this.pBoxUnicleo.TabStop = false;
            // 
            // pBoxStm
            // 
            this.pBoxStm.BackgroundImage = global::Aplikacja_MEMS.Properties.Resources.STMICROELECTRONICS;
            this.pBoxStm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxStm.Location = new System.Drawing.Point(602, 191);
            this.pBoxStm.Name = "pBoxStm";
            this.pBoxStm.Size = new System.Drawing.Size(120, 120);
            this.pBoxStm.TabIndex = 2;
            this.pBoxStm.TabStop = false;
            // 
            // pBoxWEL
            // 
            this.pBoxWEL.BackgroundImage = global::Aplikacja_MEMS.Properties.Resources.wel;
            this.pBoxWEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBoxWEL.Location = new System.Drawing.Point(602, 65);
            this.pBoxWEL.Name = "pBoxWEL";
            this.pBoxWEL.Size = new System.Drawing.Size(120, 120);
            this.pBoxWEL.TabIndex = 1;
            this.pBoxWEL.TabStop = false;
            // 
            // rTBoxAbout
            // 
            this.rTBoxAbout.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rTBoxAbout.BackColor = System.Drawing.Color.White;
            this.rTBoxAbout.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTBoxAbout.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rTBoxAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rTBoxAbout.ForeColor = System.Drawing.Color.Black;
            this.rTBoxAbout.Location = new System.Drawing.Point(12, 135);
            this.rTBoxAbout.Name = "rTBoxAbout";
            this.rTBoxAbout.ReadOnly = true;
            this.rTBoxAbout.Size = new System.Drawing.Size(584, 263);
            this.rTBoxAbout.TabIndex = 4;
            this.rTBoxAbout.TabStop = false;
            this.rTBoxAbout.Text = "";
            // 
            // rTBoxAboutData
            // 
            this.rTBoxAboutData.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.rTBoxAboutData.BackColor = System.Drawing.Color.White;
            this.rTBoxAboutData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rTBoxAboutData.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rTBoxAboutData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rTBoxAboutData.ForeColor = System.Drawing.Color.Black;
            this.rTBoxAboutData.Location = new System.Drawing.Point(12, 65);
            this.rTBoxAboutData.Name = "rTBoxAboutData";
            this.rTBoxAboutData.ReadOnly = true;
            this.rTBoxAboutData.Size = new System.Drawing.Size(584, 64);
            this.rTBoxAboutData.TabIndex = 5;
            this.rTBoxAboutData.TabStop = false;
            this.rTBoxAboutData.Text = "";
            // 
            // labBottom
            // 
            this.labBottom.AutoSize = true;
            this.labBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labBottom.Location = new System.Drawing.Point(69, 415);
            this.labBottom.Name = "labBottom";
            this.labBottom.Size = new System.Drawing.Size(568, 16);
            this.labBottom.TabIndex = 6;
            this.labBottom.Text = "Copyright © sierż. pchor.  inż. Dawid MUZYCZUK | Wojskowa Akademia Techniczna | W" +
    "EL | ISŁ";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.labBottom);
            this.Controls.Add(this.rTBoxAboutData);
            this.Controls.Add(this.rTBoxAbout);
            this.Controls.Add(this.pBoxUnicleo);
            this.Controls.Add(this.pBoxStm);
            this.Controls.Add(this.pBoxWEL);
            this.Controls.Add(this.Title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "About";
            this.Text = "O programie";
            ((System.ComponentModel.ISupportInitialize)(this.pBoxUnicleo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxStm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxWEL)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.PictureBox pBoxWEL;
        private System.Windows.Forms.PictureBox pBoxStm;
        private System.Windows.Forms.PictureBox pBoxUnicleo;
        private System.Windows.Forms.RichTextBox rTBoxAbout;
        private System.Windows.Forms.RichTextBox rTBoxAboutData;
        private System.Windows.Forms.Label labBottom;
    }
}