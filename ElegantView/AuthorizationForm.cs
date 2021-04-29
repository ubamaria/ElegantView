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
    public partial class AuthorizationForm : Form
    {

        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly IUserLogic _user;
        public AuthorizationForm(IUserLogic user)
        {
            InitializeComponent();
            _user = user;
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            //Метод
            stopwatch.Stop();
            if (!string.IsNullOrEmpty(textBoxLogin.Text) && !string.IsNullOrEmpty(textBoxPassword.Text))
            {
                try
                {
                    var user = _user.Read(null);
                    foreach (var us in user)
                    {
                        if (us.Login == textBoxLogin.Text && us.Password == textBoxPassword.Text)
                        {
                            Hide();
                            var form = Container.Resolve<MainForm>();
                            form.ShowDialog();
                            Close();

                        }
                        else
                        {
                            MessageBox.Show("Неверно введен логин и/или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Введите логин и пароль", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }

        }
    }
}
