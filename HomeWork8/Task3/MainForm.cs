using System;
using System.Windows.Forms;

namespace Task3
{
    public partial class MainForm : Form
    {
        private TrueFalseEngine database;
        public MainForm()
        {
            InitializeComponent();
        }
        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalseEngine(saveFileDialog.FileName);
                database.Add("Земля круглая?", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
            }

        }
        private void menuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalseEngine(openFileDialog.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
            }
        }


        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                tbQuestion.Text = database[(int)nudNumber.Value - 1].Text;
                cbTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Подробности: {ex.Message}", "Данный вопрос отсутствует");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string questionText = $"#{database.Count + 1}";
            database.Add(questionText, true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null) return;
            database.Remove((int)nudNumber.Value - 1);
            nudNumber.Maximum = database.Count;
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            database.Save();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                database[(int)nudNumber.Value - 1].Text = tbQuestion.Text;
                database[(int)nudNumber.Value - 1].TrueFalse = cbTrue.Checked;
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Подробности: {ex.Message}", "Откройте или создайте файл с вопросами");
            }
        }
        private void menuItemAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Зикранец Константин\nВсе права защищены\nВерсия 0.01а", "О программе");
        }

        private void menuItemSaveAs_Click(object sender, EventArgs e)
        {
            if (DialogSaveAs.ShowDialog() == DialogResult.Cancel)
                return;
            if (database == null)
            {
                database = new TrueFalseEngine(DialogSaveAs.FileName);
                database.Add("123", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
                MessageBox.Show("Файл сохранен");
            }
            else
            {
                database.FileName = DialogSaveAs.FileName;
                database.Save();
                MessageBox.Show("Файл сохранен");
            }
        }
    }
}
