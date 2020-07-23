using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binary
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void background_overlay_Click(object sender, EventArgs e)
        {

        }

        private void generate_code_Click(object sender, EventArgs e)
        {
            int decimal_number;
            string binary_number, hex_number;

            // Generate a random integer
            decimal_number = new Random().Next(1, 10);

            // Converting to binary
            binary_number = Convert.ToString(Convert.ToInt32(decimal_number.ToString(), 10), 2);

            // Converting to hex
            hex_number = decimal_number.ToString("X");

            // Display the code
            decimal_code.Text = decimal_number.ToString();

            // Update and hide the other code
            binary_code.Text = binary_number;
            hex_code.Text = hex_number;

            binary_code.Visible = false;
            hex_code.Visible = false;
        }

        private void verify_code_Click(object sender, EventArgs e)
        {
            if (binary_code.Text == binary_answer.Text && hex_code.Text == hex_answer.Text) {
                // Change the status
                status.Text = "O COMPLETE";
                status.ForeColor = System.Drawing.Color.LightGreen;

                // Show the code
                binary_code.Visible = true;
                hex_code.Visible = true;

                // Change the background
                background_overlay.BackgroundImage = Properties.Resources.background;
            }
            else if (binary_code.Text != binary_answer.Text && hex_code.Text == hex_answer.Text) {
                // Change the status
                status.Text = "X BINARY ERROR";

                // Change the background
                background_overlay.BackgroundImage = Properties.Resources.explode;
            }
            else if (binary_code.Text == binary_answer.Text && hex_code.Text != hex_answer.Text) {
                // Change the status
                status.Text = "X HEX ERROR";

                // Change the background
                background_overlay.BackgroundImage = Properties.Resources.explode;
            }
            else {
                // Change the status
                status.Text = "X CODE ERROR";

                // Change the background
                background_overlay.BackgroundImage = Properties.Resources.explode;
            }
        }
    }
}
