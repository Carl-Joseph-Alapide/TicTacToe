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
        //first click is true
            if (x_turn)
                btnL1.Text = "X";
            else
                btnL1.Text = "O";
        x_turn = false; 
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
    }
}