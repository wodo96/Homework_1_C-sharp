namespace Homework_1_C_sharp
{
    public partial class Form1 : Form
    {
        bool isBeenSaved = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.richTextBox1.Visible = false;
            this.richTextBox1.Enabled = false;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button1.AutoSize = true;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
            if(this.richTextBox1.Text.Length == 0 && !isBeenSaved)
            {
                this.button1.Visible = false;
                this.button2.Visible = false;
            }
            else
            {
                this.button1.Visible = true;
                this.button2.Visible = true;

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked)
            {
                this.richTextBox1.Visible = true;
                this.richTextBox1.Enabled = true;
            }
            else
            {
                this.richTextBox1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(this.richTextBox1.Text.Length == 0))
            {
                this.isBeenSaved = true;
                this.labelResponseOutput.Visible = true;
                this.labelResponseOutput.Text = this.richTextBox1.Text;
                this.button1.BackColor = System.Drawing.Color.Green;
                this.button1.Text = "Saved!";
                this.labelResponseOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            }
            else
            {
                this.button1.Text = "You should write something at least!";
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.Text = "Click me!";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            if (!(this.button1.BackColor.Equals(System.Drawing.Color.Green)))
            {
                this.button1.Text = "Save";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Text = "Save";
            this.labelResponseOutput.Visible = false;
        }
    }

}