namespace Chapter_2___Program_4
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
            this.enableCheckbox = new System.Windows.Forms.CheckBox();
            this.changeText = new System.Windows.Forms.Button();
            this.labelToChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // enableCheckbox
            // 
            this.enableCheckbox.AutoSize = true;
            this.enableCheckbox.Checked = true;
            this.enableCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableCheckbox.Location = new System.Drawing.Point(502, 14);
            this.enableCheckbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enableCheckbox.Name = "enableCheckbox";
            this.enableCheckbox.Size = new System.Drawing.Size(199, 24);
            this.enableCheckbox.TabIndex = 0;
            this.enableCheckbox.Text = "Wlącza zmianę etykiety";
            this.enableCheckbox.UseVisualStyleBackColor = true;
            this.enableCheckbox.CheckedChanged += new System.EventHandler(this.enableCheckbox_Click);
            // 
            // changeText
            // 
            this.changeText.Location = new System.Drawing.Point(28, 14);
            this.changeText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.changeText.Name = "changeText";
            this.changeText.Size = new System.Drawing.Size(312, 35);
            this.changeText.TabIndex = 1;
            this.changeText.Text = "Naciśnij przycisk, aby zmienieć tekst";
            this.changeText.UseVisualStyleBackColor = true;
            this.changeText.Click += new System.EventHandler(this.changeText_Click);
            // 
            // labelToChange
            // 
            this.labelToChange.Location = new System.Drawing.Point(-1, 67);
            this.labelToChange.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToChange.Name = "labelToChange";
            this.labelToChange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelToChange.Size = new System.Drawing.Size(729, 43);
            this.labelToChange.TabIndex = 2;
            this.labelToChange.Text = "Kliknięcie zmienia etykietę";
            this.labelToChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelToChange.Click += new System.EventHandler(this.labelToChange_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 140);
            this.Controls.Add(this.labelToChange);
            this.Controls.Add(this.changeText);
            this.Controls.Add(this.enableCheckbox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Moja aplikacja Windows";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox enableCheckbox;
        private System.Windows.Forms.Button changeText;
        private System.Windows.Forms.Label labelToChange;
    }
}

