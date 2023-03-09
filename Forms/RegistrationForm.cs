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
    public partial class RegistrationForm : Form
    {
        UserController uc;
        public RegistrationForm(UserController uc)
        {
            this.uc = uc;
            InitializeComponent();
        }
        string login
        {
            get => loginTextBox.Text.Trim();
        }
        string pass
        {
            get => passTextBox.Text.Trim();
        }
        string name
        {
            get => nameTextBox.Text.Trim();
        }
        bool admin
        {
            get => adminCheckBox.Checked;
        }
        public new void Show()
        {
            ShowDialog();
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if (uc.RegisterUser(login, pass, name, admin))
            {
                Close();
            }
            else
            {
                MessageBox.Show("Данный логин уже используется", "Ошибка");
            }
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
