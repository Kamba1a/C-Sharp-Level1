using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//ОЛЬГА НАЗАРОВА
//1. а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
//б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.Игрок должен получить это число за минимальное количество ходов.
//в) * Добавить кнопку «Отменить», которая отменяет последние ходы.Используйте  библиотечный обобщенный класс Stack
// Вся логика игры должна быть реализована в классе с удвоителем.

namespace Task1_doublerGame
{
    public partial class FormGame : Form
    {
        Random rand = new Random();

        /// <summary>
        /// Коллекция для хранения всех значений labelNumber.Text
        /// </summary>
        Stack<string> stepsMemory = new Stack<string>();

        public FormGame()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработка нажатия на кнопку "+1"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPlusOne_Click(object sender, EventArgs e)
        {
            stepsMemory.Push(labelNumber.Text);
            labelNumber.Text = (int.Parse(labelNumber.Text) + 1).ToString();
            labelStepCount.Text = (int.Parse(labelStepCount.Text) + 1).ToString();
            checkWin();
        }

        /// <summary>
        /// Обработка нажатия на кнопку "х2"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMultiTwo_Click(object sender, EventArgs e)
        {
            stepsMemory.Push(labelNumber.Text);
            labelNumber.Text = (int.Parse(labelNumber.Text) * 2).ToString();
            labelStepCount.Text = (int.Parse(labelStepCount.Text) + 1).ToString();
            checkWin();
        }

        /// <summary>
        /// Обработка нажатия на кнопку "Сброс"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonReset_Click(object sender, EventArgs e)
        {
            labelNumber.Text = "1";
            labelStepCount.Text = "0";
            stepsMemory.Clear();
        }

        /// <summary>
        /// Обработка нажатия на кнопку "Новое число"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNumberGen_Click(object sender, EventArgs e)
        {
            newNumber();
        }

        /// <summary>
        /// Генерация нового числа и обнуление всех игровых значений
        /// </summary>
        void newNumber()
        {
            int r = rand.Next(10, 100);
            labelNewNumber.Text = r.ToString();
            labelSteps.Text = Steps(r);
            labelNumber.Text = "1";
            labelStepCount.Text = "0";
            stepsMemory.Clear();
            MessageBox.Show($"За {labelSteps.Text} ходов преобразуйте единицу в число {labelNewNumber.Text}");
        }

        /// <summary>
        ///  Проверка на достижение цели игры с выводом сообщения
        /// </summary>
        void checkWin()
        {
            if (labelNumber.Text == labelNewNumber.Text && labelStepCount.Text == labelSteps.Text)
            {
                MessageBox.Show($"Вы смогли набрать нужное число за минимум ходов!");
                DialogResult dialogResult = MessageBox.Show("Хотите сгенерировать новое число?", "Поздравляю!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    newNumber();
                }
            }
        }

        /// <summary>
        /// Подготовка игры при первом открытии окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Shown(object sender, EventArgs e)
        {
            buttonStepReturn.Enabled = false;
            newNumber();
        }

        /// <summary>
        /// Метод возвращает минимальное количество ходов, за которое можно достичь целевого числа
        /// </summary>
        /// <param name="number">Сгенерированное число</param>
        /// <returns>Количество ходов</returns>
        string Steps(int number)
        {
            int steps = 0;
            while (number > 1)
            {
                if (number % 2 == 0)
                {
                    number = number / 2;
                }
                else
                {
                    number = number - 1;
                }
                steps++;
            }
            return steps.ToString();
        }

        /// <summary>
        /// Обработка нажатия на кнопку "Отменить ход"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStepReturn_Click(object sender, EventArgs e)
        {
            labelNumber.Text = stepsMemory.Pop();
            labelStepCount.Text = (int.Parse(labelStepCount.Text) - 1).ToString();
        }

        /// <summary>
        /// Изменение активности кнопки "Отменить ход" при пустой коллекции stepsMemory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelNumber_TextChanged(object sender, EventArgs e)
        {
            buttonStepReturn.Enabled = (int.Parse(labelNumber.Text) > 1);
        }
    }
}
