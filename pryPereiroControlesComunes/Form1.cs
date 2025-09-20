namespace pryPereiroControlesComunes
{
    public partial class frmEjemplo : Form
    {
        public frmEjemplo()
        {
            InitializeComponent();
        }

        private void frmEjemplo_Load(object sender, EventArgs e)
        {

        }

        private void chkRojo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRojo.Checked == true)
            {
                lblEjemplo.ForeColor = Color.Red;
                if (chkAzul.Checked == true)
                {
                    lblEjemplo.ForeColor = Color.Violet;
                }
                if (chkAmarillo.Checked == true)
                {
                    lblEjemplo.ForeColor = Color.Orange;
                }
            }
            else
            {
                lblEjemplo.ForeColor = Color.Black;
            }
        }

        private void chkAzul_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAzul.Checked == true)
            {
                lblEjemplo.ForeColor = Color.Blue;
                if (chkRojo.Checked == true)
                {
                    lblEjemplo.ForeColor = Color.Violet;
                }
                if (chkAmarillo.Checked == true)
                {
                    lblEjemplo.ForeColor = Color.Green;
                }
            }
            else
            {
                lblEjemplo.ForeColor = Color.Black;
            }

        }

        private void chkAmarillo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAmarillo.Checked == true)
            {
                lblEjemplo.ForeColor = Color.Yellow;
                if(chkAzul.Checked == true)
                {
                    lblEjemplo.ForeColor = Color.Green;
                }
                if(chkRojo.Checked == true)
                {
                    lblEjemplo.ForeColor = Color.Orange;
                }
            }
            else
            {
                lblEjemplo.ForeColor = Color.Black;
            }

            }
        }
    }

    

