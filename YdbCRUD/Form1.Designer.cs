namespace OnlineStore
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CustomersPage = new System.Windows.Forms.TabPage();
            this.customerInsertButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.customerUpdateButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.customerDeleteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.ProductsPage = new System.Windows.Forms.TabPage();
            this.productInsertButton = new System.Windows.Forms.Button();
            this.productUpdateButton = new System.Windows.Forms.Button();
            this.productDeleteButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.OrdersPage = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.OrdersProductsPage = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.CustomersPage.SuspendLayout();
            this.ProductsPage.SuspendLayout();
            this.OrdersPage.SuspendLayout();
            this.OrdersProductsPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CustomersPage);
            this.tabControl1.Controls.Add(this.ProductsPage);
            this.tabControl1.Controls.Add(this.OrdersPage);
            this.tabControl1.Controls.Add(this.OrdersProductsPage);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.ItemSize = new System.Drawing.Size(131, 25);
            this.tabControl1.Location = new System.Drawing.Point(33, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(795, 254);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 12;
            // 
            // CustomersPage
            // 
            this.CustomersPage.BackColor = System.Drawing.Color.Transparent;
            this.CustomersPage.Controls.Add(this.customerInsertButton);
            this.CustomersPage.Controls.Add(this.label4);
            this.CustomersPage.Controls.Add(this.customerUpdateButton);
            this.CustomersPage.Controls.Add(this.label3);
            this.CustomersPage.Controls.Add(this.customerDeleteButton);
            this.CustomersPage.Controls.Add(this.label2);
            this.CustomersPage.Controls.Add(this.lastNameTextBox);
            this.CustomersPage.Controls.Add(this.middleNameTextBox);
            this.CustomersPage.Controls.Add(this.firstNameTextBox);
            this.CustomersPage.Location = new System.Drawing.Point(4, 29);
            this.CustomersPage.Name = "CustomersPage";
            this.CustomersPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.CustomersPage.Size = new System.Drawing.Size(787, 221);
            this.CustomersPage.TabIndex = 0;
            this.CustomersPage.Text = "Worker";
            // 
            // customerInsertButton
            // 
            this.customerInsertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.customerInsertButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerInsertButton.Location = new System.Drawing.Point(245, 172);
            this.customerInsertButton.Name = "customerInsertButton";
            this.customerInsertButton.Size = new System.Drawing.Size(111, 34);
            this.customerInsertButton.TabIndex = 2;
            this.customerInsertButton.Text = "Insert";
            this.customerInsertButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Middle Name:";
            // 
            // customerUpdateButton
            // 
            this.customerUpdateButton.BackColor = System.Drawing.Color.Yellow;
            this.customerUpdateButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerUpdateButton.Location = new System.Drawing.Point(361, 172);
            this.customerUpdateButton.Name = "customerUpdateButton";
            this.customerUpdateButton.Size = new System.Drawing.Size(111, 34);
            this.customerUpdateButton.TabIndex = 3;
            this.customerUpdateButton.Text = "Update ()";
            this.customerUpdateButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "First Name:";
            // 
            // customerDeleteButton
            // 
            this.customerDeleteButton.BackColor = System.Drawing.Color.Red;
            this.customerDeleteButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.customerDeleteButton.Location = new System.Drawing.Point(478, 172);
            this.customerDeleteButton.Name = "customerDeleteButton";
            this.customerDeleteButton.Size = new System.Drawing.Size(111, 34);
            this.customerDeleteButton.TabIndex = 4;
            this.customerDeleteButton.Text = "Delete ()";
            this.customerDeleteButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameTextBox.Location = new System.Drawing.Point(140, 28);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(96, 23);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.middleNameTextBox.Location = new System.Drawing.Point(140, 114);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(96, 23);
            this.middleNameTextBox.TabIndex = 8;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameTextBox.Location = new System.Drawing.Point(140, 70);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(96, 23);
            this.firstNameTextBox.TabIndex = 7;
            // 
            // ProductsPage
            // 
            this.ProductsPage.BackColor = System.Drawing.Color.Transparent;
            this.ProductsPage.Controls.Add(this.productInsertButton);
            this.ProductsPage.Controls.Add(this.productUpdateButton);
            this.ProductsPage.Controls.Add(this.productDeleteButton);
            this.ProductsPage.Controls.Add(this.label7);
            this.ProductsPage.Controls.Add(this.nameTextBox);
            this.ProductsPage.Location = new System.Drawing.Point(4, 29);
            this.ProductsPage.Name = "ProductsPage";
            this.ProductsPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.ProductsPage.Size = new System.Drawing.Size(787, 221);
            this.ProductsPage.TabIndex = 1;
            this.ProductsPage.Text = "Products";
            // 
            // productInsertButton
            // 
            this.productInsertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.productInsertButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productInsertButton.Location = new System.Drawing.Point(242, 172);
            this.productInsertButton.Name = "productInsertButton";
            this.productInsertButton.Size = new System.Drawing.Size(111, 34);
            this.productInsertButton.TabIndex = 21;
            this.productInsertButton.Text = "Insert";
            this.productInsertButton.UseVisualStyleBackColor = false;
            // 
            // productUpdateButton
            // 
            this.productUpdateButton.BackColor = System.Drawing.Color.Yellow;
            this.productUpdateButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productUpdateButton.Location = new System.Drawing.Point(359, 172);
            this.productUpdateButton.Name = "productUpdateButton";
            this.productUpdateButton.Size = new System.Drawing.Size(111, 34);
            this.productUpdateButton.TabIndex = 22;
            this.productUpdateButton.Text = "Update ()";
            this.productUpdateButton.UseVisualStyleBackColor = false;
            // 
            // productDeleteButton
            // 
            this.productDeleteButton.BackColor = System.Drawing.Color.Red;
            this.productDeleteButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productDeleteButton.Location = new System.Drawing.Point(475, 172);
            this.productDeleteButton.Name = "productDeleteButton";
            this.productDeleteButton.Size = new System.Drawing.Size(111, 34);
            this.productDeleteButton.TabIndex = 23;
            this.productDeleteButton.Text = "Delete ()";
            this.productDeleteButton.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(24, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTextBox.Location = new System.Drawing.Point(112, 28);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(101, 23);
            this.nameTextBox.TabIndex = 15;
            // 
            // OrdersPage
            // 
            this.OrdersPage.BackColor = System.Drawing.Color.Transparent;
            this.OrdersPage.Controls.Add(this.label18);
            this.OrdersPage.Location = new System.Drawing.Point(4, 29);
            this.OrdersPage.Name = "OrdersPage";
            this.OrdersPage.Size = new System.Drawing.Size(787, 221);
            this.OrdersPage.TabIndex = 2;
            this.OrdersPage.Text = "Report";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(22, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(414, 90);
            this.label18.TabIndex = 20;
            this.label18.Text = "    Таблица Orders служит для хранения заказов и имеет следующие поля:\r\n- Id\r\n- W" +
    "orkerId\r\n- Price\r\n- CreationDate\r\n- PaymentDate\r\n";
            // 
            // OrdersProductsPage
            // 
            this.OrdersProductsPage.BackColor = System.Drawing.Color.Transparent;
            this.OrdersProductsPage.Controls.Add(this.label16);
            this.OrdersProductsPage.Location = new System.Drawing.Point(4, 29);
            this.OrdersProductsPage.Name = "OrdersProductsPage";
            this.OrdersProductsPage.Size = new System.Drawing.Size(787, 221);
            this.OrdersProductsPage.TabIndex = 3;
            this.OrdersProductsPage.Text = "OrdersProducts";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(22, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(442, 75);
            this.label16.TabIndex = 20;
            this.label16.Text = "    Таблица OrdersProducts служит для хранения товаров в заказе и имеет поля:\r\n- " +
    "OrderId\r\n- ProductrId\r\n- QuantityProduct\r\n- PricePRoducts\r\n";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(787, 221);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Отчеты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(21, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 47);
            this.button1.TabIndex = 23;
            this.button1.Text = "Отчет по работникам";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateBlue;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(203, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 47);
            this.button2.TabIndex = 24;
            this.button2.Text = "Отчет по статьям затрат";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = " Отчёты по статьям затрат и сотрудникам.";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 676);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(859, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(104, 17);
            this.toolStripStatusLabel1.Text = "Number of row(s):";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(859, 675);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 321);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(792, 268);
            this.dataGridView1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(859, 698);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Предпиятие";
            this.tabControl1.ResumeLayout(false);
            this.CustomersPage.ResumeLayout(false);
            this.CustomersPage.PerformLayout();
            this.ProductsPage.ResumeLayout(false);
            this.ProductsPage.PerformLayout();
            this.OrdersPage.ResumeLayout(false);
            this.OrdersPage.PerformLayout();
            this.OrdersProductsPage.ResumeLayout(false);
            this.OrdersProductsPage.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button customerInsertButton;
        private System.Windows.Forms.Button customerUpdateButton;
        private System.Windows.Forms.Button customerDeleteButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CustomersPage;
        private System.Windows.Forms.TabPage ProductsPage;
        private System.Windows.Forms.TabPage OrdersPage;
        private System.Windows.Forms.TabPage OrdersProductsPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button productInsertButton;
        private System.Windows.Forms.Button productUpdateButton;
        private System.Windows.Forms.Button productDeleteButton;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private TabPage tabPage1;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}

