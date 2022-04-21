using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using ExcelDataReader;

namespace Kursach
{
    public partial class MainForm : Form
    {
        private string _fileName = string.Empty;

        private DataTableCollection _tableCollection = null;
        private int ID;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = openFileDialog1.ShowDialog();
                if (res == DialogResult.OK)
                {
                    _fileName = openFileDialog1.FileName;
                    Text = _fileName;
                    OpenExcelFile(_fileName);
                    действияСТаблицейToolStripMenuItem.Enabled = true;
                    редактированиеТаблицыToolStripMenuItem.Enabled = true;
                }
                else
                {
                    throw new Exception("Файл не выбран");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenExcelFile(string path)
        {
            FileStream stream = File.Open(path, FileMode.Open, FileAccess.Read);

            IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream);

            DataSet db = reader.AsDataSet(new ExcelDataSetConfiguration()
            {
                ConfigureDataTable = (x) => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true
                } 
            });
            _tableCollection = db.Tables;
            
            toolStripComboBox1.Items.Clear();

            foreach (DataTable table in _tableCollection)
            {
                toolStripComboBox1.Items.Add(table.TableName);
            }

            toolStripComboBox1.SelectedIndex = 0;
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable table = _tableCollection[Convert.ToString(toolStripComboBox1.SelectedItem)];

            dataGridView1.DataSource = table;
            ID = dataGridView1.Rows.Count + 1001;
            
            dataGridView1.AutoResizeColumns();
            int width = dataGridView1.Columns[2].Width;
            for (int i = 3; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.Columns[i].Width -= width/4;
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExitWindow exitWindow = new ExitWindow();
            exitWindow.ShowDialog();
            if (exitWindow.exit)
            {
                Close();
            }
        }

        public void UserInitialization()
        {
            DataTable table = _tableCollection[Convert.ToString(toolStripComboBox1.SelectedItem)];
            
            string userName = DataBank.UserName + " " + DataBank.UserSurname[0] + "." + " "
                              + DataBank.UserSecondName[0] + ".";
            table.Rows.Add(ID, userName, DataBank.Disease,
                DataBank.NumberOfSector, DataBank.Duration, DataBank.PricePerDay, DataBank.Expenses);

            ID++;
            dataGridView1.DataSource = table;
        }

        private void AddUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser addWindow = new AddUser(this);
            addWindow.ShowDialog();
        }

        private void DeleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteUser.Visible = true;
            DeleteUser.Enabled = true;
            buttonDeleteUser.Visible = true;
            buttonDeleteUser.Enabled = true;
            textBoxDeleteUser.Visible = true;
            textBoxDeleteUser.Enabled = true;
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable table = _tableCollection[Convert.ToString(toolStripComboBox1.SelectedItem)];

                int n = -1;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (Convert.ToInt32(textBoxDeleteUser.Text) == Convert.ToInt32(table.Rows[i][0]))
                    {
                        n = i;
                        break;
                    }
                }
                table.Rows.Remove(table.Rows[n]);
                dataGridView1.DataSource = table;
            }
            catch (Exception exception)
            {
                throw new Exception("Данного пользователя не существует");
            }
            DeleteUser.Visible = false;
            DeleteUser.Enabled = false;
            buttonDeleteUser.Visible = false;
            buttonDeleteUser.Enabled = false;
            textBoxDeleteUser.Visible = false;
            textBoxDeleteUser.Enabled = false;
            textBoxDeleteUser.Text = "";
        }

        private void InfoDiseaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoWindow infoWindow = new InfoWindow(dataGridView1);
            infoWindow.ShowDialog();
        }

        private void ChangeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser reAddUser = new AddUser(dataGridView1, this);
            reAddUser.label1.Text = "Изменение данных пациента";
            reAddUser.button1.Text = "Изменить";
            reAddUser.labelID.Visible = true;
            reAddUser.labelID.Enabled = true;
            reAddUser.textBoxID.Visible = true;
            reAddUser.textBoxID.Enabled = true;
            reAddUser.buttonSearch.Visible = true;
            reAddUser.buttonSearch.Enabled = true;
            reAddUser.ShowDialog();
        }
        
        public void UserReInitialization()
        {
            DataTable table = _tableCollection[Convert.ToString(toolStripComboBox1.SelectedItem)];
            
            string userName = DataBank.UserSurname + " " + DataBank.UserName[0] + "." + " "
                              + DataBank.UserSecondName[0] + ".";
            int n = -1;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (DataBank.ID == Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value))
                {
                    n = i;
                    break;
                }
            }

            dataGridView1.Rows[n].Cells[1].Value = userName;
            dataGridView1.Rows[n].Cells[2].Value = DataBank.Disease;
            dataGridView1.Rows[n].Cells[3].Value = DataBank.NumberOfSector;
            dataGridView1.Rows[n].Cells[4].Value = DataBank.Duration;
            dataGridView1.Rows[n].Cells[5].Value = DataBank.PricePerDay;
            dataGridView1.Rows[n].Cells[6].Value = DataBank.Expenses;

            dataGridView1.DataSource = table;
        }

        private void SecondTableViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataTable table = _tableCollection[Convert.ToString(toolStripComboBox1.SelectedItem)];
            SecondTable secondTable = new SecondTable(table);
            secondTable.ShowDialog();
        }

        private void ChangePriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PriceChangeWindow priceChangeWindow = new PriceChangeWindow(dataGridView1);
            priceChangeWindow.ShowDialog();
        }

        private void RemoveRowsWithMinPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int min = Int32.MaxValue;
            DataTable table = _tableCollection[Convert.ToString(toolStripComboBox1.SelectedItem)];
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (min > Convert.ToInt32(table.Rows[i][5]))
                {
                    min = Convert.ToInt32(table.Rows[i][5]);
                }
            }

            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (min == Convert.ToInt32(table.Rows[i][5]))
                {
                    table.Rows.Remove(table.Rows[i]);
                    i--;
                    dataGridView1.DataSource = table;
                }
            }
            
        }
    }
}