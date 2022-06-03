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
            if (x_turn)
                lblturn.Text = "X Turn";
            else
                lblturn.Text = "O Turn";


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