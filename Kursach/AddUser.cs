using System;
using System.Threading;
using System.Windows.Forms;

namespace Kursach
{
    public partial class AddUser : Form
    {
        public bool Init { get; private set; }
        private DataGridView _dataGridView;
        private MainForm _mainForm;
        public AddUser(MainForm mainForm)
        {
            InitializeComponent();
            Init = false;
            _mainForm = mainForm;
        }
        
        public AddUser(DataGridView dataGridView, MainForm mainForm)
        {
            InitializeComponent();
            Init = false;
            _dataGridView = dataGridView;
            _mainForm = mainForm;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(comboBoxNumber.Text) > 7 || Convert.ToInt32(comboBoxNumber.Text) < 1)
                {
                   
                    throw new Exception($"Введено некорректное значение, значение может лежать в диапозоне " +
                                        $"{comboBoxNumber.Items[0]} - {comboBoxNumber.Items[comboBoxNumber.Items.Count - 1]}");
                    comboBox1.Text = "";
                }
            }   
            catch (Exception exception)
            {
                if (comboBoxNumber.Text != "")
                {
                    comboBoxNumber.Text = "";
                    MessageBox.Show(exception.Message, "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Init = true;
                Close();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int n = -1;
                for (int i = 0; i < _dataGridView.Rows.Count; i++)
                {
                    if (Convert.ToInt32(textBoxID.Text) == Convert.ToInt32(_dataGridView.Rows[i].Cells[0].Value))
                    {
                        n = i;
                        break;
                    }
                }

                char name = _dataGridView.Rows[n].Cells[1].Value.ToString().Split()[1][0];
                string surname = _dataGridView.Rows[n].Cells[1].Value.ToString().Split()[0];
                char secondName = _dataGridView.Rows[n].Cells[1].Value.ToString().Split()[2][0];
                textBoxName.Text = name.ToString();
                textBoxSurName.Text = surname;
                textBoxSecondName.Text = secondName.ToString();
                comboBoxNumber.Text = _dataGridView.Rows[n].Cells[3].Value.ToString();
                textBoxDuration.Text = _dataGridView.Rows[n].Cells[4].Value.ToString();
                textBoxExpenses.Text = _dataGridView.Rows[n].Cells[6].Value.ToString();
                textBoxPrice.Text = _dataGridView.Rows[n].Cells[5].Value.ToString();
                TextBoxDisease.Text = _dataGridView.Rows[n].Cells[2].Value.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void AddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Init)
            {
                DataBank.UserName = textBoxName.Text;
                DataBank.UserSurname = textBoxSurName.Text;
                DataBank.UserSecondName = textBoxSecondName.Text;
                DataBank.Disease = TextBoxDisease.Text;
                DataBank.NumberOfSector = Convert.ToInt32(comboBoxNumber.Text);
                DataBank.Duration = Convert.ToInt32(textBoxDuration.Text);
                DataBank.PricePerDay = Convert.ToInt32(textBoxPrice.Text);
                DataBank.Expenses = Convert.ToInt32(textBoxExpenses.Text);
                if (textBoxID.Visible)
                {
                    DataBank.ID = Convert.ToInt32(textBoxID.Text);
                }

                if (_dataGridView == null)
                {
                    _mainForm.UserInitialization();
                }
                else
                {
                    _mainForm.UserReInitialization();
                }
            }
        }
    }
}