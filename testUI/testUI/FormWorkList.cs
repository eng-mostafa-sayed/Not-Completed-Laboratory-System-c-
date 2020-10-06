using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace testUI
{
    public partial class FormWorkList : Form
    {
        public FormWorkList()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        float PriceValue=0;
 //       SqlConnection con = new SqlConnection(@"Data Source=MR_ROBOT\SQLDEVELOPER2019;Initial Catalog=patients;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=MR_ROBOT\\SQLDEVELOPER2019;Initial Catalog=patients;Integrated Security=True");
            con.Open();
            //string query = "INSERT INTO patients(Namex,Agex,Expx,pricex,Genderx,cashex) VALUES(" +
            //"'" + NameText.Text + "','" + int.Parse(AgeText.Text) + "','" + ExpText.Text + "','" + int.Parse(CashText.Text) + "','" + GenderText.Text + "','" + int.Parse(CashText.Text) + "')";  
            // SqlDataAdapter SDA = new SqlDataAdapter(query, con);


            string query = "INSERT INTO patients(Namex,Agex,Expx,Pricex,Genderx,Cashx,Exp2x,Exp3x,Exp4x)" +
                " VALUES('"+NameText.Text+ "','" + AgeText.Text + "','" 
                + ExpText.Text + "','" + PriceText.Text + "','" + GenderText.Text + "','" 
                + CashText.Text + "','" + Exp2Text.Text + "','" + Exp3Text.Text + "','" + Exp4Text.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
              cmd.ExecuteNonQuery();
            MessageBox.Show("Done", "Saved Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void ExpText_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ExpText.Text == "تحليل (C.B.C)") { PriceValue += 60;PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "تحليل (E.S.R)") { PriceValue += 40; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == " تحاليل ( BT وAPTT و PT))") { PriceValue += 80; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "تحليل (C.B.C)") { PriceValue += 120; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "تحليل (G6PD )") { PriceValue += 100; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "تحليل إنزيم (AST)") { PriceValue += 50; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "تحليل إنزيم (ALT)") { PriceValue += 90; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "تحليل إنزيم (LDH)") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "إنزيم (Lipase)") { PriceValue += 400; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "الغدة الدرقية") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "الغدة الكظرية") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "التناسلية") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "الغدة النخامية") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "البنكرياس") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "إرثروبويتين") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "الرينين") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "الكالسيتريول") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
        }

        private void Exp2Text_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ExpText.Text == "تحليل (C.B.C)") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "تحليل (E.S.R)") { PriceValue += 40; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == " تحاليل ( BT وAPTT و PT))") { PriceValue += 80; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "تحليل (C.B.C)") { PriceValue += 120; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "تحليل (G6PD )") { PriceValue += 100; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "تحليل إنزيم (AST)") { PriceValue += 50; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "تحليل إنزيم (ALT)") { PriceValue += 90; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "تحليل إنزيم (LDH)") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "إنزيم (Lipase)") { PriceValue += 400; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "الغدة الدرقية") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "الغدة الكظرية") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "التناسلية") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "الغدة النخامية") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "البنكرياس") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "إرثروبويتين") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "الرينين") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "الكالسيتريول") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
        }

        private void Exp3Text_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ExpText.Text == "تحليل (C.B.C)") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "تحليل (E.S.R)") { PriceValue += 40; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == " تحاليل ( BT وAPTT و PT))") { PriceValue += 80; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "تحليل (C.B.C)") { PriceValue += 120; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "تحليل (G6PD )") { PriceValue += 100; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "تحليل إنزيم (AST)") { PriceValue += 50; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "تحليل إنزيم (ALT)") { PriceValue += 90; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "تحليل إنزيم (LDH)") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "إنزيم (Lipase)") { PriceValue += 400; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "الغدة الدرقية") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "الغدة الكظرية") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "التناسلية") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "الغدة النخامية") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "البنكرياس") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "إرثروبويتين") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "الرينين") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "الكالسيتريول") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
        }

        private void Exp4Text_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ExpText.Text == "تحليل (C.B.C)") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "تحليل (E.S.R)") { PriceValue += 40; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == " تحاليل ( BT وAPTT و PT))") { PriceValue += 80; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "تحليل (C.B.C)") { PriceValue += 120; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "تحليل (G6PD )") { PriceValue += 100; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "تحليل إنزيم (AST)") { PriceValue += 50; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "تحليل إنزيم (ALT)") { PriceValue += 90; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "تحليل إنزيم (LDH)") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "إنزيم (Lipase)") { PriceValue += 400; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "الغدة الدرقية") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "الغدة الكظرية") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "التناسلية") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "الغدة النخامية") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "البنكرياس") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "إرثروبويتين") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "الرينين") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
            if (ExpText.Text == "الكالسيتريول") { PriceValue += 60; PriceText.Text = PriceValue.ToString(); }
        }
    }
}
