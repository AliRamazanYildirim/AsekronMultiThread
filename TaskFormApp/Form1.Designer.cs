﻿namespace TaskFormApp
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.BtnTheke = new System.Windows.Forms.Button();
            this.textBoxTheke = new System.Windows.Forms.TextBox();
            this.BtnDateiLesen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(86, 49);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(645, 220);
            this.richTextBox.TabIndex = 1;
            this.richTextBox.Text = "";
            // 
            // BtnTheke
            // 
            this.BtnTheke.Location = new System.Drawing.Point(86, 20);
            this.BtnTheke.Name = "BtnTheke";
            this.BtnTheke.Size = new System.Drawing.Size(75, 23);
            this.BtnTheke.TabIndex = 2;
            this.BtnTheke.Text = "Theke";
            this.BtnTheke.UseVisualStyleBackColor = true;
            this.BtnTheke.Click += new System.EventHandler(this.BtnTheke_Click);
            // 
            // textBoxTheke
            // 
            this.textBoxTheke.Location = new System.Drawing.Point(182, 22);
            this.textBoxTheke.Name = "textBoxTheke";
            this.textBoxTheke.Size = new System.Drawing.Size(100, 20);
            this.textBoxTheke.TabIndex = 3;
            // 
            // BtnDateiLesen
            // 
            this.BtnDateiLesen.Location = new System.Drawing.Point(656, 294);
            this.BtnDateiLesen.Name = "BtnDateiLesen";
            this.BtnDateiLesen.Size = new System.Drawing.Size(75, 23);
            this.BtnDateiLesen.TabIndex = 4;
            this.BtnDateiLesen.Text = "Datei lesen";
            this.BtnDateiLesen.UseVisualStyleBackColor = true;
            this.BtnDateiLesen.Click += new System.EventHandler(this.BtnDateiLesen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDateiLesen);
            this.Controls.Add(this.textBoxTheke);
            this.Controls.Add(this.BtnTheke);
            this.Controls.Add(this.richTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button BtnTheke;
        private System.Windows.Forms.TextBox textBoxTheke;
        private System.Windows.Forms.Button BtnDateiLesen;
    }
}

