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
    public partial class RequestForm : Form
    {

        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IRequestLogic logic;


        public RequestForm(IRequestLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void buttonMake_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<AddRequestForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Удалить запись", "Вопрос", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id =
                   Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                    try
                    {
                        logic.Delete(new RequestBindingModel { Id = id });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    LoadData();
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    //Метод
                    
                    stopwatch.Stop();
                }
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<AddRequestForm>();
                form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
            }
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<ReportForm>();
            form.ShowDialog();
        }
        private void LoadData()
        {

            try
            {
                var list = logic.Read(null);
                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[1].Visible = false;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void RequestForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int t = (DateTime.Now.Date.AddMonths(1) - DateTime.Now.Date.AddMonths(2)).Days;
                for (int i = 0; i < 100000; i++)
                {
                    logic.CreateOrUpdate(new RequestBindingModel
                    {
                       Id = i,
                        ProductionId = 1,
                        ProductionName = "продукция1",
                        Customer = "заказчик1",
                        Date = DateTime.Now.Date.AddMonths(1),                      
                        Executor = "улгту",
                        Count = 42,
                    });
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    //Метод
                    stopwatch.Stop();
                }
                MessageBox.Show("Заявки добавлены", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}
