
namespace WinFormsApp.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.outputListView = new System.Windows.Forms.ListView();
            this.colName1 = new System.Windows.Forms.ColumnHeader();
            this.nameLabel = new System.Windows.Forms.Label();
            this.transferButton = new System.Windows.Forms.Button();
            this.moneyTextBox = new System.Windows.Forms.TextBox();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.toUserTextBox = new System.Windows.Forms.TextBox();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adminCheatButton = new System.Windows.Forms.Button();
            this.adminMoneyTextBox = new System.Windows.Forms.TextBox();
            this.adminToUserTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.adminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.closeButton);
            this.panel1.Controls.Add(this.outputListView);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Controls.Add(this.transferButton);
            this.panel1.Controls.Add(this.moneyTextBox);
            this.panel1.Controls.Add(this.moneyLabel);
            this.panel1.Controls.Add(this.toUserTextBox);
            this.panel1.Controls.Add(this.adminPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 450);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(214, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "Переводы другим";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Сколько";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 32);
            this.label1.TabIndex = 12;
            this.label1.Text = "Кому перевести";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeButton.Location = new System.Drawing.Point(848, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(40, 40);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "x";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // outputListView
            // 
            this.outputListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.outputListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName1});
            this.outputListView.ForeColor = System.Drawing.Color.White;
            this.outputListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.outputListView.HideSelection = false;
            this.outputListView.LabelWrap = false;
            this.outputListView.Location = new System.Drawing.Point(278, 75);
            this.outputListView.Margin = new System.Windows.Forms.Padding(5);
            this.outputListView.MultiSelect = false;
            this.outputListView.Name = "outputListView";
            this.outputListView.Size = new System.Drawing.Size(250, 331);
            this.outputListView.TabIndex = 7;
            this.outputListView.TileSize = new System.Drawing.Size(220, 30);
            this.outputListView.UseCompatibleStateImageBehavior = false;
            this.outputListView.View = System.Windows.Forms.View.Tile;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(39, 48);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(76, 41);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Имя";
            // 
            // transferButton
            // 
            this.transferButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.transferButton.FlatAppearance.BorderSize = 0;
            this.transferButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transferButton.Location = new System.Drawing.Point(68, 361);
            this.transferButton.Margin = new System.Windows.Forms.Padding(5);
            this.transferButton.Name = "transferButton";
            this.transferButton.Size = new System.Drawing.Size(153, 45);
            this.transferButton.TabIndex = 4;
            this.transferButton.Text = "Перевести";
            this.transferButton.UseVisualStyleBackColor = false;
            this.transferButton.Click += new System.EventHandler(this.transferButton_Click);
            // 
            // moneyTextBox
            // 
            this.moneyTextBox.Location = new System.Drawing.Point(41, 291);
            this.moneyTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.Size = new System.Drawing.Size(201, 39);
            this.moneyTextBox.TabIndex = 3;
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.moneyLabel.Location = new System.Drawing.Point(39, 93);
            this.moneyLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(34, 41);
            this.moneyLabel.TabIndex = 2;
            this.moneyLabel.Text = "0";
            // 
            // toUserTextBox
            // 
            this.toUserTextBox.Location = new System.Drawing.Point(41, 177);
            this.toUserTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.toUserTextBox.Name = "toUserTextBox";
            this.toUserTextBox.Size = new System.Drawing.Size(201, 39);
            this.toUserTextBox.TabIndex = 1;
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.adminPanel.Controls.Add(this.label4);
            this.adminPanel.Controls.Add(this.label3);
            this.adminPanel.Controls.Add(this.adminCheatButton);
            this.adminPanel.Controls.Add(this.adminMoneyTextBox);
            this.adminPanel.Controls.Add(this.adminToUserTextBox);
            this.adminPanel.Location = new System.Drawing.Point(559, 75);
            this.adminPanel.Margin = new System.Windows.Forms.Padding(5);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(277, 287);
            this.adminPanel.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Сколько";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Кому начитерить";
            // 
            // adminCheatButton
            // 
            this.adminCheatButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(119)))));
            this.adminCheatButton.FlatAppearance.BorderSize = 0;
            this.adminCheatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminCheatButton.Location = new System.Drawing.Point(49, 197);
            this.adminCheatButton.Margin = new System.Windows.Forms.Padding(5);
            this.adminCheatButton.Name = "adminCheatButton";
            this.adminCheatButton.Size = new System.Drawing.Size(192, 48);
            this.adminCheatButton.TabIndex = 2;
            this.adminCheatButton.Text = "Создать деньги";
            this.adminCheatButton.UseVisualStyleBackColor = false;
            this.adminCheatButton.Click += new System.EventHandler(this.adminCheatButton_Click);
            // 
            // adminMoneyTextBox
            // 
            this.adminMoneyTextBox.Location = new System.Drawing.Point(43, 139);
            this.adminMoneyTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.adminMoneyTextBox.Name = "adminMoneyTextBox";
            this.adminMoneyTextBox.Size = new System.Drawing.Size(201, 39);
            this.adminMoneyTextBox.TabIndex = 1;
            // 
            // adminToUserTextBox
            // 
            this.adminToUserTextBox.Location = new System.Drawing.Point(40, 47);
            this.adminToUserTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.adminToUserTextBox.Name = "adminToUserTextBox";
            this.adminToUserTextBox.Size = new System.Drawing.Size(201, 39);
            this.adminToUserTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Button adminCheatButton;
        private System.Windows.Forms.TextBox adminMoneyTextBox;
        private System.Windows.Forms.TextBox adminToUserTextBox;
        private System.Windows.Forms.TextBox moneyTextBox;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.TextBox toUserTextBox;
        private System.Windows.Forms.Button transferButton;
        private System.Windows.Forms.ListView outputListView;
        private System.Windows.Forms.ColumnHeader colName1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}