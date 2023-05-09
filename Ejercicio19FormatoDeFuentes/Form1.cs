using System.Drawing.Text;

namespace Ejercicio19FormatoDeFuentes
{
    public partial class Form1 : Form
    {
        private FontFamily[] fuentes;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fuentes = new InstalledFontCollection().Families;
            foreach (FontFamily x in fuentes)
            {
                lbox_Fuentes.Items.Add(x.Name);
            }
          
        }

        private void buttonIncrese_Click(object sender, EventArgs e)
        {
            this.Width += 100;
            this.Height += 100;
        }

        private void buttonReduce_Click(object sender, EventArgs e)
        {
            this.Width -= 100;
            this.Height -= 100;
        }

        private void buttonGreenFrom_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void buttonBlueForm_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void buttonRedForm_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(comboBox1.SelectedItem.ToString(), out int selectedNumber))
            {
                Font currentFont = labelText.Font;
                Font newFont = new Font(currentFont.FontFamily, selectedNumber, currentFont.Style);
                labelText.Font = newFont;

                // labelText.Font = new Font(labelText.Font.FontFamily, selectedNumber);
            }
        }

        private void buttonGreenText_Click(object sender, EventArgs e)
        {
            labelText.ForeColor= Color.Green;
        }

        private void buttonBlueText_Click(object sender, EventArgs e)
        {
            labelText.ForeColor = Color.Blue;
        }

        private void buttonRedText_Click(object sender, EventArgs e)
        {
            labelText.ForeColor = Color.Red;
        }

        private void buttonHidenText_Click(object sender, EventArgs e)
        {
            labelText.Visible = false;
        }

        private void buttonShowText_Click(object sender, EventArgs e)
        {
            labelText.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBold.Checked)
            {
                labelText.Font = new Font(labelText.Font, labelText.Font.Style | FontStyle.Bold);
            }
            else
            {
                labelText.Font = new Font(labelText.Font, labelText.Font.Style ^ FontStyle.Bold);
            }
        }

        private void checkItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (checkItalic.Checked)
            {
                labelText.Font = new Font(labelText.Font, labelText.Font.Style | FontStyle.Italic);
            }
            else
            {
                labelText.Font = new Font(labelText.Font, labelText.Font.Style ^ FontStyle.Italic);
            }
        }

        private void checkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            if (checkUnderline.Checked)
            {
                labelText.Font = new Font(labelText.Font, labelText.Font.Style | FontStyle.Underline);
            }
            else
            {
                labelText.Font = new Font(labelText.Font, labelText.Font.Style ^ FontStyle.Underline);
            }
        }

        private void lbox_Fuentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            


             labelText.Font = new Font(fuentes[lbox_Fuentes.SelectedIndex].Name, labelText.Font.Size);

        }

        private void buttonCloseText_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}