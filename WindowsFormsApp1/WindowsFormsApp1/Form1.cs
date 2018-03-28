using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int n = 0;
            for (int i= 0; i < 5; i++)
            {
                /// Adding Rows
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = "Team 4-Bit";
                dataGridView1.Rows[n].Cells[1].Value = "Jasper, Jerome, Carl, Jay";
                dataGridView1.Rows[n].Cells[2].Value = "3";//wins
                dataGridView1.Rows[n].Cells[3].Value = "0";//loss

                /// Adding Rows 
                n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = "Team Solid";
                dataGridView1.Rows[n].Cells[1].Value = "Alvin, Viane, Miguel , Janine";
                dataGridView1.Rows[n].Cells[2].Value = "2";// wins
                dataGridView1.Rows[n].Cells[3].Value = "0";//lost



            }

            /// Design of UI goes here

            // Design for Vertical Rows
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            // Design for Horizontal Columns
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

        }
    }
}
