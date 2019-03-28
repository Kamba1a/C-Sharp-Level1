using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// ОЛЬГА НАЗАРОВА
//2. Используя Windows Forms, разработать игру «Угадай число».
//Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток.
//Компьютер говорит, больше или меньше загаданное число введенного.
//a) Для ввода данных от человека используется элемент TextBox;
//б) ** Реализовать отдельную форму c TextBox для ввода числа.

namespace Task2_guessingGame
{
    public partial class FormGame : Form
    {
        Random rand = new Random();

        /// <summary>
        /// Загаданное число
        /// </summary>
        int hiddenNumber;

        /// <summary>
        /// Заданное количество попыток
        /// </summary>
        int attempts = 7;

        /// <summary>
        /// Счетчик попыток игрока
        /// </summary>
        int attemptsCount;

        public FormGame()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Подготовка к игре при первом открытии окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormGame_Shown(object sender, EventArgs e)
        {
            NewGame();
        }

        /// <summary>
        /// Начало новой игры (загадывается число, обновляются параметры)
        /// </summary>
       void NewGame()
        {
            labelCommunication.Text = "Компьютер загадал число - отгадай его!";
            hiddenNumber = rand.Next(1, 101);
            estimatedNumber.Value = 100;
            estimatedNumber.Select(0, estimatedNumber.Text.Length);
            attemptsCount = 1;
            labelAttempts.Text = $"Попытка {attemptsCount}";
        }

        /// <summary>
        /// Обработка нажатия кнопки "ОК"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOK_Click(object sender, EventArgs e)
        {
            attemptsCount++;
            labelAttempts.Text = $"Попытка {attemptsCount}";
            if (estimatedNumber.Value > hiddenNumber)
            {
                labelCommunication.Text = "Загаданное число меньше";
            }
            else if (estimatedNumber.Value < hiddenNumber)
            {
                labelCommunication.Text = "Загаданное число больше";
            }
            else
            {
                labelCommunication.Text = "Вы угадали!";
                DialogResult dialogResult = MessageBox.Show($"Вы угадали! Загаданное число было {hiddenNumber}\nХотите сыграть еще раз?","Поздравляю!", MessageBoxButtons.YesNo);
                checkAnswerGameContinue(dialogResult);
            }

            if (attemptsCount > attempts)
            {
                labelCommunication.Text = "Не угадали =(";
                labelAttempts.Text = "Попытки кончились";
                DialogResult dialogResult = MessageBox.Show($"Вы не угадали =( Загаданное число было {hiddenNumber}\nХотите сыграть еще раз?", "Попытки кончились", MessageBoxButtons.YesNo);
                checkAnswerGameContinue(dialogResult);
            }

            estimatedNumber.Select(0, estimatedNumber.Text.Length);
        }

        /// <summary>
        /// Обработка ответа игрока на предложение новой игры
        /// </summary>
        /// <param name="dialogResult"></param>
        void checkAnswerGameContinue(DialogResult dialogResult)
        {
            if (dialogResult == DialogResult.No)
            {
                Close();
            }
            else
            {
                NewGame();
            }
        }
    }
}
