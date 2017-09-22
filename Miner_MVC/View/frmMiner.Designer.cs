namespace Miner_MVC.View
{
    partial class frmMiner
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
            this.mnuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mni_NewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mni_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.stsStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.mineField = new System.Windows.Forms.Panel();
            this.mnuStrip1.SuspendLayout();
            this.stsStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuStrip1
            // 
            this.mnuStrip1.AutoSize = false;
            this.mnuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mniSettings});
            this.mnuStrip1.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip1.Name = "mnuStrip1";
            this.mnuStrip1.Size = new System.Drawing.Size(342, 24);
            this.mnuStrip1.TabIndex = 0;
            this.mnuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mni_NewGame,
            this.toolStripMenuItem1,
            this.mni_Exit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(45, 20);
            this.mnuFile.Text = "Файл";
            // 
            // mni_NewGame
            // 
            this.mni_NewGame.Name = "mni_NewGame";
            this.mni_NewGame.Size = new System.Drawing.Size(132, 22);
            this.mni_NewGame.Text = "Новая Игра";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 6);
            // 
            // mni_Exit
            // 
            this.mni_Exit.Name = "mni_Exit";
            this.mni_Exit.Size = new System.Drawing.Size(132, 22);
            this.mni_Exit.Text = "Выход";
            // 
            // mniSettings
            // 
            this.mniSettings.Name = "mniSettings";
            this.mniSettings.Size = new System.Drawing.Size(73, 20);
            this.mniSettings.Text = "Настройки";
            // 
            // stsStrip1
            // 
            this.stsStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.stsStrip1.Location = new System.Drawing.Point(0, 294);
            this.stsStrip1.Name = "stsStrip1";
            this.stsStrip1.Size = new System.Drawing.Size(342, 22);
            this.stsStrip1.TabIndex = 4;
            this.stsStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(71, 17);
            this.lblStatus.Text = "10 Mines Left";
            // 
            // btnNewGame
            // 
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Location = new System.Drawing.Point(126, 25);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(79, 23);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "Новая Игра";
            this.btnNewGame.UseVisualStyleBackColor = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(342, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // mineField
            // 
            this.mineField.BackColor = System.Drawing.SystemColors.Control;
            this.mineField.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mineField.Location = new System.Drawing.Point(0, 49);
            this.mineField.Name = "mineField";
            this.mineField.Size = new System.Drawing.Size(342, 245);
            this.mineField.TabIndex = 6;
            // 
            // frmMiner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(342, 316);
            this.Controls.Add(this.mineField);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.stsStrip1);
            this.Controls.Add(this.mnuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuStrip1;
            this.Name = "frmMiner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сапёр";
            this.mnuStrip1.ResumeLayout(false);
            this.mnuStrip1.PerformLayout();
            this.stsStrip1.ResumeLayout(false);
            this.stsStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mni_NewGame;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mni_Exit;
        private System.Windows.Forms.ToolStripMenuItem mniSettings;
        private System.Windows.Forms.StatusStrip stsStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel mineField;
    }
}

