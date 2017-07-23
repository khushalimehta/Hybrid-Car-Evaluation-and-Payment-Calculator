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

namespace assignment2
{
    public partial class Form1 : Form
    {
        List<Car> carlist = new List<Car>();
        public static string recentcar;
        string[] getdata;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int no;
            if (!(textBox1.Text == String.Empty) && !int.TryParse(textBox1.Text, out no))
                MessageBox.Show(String.Format("Please enter valid value."));

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            double a;
            if (!(textBox2.Text == String.Empty) && !double.TryParse(textBox2.Text,out a))
                MessageBox.Show(String.Format("Please Enter valid value"));
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            double a;
            if (!(textBox3.Text == String.Empty) && !double.TryParse(textBox2.Text, out a))
                MessageBox.Show(String.Format("Please enter valid value"));
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double a;
            if (!(textBox4.Text == String.Empty) && !double.TryParse(textBox2.Text, out a))
                           MessageBox.Show(String.Format("Please enter valid value"));
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            double a;
            if (!(textBox5.Text == String.Empty) && !double.TryParse(textBox2.Text, out a))
                MessageBox.Show(String.Format("Please enter valid value"));
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            double a;
            if (!(textBox6.Text == String.Empty) && !double.TryParse(textBox2.Text, out a))
                MessageBox.Show(String.Format("Please enter valid value"));
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            double a;
            if (!(textBox7.Text == String.Empty) && !double.TryParse(textBox2.Text, out a))
                MessageBox.Show(String.Format("Please enter valid value"));
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            double a;
            if (!(textBox8.Text == String.Empty) && !double.TryParse(textBox2.Text, out a))
                MessageBox.Show(String.Format("Please enter valid value"));
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            double a;
            if (!(textBox9.Text == String.Empty) && !double.TryParse(textBox2.Text, out a))
                MessageBox.Show(String.Format("Please enter valid value"));
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            double a;
            int numberofcars = int.Parse(textBox1.Text);
            if (!(textBox10.Text == String.Empty) && !double.TryParse(textBox2.Text, out a))
                MessageBox.Show(String.Format("Please enter valid value"));
            else
            {
                if(!(textBox1.Text == ""))
                {
                    for (int i = 0; i < int.Parse(textBox1.Text); i++)
                    {
                        this.dataGridView1.Rows.Add();
                    }

                }
               
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            double a;
            if (!(textBox11.Text == String.Empty) && !double.TryParse(textBox2.Text, out a))
                MessageBox.Show(String.Format("Please enter valid value"));
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            double a;
            if (!(textBox12.Text == String.Empty) && !double.TryParse(textBox2.Text, out a))
                MessageBox.Show(String.Format("Please enter valid value"));
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            double a;
            if (!(textBox13.Text == String.Empty) && !double.TryParse(textBox2.Text, out a))
                MessageBox.Show(String.Format("Please enter valid value"));
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(savedetail() == true)
            {
                try
                {
                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "Text File|*.txt";
                    saveFileDialog1.Title = "Save the Car Report";
                    saveFileDialog1.ShowDialog();
                    if(saveFileDialog1.FileName != "")
                    {
                        File.WriteAllText(saveFileDialog1.FileName, filesave2());
                    }
                    else
                    {
                        MessageBox.Show("Please write the file name.");
                    }
                }
                catch(NullReferenceException ex)
                {
                    MessageBox.Show(string.Format(ex.Message + "Null Refeernce Exception"));
                    return;
                }
            }
        }
        public string filesave2()
        {
            string txtreport;
            txtreport = carlist.Count + "," + Car.Citymiles.ToString() + "," + Car.Highwaymiles.ToString() + ",";
            foreach(double cgas in Car.Avggas)
            {
                txtreport +=  cgas.ToString() + ",";  
            }
            
            foreach(Car comp in carlist)
            {
                txtreport = txtreport + comp.Make + "," + comp.Model + "," + comp.Initialpr.ToString() + "," + comp.CPG.ToString() + "," + comp.HPG.ToString() + ",";
                MessageBox.Show(comp.Make);
            }
            return (txtreport);
        }
        private bool savedetail()
        {
            if(textBox1.Text == "" ||
               textBox2.Text == "" ||
               textBox3.Text == "" ||
               textBox4.Text == "" ||
               textBox5.Text == "" ||
               textBox6.Text == "" ||
               textBox7.Text == "" ||
               textBox8.Text == "" ||
               textBox9.Text == "" ||
               textBox10.Text == "" ||
               textBox11.Text == "" ||
               textBox12.Text == "" ||
                textBox13.Text == "" )
                {
                    MessageBox.Show(String.Format("There are some blank fields.Plase fill all information."));
                }
            else
            {
                try
                {
                    Car.Avggas[0] = Double.Parse(textBox4.Text);
                    Car.Avggas[1] = Double.Parse(textBox5.Text);
                    Car.Avggas[2] = Double.Parse(textBox6.Text);
                    Car.Avggas[3] = Double.Parse(textBox7.Text);
                    Car.Avggas[4] = Double.Parse(textBox8.Text);
                    Car.Avggas[5] = Double.Parse(textBox9.Text);
                    Car.Avggas[6] = Double.Parse(textBox10.Text);
                    Car.Avggas[7] = Double.Parse(textBox11.Text);
                    Car.Avggas[8] = Double.Parse(textBox12.Text);
                    Car.Avggas[9] = Double.Parse(textBox13.Text);
                    Car.Citymiles = Double.Parse(textBox2.Text);
                    Car.Highwaymiles = Double.Parse(textBox3.Text);
                  /*  string maketext = comboBox1.SelectedItem.ToString();
                  
                    try
                    {
                        carlist.Add(new Car(maketext, textBox14.Text, Double.Parse(textBox15.Text), Double.Parse(textBox16.Text), Double.Parse(textBox17.Text)));
                        recentcar = maketext + "\t" + textBox14.Text;
                    }
                    */
                    return true;
                }


              
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(string.Format(ex.Message + "\n SaveUserDetails Out of Range Exception"));
                }
               
            }

            return (false);


        }
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String readfile = "";
            OpenFileDialog openfile = new OpenFileDialog();
            if (openfile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string extension = Path.GetExtension(openfile.FileName);
                if (extension.Equals(".txt"))
                {
                    try
                    {
                        System.IO.StreamReader readdata = new System.IO.StreamReader(openfile.FileName);
                        readfile = readdata.ReadToEnd();
                        readdata.Close();
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(String.Format(ex.Message + "\n Error in  opening the file.PLease try again!"));
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please select .txt file.");
                }
            }
            try
            {
                getdata = readfile.Split(',');
                int ccount = 1;
                carlist.Clear();
                try
                {
                    Car.Citymiles = Convert.ToDouble(getdata[ccount++]);
                    Car.Highwaymiles = Convert.ToDouble(getdata[ccount++]);
                    for (int i = 0; i < 10; i++)
                    {
                        Car.Avggas[i] = Convert.ToDouble(getdata[ccount++]);
                    }
                    textBox2.Text = Car.Citymiles.ToString();
                    textBox3.Text = Car.Highwaymiles.ToString();
                    textBox4.Text = Car.Avggas[0].ToString();
                    textBox5.Text = Car.Avggas[1].ToString();
                    textBox6.Text = Car.Avggas[2].ToString();
                    textBox7.Text = Car.Avggas[3].ToString();
                    textBox8.Text = Car.Avggas[4].ToString();
                    textBox9.Text = Car.Avggas[5].ToString();
                    textBox10.Text = Car.Avggas[6].ToString();
                    textBox11.Text = Car.Avggas[7].ToString();
                    textBox12.Text = Car.Avggas[8].ToString();
                    textBox13.Text = Car.Avggas[9].ToString();

                }
                catch (ArgumentOutOfRangeException ex)
                {
                    MessageBox.Show(string.Format(ex.Message + "\n LoadDataOnForm Out of Range Exception"));
                }



                catch (Exception ex)
                {
                    MessageBox.Show(string.Format(ex.Message + "\n LoadDataOnForm Exception"));
                    return;
                }

                for (int i = 0; i < Convert.ToInt32(getdata[0]); i++)
                {
                    carlist.Add(new Car(getdata[ccount++],getdata[ccount++],double.Parse(getdata[ccount++]),double.Parse(getdata[ccount++]), double.Parse(getdata[ccount++])));
                    //dataGridView1.Rows[i].Cells["Make"].Value = carlist[i].
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show(string.Format(ex.Message + "\n Error in Data present in File"));
                return;

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
       
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
