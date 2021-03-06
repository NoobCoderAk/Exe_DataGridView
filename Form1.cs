using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exe_DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //memanggil method styling winform
            StyleDataGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

        }

        //method untuk styling winform

        void StyleDataGridView()
        {
            //mengset text pada masing-masing kolom
            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Violet;
            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Green;
            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.SeaGreen;
            dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Red;

            //mengset warna background pada masing-masing kolom
            dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.Pink;
            dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.Orange;
            dataGridView1.Columns[2].DefaultCellStyle.SelectionBackColor = Color.Green;
            dataGridView1.Columns[3].DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.Maroon;

            //mengset deafault warna text saat cursor di arahkan ke text
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            //mengset align pada colom sex
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            //mengset textstyle header menjadi bold
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font(DataGridView.DefaultFont, FontStyle.Bold);

            //bakground 
            BackColor = Color.Black;
        }
    }
}
