using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClassmatesRPG
{
    public partial class Form1 : Form
    {
        StudentFighter fighter1;
        StudentFighter fighter2;
        bool turn = true;
        Timer moveTimer = new Timer();
        int step = 0;
        int maxSteps = 10;
        int offset = 5;

        public Form1()
        {
            InitializeComponent();
            cbFighter1.Items.AddRange(new string[] { "Debugger Dana", "QuizMaster Quincy" });
            cbFighter2.Items.AddRange(new string[] { "Debugger Dana", "QuizMaster Quincy" });
            moveTimer.Interval = 30;
            moveTimer.Tick += MoveCharacters;
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picPlayer1.Image = Image.FromFile(@"C:\Users\Darren\Pictures\StickmanBlue.png");
            picPlayer2.Image = Image.FromFile(@"C:\Users\Darren\Pictures\StickmanRed.png");
            picPlayer1.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlayer2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private StudentFighter CreateFighter(string type, string name)
        {
            if (type == "Debugger Dana")
                return new StickmanRed(name);
            else if (type == "QuizMaster Quincy")
                return new StickmanBlue(name);
            else
                throw new Exception("Unknown fighter type.");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName1.Text) || string.IsNullOrWhiteSpace(txtName2.Text))
                    throw new Exception("Please enter both names.");
                if (cbFighter1.SelectedIndex == -1 || cbFighter2.SelectedIndex == -1)
                    throw new Exception("Please select both fighters.");

                fighter1 = CreateFighter(cbFighter1.Text, txtName1.Text);
                fighter2 = CreateFighter(cbFighter2.Text, txtName2.Text);

                lblHealth1.Text = $"Health: {fighter1.Health}";
                lblHealth2.Text = $"Health: {fighter2.Health}";
                lstBattleLog.Items.Clear();

                StartTurn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void StartTurn()
        {
            step = 0;
            moveTimer.Start();
        }

        private void MoveCharacters(object sender, EventArgs e)
        {
            if (turn)
            {
                if (step < maxSteps)
                    picPlayer1.Left += offset;
                else if (step < maxSteps * 2)
                    picPlayer1.Left -= offset;
            }
            else
            {
                if (step < maxSteps)
                    picPlayer2.Left -= offset;
                else if (step < maxSteps * 2)
                    picPlayer2.Left += offset;
            }

            step++;

            if (step >= maxSteps * 2)
            {
                moveTimer.Stop();
                PerformAttack();
            }
        }

        private void PerformAttack()
        {
            int damage = turn ? fighter1.Attack() : fighter2.Attack();
            string attacker = turn ? fighter1.Name : fighter2.Name;
            string defender = turn ? fighter2.Name : fighter1.Name;

            if (turn)
                fighter2.TakeDamage(damage);
            else
                fighter1.TakeDamage(damage);

            lstBattleLog.Items.Add($"{attacker} attacks {defender} for {damage} damage!");
            lblHealth1.Text = $"Health: {fighter1.Health}";
            lblHealth2.Text = $"Health: {fighter2.Health}";

            if (fighter1.Health <= 0 || fighter2.Health <= 0)
            {
                string winner = fighter1.Health > 0 ? fighter1.Name : fighter2.Name;
                lstBattleLog.Items.Add($"🎉 {winner} wins the battle!");
                return;
            }

            turn = !turn;
            StartTurn();
        }
    }
}
