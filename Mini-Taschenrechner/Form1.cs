namespace Mini_Taschenrechner
{
    public partial class Form1 : Form
    {
        private double x;

        public Form1()
        {
            InitializeComponent();
        }

        private void T_TextChanged(object sender, EventArgs e)
        {
            try
            {
                x = Convert.ToDouble(T.Text);
            }
            catch
            {
                T.Text = "";
                x = 0;
            }
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if(T.Text.Length != 0)
                T.Text = T.Text.Substring(0, T.Text.Length - 1);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {   T.Text = "";    }

        private void btnSinus_Click(object sender, EventArgs e)
        {
            if (chkInv.Checked)
            {
                T.Text = "" + Math.Asin(x) * 180 / Math.PI;
                chkInv.Checked = false;
            }
            else
                T.Text = "" + Math.Sin(x / 180.0 * Math.PI);
        }

        private void btnCosinus_Click(object sender, EventArgs e)
        {
            if (chkInv.Checked)
            {
                T.Text = "" + Math.Acos(x) * 180 / Math.PI;
                chkInv.Checked = false;
            }
            else
                T.Text = "" + Math.Cos(x / 180.0 * Math.PI);
        }

        private void btnTangens_Click(object sender, EventArgs e)
        {
            if (chkInv.Checked)
            {
                T.Text = "" + Math.Atan(x) * 180 / Math.PI;
                chkInv.Checked = false;
            }
            else
                T.Text = "" + Math.Tan(x / 180.0 * Math.PI);
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            if (chkInv.Checked)
            {
                T.Text = "" + Math.Exp(x);
                chkInv.Checked = false;
            }
            else
                T.Text = "" + Math.Log(x);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (chkInv.Checked)
            {
                T.Text = "" + Math.Pow(10.0, x);
                chkInv.Checked = false;
            }
            else
                T.Text = "" + Math.Log10(x);
        }

        private void btnPI_Click(object sender, EventArgs e)
        {   T.Text = "" + Math.PI;  }

        private void btnE_Click(object sender, EventArgs e)
        {   T.Text = "" + Math.E;   }

        private void btnCeiling_Click(object sender, EventArgs e)
        {   T.Text = "" + Math.Ceiling(x);  }

        private void btnFloor_Click(object sender, EventArgs e)
        {   T.Text = "" + Math.Floor(x);    }

        private void btnRound_Click(object sender, EventArgs e)
        {   T.Text = "" + Math.Round(x);    }

        private void btnTruncate_Click(object sender, EventArgs e)
        {   T.Text = "" + Math.Truncate(x); }

        private void btnWurzel_Click(object sender, EventArgs e)
        {
            if (chkInv.Checked)
            {
                T.Text = "" + Math.Pow(x, 2.0);
                chkInv.Checked = false;
            }
            else
                T.Text = "" + Math.Sqrt(x);
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {   T.Text = "" + x * -1.0; }

        private void btnKehrwert_Click(object sender, EventArgs e)
        {   T.Text = "" + 1.0 / x;  }

        private void btnZiffer_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            T.Text += b.Text;
        }

        private void btnKomma_Click(object sender, EventArgs e)
        {
            if (T.Text.IndexOf(",") < 0)
                T.Text += ",";
        }
    }
}