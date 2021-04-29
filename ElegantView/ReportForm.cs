using BusinessLogic.BindingModel;
using DBImplement.Implements;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace ElegantView
{
    public partial class ReportForm : Form
    {

        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ReportLogic logic;
        private readonly RequestLogic logicR;

        public ReportForm(ReportLogic logic, RequestLogic logicR)
        {
            InitializeComponent();
            this.logic = logic;
            this.logicR = logicR;
        }

        [Obsolete]
        private void buttonToPdf_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog { Filter = "pdf|*.pdf" })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    try
                    {
                        logic.SaveReportToPdfFile(new ReportBindingModel
                        {
                            FileName = dialog.FileName,
                            DateFrom = dateTimePickerFrom.Value.Date,
                            DateTo = dateTimePickerTo.Value.Date
                        });
                        MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        Stopwatch stopwatch = new Stopwatch();
                        stopwatch.Start();
                        //Метод
                        stopwatch.Stop();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                    }
                    
                }
            }
        }

        private void buttonMake_Click(object sender, EventArgs e)
        {
            //if (dateTimePickerFrom.Value.Date >= dateTimePickerTo.Value.Date)
            //{
            //    MessageBox.Show("Дата начала должна быть меньше даты окончания", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}
            try
            {
                var dict = logic.GetRequests(new ReportBindingModel 
                { 
                    DateFrom = dateTimePickerFrom.Value.Date, 
                    DateTo = dateTimePickerTo.Value.Date 
                });
                if (dict != null)
                {
                    dataGridView.Rows.Clear();
                    foreach (var request in dict)
                    {
                        dataGridView.Rows.Add(new object[] 
                        { 
                            request.Date.ToShortDateString(), 
                            request.ProductionName, 
                            request.Count, 
                            request.Customer, 
                            request.Executor 
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 10000; i++)
                {
                    logicR.CreateOrUpdate(new RequestBindingModel
                    {
                        Id = i,
                        ProductionId = 1,
                        ProductionName = "продукция1",
                        Customer = "заказчик1",
                        Date = DateTime.Now.Date,
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
