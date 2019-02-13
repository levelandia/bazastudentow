using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
        }

        private void add(string indeks, string imie, string semestr, string programowanie)
        {
            String[] row = { indeks, imie, semestr, programowanie };

            ListViewItem item = new ListViewItem(row);

            listView1.Items.Add(item);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Random generator = new Random();
            int randomValue;
            randomValue = generator.Next(10000, 99999);
            int x = randomValue;
            indeksTxt.Text = (x.ToString());


            add(indeksTxt.Text, imieTxt.Text, semestrTxt.Text, programowanieTxt.Text);
            indeksTxt.Text = "";
            imieTxt.Text = "";
            semestrTxt.Text = "";
            programowanieTxt.Text = "";
            
        }

        private void dodajocenebtn_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            groupBox3.Visible = true;
        }



        private static void add(string text)
        {
            throw new NotImplementedException();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            String indeks = listView1.SelectedItems[0].SubItems[0].Text;
            String imie = listView1.SelectedItems[0].SubItems[1].Text;
            String semestr = listView1.SelectedItems[0].SubItems[2].Text;
            String programowanie = listView1.SelectedItems[0].SubItems[3].Text;

            indeksTxt.Text = indeks;
            imieTxt.Text = imie;
            semestrTxt.Text = semestr;
            programowanieTxt.Text = programowanie;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz wyczyścic listę?", "Czyszczenie listy...", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                listView1.Items.Clear();
                indeksTxt.Text = "";
                imieTxt.Text = "";
                semestrTxt.Text = "";
                
            }

        }

        private void usunbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz usunąć studenta?", "Usuwanie studenta...", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                listView1.Items.RemoveAt(listView1.SelectedIndices[0]);

                indeksTxt.Text = "";
                imieTxt.Text = "";
                semestrTxt.Text = "";
                programowanieTxt.Text = "";
                
            }
        }

        private void edytujbtn_Click(object sender, EventArgs e)
        {
            

            listView1.SelectedItems[0].SubItems[0].Text = indeksTxt.Text;
            listView1.SelectedItems[0].SubItems[1].Text = imieTxt.Text;
            listView1.SelectedItems[0].SubItems[2].Text = semestrTxt.Text;



            indeksTxt.Text = "";
            imieTxt.Text = "";
            semestrTxt.Text = "";
            programowanieTxt.Text = "";
            
        }

        private void zakoncz_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz zamknąć program?", "Zamykanie...", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }

        }

        private void programowanieTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void edytujocenebtn_Click(object sender, EventArgs e)
        {
            listView1.SelectedItems[0].SubItems[3].Text = programowanieTxt.Text;
            
            indeksTxt.Text = "";
            imieTxt.Text = "";
            semestrTxt.Text = "";

            listBox1.Items.Add(programowanieTxt.Text);
            programowanieTxt.Text = "";

            
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {



            {
                SaveFileDialog sfd = new SaveFileDialog
                {
                    Title = "Wybierz folder",
                    FileName = "studenci.csv",
                    Filter = "CSV (*.csv)|*.csv",
                    FilterIndex = 0,

                };




                if (sfd.ShowDialog() == DialogResult.OK)
                {

                    string[] headers = listView1.Columns
                               .OfType<ColumnHeader>()
                               .Select(header => header.Text.Trim())
                               .ToArray();

                    string[][] items = listView1.Items
                                .OfType<ListViewItem>()
                                .Select(lvi => lvi.SubItems
                                    .OfType<ListViewItem.ListViewSubItem>()
                                    .Select(si => si.Text).ToArray()).ToArray();

                    string table = string.Join(",", headers) + Environment.NewLine;
                    foreach (string[] a in items)
                    {
                        table += string.Join(",", a) + Environment.NewLine;
                    }
                    table = table.TrimEnd('\r', '\n');
                    System.IO.File.WriteAllText(sfd.FileName, table);

                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            groupBox1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void listView1_ItemMouseHover(object sender, ListViewItemMouseHoverEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_2(object sender, EventArgs e)
        {

        }

        private void button3_Click_3(object sender, EventArgs e)
        {
            

            

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void button3_Click_4(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
                
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                decimal sum = 0;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    sum += Convert.ToDecimal(listBox1.Items[i]);
                }
                label5.Text = "Średnia ocen jest równa: " + sum / listBox1.Items.Count;
            }
            else
            {
                label5.Text = "Brak ocen";
            }

        }

        private void button3_Click_5(object sender, EventArgs e)
        {
            this.listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }   

        private void button8_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                decimal sum = 0;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    sum += Convert.ToDecimal(listBox1.Items[i]);
                }
                label5.Text = "Odchylenie ocen jest równe: " + sum / listBox1.Items.Count;
            }
            else
            {
                label5.Text = "Brak ocen";
            }
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                decimal sum = 0;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    sum += Convert.ToDecimal(listBox1.Items[i]);
                }
                label5.Text = "Mediana ocen jest równa:" + sum / listBox1.Items.Count;
            }
            else
            {
                label5.Text = "Brak ocen";
            }
            
        }

        private void semestrTxt_TextChanged(object sender, EventArgs e)
        {

        }


    }
        
}
