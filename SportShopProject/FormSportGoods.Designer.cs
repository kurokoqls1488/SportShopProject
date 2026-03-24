namespace SportShopProject
{
    partial class FormSportGoods
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelTopSportGoods = new Panel();
            labelUserName = new Label();
            buttonExit = new Button();
            dataGridViewSportGoods = new DataGridView();
            panelTopSportGoods.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSportGoods).BeginInit();
            SuspendLayout();
            // 
            // panelTopSportGoods
            // 
            panelTopSportGoods.Controls.Add(labelUserName);
            panelTopSportGoods.Controls.Add(buttonExit);
            panelTopSportGoods.Dock = DockStyle.Top;
            panelTopSportGoods.Location = new Point(10, 10);
            panelTopSportGoods.Name = "panelTopSportGoods";
            panelTopSportGoods.Size = new Size(964, 40);
            panelTopSportGoods.TabIndex = 0;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Dock = DockStyle.Right;
            labelUserName.Location = new Point(798, 0);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(53, 21);
            labelUserName.TabIndex = 1;
            labelUserName.Text = "label1";
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(67, 97, 238);
            buttonExit.Dock = DockStyle.Right;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.ForeColor = Color.White;
            buttonExit.Location = new Point(851, 0);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(113, 40);
            buttonExit.TabIndex = 0;
            buttonExit.Text = "Выход";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += ButtonExit_Click;
            // 
            // dataGridViewSportGoods
            // 
            dataGridViewSportGoods.AllowUserToAddRows = false;
            dataGridViewSportGoods.AllowUserToDeleteRows = false;
            dataGridViewSportGoods.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSportGoods.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewSportGoods.BackgroundColor = Color.White;
            dataGridViewSportGoods.BorderStyle = BorderStyle.None;
            dataGridViewSportGoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSportGoods.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewSportGoods.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSportGoods.Dock = DockStyle.Fill;
            dataGridViewSportGoods.Location = new Point(10, 50);
            dataGridViewSportGoods.MultiSelect = false;
            dataGridViewSportGoods.Name = "dataGridViewSportGoods";
            dataGridViewSportGoods.ReadOnly = true;
            dataGridViewSportGoods.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSportGoods.Size = new Size(964, 601);
            dataGridViewSportGoods.TabIndex = 1;
            // 
            // FormSportGoods
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 661);
            Controls.Add(dataGridViewSportGoods);
            Controls.Add(panelTopSportGoods);
            Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            Name = "FormSportGoods";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Tag = "Список спортивных товаров";
            Text = "FormSportGoods";
            panelTopSportGoods.ResumeLayout(false);
            panelTopSportGoods.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSportGoods).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTopSportGoods;
        private DataGridView dataGridViewSportGoods;
        private Button buttonExit;
        private Label labelUserName;
    }
}