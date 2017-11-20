using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Factory_management
{
    public partial class addagent_form : Form
    {
        public addagent_form()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtadd_TextChanged(object sender, EventArgs e)
        {

        }
 

        private void button1_Click_1(object sender, EventArgs e)
        {
            int warning = 0;
            bool warning2 = false;
            bool warning3 = false;


            if (!String.IsNullOrEmpty(txtName.Text))
            {
                warning++;
            }
            if (!String.IsNullOrEmpty(txtadd.Text))
            {
                warning++;
            }
            if (!String.IsNullOrEmpty(txtmbl.Text))
            {
                warning++;
            }
            if (!String.IsNullOrEmpty(txtlnd.Text))
            {
                warning++;
            }
            if (!String.IsNullOrEmpty(txtun.Text))
            {
                warning++;
            }
            if (!String.IsNullOrEmpty(txtpw.Text))
            {
                warning++;
            }

            ///////////////////////////////////


            if ((!txtlnd.Text.All(char.IsDigit)) || (txtlnd.Text.Length != 10))
            {
                MessageBox.Show("Invalid land number");
                warning2 = true;
            }

            //////////////////////

            if ((!txtmbl.Text.All(char.IsDigit)) || (txtmbl.Text.Length != 10))
            {
                warning3 = true;
                MessageBox.Show("Invalid mobile number");
            }

            ///////////////////////////////////////////

            if (warning != 6)
            {
                MessageBox.Show("Fill Empty Fields");
            }
            ///////////////////

            if ((warning == 6) && (warning2 == false) && (warning3 == false))

            {
                agentClass ac = new agentClass();
                ac.insertAgent(txtName.Text, txtadd.Text, txtmbl.Text, txtlnd.Text, txtun.Text, txtpw.Text); ;
                txtName.Text = string.Empty;
                txtadd.Text = string.Empty;
                txtmbl.Text = string.Empty;
                txtlnd.Text = string.Empty;
                txtun.Text = string.Empty;
                txtpw.Text = string.Empty;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtadd.Text = string.Empty;
            txtmbl.Text = string.Empty;
            txtlnd.Text = string.Empty;
            txtun.Text = string.Empty;
            txtpw.Text = string.Empty;
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {

        }

        private void agent_search_Click(object sender, EventArgs e)
        {
            //search  
            if (radioButton1.Checked)
            {

                if ((!textBox3.Text.All(char.IsDigit)) || (String.IsNullOrEmpty(textBox3.Text)))
                {
                    MessageBox.Show("Invalid Id or Empty Field");
                }
                else
                {
                    agentClass ac = new agentClass();
                    DataTable dt = ac.searchAgents(textBox3.Text);
                    if (dt == null)
                    {
                        MessageBox.Show("Not Found");
                    }
                    else
                    {
                        dataGridView1.Rows.Clear();

                       // dataGridView1.DataSource = dt;
                        foreach (DataRow row in dt.Rows)
                        {

                            dataGridView1.Rows.Add(row.ItemArray);
                        }




                        //  this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
                        textBox3.Text = string.Empty;
                        radioButton1.Checked = false;
                    }
                }
            }


            if (radioButton2.Checked)
            {
                if ((String.IsNullOrEmpty(textBox11.Text)))
                {
                    MessageBox.Show("Enter Name");
                }
                else
                {

                    agentClass ac = new agentClass();
                    DataTable dt = ac.searchAgents(textBox11.Text);
                    if (dt == null)
                    {
                        MessageBox.Show("Not Found");
                    }
                    else
                    {
                        dataGridView1.Rows.Clear();
                        //  dataGridView1.DataSource = dt;
                        //  this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
                        foreach(DataRow row in dt.Rows)
                        {
                            dataGridView1.Rows.Add(row.ItemArray);
                        }
                        textBox11.Text = string.Empty;
                        radioButton2.Checked = false;
                    }
                }
            }
        }

        private void agent_viewAll_Click(object sender, EventArgs e)
        {
            agentClass ac = new agentClass();
            DataTable dt = ac.getAgents();
            dataGridView1.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                dataGridView1.Rows.Add(row.ItemArray);
            }
        //    this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void update_agent_Click(object sender, EventArgs e)
        {

            int warning = 0;
            bool warning2 = false;
            bool warning3 = false;


            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                warning++;
            }
            if (!String.IsNullOrEmpty(richTextBox1.Text))
            {
                warning++;
            }
            if (!String.IsNullOrEmpty(textBox10.Text))
            {
                warning++;
            }
            if (!String.IsNullOrEmpty(textBox12.Text))
            {
                warning++;
            }
            if (!String.IsNullOrEmpty(textBox8.Text))
            {
                warning++;
            }
            if (!String.IsNullOrEmpty(textBox9.Text))
            {
                warning++;
            }

            ///////////////////////////////////


            if ((!textBox12.Text.All(char.IsDigit)) || (textBox12.Text.Length != 10))
            {
                MessageBox.Show("Invalid land number");
                warning2 = true;
            }

            //////////////////////

            if ((!textBox10.Text.All(char.IsDigit)) || (textBox10.Text.Length != 10))
            {
                warning3 = true;
                MessageBox.Show("Invalid mobile number");
            }

            ///////////////////////////////////////////

            if (warning != 6)
            {
                MessageBox.Show("Fill Empty Fields");
            }
            ///////////////////

            if ((warning == 6) && (warning2 == false) && (warning3 == false))

            {
                agentClass ac = new agentClass(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), textBox1.Text, richTextBox1.Text, textBox10.Text, textBox12.Text, textBox8.Text, textBox9.Text);
                ac.updateAgent(ac);

                DataTable dt = ac.getAgents();
                dataGridView1.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    dataGridView1.Rows.Add(row.ItemArray);
                }
                dataGridView1.DataSource = null;
                textBox1.Text = string.Empty;
                richTextBox1.Text = string.Empty;
                textBox10.Text = string.Empty;
                textBox12.Text = string.Empty;
                textBox8.Text = string.Empty;
                textBox9.Text = string.Empty;
            }
            //update
        }

        private void delete_agent_Click(object sender, EventArgs e)
        {
            //delete

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a row to delete");
            }
            else
            {

                if (MessageBox.Show("Do You Need To Delete This Agent ?? ", "WARNING!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    agentClass ac = new agentClass();
                    string key = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    ac.deleteAgent(key);

                    
                    DataTable dt = ac.getAgents();
                    dataGridView1.Rows.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        dataGridView1.Rows.Add(row.ItemArray);
                    }

                    //    dataGridView1.DataSource = ac.getAgents();
                    //     this.dataGridView1.Sort(this.dataGridView1.Columns[0], ListSortDirection.Ascending);
                }

            }

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           // textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox10.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox12.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox8.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
