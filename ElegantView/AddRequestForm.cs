using BusinessLogic.BindingModel;
using BusinessLogic.Interfaces;
using BusinessLogic.ViewModel;
using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
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
    public partial class AddRequestForm : Form
    {

        [Dependency]
        public new IUnityContainer Container { get; set; }
        public int Id {
            set { id = value; }
        }
        private readonly IRequestLogic logicR;
        private readonly IProductionLogic logicP;
        private int? id;
        public AddRequestForm(IProductionLogic logicP, IRequestLogic logicR)
        {
            InitializeComponent();
            this.logicR = logicR;
            this.logicP = logicP;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (comboBoxProd.SelectedValue == null)
            {
                MessageBox.Show("Выберите продукцию", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(textBoxCount.Text))
            {
                MessageBox.Show("Заполните количество", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Convert.ToInt32(textBoxCount.Text) < 0)
            {
                MessageBox.Show("Количество должно быть больше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxCust.Text))
            {
                MessageBox.Show("Заполните заказчика", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(textBoxCust.Text.Length > 3 && textBoxCust.Text.Length < 50))
            {
                MessageBox.Show("Заказчик должен содержать от 3 до 50 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxEx.Text))
            {
                MessageBox.Show("Заполните исполнителя", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(textBoxEx.Text.Length > 3 && textBoxEx.Text.Length < 50))
            {
                MessageBox.Show("Исполнитель должен содержать от 3 до 50 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                logicR.CreateOrUpdate(new RequestBindingModel
                {
                    Id = id,
                    Count = Convert.ToInt32(textBoxCount.Text),
                    Date = dateTimePicker1.Value.Date,
                    ProductionId = Convert.ToInt32(comboBoxProd.SelectedValue),
                    ProductionName = comboBoxProd.Text,
                    Customer = textBoxCust.Text,
                    Executor = textBoxEx.Text
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
        private void AddRequestForm_Load(object sender, EventArgs e)
        {
            var list = logicP.Read(null);
            if (list != null)
            {
                comboBoxProd.DataSource = list;
                comboBoxProd.DisplayMember = "Name";
                comboBoxProd.ValueMember = "Id";
            }
            if (id.HasValue)
            {
                try
                {
                    var view = logicR.Read(new RequestBindingModel { Id = id })?[0];
                    if (view != null)
                    {
                        textBoxCount.Text = view.Count.ToString();
                        textBoxCust.Text = view.Customer.ToString();
                        textBoxEx.Text = view.Executor.ToString();
                        dateTimePicker1.Value = view.Date;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
