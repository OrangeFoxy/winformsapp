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
using WinFormsApp.DB;

namespace WinFormsApp.Forms
{
    public partial class MainForm : Form
    {
        ApplicationContext ac;
        UserController uc;
        OperationController oc;
        User ActiveUser;
        public MainForm(ApplicationContext ac, UserController uc, OperationController oc)
        {
            this.ac = ac;
            this.uc = uc;
            this.oc = oc;
            InitializeComponent();
        }
        public new void Show()
        {
            ac.MainForm = this;
            ActiveUser = uc.ActiveUser;
            admin = ActiveUser.Admin;
            UpdateData();
            base.Show();
        }
        string name
        {
            set => nameLabel.Text = value;
        }

        string toUser
        {
            get => toUserTextBox.Text.Trim();
        }
        int money
        {
            get => Convert.ToInt32(moneyTextBox.Text);
        }
        int sum
        {
            set => moneyLabel.Text = $"Баланс: {value}";
        }
        string adminToUser
        {
            get => adminToUserTextBox.Text.Trim();
        }
        int adminMoney
        {
            get => Convert.ToInt32(adminMoneyTextBox.Text);
        }
        bool admin
        {
            set
            {
                adminPanel.Visible = value;
                if (!value) Size = new Size(550, Size.Height);
            }
        }
        List<(string name, int money)> outputList
        {
            set
            {
                outputListView.Clear();
                foreach (var i in value)
                {
                    ListViewItem lvi = new ListViewItem($"{i.name} - {i.money}");
                    lvi.SubItems.Add(i.money.ToString());
                    outputListView.Items.Add(lvi);
                }
            }
        }
        //List<(string name, int money)> inputList
        //{
        //    set
        //    {
        //        outputListView.Clear();
        //        foreach (var i in value)
        //        {
        //            ListViewItem lvi = new ListViewItem(i.name);
        //            lvi.SubItems.Add(i.money.ToString());
        //            outputListView.Items.Add(lvi);
        //        }
        //    }
        //}
        private void UpdateData()
        {
            sum = ActiveUser.Money;
            name = ActiveUser.Name;
            outputList = oc.GetOutputOperations(ActiveUser);
            //inputList = oc.GetInputOperations(ActiveUser.Login);
        }
        private void transferButton_Click(object sender, EventArgs e)
        {
            if (oc.TransferMoney(ActiveUser, toUser, money))
            {
                UpdateData();
                MessageBox.Show("Деньги переведены", "Успех");
            }
            else
            {
                MessageBox.Show("Недостаток денег или неверный пользователь", "Ошибка");
            }
        }
        private void adminCheatButton_Click(object sender, EventArgs e)
        {
            if (oc.CheatMoney(adminToUser, adminMoney))
            {
                UpdateData();
                MessageBox.Show("Деньги созданы", "Успех");
            }
            else
            {
                MessageBox.Show("Неверный пользователь", "Ошибка");
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
