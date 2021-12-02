﻿using System;
using System.Windows.Forms;

namespace Task2
{
    public partial class MainForm : Form
    {
        Random rnd = new Random();
        int num;
        FrnForReadingNumb frmEnterValue = new FrnForReadingNumb();

        public int UserAns { get; set; }

        public MainForm()
        {
            InitializeComponent();
            lblInfo.Text = "Нажмите Запустить игру";
            btnEnterNumber.Enabled = false;
            btnStart.TabIndex = 0;
        }

        private void btnStart_Click(Object sender, EventArgs e)
        {
            lblInfo.Text = "Игра началась, загадано число от 1 до 100. Чтобы угадать число, откройте форму ввода числа и введите нужное число";
            btnStart.Enabled = false;
            btnEnterNumber.Enabled = true;
            num = rnd.Next(1, 101);
        }

        private void btnEnterNumber_Click(Object sender, EventArgs e)
        {
            frmEnterValue.ShowDialog();
            checkAns();
        }

        void checkAns()
        {
            if (int.Parse(Tag.ToString()) > num)
            {
                lblInfo.Text = $"Попробуйте еще раз, число должно быть меньше";
            }
            else if (int.Parse(Tag.ToString()) < num)
            {
                lblInfo.Text = $"Попробуйте еще раз, число должно быть больше";
            }
            else lblInfo.Text = $"Вы угадали, Компюьтер загадал число : {num}";
        }
    }
}
