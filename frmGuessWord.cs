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
            StringBuilder wordGuess = new StringBuilder("computer");

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
            StringBuilder wordGuess = new StringBuilder("computer");

            string guessInput = textBox1.Text;

            if (wordGuess.Equals(guessInput))
            {
                MessageBox.Show("Yay you guessed the word!");
                label1.Text = wordGuess.ToString();
            }
            else
            {
                MessageBox.Show("Aww wrong answer. Try again.");
                listBox1.Items.Add(guessInput);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
