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
            //checking the winnner
            Boolean winner = false;
                if ((btnL1 == btnL2) == (btnL1 == btnL3) && (All.Enabled))
                winner = true;
            else if ((btnC1 == btnC2) == (btnC1 == btnC3) && (All.Enabled))
                winner = true;
            else if ((btnR1 == btnR2) == (btnR1 == btnR3) && (All.Enabled))
                    winner = true;
            if (winner)
                if (x_turn)
                    MessageBox.Show("The winner is O","Congratulations");
                else
                    MessageBox.Show("The winner is X","Congratulations");


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void lblturn_Click(object sender, EventArgs e)
        {
            
        }
    }
}