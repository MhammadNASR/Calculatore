﻿
namespace Calculatore
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
            this.texAdadAval = new System.Windows.Forms.TextBox();
            this.texAdadDovom = new System.Windows.Forms.TextBox();
            this.texMohasebe = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.clearbtn = new System.Windows.Forms.Button();
            this.showbtn = new System.Windows.Forms.Button();
            this.richrez = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // texAdadAval
            // 
            this.texAdadAval.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texAdadAval.Location = new System.Drawing.Point(99, 28);
            this.texAdadAval.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.texAdadAval.Multiline = true;
            this.texAdadAval.Name = "texAdadAval";
            this.texAdadAval.Size = new System.Drawing.Size(193, 56);
            this.texAdadAval.TabIndex = 0;
            // 
            // texAdadDovom
            // 
            this.texAdadDovom.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texAdadDovom.Location = new System.Drawing.Point(456, 28);
            this.texAdadDovom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.texAdadDovom.Multiline = true;
            this.texAdadDovom.Name = "texAdadDovom";
            this.texAdadDovom.Size = new System.Drawing.Size(193, 56);
            this.texAdadDovom.TabIndex = 1;
            this.texAdadDovom.TextChanged += new System.EventHandler(this.texAdadDovom_TextChanged);
            // 
            // texMohasebe
            // 
            this.texMohasebe.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texMohasebe.Location = new System.Drawing.Point(144, 210);
            this.texMohasebe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.texMohasebe.Multiline = true;
            this.texMohasebe.Name = "texMohasebe";
            this.texMohasebe.Size = new System.Drawing.Size(441, 56);
            this.texMohasebe.TabIndex = 2;
            this.texMohasebe.TextChanged += new System.EventHandler(this.texMohasebe_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(83, 122);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(249, 122);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 53);
            this.button2.TabIndex = 4;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(423, 122);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(57, 53);
            this.button3.TabIndex = 5;
            this.button3.Text = "*";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(600, 122);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 53);
            this.button4.TabIndex = 6;
            this.button4.Text = "/";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Adad aval";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(363, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Adad dovom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mohasebe";
            // 
            // clearbtn
            // 
            this.clearbtn.Location = new System.Drawing.Point(431, 287);
            this.clearbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(227, 39);
            this.clearbtn.TabIndex = 10;
            this.clearbtn.Text = "Clear";
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.clearbtn_Click);
            // 
            // showbtn
            // 
            this.showbtn.Location = new System.Drawing.Point(83, 287);
            this.showbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(227, 39);
            this.showbtn.TabIndex = 11;
            this.showbtn.Text = "Show";
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // richrez
            // 
            this.richrez.Location = new System.Drawing.Point(83, 371);
            this.richrez.Name = "richrez";
            this.richrez.Size = new System.Drawing.Size(566, 169);
            this.richrez.TabIndex = 13;
            this.richrez.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 589);
            this.Controls.Add(this.richrez);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.clearbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.texMohasebe);
            this.Controls.Add(this.texAdadDovom);
            this.Controls.Add(this.texAdadAval);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texAdadAval;
        private System.Windows.Forms.TextBox texAdadDovom;
        private System.Windows.Forms.TextBox texMohasebe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.RichTextBox richrez;
    }
}

