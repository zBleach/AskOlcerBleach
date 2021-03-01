
namespace AskOlcerBleach
{
    partial class AskOlcer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hesaplabtn = new System.Windows.Forms.Button();
            this.yuzde = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.askyuzdelbl = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ask1tbox = new System.Windows.Forms.TextBox();
            this.ask2tbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ask1lbl = new System.Windows.Forms.Label();
            this.ask2lbl = new System.Windows.Forms.Label();
            this.sozlbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hesaplabtn
            // 
            this.hesaplabtn.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hesaplabtn.Location = new System.Drawing.Point(426, 424);
            this.hesaplabtn.Name = "hesaplabtn";
            this.hesaplabtn.Size = new System.Drawing.Size(173, 58);
            this.hesaplabtn.TabIndex = 0;
            this.hesaplabtn.Text = "HESAPLA";
            this.hesaplabtn.UseVisualStyleBackColor = true;
            this.hesaplabtn.Click += new System.EventHandler(this.hesaplabtn_Click);
            // 
            // yuzde
            // 
            this.yuzde.AutoSize = true;
            this.yuzde.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yuzde.Location = new System.Drawing.Point(65, 39);
            this.yuzde.Name = "yuzde";
            this.yuzde.Size = new System.Drawing.Size(52, 44);
            this.yuzde.TabIndex = 1;
            this.yuzde.Text = "%";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.askyuzdelbl);
            this.groupBox1.Controls.Add(this.yuzde);
            this.groupBox1.Location = new System.Drawing.Point(405, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 116);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // askyuzdelbl
            // 
            this.askyuzdelbl.AutoSize = true;
            this.askyuzdelbl.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.askyuzdelbl.Location = new System.Drawing.Point(105, 36);
            this.askyuzdelbl.Name = "askyuzdelbl";
            this.askyuzdelbl.Size = new System.Drawing.Size(33, 45);
            this.askyuzdelbl.TabIndex = 2;
            this.askyuzdelbl.Text = "-";
            this.askyuzdelbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // ask1tbox
            // 
            this.ask1tbox.Location = new System.Drawing.Point(241, 48);
            this.ask1tbox.Name = "ask1tbox";
            this.ask1tbox.Size = new System.Drawing.Size(100, 23);
            this.ask1tbox.TabIndex = 3;
            this.ask1tbox.TextChanged += new System.EventHandler(this.ask1tbox_TextChanged);
            // 
            // ask2tbox
            // 
            this.ask2tbox.Location = new System.Drawing.Point(781, 48);
            this.ask2tbox.Name = "ask2tbox";
            this.ask2tbox.Size = new System.Drawing.Size(100, 23);
            this.ask2tbox.TabIndex = 4;
            this.ask2tbox.TextChanged += new System.EventHandler(this.ask2tbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(141, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "1. Kişi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(681, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "2. Kişi : ";
            // 
            // ask1lbl
            // 
            this.ask1lbl.AutoSize = true;
            this.ask1lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ask1lbl.Location = new System.Drawing.Point(346, 143);
            this.ask1lbl.Name = "ask1lbl";
            this.ask1lbl.Size = new System.Drawing.Size(126, 50);
            this.ask1lbl.TabIndex = 7;
            this.ask1lbl.Text = "1. Aşık";
            // 
            // ask2lbl
            // 
            this.ask2lbl.AutoSize = true;
            this.ask2lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ask2lbl.Location = new System.Drawing.Point(546, 143);
            this.ask2lbl.Name = "ask2lbl";
            this.ask2lbl.Size = new System.Drawing.Size(132, 50);
            this.ask2lbl.TabIndex = 8;
            this.ask2lbl.Text = "2. Aşık";
            // 
            // sozlbl
            // 
            this.sozlbl.AutoSize = true;
            this.sozlbl.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sozlbl.Location = new System.Drawing.Point(405, 357);
            this.sozlbl.Name = "sozlbl";
            this.sozlbl.Size = new System.Drawing.Size(209, 32);
            this.sozlbl.TabIndex = 9;
            this.sozlbl.Text = "Kimler bulayım? :)";
            // 
            // AskOlcer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 695);
            this.Controls.Add(this.sozlbl);
            this.Controls.Add(this.ask2lbl);
            this.Controls.Add(this.ask1lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ask2tbox);
            this.Controls.Add(this.ask1tbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hesaplabtn);
            this.Name = "AskOlcer";
            this.Text = "Aşk Ölçer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hesaplabtn;
        private System.Windows.Forms.Label yuzde;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label askyuzdelbl;
        private System.Windows.Forms.TextBox ask1tbox;
        private System.Windows.Forms.TextBox ask2tbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ask1lbl;
        private System.Windows.Forms.Label ask2lbl;
        private System.Windows.Forms.Label sozlbl;
    }
}

