using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* PROG2370-SEC6
 * ASSIGNMENT 3: Tic-Tac-Toe
 * Nicholas Parker - #8464257
 */

namespace NParkerAssignment3
{
    public partial class Form1 : Form
    {
        int i = 0;
        PictureBox senderPictureBox;

        public Form1()
        {
            InitializeComponent();
        }

        ///decides whether player is x or o and changes the text of the picturebox to that letter
        ///calls as action for each picturebox click
        ///if int i is even player is x else player is o, i starts at 0 and increases every click
        ///disables picturebox from being clicked again once clicked
        private void _Decision(object sender, EventArgs e)
        {
            senderPictureBox = sender as PictureBox;
            senderPictureBox.BringToFront();
            senderPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            if (i % 2 == 0)
            {
                senderPictureBox.Text = "X";
                senderPictureBox.Image = NParkerAssignment3.Properties.Resources.x;
                senderPictureBox.Enabled = false;

            }
            else
            {
                senderPictureBox.Text = "O";
                senderPictureBox.Image = NParkerAssignment3.Properties.Resources.o;
                senderPictureBox.Enabled = false;

            }

            i++;

            //if a valid line is true:
            //reset the text for all of them to the different values
            //reset the images for the pictureboxes to null
            //finally enable all of the pictureboxes to be clicked again and reset i back to 0
            //if a draw occurs follow the same steps
            if (validLine() == true)
            {
                pictureBox1.Text = "1";
                pictureBox2.Text = "2";
                pictureBox3.Text = "3";
                pictureBox4.Text = "4";
                pictureBox5.Text = "5";
                pictureBox6.Text = "6";
                pictureBox7.Text = "7";
                pictureBox8.Text = "8";
                pictureBox9.Text = "9";

                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;

                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox4.Enabled = true;
                pictureBox5.Enabled = true;
                pictureBox6.Enabled = true;
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;

                i = 0;
            }

            if (pictureBox1.Text != "1" && pictureBox2.Text != "2" && pictureBox3.Text != "3" && pictureBox4.Text != "4" && pictureBox5.Text != "5" && pictureBox6.Text != "6" && pictureBox7.Text != "7" && pictureBox8.Text != "8" && pictureBox9.Text != "9")
            {

                pictureBox1.Text = "1";
                pictureBox2.Text = "2";
                pictureBox3.Text = "3";
                pictureBox4.Text = "4";
                pictureBox5.Text = "5";
                pictureBox6.Text = "6";
                pictureBox7.Text = "7";
                pictureBox8.Text = "8";
                pictureBox9.Text = "9";

                pictureBox1.Image = null;
                pictureBox2.Image = null;
                pictureBox3.Image = null;
                pictureBox4.Image = null;
                pictureBox5.Image = null;
                pictureBox6.Image = null;
                pictureBox7.Image = null;
                pictureBox8.Image = null;
                pictureBox9.Image = null;

                pictureBox1.Enabled = true;
                pictureBox2.Enabled = true;
                pictureBox3.Enabled = true;
                pictureBox4.Enabled = true;
                pictureBox5.Enabled = true;
                pictureBox6.Enabled = true;
                pictureBox7.Enabled = true;
                pictureBox8.Enabled = true;
                pictureBox9.Enabled = true;

                i = 0;
            }
        }

        ///checks each option for a valid line
        ///if a line is valid, Messagebox.Show the winner and return true
        ///if a line is not valid, and the pictureboxes text does not all equal the default text from form load, MessageBox.Show it is a draw and return false
        public bool validLine()
        {

            if ((pictureBox1.Text == pictureBox2.Text && pictureBox2.Text == pictureBox3.Text) || (pictureBox4.Text == pictureBox5.Text && pictureBox5.Text == pictureBox6.Text) || (pictureBox7.Text == pictureBox8.Text && pictureBox8.Text == pictureBox9.Text) || (pictureBox1.Text == pictureBox5.Text && pictureBox5.Text == pictureBox9.Text) || (pictureBox3.Text == pictureBox5.Text && pictureBox5.Text == pictureBox7.Text) || (pictureBox1.Text == pictureBox4.Text && pictureBox4.Text == pictureBox7.Text) || (pictureBox2.Text == pictureBox5.Text && pictureBox5.Text == pictureBox8.Text) || (pictureBox3.Text == pictureBox6.Text && pictureBox6.Text == pictureBox9.Text))
            {
                string winner = $"{senderPictureBox.Text} Wins";
                MessageBox.Show(winner,"Tic Tac Toe",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return true;

            }
            else
            {
                if (pictureBox1.Text != "1" && pictureBox2.Text != "2" && pictureBox3.Text != "3" && pictureBox4.Text != "4" && pictureBox5.Text != "5" && pictureBox6.Text != "6" && pictureBox7.Text != "7" && pictureBox8.Text != "8" && pictureBox9.Text != "9")
                {
                    MessageBox.Show("Draw", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                return false;
            }
        }

        ///assigning the text for each picturebox to be unique
        public void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Text = "1";
            pictureBox2.Text = "2";
            pictureBox3.Text = "3";
            pictureBox4.Text = "4";
            pictureBox5.Text = "5";
            pictureBox6.Text = "6";
            pictureBox7.Text = "7";
            pictureBox8.Text = "8";
            pictureBox9.Text = "9";
        }
    }
}
