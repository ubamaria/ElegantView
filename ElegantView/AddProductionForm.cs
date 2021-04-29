using BusinessLogic.BindingModel;
using BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace ElegantView
{
    public partial class AddProductionForm : Form
    {

        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id { set { id = value; } }
        private readonly IProductionLogic logic;
        private int? id;
        public AddProductionForm(IProductionLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void AddProductionForm_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    var view = logic.Read(new ProductionBindingModel { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxName.Text = view.Name.ToString();
                        textBoxKind.Text = view.Kind.ToString();
                        textBoxGender.Text = view.Gender.ToString();
                        textBoxSize.Text = view.Size.ToString();
                        textBoxColor.Text = view.Color.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)       
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && (l < 'A' || l > 'z') && l != '\b')
            {
                e.Handled = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Введите название", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(textBoxName.Text.Length > 3 && textBoxName.Text.Length < 50))
            {
                MessageBox.Show("Наименование продукции должно содержать от 3 до 50 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxKind.Text))
            {
                MessageBox.Show("Введите вид", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(textBoxKind.Text.Length > 3 && textBoxKind.Text.Length < 50))
            {
                MessageBox.Show("Вид должен содержать от 3 до 50 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(textBoxGender.Text.Length < 15))
            {
                MessageBox.Show("Пол должен содержать от 1 до 15 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxGender.Text))
            {
                MessageBox.Show("Введите пол", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxSize.Text))
            {
                MessageBox.Show("Введите размер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(textBoxSize.Text.Length < 15))
            {
                MessageBox.Show("Размер должен содержать от 1 до 15 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxColor.Text))
            {
                MessageBox.Show("Введите цвет", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(textBoxColor.Text.Length > 3 && textBoxColor.Text.Length < 50))
            {
                MessageBox.Show("Цвет должен содержать от 3 до 50 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                logic.CreateOrUpdate(new ProductionBindingModel
                {
                    Id = id,
                    Name = textBoxName.Text,
                    Kind = textBoxKind.Text,
                    Gender = textBoxGender.Text,
                    Size = Convert.ToInt32(textBoxSize.Text),
                    Color = textBoxColor.Text,
                });
                MessageBox.Show("Добавление прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                //Метод
                stopwatch.Stop();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            try
            {
                logic.CreateOrUpdate(new ProductionBindingModel
                {
                    Id = id,
                    Name = textBoxName.Text,
                    Kind = textBoxKind.Text,
                    Gender = textBoxGender.Text,
                    Size = Convert.ToInt32(textBoxSize.Text),
                    Color = textBoxColor.Text,
                });
                MessageBox.Show("Добавление прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
