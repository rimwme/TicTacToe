namespace TicTacToe
{
    partial class ChoiceForm
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
            this.playerFirst = new System.Windows.Forms.Button();
            this.botFirst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playerFirst
            // 
            this.playerFirst.Location = new System.Drawing.Point(57, 99);
            this.playerFirst.Name = "playerFirst";
            this.playerFirst.Size = new System.Drawing.Size(110, 110);
            this.playerFirst.TabIndex = 0;
            this.playerFirst.Text = "I\'ll go first";
            this.playerFirst.UseVisualStyleBackColor = true;
            this.playerFirst.Click += new System.EventHandler(this.button1_Click);
            // 
            // botFirst
            // 
            this.botFirst.Location = new System.Drawing.Point(219, 99);
            this.botFirst.Name = "botFirst";
            this.botFirst.Size = new System.Drawing.Size(110, 110);
            this.botFirst.TabIndex = 1;
            this.botFirst.Text = "bot will go first";
            this.botFirst.UseVisualStyleBackColor = true;
            this.botFirst.Click += new System.EventHandler(this.button2_Click);
            // 
            // ChoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 281);
            this.Controls.Add(this.botFirst);
            this.Controls.Add(this.playerFirst);
            this.Name = "ChoiceForm";
            this.Text = "ChoiceForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playerFirst;
        private System.Windows.Forms.Button botFirst;
    }
}