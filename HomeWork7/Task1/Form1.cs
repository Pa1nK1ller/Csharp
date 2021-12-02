using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HomeWork7
{
    public partial class Form1 : Form
    {
        private readonly Random random = new Random();
        private int computerNumber;
        private int userNumber = 1;
        int clickNum = 0;
        Stack<int> stack = new Stack<int>();

        public Form1()
        {
            InitializeComponent();
            stack.Push(userNumber);
            Init(false);
        }

        private void BtnRestart_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            UpdateGameState(++userNumber, ++clickNum);
            stack.Push(userNumber);
            CheckWin();
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            UpdateGameState(userNumber *= 2, ++clickNum);
            stack.Push(userNumber);
            CheckWin();
        }

        private void UpdateGameState(int userNumber, int clickNumber)
        {
            lbUserNumber.Text = $"Текущее число: {userNumber}";
            lbCounter.Text = $"Кол-во кликов: {clickNumber}";

        }

        private void UpdateGameState(int userNumber, int computerNumber, int clickNumber)
        {
            UpdateGameState(userNumber, 0);
            this.computerNumber = computerNumber;
            this.clickNum = 0;
            lbComputerNumber.Text = $"Получите число: {computerNumber}";
            lbCounter.Text = $"Кол-во кликов: {clickNumber}";
        }

        private void CheckWin()
        {
            if (computerNumber == userNumber)
            {
                MessageBox.Show($"Вы успешно завершили игру за {clickNum} ходов", "Удвоитель",
                    MessageBoxButtons.OK, MessageBoxIcon.Information); ; ;
                if (MessageBox.Show("Желаете сыграть еще раз?", "Удвоитель",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Restart();
                }
                else
                {
                    Close();
                }
            }
        }

        private void menuItemGame_Click(object sender, EventArgs e)
        {
            int rnd = random.Next(50);
            MessageBox.Show($"Получите за минимальное кол-во ходов число: {rnd}");
            UpdateGameState(userNumber *= 0, rnd, 0);
            stack.Clear();
            stack.Push(userNumber);
            Init(true);
        }
        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnUndo_Click(object sender, EventArgs e)
        {
            try
            {
                stack.Pop();
                userNumber = stack.Peek();

            }
            catch (Exception)
            {
                MessageBox.Show($"Стек пуст");
                stack.Push(1);
            }
            UpdateGameState(userNumber, ++clickNum);
        }
        private void Restart()
        {
            UpdateGameState(userNumber *= 0, random.Next(50), 0);
            stack.Clear();
            stack.Push(userNumber);
            clickNum = 0;
        }
        private void Init(bool init)
        {
            btnPlus1.Visible = init;
            btnReset.Visible = init;
            btnX2.Visible = init;
            btnUndo.Visible = init;
        }
    }
}
