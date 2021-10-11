using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitcheckgui
{
    public partial class Form1 : Form
    {
        public class Globals
        {
            public static int enteredNumber = 0;
            public static bool bitState = false ;
            public static int bitToCheck = 0;
            public static string strBinary;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void lblEnterNumber(object sender, EventArgs e)
        {

        }

        private void btnUnsetBit_Click(object sender, EventArgs e)
        {
            Globals.enteredNumber &= ~(1 << Globals.bitToCheck);
            txtEnterNumber.Text = Globals.enteredNumber.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtEnterNumber_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtEnterNumber.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please Enter Numbers Only!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEnterNumber.Text = "0";
                }

                if (txtEnterNumber.Text == "")
                {
                    MessageBox.Show("Please Enter Numbers Only!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEnterNumber.Text = "0";
                }

                Globals.enteredNumber = Int32.Parse(txtEnterNumber.Text);
                Globals.strBinary = Convert.ToString(Globals.enteredNumber, 2);
                lblBinaryOutput.Text = Globals.strBinary;

                int isBitSet = Globals.enteredNumber & (1 << Globals.bitToCheck);

                if (isBitSet > 0)
                {
                    Globals.bitState = true;
                    lblBitState.Text = "Bit Is Set";
                }
                else
                {
                    Globals.bitState = false;
                    lblBitState.Text = "Bit Is Not Set";
                }
            }

            catch
            {
                MessageBox.Show("Please Enter Numbers Only!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEnterNumber.Text = "0";
            }
        }

        private void txtBit_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(txtBit.Text, "[^0-9]")) // If not 0-9
                {
                    MessageBox.Show("Please Enter Numbers Only!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBit.Text = "0";
                }

                if (txtBit.Text == "")
                {
                    MessageBox.Show("Please Enter Numbers Only!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBit.Text = "0";
                }

                Globals.bitToCheck = Int32.Parse(txtBit.Text);

                int isBitSet = Globals.enteredNumber & (1 << Globals.bitToCheck);
                if (isBitSet > 0)
                {
                    Globals.bitState = true;
                    lblBitState.Text = "Bit Is Set";
                }
                else
                {
                    Globals.bitState = false;
                    lblBitState.Text = "Bit Is Not Set";
                }
            }
            catch
            {
                MessageBox.Show("Please enter only numbers.");
                txtBit.Text = "0";
            }
        }

        private void btnCheckBit_Click(object sender, EventArgs e)
        {
            int isBitSet = Globals.enteredNumber & (1 << Globals.bitToCheck);
            if (isBitSet > 0)
            {
                Globals.bitState = true;
                lblBitState.Text = "Bit Is Set";
            }
            else
            {
                Globals.bitState = false;
                lblBitState.Text = "Bit Is Not Set";
            }
        }

        private void btnSetBit_Click(object sender, EventArgs e)
        {
            Globals.enteredNumber |= 1 << Globals.bitToCheck;
            txtEnterNumber.Text = Globals.enteredNumber.ToString();
        }

        private void btnToggleBit_Click(object sender, EventArgs e)
        {
            Globals.enteredNumber ^= 1 << Globals.bitToCheck;
            txtEnterNumber.Text = Globals.enteredNumber.ToString();
        }
    }
}
