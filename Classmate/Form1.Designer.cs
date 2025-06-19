namespace ClassmatesRPG
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox picPlayer1;
        private System.Windows.Forms.PictureBox picPlayer2;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.ComboBox cbFighter1;
        private System.Windows.Forms.ComboBox cbFighter2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblHealth1;
        private System.Windows.Forms.Label lblHealth2;
        private System.Windows.Forms.ListBox lstBattleLog;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.picPlayer1 = new System.Windows.Forms.PictureBox();
            this.picPlayer2 = new System.Windows.Forms.PictureBox();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.cbFighter1 = new System.Windows.Forms.ComboBox();
            this.cbFighter2 = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblHealth1 = new System.Windows.Forms.Label();
            this.lblHealth2 = new System.Windows.Forms.Label();
            this.lstBattleLog = new System.Windows.Forms.ListBox();

            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).BeginInit();
            this.SuspendLayout();

            // PictureBoxes
            this.picPlayer1.BackColor = System.Drawing.Color.LightBlue;
            this.picPlayer1.Location = new System.Drawing.Point(50, 50);
            this.picPlayer1.Size = new System.Drawing.Size(100, 100);

            this.picPlayer2.BackColor = System.Drawing.Color.LightCoral;
            this.picPlayer2.Location = new System.Drawing.Point(600, 50);
            this.picPlayer2.Size = new System.Drawing.Size(100, 100);

            // TextBoxes and ComboBoxes
            this.txtName1.Location = new System.Drawing.Point(50, 160);
            this.txtName1.Size = new System.Drawing.Size(120, 23);

            this.txtName2.Location = new System.Drawing.Point(600, 160);
            this.txtName2.Size = new System.Drawing.Size(120, 23);

            this.cbFighter1.Location = new System.Drawing.Point(50, 190);
            this.cbFighter1.Size = new System.Drawing.Size(120, 23);

            this.cbFighter2.Location = new System.Drawing.Point(600, 190);
            this.cbFighter2.Size = new System.Drawing.Size(120, 23);

            // Start Button
            this.btnStart.Location = new System.Drawing.Point(330, 160);
            this.btnStart.Size = new System.Drawing.Size(120, 30);
            this.btnStart.Text = "Start Battle";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // Health Labels
            this.lblHealth1.Location = new System.Drawing.Point(50, 220);
            this.lblHealth1.Size = new System.Drawing.Size(120, 23);
            this.lblHealth1.Text = "Health: 100";

            this.lblHealth2.Location = new System.Drawing.Point(600, 220);
            this.lblHealth2.Size = new System.Drawing.Size(120, 23);
            this.lblHealth2.Text = "Health: 100";

            // Battle Log
            this.lstBattleLog.Location = new System.Drawing.Point(200, 260);
            this.lstBattleLog.Size = new System.Drawing.Size(400, 150);

            // Form1
            this.ClientSize = new System.Drawing.Size(784, 450);
            this.Controls.Add(this.picPlayer1);
            this.Controls.Add(this.picPlayer2);
            this.Controls.Add(this.txtName1);
            this.Controls.Add(this.txtName2);
            this.Controls.Add(this.cbFighter1);
            this.Controls.Add(this.cbFighter2);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblHealth1);
            this.Controls.Add(this.lblHealth2);
            this.Controls.Add(this.lstBattleLog);
            this.Text = "Classmates RPG Battle Simulator";

            ((System.ComponentModel.ISupportInitialize)(this.picPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
