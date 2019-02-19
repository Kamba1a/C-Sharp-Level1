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
//3. а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок
//(не создана база данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
//б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
//в) Добавить в приложение меню «О программе» с информацией о программе(автор, версия, авторские права и др.).
//г)* Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных(элемент SaveFileDialog).

namespace Task3
{
    public partial class Form1 : Form
    {
        // Инициализация экземпляра класса TrueFalse
        /// <summary>
        /// База данных с вопросами
        /// </summary>
        TrueFalse database;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик пункта меню Exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Обработчик пункта меню New
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(sfd.FileName);
                database.Add("Введите сюда вопрос, внизу поставьте галочку правда/нет и нажмите [Сохранить вопрос]. Чтобы добавить следующий вопрос, нажмите кнопку [Добавить новый вопрос]", true);
                database.Save();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = 1;
                nudNumber.Value = 1;
                tboxQuestion.Text = database[0].Text;
                this.Text = $"{database.FileName}";
            };
        }

        /// <summary>
        /// Обработчик события изменения значения numericUpDown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nudNumber_ValueChanged(object sender, EventArgs e)
        {
            tboxQuestion.Text = database[(int)nudNumber.Value - 1].Text;
            cboxTrue.Checked = database[(int)nudNumber.Value - 1].TrueFalse;
        }

        /// <summary>
        /// Обработчик кнопки Добавить вопрос
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Сообщение");
                return;
            }
            database.Add("Введите сюда новый вопрос", true);
            nudNumber.Maximum = database.Count;
            nudNumber.Value = database.Count;
        }

        /// <summary>
        /// Обработчик кнопки Удалить вопрос
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (nudNumber.Maximum == 1 || database == null)
            {
                MessageBox.Show("Все вопросы удалены!");
                tboxQuestion.Text = "Введите сюда вопрос, внизу поставьте галочку правда/нет и нажмите [Сохранить вопрос]. Чтобы добавить следующий вопрос, нажмите кнопку [Добавить новый вопрос]";
                return;
            }
            database.Remove((int)nudNumber.Value-1);
            nudNumber.Maximum--;
            tboxQuestion.Text = database[(int)nudNumber.Value - 1].Text;
        }

        /// <summary>
        /// Обработчик пункта меню Сохранить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miSave_Click(object sender, EventArgs e)
        {
            if (database != null) database.Save();
            else MessageBox.Show("База данных не создана");
        }

        /// <summary>
        /// Обработчик пункта меню Open
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(ofd.FileName);
                database.Load();
                nudNumber.Minimum = 1;
                nudNumber.Maximum = database.Count;
                nudNumber.Value = 1;
                tboxQuestion.Text = database[0].Text;
                this.Text = $"{database.FileName}";
            }
        }

        /// <summary>
        /// Обработчик кнопки Сохранить вопрос
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveQuest_Click(object sender, EventArgs e)
        {
            database[(int)nudNumber.Value - 1].Text = tboxQuestion.Text;
            database[(int)nudNumber.Value - 1].TrueFalse = cboxTrue.Checked;
        }

        /// <summary>
        /// Обработчик пункта меню "Автор"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miAuthor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Первоначальный код программы предоставлен сайтом GeekBrains.ru\nДо текущей версии программа доработана Назаровой Ольгой", "Автор");
        }

        /// <summary>
        /// Обработчик пункта меню "Версия"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miVersion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Версия 2.0", "Версия");
        }

        /// <summary>
        /// Обработчик пункта меню "Авторские права"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miCopyright_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"CopyRight{Convert.ToChar(0169)} GeekBrains & Nazarova Olga", "CopyRight");
        }

        /// <summary>
        /// Обработчик пункта меню "Сохранить как"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miSaveAs_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    database.FileName = sfd.FileName;
                    database.Save();
                }
            }
            else MessageBox.Show("База данных не создана");
            this.Text = $"{database.FileName}";
        }
    }
}

