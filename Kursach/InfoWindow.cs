using System;
using System.Windows.Forms;

namespace Kursach
{
    public partial class InfoWindow : Form
    {

        private DataGridView _gridView;
        public InfoWindow(DataGridView gridView)
        {
            InitializeComponent();
            _gridView = gridView;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in _gridView.Rows)
            {
                if (row.Cells[2].Value.ToString() == textBoxName.Text)
                {
                    textBoxPrice.Text = row.Cells[5].Value.ToString();
                    textBoxExpenses.Text = row.Cells[6].Value.ToString();
                    break;
                }
            }
        }
    }
}