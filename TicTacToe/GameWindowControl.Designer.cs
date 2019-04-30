namespace TicTacToe
{
    partial class GameWindowControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.playGroundPanel = new System.Windows.Forms.Panel();
            this.restartButton = new System.Windows.Forms.Button();
            this.headerLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playGroundPanel
            // 
            this.playGroundPanel.Location = new System.Drawing.Point(49, 58);
            this.playGroundPanel.Name = "playGroundPanel";
            this.playGroundPanel.Size = new System.Drawing.Size(315, 300);
            this.playGroundPanel.TabIndex = 0;
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(223, 364);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(141, 50);
            this.restartButton.TabIndex = 1;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // headerLable
            // 
            this.headerLable.AutoSize = true;
            this.headerLable.Font = new System.Drawing.Font("Century Gothic", 15F);
            this.headerLable.Location = new System.Drawing.Point(119, 15);
            this.headerLable.Name = "headerLable";
            this.headerLable.Size = new System.Drawing.Size(0, 31);
            this.headerLable.TabIndex = 2;
            // 
            // GameWindowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.headerLable);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.playGroundPanel);
            this.Name = "GameWindowControl";
            this.Size = new System.Drawing.Size(415, 465);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel playGroundPanel;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Label headerLable;
    }
}
