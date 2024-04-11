using System.Text;
namespace WordGuessApplication
{
    public partial class frmGuessWord : Form
    {
        public frmGuessWord()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StringBuilder wordGuess = new StringBuilder("lucky");

            for (int i = 0; i < wordGuess.Length; i++)
            {
                if (i == 0 || i == wordGuess.Length - 1)
                {
                    continue;
                }
                wordGuess.Replace(wordGuess[i], '?');
            }
            label1.Text = wordGuess.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder wordGuess = new StringBuilder("lucky");

            string guessInput = textBox1.Text;

            if (wordGuess.Equals(guessInput))
            {
                label1.Text = wordGuess.ToString();
                MessageBox.Show("Correct guess!"); 
            }
            else
            {
                listBox1.Items.Add(guessInput); 
                MessageBox.Show("Wrong guess!\nTry again.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
