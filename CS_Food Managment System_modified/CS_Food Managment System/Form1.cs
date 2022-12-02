using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Food_Managment_System
{
    public partial class Form1 : Form
    {


        const double Price_checkBox1 = 60;
        const double Price_checkBox2 = 180;
        const double Price_checkBox3 = 220;
        const double Price_checkBox4 = 160;
        const double Price_checkBox5 = 150;
        const double Price_checkBox7 = 150;
        const double Price_checkBox6 = 60;
        const double Price_checkBox8 = 120;
        const double Price_checkBox17 = 150;
        const double Price_checkBox20 = 60;
        const double Price_checkBox24 = 30;
        const double Price_checkBox23 = 50;
        const double Price_checkBox19 = 40;
        const double Price_checkBox22 = 60;
        const double Price_checkBox18 = 50;
        const double Price_checkBox9 = 20;
        const double Price_checkBox13 = 60;
        const double Price_checkBox11 = 60;
        const double Price_checkBox15 = 20;
        const double Price_checkBox10 = 40;
        const double Price_checkBox14 = 160;
        const double Price_checkBox12 = 60;
        const double Price_checkBox16 = 80;
        const double Price_checkBox21 = 60;


        double iTax, iSubTotal, iTotal,iGiven;

        float Tax_Rate = 15;


        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBox21_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox21.Checked == true)
            {
                textBox21.Enabled = true;
                textBox21.Text = "";
                textBox21.Focus();
            }
            else
            {
                textBox21.Enabled = false;
                textBox21.Text = "0";
            }
        }

        private void Dessertspanel_Paint(object sender, PaintEventArgs e)
        {

        }




        //=======================Exit===================



        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm you want to Exit the system", "Food", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }


        private void ResetTextBoxs()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        //======================================================EnableTextBoxs()==========================

        private void EnableTextBoxs()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        //=================================ResetCheckBoxs()=============================================

        private void ResetCheckBoxs()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetTextBoxs();
            ResetCheckBoxs();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label14.Text = DateTime.Now.ToLongDateString();
            timer1.Start();

            comboBox1.Items.Add("");
            comboBox1.Items.Add("Cash");
            comboBox1.Items.Add("Master Card");
            comboBox1.Items.Add("Visa");
            comboBox1.Items.Add("Debit card");

            EnableTextBoxs();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
                textBox1.Text = "";
                textBox1.Focus();
            }
            else
            {
                textBox1.Enabled = false;
                textBox1.Text = "0";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Enabled = true;
                textBox2.Text = "";
                textBox2.Focus();
            }
            else
            {
                textBox2.Enabled = false;
                textBox2.Text = "0";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox3.Enabled = true;
                textBox3.Text = "";
                textBox3.Focus();
            }
            else
            {
                textBox3.Enabled = false;
                textBox3.Text = "0";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox4.Enabled = true;
                textBox4.Text = "";
                textBox4.Focus();
            }
            else
            {
                textBox4.Enabled = false;
                textBox4.Text = "0";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox5.Enabled = true;
                textBox5.Text = "";
                textBox5.Focus();
            }
            else
            {
                textBox5.Enabled = false;
                textBox5.Text = "0";
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                textBox7.Enabled = true;
                textBox7.Text = "";
                textBox7.Focus();
            }
            else
            {
                textBox7.Enabled = false;
                textBox7.Text = "0";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                textBox6.Enabled = true;
                textBox6.Text = "";
                textBox6.Focus();
            }
            else
            {
                textBox6.Enabled = false;
                textBox6.Text = "0";
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                textBox8.Enabled = true;
                textBox8.Text = "";
                textBox8.Focus();
            }
            else
            {
                textBox8.Enabled = false;
                textBox8.Text = "0";
            }
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox17.Checked == true)
            {
                textBox17.Enabled = true;
                textBox17.Text = "";
                textBox17.Focus();
            }
            else
            {
                textBox17.Enabled = false;
                textBox17.Text = "0";
            }
        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox20.Checked == true)
            {
                textBox20.Enabled = true;
                textBox20.Text = "";
                textBox20.Focus();
            }
            else
            {
                textBox20.Enabled = false;
                textBox20.Text = "0";
            }
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox24.Checked == true)
            {
                textBox24.Enabled = true;
                textBox24.Text = "";
                textBox24.Focus();
            }
            else
            {
                textBox24.Enabled = false;
                textBox24.Text = "0";
            }
        }

        private void checkBox23_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox23.Checked == true)
            {
                textBox23.Enabled = true;
                textBox23.Text = "";
                textBox23.Focus();
            }
            else
            {
                textBox23.Enabled = false;
                textBox23.Text = "0";
            }
        }

        private void checkBox19_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox19.Checked == true)
            {
                textBox19.Enabled = true;
                textBox19.Text = "";
                textBox19.Focus();
            }
            else
            {
                textBox19.Enabled = false;
                textBox19.Text = "0";
            }
        }

        private void checkBox22_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox22.Checked == true)
            {
                textBox22.Enabled = true;
                textBox22.Text = "";
                textBox22.Focus();
            }
            else
            {
                textBox22.Enabled = false;
                textBox22.Text = "0";
            }
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox18.Checked == true)
            {
                textBox18.Enabled = true;
                textBox18.Text = "";
                textBox18.Focus();
            }
            else
            {
                textBox18.Enabled = false;
                textBox18.Text = "0";
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                textBox9.Enabled = true;
                textBox9.Text = "";
                textBox9.Focus();
            }
            else
            {
                textBox9.Enabled = false;
                textBox9.Text = "0";
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                textBox13.Enabled = true;
                textBox13.Text = "";
                textBox13.Focus();
            }
            else
            {
                textBox13.Enabled = false;
                textBox13.Text = "0";
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                textBox11.Enabled = true;
                textBox11.Text = "";
                textBox11.Focus();
            }
            else
            {
                textBox11.Enabled = false;
                textBox11.Text = "0";
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked == true)
            {
                textBox15.Enabled = true;
                textBox15.Text = "";
                textBox15.Focus();
            }
            else
            {
                textBox15.Enabled = false;
                textBox15.Text = "0";
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                textBox10.Enabled = true;
                textBox10.Text = "";
                textBox10.Focus();
            }
            else
            {
                textBox10.Enabled = false;
                textBox10.Text = "0";
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked == true)
            {
                textBox14.Enabled = true;
                textBox14.Text = "";
                textBox14.Focus();
            }
            else
            {
                textBox14.Enabled = false;
                textBox14.Text = "0";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cash")
            {
                txt.Enabled = true;
                txt.Text = "";
                

                txt.Focus();
            }
            else
            {
                txt.Enabled = false;
                txt.Text = "0";
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double[] itemcost = new double[24];
            itemcost[0] = Convert.ToDouble(textBox1.Text) * Price_checkBox1;
            itemcost[1] = Convert.ToDouble(textBox2.Text) * Price_checkBox2;
            itemcost[2] = Convert.ToDouble(textBox3.Text) * Price_checkBox3;
            itemcost[3] = Convert.ToDouble(textBox4.Text) * Price_checkBox4;
            itemcost[4] = Convert.ToDouble(textBox5.Text) * Price_checkBox5;
            itemcost[5] = Convert.ToDouble(textBox7.Text) * Price_checkBox7;
            itemcost[6] = Convert.ToDouble(textBox6.Text) * Price_checkBox6;
            itemcost[7] = Convert.ToDouble(textBox8.Text) * Price_checkBox8;
            itemcost[8] = Convert.ToDouble(textBox17.Text) * Price_checkBox17;
            itemcost[9] = Convert.ToDouble(textBox20.Text) * Price_checkBox20;
            itemcost[10] = Convert.ToDouble(textBox24.Text) * Price_checkBox24;
            itemcost[11] = Convert.ToDouble(textBox23.Text) * Price_checkBox23;
            itemcost[12] = Convert.ToDouble(textBox19.Text) * Price_checkBox19;
            itemcost[13] = Convert.ToDouble(textBox22.Text) * Price_checkBox22;
            itemcost[14] = Convert.ToDouble(textBox18.Text) * Price_checkBox18;
            itemcost[15] = Convert.ToDouble(textBox9.Text) * Price_checkBox9;
            itemcost[16] = Convert.ToDouble(textBox13.Text) * Price_checkBox13;
            itemcost[17] = Convert.ToDouble(textBox11.Text) * Price_checkBox11;
            itemcost[18] = Convert.ToDouble(textBox15.Text) * Price_checkBox15;
            itemcost[19] = Convert.ToDouble(textBox10.Text) * Price_checkBox10;
            itemcost[20] = Convert.ToDouble(textBox14.Text) * Price_checkBox14;
            itemcost[21] = Convert.ToDouble(textBox12.Text) * Price_checkBox12;
            itemcost[22] = Convert.ToDouble(textBox16.Text) * Price_checkBox16;
            itemcost[23] = Convert.ToDouble(textBox21.Text) * Price_checkBox21;

            double cost,iChange;



            if(comboBox1.Text== "Cash")
            {
                iSubTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] + itemcost[8] +
                    itemcost[9] + itemcost[10] + itemcost[11] + itemcost[12] + itemcost[13] + itemcost[14] + itemcost[15] + itemcost[16] + itemcost[17] + itemcost[18] +
                    itemcost[18] + itemcost[20] + itemcost[21] + itemcost[22] + itemcost[23];

                textBox28.Text = Convert.ToString(iSubTotal);
                iTax = (iSubTotal * Tax_Rate) / 100;
                textBox26.Text = Convert.ToString(iTax);
                iTotal = (iSubTotal + iTax);
                textBox25.Text = Convert.ToString(iTotal);
                iGiven = Convert.ToDouble(txt.Text);





                iChange = Convert.ToDouble(txt.Text);
               cost = iGiven - iTotal;
               textBox27.Text = Convert.ToString(cost);
                

                textBox27.Text = String.Format("{0:C}", cost);
                textBox26.Text = String.Format("{0:C}", iTax);
                textBox28.Text = String.Format("{0:C}",iSubTotal);
                textBox25.Text = String.Format("{0:C}", iTotal);
                textBox29.Text = String.Format("{0:C}", iGiven);
            }


            else
            {
                iSubTotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] + itemcost[8] +
                    itemcost[9] + itemcost[10] + itemcost[11] + itemcost[12] + itemcost[13] + itemcost[14] + itemcost[15] + itemcost[16] + itemcost[17] + itemcost[18] +
                    itemcost[18] + itemcost[20] + itemcost[21] + itemcost[22] + itemcost[23];

                textBox28.Text = Convert.ToString(iSubTotal);
                iTax = (iSubTotal * Tax_Rate) / 100;
                textBox26.Text = Convert.ToString(iTax);
                iTotal = (iSubTotal + iTax);
                textBox25.Text = Convert.ToString(iTotal);

                textBox26.Text = String.Format("{0:C}", iTax);
                textBox28.Text = String.Format("{0:C}",iSubTotal);
                textBox25.Text = String.Format("{0:C}", iTotal);
                textBox29.Text = String.Format("{0:C}", iGiven);
            }
            
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label13.Text = DateTime.Now.ToLongTimeString();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            // This code will open Text files
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                richTextBox1.LoadFile(openFile.FileName, RichTextBoxStreamType.PlainText);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            // This code will save the file
            SaveFileDialog saveFile = new SaveFileDialog();

            saveFile.FileName = "Notepad Text";
            saveFile.Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFile.ShowDialog()==DialogResult.OK)

            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFile.FileName))
                    sw.WriteLine(richTextBox1.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();

            richTextBox1.AppendText(Environment.NewLine);
            richTextBox1.AppendText("===============================================" + Environment.NewLine);
            richTextBox1.AppendText("\t\t\t" + "Bill Receipt" + Environment.NewLine);
            richTextBox1.AppendText("===============================================" + Environment.NewLine + Environment.NewLine);

            richTextBox1.AppendText("Vat Vorta-60/- \t\t\t" + textBox1.Text + Environment.NewLine);
            richTextBox1.AppendText("Biriani-180/- \t\t\t\t" + textBox2.Text + Environment.NewLine);
            richTextBox1.AppendText("Kacchi-220/- \t\t\t\t" + textBox3.Text + Environment.NewLine);
            richTextBox1.AppendText("Chicken Biriani-160/- \t\t" + textBox4.Text + Environment.NewLine);
            richTextBox1.AppendText("Khichuri-150/- \t\t\t" + textBox5.Text + Environment.NewLine);
            richTextBox1.AppendText("Khude Vat-150/- \t\t\t" + textBox7.Text + Environment.NewLine);
            richTextBox1.AppendText("Chicken Curry-60/- \t\t\t" + textBox6.Text + Environment.NewLine);
            richTextBox1.AppendText("Beef Curry-120/- \t\t\t" + textBox8.Text + Environment.NewLine);
            richTextBox1.AppendText("Mutton Curry-150/- \t\t\t" + textBox17.Text + Environment.NewLine);
            richTextBox1.AppendText("Fish Curry-60/- \t\t\t" + textBox20.Text + Environment.NewLine);

            richTextBox1.AppendText("Water Bottle-20/- \t\t\t" + textBox9.Text + Environment.NewLine);
            richTextBox1.AppendText("Borhani-60/- \t\t\t\t" + textBox13.Text + Environment.NewLine);
            richTextBox1.AppendText("Orange Juice-60/- \t\t\t" + textBox11.Text + Environment.NewLine);
            richTextBox1.AppendText("Tea-20/- \t\t\t\t" + textBox15.Text + Environment.NewLine);
            richTextBox1.AppendText("Coffee-40/- \t\t\t\t" + textBox10.Text + Environment.NewLine);

            richTextBox1.AppendText("Finni-30/- \t\t\t\t" + textBox24.Text + Environment.NewLine);
            richTextBox1.AppendText("Jorda-50/- \t\t\t\t" + textBox23.Text + Environment.NewLine);
            richTextBox1.AppendText("Dodhi-40/- \t\t\t\t" + textBox19.Text + Environment.NewLine);
            richTextBox1.AppendText("Ice Cream-60/- \t\t\t" + textBox22.Text + Environment.NewLine);
            richTextBox1.AppendText("BD Sweet Special-50/- \t\t" + textBox18.Text + Environment.NewLine);

            richTextBox1.AppendText("Olive-oil Nutty Salat-160/- \t\t" + textBox14.Text + Environment.NewLine);
            richTextBox1.AppendText("French Fry-60/- \t\t\t" + textBox12.Text + Environment.NewLine);
            richTextBox1.AppendText("Chicken Fry-80/- \t\t\t" + textBox16.Text + Environment.NewLine);
            richTextBox1.AppendText("Chicken soup-60/- \t\t\t" + textBox21.Text + Environment.NewLine);
            richTextBox1.AppendText("===============================================" + Environment.NewLine);
            richTextBox1.AppendText("Given \t\t\t\t" + textBox29.Text + Environment.NewLine);
            richTextBox1.AppendText("Tax-15%\t\t\t" + textBox26.Text + Environment.NewLine);
            richTextBox1.AppendText("Sub-Total \t\t\t" + textBox28.Text + Environment.NewLine);
            richTextBox1.AppendText("Total \t\t\t\t" + textBox25.Text + Environment.NewLine);
            richTextBox1.AppendText("Change \t\t\t" + textBox27.Text + Environment.NewLine);
            richTextBox1.AppendText("===============================================" + Environment.NewLine);
            richTextBox1.AppendText(label13.Text+"\t\t\t\t" +label14.Text );


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                textBox12.Enabled = true;
                textBox12.Text = "";
                textBox12.Focus();
            }
            else
            {
                textBox12.Enabled = false;
                textBox12.Text = "0";
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked == true)
            {
                textBox16.Enabled = true;
                textBox16.Text = "";
                textBox16.Focus();
            }
            else
            {
                textBox16.Enabled = false;
                textBox16.Text = "0";
            }
        }
    }
}