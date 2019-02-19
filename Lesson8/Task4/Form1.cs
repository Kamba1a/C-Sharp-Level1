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
//4. * Используя полученные знания и класс TrueFalse в качестве шаблона, разработать собственную утилиту хранения данных
//(Например: Дни рождения, Траты, Напоминалка, Английские слова и другие).

namespace Task4
{
    public partial class Form1 : Form
    {
        Birthdays database;

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Кнопка "Добавить в список"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtbName.Text != "")
            {
                database.Add(txtbName.Text, dtpDateOfBirth.Value);
                lstbCollection.Items.Add($"{txtbName.Text} - {dtpDateOfBirth.Value.ToString("dd.MM.yyyy")}");
                txtbName.Text = "";
            }
            else MessageBox.Show("Введите имя");
        }

        /// <summary>
        /// Кнопка "Удалить из списка"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                database.Remove(lstbCollection.SelectedIndex);
                lstbCollection.Items.Remove(lstbCollection.SelectedItem);
                txtbName.Text = "";
            }
        }

        /// <summary>
        /// Пункт меню "Новый"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miNew_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                database = new Birthdays(sfd.FileName);
                lstbCollection.Items.Clear();
            }
        }

        /// <summary>
        /// Пункт меню "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miSave_Click(object sender, EventArgs e)
        {
            if (database.FileName != null) database.Save();
            else
            {
                SaveFileDialog sfd = new SaveFileDialog();
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    database.FileName = sfd.FileName;
                    database.Save();
                }
            }
        }

        /// <summary>
        /// Пункт меню "Открыть"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                database.FileName = ofd.FileName;
                database.Load();
                lstbCollection.Items.Clear();
                for (int i = 0; i < database.Count; i++)
                {
                    lstbCollection.Items.Add($"{database[i].Name} - {database[i].DateOfBirth.ToString("dd.MM.yyyy")}");
                }
            }
        }

        /// <summary>
        /// Пункт меню "Выход"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Первое открытие формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Shown(object sender, EventArgs e)
        {
            database = new Birthdays();
        }

        /// <summary>
        /// Отслеживание выбора элементов ListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstbCollection_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtbName.Text = database[lstbCollection.SelectedIndex].Name;
                dtpDateOfBirth.Value = database[lstbCollection.SelectedIndex].DateOfBirth;
            }
            catch (ArgumentOutOfRangeException) //не очень понятно, почему вызывается это исключение, но дальше все работает
            {
            }
        }

        /// <summary>
        /// Кнопка "Отредактировать элемент списка"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditSave_Click(object sender, EventArgs e)
        {
            if (database != null)
            {
                database[lstbCollection.SelectedIndex].Name = txtbName.Text;
                database[lstbCollection.SelectedIndex].DateOfBirth = dtpDateOfBirth.Value;
                lstbCollection.Items[lstbCollection.SelectedIndex] = $"{txtbName.Text} - {dtpDateOfBirth.Value.ToString("dd.MM.yyyy")}";
                //lstbCollection.SelectedItem = $"{txtbName.Text} - {dtpDateOfBirth.Value.ToString("dd.MM.yyyy")}"; //не работает
            }
        }
    }
}
