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
    public partial class MainForm : Form
    {

        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IProductionLogic logic;
        public MainForm(IProductionLogic logic)
        {
            InitializeComponent();
            this.logic = logic;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<AddProductionForm>();
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
                        logic.Delete(new ProductionBindingModel { Id = id });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    LoadData();
                }
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                //Метод
                stopwatch.Stop();
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {

            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<AddProductionForm>();
                form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadData();
                }
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
                //Метод
                stopwatch.Stop();
            }
        }

        private void buttonReq_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<RequestForm>();
            form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 20; i++)
                {
                    logic.CreateOrUpdate(new ProductionBindingModel
                    {
                        Id = i,
                        Name = "рубашка",
                        Kind = "классика",
                        Gender = "мужской",
                        Size = 42,
                        Color = "белый"
                    });
                    Stopwatch stopwatch = new Stopwatch();
                    stopwatch.Start();
                    //Метод
                    stopwatch.Stop();
                }
                MessageBox.Show("Продукция добавлена", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
    }
}
