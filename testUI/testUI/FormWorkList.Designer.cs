namespace testUI
{
    partial class FormWorkList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorkList));
            this.CloseBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NameText = new System.Windows.Forms.TextBox();
            this.AgeText = new System.Windows.Forms.TextBox();
            this.GenderText = new System.Windows.Forms.ComboBox();
            this.ExpText = new System.Windows.Forms.ComboBox();
            this.CashText = new System.Windows.Forms.TextBox();
            this.Exp2Text = new System.Windows.Forms.ComboBox();
            this.Exp3Text = new System.Windows.Forms.ComboBox();
            this.Exp4Text = new System.Windows.Forms.ComboBox();
            this.PriceText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.Red;
            this.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseBtn.Font = new System.Drawing.Font("Tempus Sans ITC", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.Location = new System.Drawing.Point(57, 43);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(54, 40);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.Text = "X";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 104);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 511);
            this.panel1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(267, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save Patient";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.PriceText);
            this.groupBox1.Controls.Add(this.Exp4Text);
            this.groupBox1.Controls.Add(this.Exp3Text);
            this.groupBox1.Controls.Add(this.Exp2Text);
            this.groupBox1.Controls.Add(this.CashText);
            this.groupBox1.Controls.Add(this.ExpText);
            this.groupBox1.Controls.Add(this.GenderText);
            this.groupBox1.Controls.Add(this.AgeText);
            this.groupBox1.Controls.Add(this.NameText);
            this.groupBox1.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 16F, System.Drawing.FontStyle.Italic);
            this.groupBox1.Location = new System.Drawing.Point(3, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 363);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patient Information";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(123, 69);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(218, 31);
            this.NameText.TabIndex = 0;
            // 
            // AgeText
            // 
            this.AgeText.Location = new System.Drawing.Point(123, 122);
            this.AgeText.Name = "AgeText";
            this.AgeText.Size = new System.Drawing.Size(64, 31);
            this.AgeText.TabIndex = 1;
            // 
            // GenderText
            // 
            this.GenderText.FormattingEnabled = true;
            this.GenderText.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderText.Location = new System.Drawing.Point(123, 174);
            this.GenderText.Name = "GenderText";
            this.GenderText.Size = new System.Drawing.Size(121, 32);
            this.GenderText.TabIndex = 2;
            // 
            // ExpText
            // 
            this.ExpText.FormattingEnabled = true;
            this.ExpText.Items.AddRange(new object[] {
            "تحليل (C.B.C)",
            "تحليل (E.S.R)",
            " تحاليل ( BT وAPTT و PT)",
            "تحليل (G6PD )",
            "تحليل إنزيم (AST)",
            "تحليل إنزيم (ALT)",
            "تحليل إنزيم (LDH)",
            "إنزيم (Lipase)",
            "الغدة الدرقية",
            "الغدة الكظرية",
            "التناسلية",
            "الغدة النخامية",
            "البنكرياس",
            "إرثروبويتين",
            "الرينين",
            "الكالسيتريول"});
            this.ExpText.Location = new System.Drawing.Point(123, 235);
            this.ExpText.Name = "ExpText";
            this.ExpText.Size = new System.Drawing.Size(121, 32);
            this.ExpText.TabIndex = 3;
            // 
            // CashText
            // 
            this.CashText.Location = new System.Drawing.Point(557, 309);
            this.CashText.Name = "CashText";
            this.CashText.Size = new System.Drawing.Size(100, 31);
            this.CashText.TabIndex = 4;
            // 
            // Exp2Text
            // 
            this.Exp2Text.FormattingEnabled = true;
            this.Exp2Text.Items.AddRange(new object[] {
            "تحليل (C.B.C)",
            "تحليل (E.S.R)",
            " تحاليل ( BT وAPTT و PT)",
            "تحليل (G6PD )",
            "تحليل إنزيم (AST)",
            "تحليل إنزيم (ALT)",
            "تحليل إنزيم (LDH)",
            "إنزيم (Lipase)",
            "الغدة الدرقية",
            "الغدة الكظرية",
            "التناسلية",
            "الغدة النخامية",
            "البنكرياس",
            "إرثروبويتين",
            "الرينين",
            "الكالسيتريول"});
            this.Exp2Text.Location = new System.Drawing.Point(509, 68);
            this.Exp2Text.Name = "Exp2Text";
            this.Exp2Text.Size = new System.Drawing.Size(121, 32);
            this.Exp2Text.TabIndex = 5;
            this.Exp2Text.SelectedIndexChanged += new System.EventHandler(this.Exp2Text_SelectedIndexChanged);
            // 
            // Exp3Text
            // 
            this.Exp3Text.FormattingEnabled = true;
            this.Exp3Text.Items.AddRange(new object[] {
            "تحليل (C.B.C)",
            "تحليل (E.S.R)",
            " تحاليل ( BT وAPTT و PT)",
            "تحليل (G6PD )",
            "تحليل إنزيم (AST)",
            "تحليل إنزيم (ALT)",
            "تحليل إنزيم (LDH)",
            "إنزيم (Lipase)",
            "الغدة الدرقية",
            "الغدة الكظرية",
            "التناسلية",
            "الغدة النخامية",
            "البنكرياس",
            "إرثروبويتين",
            "الرينين",
            "الكالسيتريول"});
            this.Exp3Text.Location = new System.Drawing.Point(509, 123);
            this.Exp3Text.Name = "Exp3Text";
            this.Exp3Text.Size = new System.Drawing.Size(121, 32);
            this.Exp3Text.TabIndex = 6;
            this.Exp3Text.SelectedIndexChanged += new System.EventHandler(this.Exp3Text_SelectedIndexChanged);
            // 
            // Exp4Text
            // 
            this.Exp4Text.FormattingEnabled = true;
            this.Exp4Text.Items.AddRange(new object[] {
            "تحليل (C.B.C)",
            "تحليل (E.S.R)",
            " تحاليل ( BT وAPTT و PT)",
            "تحليل (G6PD )",
            "تحليل إنزيم (AST)",
            "تحليل إنزيم (ALT)",
            "تحليل إنزيم (LDH)",
            "إنزيم (Lipase)",
            "الغدة الدرقية",
            "الغدة الكظرية",
            "التناسلية",
            "الغدة النخامية",
            "البنكرياس",
            "إرثروبويتين",
            "الرينين",
            "الكالسيتريول"});
            this.Exp4Text.Location = new System.Drawing.Point(509, 176);
            this.Exp4Text.Name = "Exp4Text";
            this.Exp4Text.Size = new System.Drawing.Size(121, 32);
            this.Exp4Text.TabIndex = 7;
            this.Exp4Text.SelectedIndexChanged += new System.EventHandler(this.Exp4Text_SelectedIndexChanged);
            // 
            // PriceText
            // 
            this.PriceText.Location = new System.Drawing.Point(197, 309);
            this.PriceText.Name = "PriceText";
            this.PriceText.ReadOnly = true;
            this.PriceText.Size = new System.Drawing.Size(100, 31);
            this.PriceText.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Exp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(480, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cash";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Exp2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Exp3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(425, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 26);
            this.label8.TabIndex = 16;
            this.label8.Text = "Exp4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(118, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 26);
            this.label9.TabIndex = 17;
            this.label9.Text = "Price";
            // 
            // FormWorkList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(46)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(749, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CloseBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWorkList";
            this.Text = "FormWorkList";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PriceText;
        private System.Windows.Forms.ComboBox Exp4Text;
        private System.Windows.Forms.ComboBox Exp3Text;
        private System.Windows.Forms.ComboBox Exp2Text;
        private System.Windows.Forms.TextBox CashText;
        private System.Windows.Forms.ComboBox ExpText;
        private System.Windows.Forms.ComboBox GenderText;
        private System.Windows.Forms.TextBox AgeText;
        private System.Windows.Forms.TextBox NameText;
    }
}