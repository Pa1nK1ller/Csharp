using System;
using System.Windows.Forms;

namespace Task2
{
    public partial class FrnForReadingNumb : Form
    {
        public FrnForReadingNumb()
        {
            InitializeComponent();
            txtNumber.TabIndex = 0;
        }

        private void btnEnterNumber_Click(Object sender, EventArgs e)
        {
            int userAns;
            int itemIndex = -1;
            if (!int.TryParse(txtNumber.Text, out userAns)) userAns = 0;

            FormCollection openForm = Application.OpenForms;

            for (int i = 0; i < openForm.Count; i++)
            {
                if (openForm[i].ToString().Contains("MainForm"))
                {
                    itemIndex = i;
                    break;
                };
            }
            openForm[itemIndex].Show();
            openForm[itemIndex].Tag = userAns;
            txtNumber.Text = "";
            Close();
        }
    }
}
