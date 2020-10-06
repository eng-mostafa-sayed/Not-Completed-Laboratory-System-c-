using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelRightSide.Controls.Add(childForm);
            panelRightSide.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FormAddmin());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FormReg());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FormFinancial());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FormWorkList());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new FormSearch());
        }
    }
}
