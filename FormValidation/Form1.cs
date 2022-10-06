using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormValidation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool valid = false;
            int number = 0;
            //at if the first statement it is always the TRUE conditional

            if (!int.TryParse(textBoxNumber.Text,out number))
            {
                MessageBox.Show("The value must be numeric", "Validation");
                valid = false;
                textBoxNumber.Clear();
                textBoxNumber.Focus();
                return;
            }

            for (int i = 0; i <= listBoxNumber.Items.Count-1 ; i++)
            {
                //homework, tell WHY I put count-1 
                // and TRY your BEST LOVE to not allow duplicate values
                //at listbox
            }
            
        }
    }
}
