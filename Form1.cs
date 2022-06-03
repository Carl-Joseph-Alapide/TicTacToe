namespace TicTacToe
{
    public partial class TicTacToe : Form
    { Boolean x_turn= true;

        public TicTacToe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        Button All = (Button)sender;    //tried to synchronize the buttons

            if (x_turn)
                All.Text = "X";
            else 
                All.Text = "O";
        All.Enabled = false;
        x_turn = !x_turn;
         //labeling the turns   
            if (x_turn)
                lblturn.Text = "X Turn";
            else
                lblturn.Text = "O Turn";

            Results();
            
        }
        private void Results()
        {
            //checking the winnner
            //L = left column C = center column R = Right Column 
            //vertical winner
            Boolean winner = false;
            if ((btnL1.Text == btnL2.Text) && (btnL2.Text == btnL3.Text) && (!btnL1.Enabled) && (!btnL2.Enabled) && (!btnL3.Enabled))
                winner = true;
            else if ((btnC1.Text == btnC2.Text) && (btnC2.Text == btnC3.Text) && (!btnC1.Enabled) && (!btnC2.Enabled) && (!btnC3.Enabled))
                winner = true;
            else if ((btnR1.Text == btnR2.Text) && (btnR2.Text == btnR3.Text) && (!btnR1.Enabled) && (!btnR2.Enabled) && (!btnR3.Enabled))
                winner = true;
            //horizontal winner
            else if ((btnL1.Text == btnC1.Text) && (btnC1.Text == btnR1.Text) && (!btnL1.Enabled) && (!btnC1.Enabled) && (!btnR1.Enabled))
                winner = true;
            else if ((btnL2.Text == btnC2.Text) && (btnC2.Text == btnR2.Text) && (!btnL2.Enabled) && (!btnC2.Enabled) && (!btnR2.Enabled))
                winner = true;
            else if ((btnL3.Text == btnC3.Text) && (btnC3.Text == btnR3.Text) && (!btnL3.Enabled) && (!btnC3.Enabled) && (!btnR3.Enabled))
                winner = true;
            //diagonal winner
            else if ((btnL1.Text == btnC2.Text) && (btnC2.Text == btnR3.Text) && (!btnL1.Enabled) && (!btnC2.Enabled) && (!btnR3.Enabled))
                winner = true;
            else if ((btnR1.Text == btnC2.Text) && (btnC2.Text == btnL3.Text) && (!btnR1.Enabled) && (!btnC2.Enabled) && (!btnL3.Enabled))
                winner = true;
            else if ((!btnL1.Enabled) && (!btnL2.Enabled) && (!btnL3.Enabled) && (!btnC1.Enabled) && (!btnC2.Enabled) && (!btnC3.Enabled) && (!btnR1.Enabled) && (!btnR2.Enabled) && (!btnR3.Enabled))
                MessageBox.Show("Draw", "Good Game");
            if (winner)
            {
                Disable_the_remaining_buttons();
                if (x_turn)
                    MessageBox.Show("The winner is O", "Congratulations");
                else
                    MessageBox.Show("The winner is X", "Congratulations");
            }
        }
        private void Disable_the_remaining_buttons()
        {
            btnL1.Enabled = false;
            btnL2.Enabled = false;
            btnL3.Enabled = false;
            btnC1.Enabled = false;
            btnC2.Enabled = false;
            btnC3.Enabled = false;
            btnR1.Enabled = false;
            btnR2.Enabled = false;
            btnR3.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("welcome to TicTacToe","Greetings Players");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            //re-enable the buttons
            btnL1.Enabled = true;
            btnL2.Enabled = true;
            btnL3.Enabled = true;
            btnC1.Enabled = true;
            btnC2.Enabled = true;
            btnC3.Enabled = true;
            btnR1.Enabled = true;
            btnR2.Enabled = true;
            btnR3.Enabled = true;
            //reset the text on buttons
            btnL1.Text = "";
            btnL2.Text = "";
            btnL3.Text = "";
            btnC1.Text = "";
            btnC2.Text = "";
            btnC3.Text = "";
            btnR1.Text = "";
            btnR2.Text = "";
            btnR3.Text = "";
        }

        private void lblturn_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblver_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}