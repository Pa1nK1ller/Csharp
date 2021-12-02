
namespace HomeWork7
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPlus1 = new System.Windows.Forms.Button();
            this.btnX2 = new System.Windows.Forms.Button();
            this.lbUserNumber = new System.Windows.Forms.Label();
            this.lbComputerNumber = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.менюFormMain = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUndo = new System.Windows.Forms.Button();
            this.lbCounter = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(167, 35);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 44);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Рестарт";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnRestart_Click);
            // 
            // btnPlus1
            // 
            this.btnPlus1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnPlus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus1.Location = new System.Drawing.Point(13, 35);
            this.btnPlus1.Name = "btnPlus1";
            this.btnPlus1.Size = new System.Drawing.Size(71, 44);
            this.btnPlus1.TabIndex = 0;
            this.btnPlus1.Text = "+1";
            this.btnPlus1.UseVisualStyleBackColor = true;
            this.btnPlus1.Click += new System.EventHandler(this.BtnPlus_Click);
            // 
            // btnX2
            // 
            this.btnX2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnX2.Location = new System.Drawing.Point(90, 35);
            this.btnX2.Name = "btnX2";
            this.btnX2.Size = new System.Drawing.Size(71, 44);
            this.btnX2.TabIndex = 0;
            this.btnX2.Text = "х2";
            this.btnX2.UseVisualStyleBackColor = true;
            this.btnX2.Click += new System.EventHandler(this.BtnMultiply_Click);
            // 
            // lbUserNumber
            // 
            this.lbUserNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbUserNumber.ForeColor = System.Drawing.Color.Maroon;
            this.lbUserNumber.Location = new System.Drawing.Point(9, 115);
            this.lbUserNumber.Name = "lbUserNumber";
            this.lbUserNumber.Size = new System.Drawing.Size(240, 24);
            this.lbUserNumber.TabIndex = 1;
            this.lbUserNumber.Text = "Текущее число:";
            this.lbUserNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbComputerNumber
            // 
            this.lbComputerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbComputerNumber.Location = new System.Drawing.Point(9, 91);
            this.lbComputerNumber.Name = "lbComputerNumber";
            this.lbComputerNumber.Size = new System.Drawing.Size(240, 24);
            this.lbComputerNumber.TabIndex = 1;
            this.lbComputerNumber.Text = "Получите число:";
            this.lbComputerNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюFormMain});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(258, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "Меню";
            // 
            // менюFormMain
            // 
            this.менюFormMain.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemGame,
            this.menuItemExit});
            this.менюFormMain.Name = "менюFormMain";
            this.менюFormMain.Size = new System.Drawing.Size(53, 20);
            this.менюFormMain.Text = "Меню";
            // 
            // menuItemGame
            // 
            this.menuItemGame.Name = "menuItemGame";
            this.menuItemGame.Size = new System.Drawing.Size(112, 22);
            this.menuItemGame.Text = "Играть";
            this.menuItemGame.Click += new System.EventHandler(this.menuItemGame_Click);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(112, 22);
            this.menuItemExit.Text = "Выход";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUndo.Location = new System.Drawing.Point(167, 169);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(86, 24);
            this.btnUndo.TabIndex = 0;
            this.btnUndo.TabStop = false;
            this.btnUndo.Text = "Назад";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // lbCounter
            // 
            this.lbCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbCounter.ForeColor = System.Drawing.Color.Maroon;
            this.lbCounter.Location = new System.Drawing.Point(9, 139);
            this.lbCounter.Name = "lbCounter";
            this.lbCounter.Size = new System.Drawing.Size(240, 24);
            this.lbCounter.TabIndex = 3;
            this.lbCounter.Text = "Кол-во кликов:";
            this.lbCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 253);
            this.Controls.Add(this.lbCounter);
            this.Controls.Add(this.lbComputerNumber);
            this.Controls.Add(this.lbUserNumber);
            this.Controls.Add(this.btnX2);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnPlus1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.menuStrip);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Удвоитель";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPlus1;
        private System.Windows.Forms.Button btnX2;
        private System.Windows.Forms.Label lbUserNumber;
        private System.Windows.Forms.Label lbComputerNumber;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem менюFormMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemGame;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Label lbCounter;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
    }
}

