namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Indeks = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Imie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Semestr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Programowanie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.indeksTxt = new System.Windows.Forms.TextBox();
            this.dodajbtn = new System.Windows.Forms.Button();
            this.imieTxt = new System.Windows.Forms.TextBox();
            this.wyczyscbtn = new System.Windows.Forms.Button();
            this.usunbtn = new System.Windows.Forms.Button();
            this.edytujbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.programowanieTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.otwierajkaoceny = new System.Windows.Forms.Button();
            this.edytujocenebtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.semestrTxt = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zarzadzaj studentami";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Indeks,
            this.Imie,
            this.Semestr,
            this.Programowanie});
            this.listView1.Location = new System.Drawing.Point(12, 41);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(475, 452);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.listView1_ItemMouseHover);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // Indeks
            // 
            this.Indeks.Text = "Nr. Indeksu";
            this.Indeks.Width = 70;
            // 
            // Imie
            // 
            this.Imie.Text = "Imię i nazwisko";
            this.Imie.Width = 250;
            // 
            // Semestr
            // 
            this.Semestr.Text = "Semestr";
            this.Semestr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Programowanie
            // 
            this.Programowanie.Text = "Programowanie";
            this.Programowanie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Programowanie.Width = 90;
            // 
            // indeksTxt
            // 
            this.indeksTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.indeksTxt.Location = new System.Drawing.Point(110, 26);
            this.indeksTxt.Name = "indeksTxt";
            this.indeksTxt.ReadOnly = true;
            this.indeksTxt.Size = new System.Drawing.Size(138, 20);
            this.indeksTxt.TabIndex = 2;
            this.indeksTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dodajbtn
            // 
            this.dodajbtn.Location = new System.Drawing.Point(51, 166);
            this.dodajbtn.Name = "dodajbtn";
            this.dodajbtn.Size = new System.Drawing.Size(75, 23);
            this.dodajbtn.TabIndex = 3;
            this.dodajbtn.Text = "Dodaj";
            this.dodajbtn.UseVisualStyleBackColor = true;
            this.dodajbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // imieTxt
            // 
            this.imieTxt.Location = new System.Drawing.Point(110, 70);
            this.imieTxt.Name = "imieTxt";
            this.imieTxt.Size = new System.Drawing.Size(138, 20);
            this.imieTxt.TabIndex = 4;
            // 
            // wyczyscbtn
            // 
            this.wyczyscbtn.Location = new System.Drawing.Point(146, 195);
            this.wyczyscbtn.Name = "wyczyscbtn";
            this.wyczyscbtn.Size = new System.Drawing.Size(75, 23);
            this.wyczyscbtn.TabIndex = 6;
            this.wyczyscbtn.Text = "Wyszyść";
            this.wyczyscbtn.UseVisualStyleBackColor = true;
            this.wyczyscbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // usunbtn
            // 
            this.usunbtn.Location = new System.Drawing.Point(52, 195);
            this.usunbtn.Name = "usunbtn";
            this.usunbtn.Size = new System.Drawing.Size(75, 23);
            this.usunbtn.TabIndex = 7;
            this.usunbtn.Text = "Usuń";
            this.usunbtn.UseVisualStyleBackColor = true;
            this.usunbtn.Click += new System.EventHandler(this.usunbtn_Click);
            // 
            // edytujbtn
            // 
            this.edytujbtn.Location = new System.Drawing.Point(146, 166);
            this.edytujbtn.Name = "edytujbtn";
            this.edytujbtn.Size = new System.Drawing.Size(75, 23);
            this.edytujbtn.TabIndex = 8;
            this.edytujbtn.Text = "Edytuj";
            this.edytujbtn.UseVisualStyleBackColor = true;
            this.edytujbtn.Click += new System.EventHandler(this.edytujbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numer indeksu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Imię i nazwisko";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Semestr";
            // 
            // programowanieTxt
            // 
            this.programowanieTxt.Location = new System.Drawing.Point(110, 22);
            this.programowanieTxt.Name = "programowanieTxt";
            this.programowanieTxt.Size = new System.Drawing.Size(138, 20);
            this.programowanieTxt.TabIndex = 14;
            this.programowanieTxt.TextChanged += new System.EventHandler(this.programowanieTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Programowanie";
            // 
            // otwierajkaoceny
            // 
            this.otwierajkaoceny.Location = new System.Drawing.Point(259, 12);
            this.otwierajkaoceny.Name = "otwierajkaoceny";
            this.otwierajkaoceny.Size = new System.Drawing.Size(228, 23);
            this.otwierajkaoceny.TabIndex = 18;
            this.otwierajkaoceny.Text = "Zarządzaj ocenami";
            this.otwierajkaoceny.UseVisualStyleBackColor = true;
            this.otwierajkaoceny.Click += new System.EventHandler(this.dodajocenebtn_Click);
            // 
            // edytujocenebtn
            // 
            this.edytujocenebtn.Location = new System.Drawing.Point(173, 48);
            this.edytujocenebtn.Name = "edytujocenebtn";
            this.edytujocenebtn.Size = new System.Drawing.Size(75, 23);
            this.edytujocenebtn.TabIndex = 19;
            this.edytujocenebtn.Text = "Zaktualizuj";
            this.edytujocenebtn.UseVisualStyleBackColor = true;
            this.edytujocenebtn.Click += new System.EventHandler(this.edytujocenebtn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(475, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Wyeksportuj do .csv";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.semestrTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dodajbtn);
            this.groupBox1.Controls.Add(this.edytujbtn);
            this.groupBox1.Controls.Add(this.usunbtn);
            this.groupBox1.Controls.Add(this.wyczyscbtn);
            this.groupBox1.Controls.Add(this.indeksTxt);
            this.groupBox1.Controls.Add(this.imieTxt);
            this.groupBox1.Location = new System.Drawing.Point(500, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 237);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student";
            // 
            // semestrTxt
            // 
            this.semestrTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.semestrTxt.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.semestrTxt.Location = new System.Drawing.Point(110, 120);
            this.semestrTxt.Name = "semestrTxt";
            this.semestrTxt.Size = new System.Drawing.Size(138, 21);
            this.semestrTxt.TabIndex = 35;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.programowanieTxt);
            this.groupBox2.Controls.Add(this.edytujocenebtn);
            this.groupBox2.Location = new System.Drawing.Point(500, 262);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 94);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Oceny";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 25;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(130, 18);
            this.button6.Name = "button6";
            this.button6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button6.Size = new System.Drawing.Size(127, 26);
            this.button6.TabIndex = 28;
            this.button6.Text = "Średnia";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(130, 53);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(127, 27);
            this.button7.TabIndex = 30;
            this.button7.Text = "Mediana";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(130, 90);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(127, 24);
            this.button8.TabIndex = 31;
            this.button8.Text = "Odchylenie";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 34);
            this.button3.TabIndex = 33;
            this.button3.Text = "Usuń ocenę";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_5);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.listBox1);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Controls.Add(this.button7);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Location = new System.Drawing.Point(500, 368);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 158);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operacje na ocenach";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(132, 128);
            this.label5.Name = "label5";
            this.label5.ReadOnly = true;
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 537);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.otwierajkaoceny);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Zarzadzenie studentami";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox indeksTxt;
        private System.Windows.Forms.Button dodajbtn;
        private System.Windows.Forms.TextBox imieTxt;
        private System.Windows.Forms.Button wyczyscbtn;
        private System.Windows.Forms.Button usunbtn;
        private System.Windows.Forms.Button edytujbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox programowanieTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button otwierajkaoceny;
        private System.Windows.Forms.Button edytujocenebtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader Indeks;
        private System.Windows.Forms.ColumnHeader Imie;
        private System.Windows.Forms.ColumnHeader Semestr;
        private System.Windows.Forms.ColumnHeader Programowanie;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox label5;
        private System.Windows.Forms.ComboBox semestrTxt;
    }
}

