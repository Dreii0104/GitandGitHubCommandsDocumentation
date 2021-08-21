
namespace GitandGitHubCommandsPractice
{
    partial class AndreisForm
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
            this.AndreiForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AndreiForm
            // 
            this.AndreiForm.AutoSize = true;
            this.AndreiForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AndreiForm.Location = new System.Drawing.Point(127, 240);
            this.AndreiForm.Name = "AndreiForm";
            this.AndreiForm.Size = new System.Drawing.Size(321, 55);
            this.AndreiForm.TabIndex = 0;
            this.AndreiForm.Text = "Andrei\'s Form";
            this.AndreiForm.Click += new System.EventHandler(this.label1_Click);
            // 
            // AndreisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(579, 547);
            this.Controls.Add(this.AndreiForm);
            this.Name = "AndreisForm";
            this.Text = "Andrei\'s Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AndreiForm;
    }
}