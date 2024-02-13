namespace WFAOOBOdev_0
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
            this.lblKullaniciIsim = new System.Windows.Forms.Label();
            this.lblKullaniciCan = new System.Windows.Forms.Label();
            this.lblDusmanIsim = new System.Windows.Forms.Label();
            this.lblDusmanCan = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnSaldir = new System.Windows.Forms.Button();
            this.btnOzelSaldiri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKullaniciIsim
            // 
            this.lblKullaniciIsim.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKullaniciIsim.Location = new System.Drawing.Point(12, 49);
            this.lblKullaniciIsim.Name = "lblKullaniciIsim";
            this.lblKullaniciIsim.Size = new System.Drawing.Size(205, 49);
            this.lblKullaniciIsim.TabIndex = 0;
            // 
            // lblKullaniciCan
            // 
            this.lblKullaniciCan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKullaniciCan.Location = new System.Drawing.Point(12, 115);
            this.lblKullaniciCan.Name = "lblKullaniciCan";
            this.lblKullaniciCan.Size = new System.Drawing.Size(205, 49);
            this.lblKullaniciCan.TabIndex = 0;
            // 
            // lblDusmanIsim
            // 
            this.lblDusmanIsim.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDusmanIsim.Location = new System.Drawing.Point(1154, 49);
            this.lblDusmanIsim.Name = "lblDusmanIsim";
            this.lblDusmanIsim.Size = new System.Drawing.Size(205, 49);
            this.lblDusmanIsim.TabIndex = 0;
            // 
            // lblDusmanCan
            // 
            this.lblDusmanCan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDusmanCan.Location = new System.Drawing.Point(1154, 115);
            this.lblDusmanCan.Name = "lblDusmanCan";
            this.lblDusmanCan.Size = new System.Drawing.Size(205, 49);
            this.lblDusmanCan.TabIndex = 0;
            // 
            // lblLevel
            // 
            this.lblLevel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLevel.Location = new System.Drawing.Point(547, 23);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(205, 49);
            this.lblLevel.TabIndex = 0;
            // 
            // lblSonuc
            // 
            this.lblSonuc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSonuc.Location = new System.Drawing.Point(369, 321);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(647, 124);
            this.lblSonuc.TabIndex = 0;
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(1157, 256);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(131, 20);
            this.txtIsim.TabIndex = 1;
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(1191, 296);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(75, 23);
            this.btnBasla.TabIndex = 2;
            this.btnBasla.Text = "Basla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnSaldir
            // 
            this.btnSaldir.Location = new System.Drawing.Point(41, 200);
            this.btnSaldir.Name = "btnSaldir";
            this.btnSaldir.Size = new System.Drawing.Size(75, 23);
            this.btnSaldir.TabIndex = 2;
            this.btnSaldir.Text = "Saldiri";
            this.btnSaldir.UseVisualStyleBackColor = true;
            this.btnSaldir.Click += new System.EventHandler(this.btnSaldir_Click);
            // 
            // btnOzelSaldiri
            // 
            this.btnOzelSaldiri.Location = new System.Drawing.Point(41, 268);
            this.btnOzelSaldiri.Name = "btnOzelSaldiri";
            this.btnOzelSaldiri.Size = new System.Drawing.Size(75, 23);
            this.btnOzelSaldiri.TabIndex = 2;
            this.btnOzelSaldiri.Text = "Ozel Saldiri";
            this.btnOzelSaldiri.UseVisualStyleBackColor = true;
            this.btnOzelSaldiri.Click += new System.EventHandler(this.btnOzelSaldiri_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 489);
            this.Controls.Add(this.btnOzelSaldiri);
            this.Controls.Add(this.btnSaldir);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.lblKullaniciCan);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblDusmanCan);
            this.Controls.Add(this.lblDusmanIsim);
            this.Controls.Add(this.lblKullaniciIsim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullaniciIsim;
        private System.Windows.Forms.Label lblKullaniciCan;
        private System.Windows.Forms.Label lblDusmanIsim;
        private System.Windows.Forms.Label lblDusmanCan;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnSaldir;
        private System.Windows.Forms.Button btnOzelSaldiri;
    }
}

