using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Chris Collins, October 4th 2022, Lab 2 includes a multiplier with a picture and short description of my cat Eleanor 
namespace CollinsLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            picPet.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the form.
            Application.Exit();
        }

        private void btnPicture_Click(object sender, EventArgs e)
        {
            //Show the picture. Hide the data label.
            picPet.Show();
            lblData.Hide();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            //Hide picture and data label.
            picPet.Hide();
            lblData.Hide();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            txtMult.Clear();
            lblResult.Text = "";
            txtNum.Focus();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            //Change Text
            lblData.Text = "My topic is about my cat Eleanor. She is the best kitty in the entire world and has been with my through difficult times.\n\n" +
                "Eleanor is 6 years old now and has been with me for 5 years. I got her in Montreal and moved her down to New Brunswick in 2018 when I started work at Point Lepreau.\n\n" +
                "Eleanor is very quiet in certain aspects, she hardly ever meows unless theres wet food involved and even then it's very soft. But she purrs louder than any cat I've ever heard. Some mornings she wakes me up by just sitting on my pillow and purring.";

            //Show Text
            lblData.Visible = true;
            picPet.Hide();
        }

        private void picPet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Eleanor investigating the washing machine.");
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //Declare 3 local variables - ints
            int operand1, operand2, answer;

            //Read from textboxes, put into 2 ints - conversion required
            operand1 = Convert.ToInt32(txtNum.Text);
            operand2 = Convert.ToInt32(txtMult.Text);

            //do the math
            answer = operand1 * operand2;

            //Display the answer - conversion required
            lblResult.Text = answer.ToString();
        }
    }
}
