namespace Diakkezelovegleg
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnlDiakok = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lstKivalaszottak = new System.Windows.Forms.ListBox();
            this.btnAdatbevitel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnKivalaszt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstLegidosebbek = new System.Windows.Forms.ListBox();
            this.kivalsztott = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(108, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diákok";
            // 
            // pnlDiakok
            // 
            this.pnlDiakok.AutoScroll = true;
            this.pnlDiakok.BackColor = System.Drawing.Color.LightSalmon;
            this.pnlDiakok.Location = new System.Drawing.Point(25, 59);
            this.pnlDiakok.Name = "pnlDiakok";
            this.pnlDiakok.Size = new System.Drawing.Size(250, 317);
            this.pnlDiakok.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Brown;
            this.label2.Location = new System.Drawing.Point(535, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kiválasztottak";
            // 
            // lstKivalaszottak
            // 
            this.lstKivalaszottak.FormattingEnabled = true;
            this.lstKivalaszottak.Location = new System.Drawing.Point(470, 77);
            this.lstKivalaszottak.Name = "lstKivalaszottak";
            this.lstKivalaszottak.Size = new System.Drawing.Size(299, 121);
            this.lstKivalaszottak.TabIndex = 3;
            this.lstKivalaszottak.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnAdatbevitel
            // 
            this.btnAdatbevitel.Location = new System.Drawing.Point(25, 405);
            this.btnAdatbevitel.Name = "btnAdatbevitel";
            this.btnAdatbevitel.Size = new System.Drawing.Size(75, 23);
            this.btnAdatbevitel.TabIndex = 4;
            this.btnAdatbevitel.Text = "Adatbevitel";
            this.btnAdatbevitel.UseVisualStyleBackColor = true;
            this.btnAdatbevitel.Click += new System.EventHandler(this.adatbevitel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnKivalaszt
            // 
            this.btnKivalaszt.Location = new System.Drawing.Point(200, 405);
            this.btnKivalaszt.Name = "btnKivalaszt";
            this.btnKivalaszt.Size = new System.Drawing.Size(75, 23);
            this.btnKivalaszt.TabIndex = 5;
            this.btnKivalaszt.Text = "Kiválasztás";
            this.btnKivalaszt.UseVisualStyleBackColor = true;
            this.btnKivalaszt.Click += new System.EventHandler(this.kivalaszt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(465, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Legidősebbek:";
            // 
            // lstLegidosebbek
            // 
            this.lstLegidosebbek.FormattingEnabled = true;
            this.lstLegidosebbek.Location = new System.Drawing.Point(470, 281);
            this.lstLegidosebbek.Name = "lstLegidosebbek";
            this.lstLegidosebbek.Size = new System.Drawing.Size(299, 95);
            this.lstLegidosebbek.TabIndex = 7;
            // 
            // kivalsztott
            // 
            this.kivalsztott.BackColor = System.Drawing.Color.PeachPuff;
            this.kivalsztott.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kivalsztott.Location = new System.Drawing.Point(470, 415);
            this.kivalsztott.Name = "kivalsztott";
            this.kivalsztott.Size = new System.Drawing.Size(299, 13);
            this.kivalsztott.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kivalsztott);
            this.Controls.Add(this.lstLegidosebbek);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnKivalaszt);
            this.Controls.Add(this.btnAdatbevitel);
            this.Controls.Add(this.lstKivalaszottak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnlDiakok);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Diákok adatai";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlDiakok;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstKivalaszottak;
        private System.Windows.Forms.Button btnAdatbevitel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnKivalaszt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstLegidosebbek;
        private System.Windows.Forms.TextBox kivalsztott;
    }
}

