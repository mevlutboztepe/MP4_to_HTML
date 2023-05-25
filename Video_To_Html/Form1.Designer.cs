
namespace Video_To_Html
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
            this.btn_sec = new System.Windows.Forms.Button();
            this.btn_html_olustur = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbl_video = new System.Windows.Forms.Label();
            this.lbl_durum = new System.Windows.Forms.Label();
            this.lbl_video2 = new System.Windows.Forms.Label();
            this.lbl_durum2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_sec
            // 
            this.btn_sec.Location = new System.Drawing.Point(16, 19);
            this.btn_sec.Name = "btn_sec";
            this.btn_sec.Size = new System.Drawing.Size(175, 52);
            this.btn_sec.TabIndex = 0;
            this.btn_sec.Text = "Video SEÇ";
            this.btn_sec.UseVisualStyleBackColor = true;
            this.btn_sec.Click += new System.EventHandler(this.btn_sec_Click);
            // 
            // btn_html_olustur
            // 
            this.btn_html_olustur.Location = new System.Drawing.Point(16, 100);
            this.btn_html_olustur.Name = "btn_html_olustur";
            this.btn_html_olustur.Size = new System.Drawing.Size(175, 52);
            this.btn_html_olustur.TabIndex = 1;
            this.btn_html_olustur.Text = "Html Oluştur";
            this.btn_html_olustur.UseVisualStyleBackColor = true;
            this.btn_html_olustur.Click += new System.EventHandler(this.btn_html_olustur_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(32, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_html_olustur);
            this.splitContainer1.Panel1.Controls.Add(this.btn_sec);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lbl_durum);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_durum2);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_video2);
            this.splitContainer1.Panel2.Controls.Add(this.lbl_video);
            this.splitContainer1.Size = new System.Drawing.Size(600, 166);
            this.splitContainer1.SplitterDistance = 222;
            this.splitContainer1.TabIndex = 2;
            // 
            // lbl_video
            // 
            this.lbl_video.AutoSize = true;
            this.lbl_video.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_video.Location = new System.Drawing.Point(16, 30);
            this.lbl_video.Name = "lbl_video";
            this.lbl_video.Size = new System.Drawing.Size(144, 25);
            this.lbl_video.TabIndex = 0;
            this.lbl_video.Text = "Seçilen Video :";
            // 
            // lbl_durum
            // 
            this.lbl_durum.AutoSize = true;
            this.lbl_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_durum.Location = new System.Drawing.Point(16, 100);
            this.lbl_durum.Name = "lbl_durum";
            this.lbl_durum.Size = new System.Drawing.Size(145, 25);
            this.lbl_durum.TabIndex = 0;
            this.lbl_durum.Text = "DURUM           :";
            // 
            // lbl_video2
            // 
            this.lbl_video2.AutoSize = true;
            this.lbl_video2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_video2.Location = new System.Drawing.Point(178, 30);
            this.lbl_video2.Name = "lbl_video2";
            this.lbl_video2.Size = new System.Drawing.Size(0, 31);
            this.lbl_video2.TabIndex = 0;
            // 
            // lbl_durum2
            // 
            this.lbl_durum2.AutoSize = true;
            this.lbl_durum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_durum2.Location = new System.Drawing.Point(178, 100);
            this.lbl_durum2.Name = "lbl_durum2";
            this.lbl_durum2.Size = new System.Drawing.Size(0, 31);
            this.lbl_durum2.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 210);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Video to HTML";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sec;
        private System.Windows.Forms.Button btn_html_olustur;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbl_durum;
        private System.Windows.Forms.Label lbl_durum2;
        private System.Windows.Forms.Label lbl_video2;
        private System.Windows.Forms.Label lbl_video;
    }
}

