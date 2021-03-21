namespace TIcTacToe_WF
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.websiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.Player1 = new System.Windows.Forms.Label();
            this.Player1Score = new System.Windows.Forms.Label();
            this.Player2Score = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(391, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newGameToolStripMenuItem.Text = "Restart";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.RestartGame);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.ResetGame);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitApp);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.helpToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.githubToolStripMenuItem,
            this.websiteToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // githubToolStripMenuItem
            // 
            this.githubToolStripMenuItem.Name = "githubToolStripMenuItem";
            this.githubToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.githubToolStripMenuItem.Text = "Github";
            this.githubToolStripMenuItem.Click += new System.EventHandler(this.OnGitButton);
            // 
            // websiteToolStripMenuItem
            // 
            this.websiteToolStripMenuItem.Name = "websiteToolStripMenuItem";
            this.websiteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.websiteToolStripMenuItem.Text = "Website";
            this.websiteToolStripMenuItem.Click += new System.EventHandler(this.OpenWebSite);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.Transparent;
            this.A1.FlatAppearance.BorderSize = 5;
            this.A1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.A1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.A1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.ForeColor = System.Drawing.Color.White;
            this.A1.Location = new System.Drawing.Point(33, 154);
            this.A1.Margin = new System.Windows.Forms.Padding(4);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(113, 105);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.ButtonClick);
            this.A1.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.A1.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.Transparent;
            this.A2.FlatAppearance.BorderSize = 5;
            this.A2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.A2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.A2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.ForeColor = System.Drawing.Color.White;
            this.A2.Location = new System.Drawing.Point(139, 154);
            this.A2.Margin = new System.Windows.Forms.Padding(4);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(113, 105);
            this.A2.TabIndex = 2;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.ButtonClick);
            this.A2.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.A2.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.Transparent;
            this.A3.FlatAppearance.BorderSize = 5;
            this.A3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.A3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.A3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.ForeColor = System.Drawing.Color.White;
            this.A3.Location = new System.Drawing.Point(248, 154);
            this.A3.Margin = new System.Windows.Forms.Padding(4);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(113, 105);
            this.A3.TabIndex = 3;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.ButtonClick);
            this.A3.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.A3.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.Transparent;
            this.B3.FlatAppearance.BorderSize = 5;
            this.B3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.ForeColor = System.Drawing.Color.White;
            this.B3.Location = new System.Drawing.Point(248, 255);
            this.B3.Margin = new System.Windows.Forms.Padding(4);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(113, 105);
            this.B3.TabIndex = 6;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.ButtonClick);
            this.B3.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.B3.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.Transparent;
            this.B2.FlatAppearance.BorderSize = 5;
            this.B2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.ForeColor = System.Drawing.Color.White;
            this.B2.Location = new System.Drawing.Point(139, 256);
            this.B2.Margin = new System.Windows.Forms.Padding(4);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(113, 105);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.ButtonClick);
            this.B2.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.B2.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.Transparent;
            this.B1.FlatAppearance.BorderSize = 5;
            this.B1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.B1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.ForeColor = System.Drawing.Color.White;
            this.B1.Location = new System.Drawing.Point(33, 255);
            this.B1.Margin = new System.Windows.Forms.Padding(4);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(113, 105);
            this.B1.TabIndex = 4;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.ButtonClick);
            this.B1.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.B1.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.Transparent;
            this.C3.FlatAppearance.BorderSize = 5;
            this.C3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.C3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.C3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.ForeColor = System.Drawing.Color.White;
            this.C3.Location = new System.Drawing.Point(248, 355);
            this.C3.Margin = new System.Windows.Forms.Padding(4);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(113, 105);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.ButtonClick);
            this.C3.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.C3.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.Transparent;
            this.C2.FlatAppearance.BorderSize = 5;
            this.C2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.C2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.C2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.ForeColor = System.Drawing.Color.White;
            this.C2.Location = new System.Drawing.Point(139, 355);
            this.C2.Margin = new System.Windows.Forms.Padding(4);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(113, 105);
            this.C2.TabIndex = 8;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.ButtonClick);
            this.C2.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.C2.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.Transparent;
            this.C1.FlatAppearance.BorderSize = 5;
            this.C1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.C1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.C1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.ForeColor = System.Drawing.Color.White;
            this.C1.Location = new System.Drawing.Point(33, 355);
            this.C1.Margin = new System.Windows.Forms.Padding(4);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(113, 105);
            this.C1.TabIndex = 7;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.ButtonClick);
            this.C1.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.C1.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1.ForeColor = System.Drawing.Color.White;
            this.Player1.Location = new System.Drawing.Point(16, 44);
            this.Player1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(120, 29);
            this.Player1.TabIndex = 10;
            this.Player1.Text = "Player One";
            this.Player1.DoubleClick += new System.EventHandler(this.ChangeP1Name);
            // 
            // Player1Score
            // 
            this.Player1Score.AutoSize = true;
            this.Player1Score.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1Score.ForeColor = System.Drawing.Color.White;
            this.Player1Score.Location = new System.Drawing.Point(152, 44);
            this.Player1Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.Size = new System.Drawing.Size(25, 29);
            this.Player1Score.TabIndex = 11;
            this.Player1Score.Text = "0";
            // 
            // Player2Score
            // 
            this.Player2Score.AutoSize = true;
            this.Player2Score.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2Score.ForeColor = System.Drawing.Color.White;
            this.Player2Score.Location = new System.Drawing.Point(152, 87);
            this.Player2Score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player2Score.Name = "Player2Score";
            this.Player2Score.Size = new System.Drawing.Size(25, 29);
            this.Player2Score.TabIndex = 13;
            this.Player2Score.Text = "0";
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2.ForeColor = System.Drawing.Color.White;
            this.Player2.Location = new System.Drawing.Point(16, 87);
            this.Player2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(120, 29);
            this.Player2.TabIndex = 12;
            this.Player2.Text = "Player Two";
            this.Player2.DoubleClick += new System.EventHandler(this.ChangeP2Name);
            // 
            // ResetBtn
            // 
            this.ResetBtn.BackColor = System.Drawing.Color.White;
            this.ResetBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ResetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.ForeColor = System.Drawing.Color.Black;
            this.ResetBtn.Location = new System.Drawing.Point(144, 502);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(100, 36);
            this.ResetBtn.TabIndex = 14;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = false;
            this.ResetBtn.Click += new System.EventHandler(this.ResetGame);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.White;
            this.CloseBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBtn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.ForeColor = System.Drawing.Color.Black;
            this.CloseBtn.Location = new System.Drawing.Point(267, 502);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(100, 36);
            this.CloseBtn.TabIndex = 15;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.ExitApp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(24, 502);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 36);
            this.button1.TabIndex = 16;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.RestartGame);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(391, 558);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.Player2Score);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1Score);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(409, 605);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Label Player1Score;
        private System.Windows.Forms.Label Player2Score;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem githubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem websiteToolStripMenuItem;
    }
}

