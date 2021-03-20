namespace TIcTacToe_WF
{
    partial class StartForm
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
            this.Player1Name = new System.Windows.Forms.Label();
            this.Player2Name = new System.Windows.Forms.Label();
            this.p1_Name = new System.Windows.Forms.TextBox();
            this.p2_Name = new System.Windows.Forms.TextBox();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Player1Name
            // 
            this.Player1Name.AutoSize = true;
            this.Player1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Name.Location = new System.Drawing.Point(16, 11);
            this.Player1Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.Size = new System.Drawing.Size(182, 25);
            this.Player1Name.TabIndex = 0;
            this.Player1Name.Text = "Player One Name";
            // 
            // Player2Name
            // 
            this.Player2Name.AutoSize = true;
            this.Player2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Name.Location = new System.Drawing.Point(16, 55);
            this.Player2Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player2Name.Name = "Player2Name";
            this.Player2Name.Size = new System.Drawing.Size(182, 25);
            this.Player2Name.TabIndex = 1;
            this.Player2Name.Text = "Player Two Name";
            // 
            // p1_Name
            // 
            this.p1_Name.Location = new System.Drawing.Point(220, 11);
            this.p1_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p1_Name.Name = "p1_Name";
            this.p1_Name.Size = new System.Drawing.Size(380, 22);
            this.p1_Name.TabIndex = 2;
            // 
            // p2_Name
            // 
            this.p2_Name.Location = new System.Drawing.Point(220, 55);
            this.p2_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p2_Name.Name = "p2_Name";
            this.p2_Name.Size = new System.Drawing.Size(380, 22);
            this.p2_Name.TabIndex = 3;
            // 
            // PlayBtn
            // 
            this.PlayBtn.Location = new System.Drawing.Point(393, 113);
            this.PlayBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(100, 28);
            this.PlayBtn.TabIndex = 4;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.OnClickPlayBtn);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(501, 113);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(100, 28);
            this.CloseBtn.TabIndex = 5;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.OnExitApp);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 154);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.p2_Name);
            this.Controls.Add(this.p1_Name);
            this.Controls.Add(this.Player2Name);
            this.Controls.Add(this.Player1Name);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(643, 201);
            this.Name = "StartForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Player1Name;
        private System.Windows.Forms.Label Player2Name;
        private System.Windows.Forms.TextBox p1_Name;
        private System.Windows.Forms.TextBox p2_Name;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button CloseBtn;
    }
}