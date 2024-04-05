namespace AssuranceUA3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow newRow = new DataGridViewRow();

            newRow.Cells[0].Value = "Value 1";
            newRow.Cells[1].Value = "Value 2";
            newRow.Cells[2].Value = "Value 3";

            dataGridView1.Rows.Add(newRow);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Refresh();
        }
    }
}
