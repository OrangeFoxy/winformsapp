using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Controllers;

namespace WinFormsApp.Forms
{
    public partial class LoginForm : Form
    {
        ApplicationContext ac;
        UserController uc;
        public event Action SuccessAuth;
        public event Action Registration;
        public LoginForm(ApplicationContext ac, UserController uc)
        {
            this.ac = ac;
            this.uc = uc;
            InitializeComponent();
        }
        public new void Show()
        {
            ac.MainForm = this;
            Application.Run(ac);
        }
        string login
        {
            get => loginTextBox.Text.Trim();
        }
        string pass
        {
            get => passTextBox.Text.Trim();
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            if(uc.AuthUser(login, pass))
            {
                SuccessAuth?.Invoke();
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль", "Ошибка");
            }
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Registration?.Invoke();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private Point mouseOffset;
        private bool isMouseDown = false;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y
                    //- SystemInformation.CaptionHeight
                    - SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
