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
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}