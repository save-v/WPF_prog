namespace поиск_пути_в_графе_wf
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
            this.my_button = new System.Windows.Forms.Button();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.numericUpDownCountVertices = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewListVertices = new System.Windows.Forms.DataGridView();
            this.labelcount = new System.Windows.Forms.Label();
            this.labelMatrix = new System.Windows.Forms.Label();
            this.textBoxWay = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDistance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStart = new System.Windows.Forms.ComboBox();
            this.comboBoxFinish = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountVertices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListVertices)).BeginInit();
            this.SuspendLayout();
            // 
            // my_button
            // 
            this.my_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.my_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.my_button.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.my_button.Location = new System.Drawing.Point(564, 359);
            this.my_button.Name = "my_button";
            this.my_button.Size = new System.Drawing.Size(89, 26);
            this.my_button.TabIndex = 0;
            this.my_button.Text = "Расчитать";
            this.my_button.UseVisualStyleBackColor = true;
            this.my_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.AllowUserToAddRows = false;
            this.dataGridViewMatrix.AllowUserToDeleteRows = false;
            this.dataGridViewMatrix.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMatrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMatrix.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.EnableHeadersVisualStyles = false;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(156, 67);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(347, 264);
            this.dataGridViewMatrix.TabIndex = 3;
            this.dataGridViewMatrix.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatrix_CellValueChanged);
            // 
            // numericUpDownCountVertices
            // 
            this.numericUpDownCountVertices.Location = new System.Drawing.Point(6, 41);
            this.numericUpDownCountVertices.Name = "numericUpDownCountVertices";
            this.numericUpDownCountVertices.ReadOnly = true;
            this.numericUpDownCountVertices.Size = new System.Drawing.Size(144, 20);
            this.numericUpDownCountVertices.TabIndex = 4;
            this.numericUpDownCountVertices.ValueChanged += new System.EventHandler(this.numericUpDownCountVertices_ValueChanged);
            // 
            // dataGridViewListVertices
            // 
            this.dataGridViewListVertices.AllowUserToAddRows = false;
            this.dataGridViewListVertices.AllowUserToDeleteRows = false;
            this.dataGridViewListVertices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewListVertices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewListVertices.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewListVertices.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewListVertices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListVertices.EnableHeadersVisualStyles = false;
            this.dataGridViewListVertices.Location = new System.Drawing.Point(6, 67);
            this.dataGridViewListVertices.Name = "dataGridViewListVertices";
            this.dataGridViewListVertices.RowHeadersVisible = false;
            this.dataGridViewListVertices.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewListVertices.Size = new System.Drawing.Size(144, 264);
            this.dataGridViewListVertices.TabIndex = 5;
            this.dataGridViewListVertices.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridViewListVertices_ColumnAdded);
            this.dataGridViewListVertices.CurrentCellDirtyStateChanged += new System.EventHandler(this.dataGridViewListVertices_CurrentCellDirtyStateChanged);
            // 
            // labelcount
            // 
            this.labelcount.AutoSize = true;
            this.labelcount.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelcount.Location = new System.Drawing.Point(6, 18);
            this.labelcount.Name = "labelcount";
            this.labelcount.Size = new System.Drawing.Size(132, 20);
            this.labelcount.TabIndex = 6;
            this.labelcount.Text = "количество вершин";
            // 
            // labelMatrix
            // 
            this.labelMatrix.AutoSize = true;
            this.labelMatrix.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMatrix.Location = new System.Drawing.Point(239, 44);
            this.labelMatrix.Name = "labelMatrix";
            this.labelMatrix.Size = new System.Drawing.Size(187, 20);
            this.labelMatrix.TabIndex = 7;
            this.labelMatrix.Text = "Введите матрицу смежности";
            // 
            // textBoxWay
            // 
            this.textBoxWay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWay.Location = new System.Drawing.Point(405, 341);
            this.textBoxWay.Name = "textBoxWay";
            this.textBoxWay.ReadOnly = true;
            this.textBoxWay.Size = new System.Drawing.Size(153, 20);
            this.textBoxWay.TabIndex = 8;
            // 
            // listBox
            // 
            this.listBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox.BackColor = System.Drawing.SystemColors.Window;
            this.listBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(509, 67);
            this.listBox.Name = "listBox";
            this.listBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox.Size = new System.Drawing.Size(144, 264);
            this.listBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(508, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "через которые путь";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(508, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "не должен проходить";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(312, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Расстояние ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(284, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Кратчайший путь";
            // 
            // textBoxDistance
            // 
            this.textBoxDistance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDistance.Location = new System.Drawing.Point(405, 366);
            this.textBoxDistance.Name = "textBoxDistance";
            this.textBoxDistance.ReadOnly = true;
            this.textBoxDistance.Size = new System.Drawing.Size(153, 20);
            this.textBoxDistance.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(5, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Начало пути";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Конец пути";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(508, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Выберите вершины";
            // 
            // comboBoxStart
            // 
            this.comboBoxStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStart.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBoxStart.FormattingEnabled = true;
            this.comboBoxStart.Items.AddRange(new object[] {
            "Не выбрано"});
            this.comboBoxStart.Location = new System.Drawing.Point(96, 340);
            this.comboBoxStart.Name = "comboBoxStart";
            this.comboBoxStart.Size = new System.Drawing.Size(173, 21);
            this.comboBoxStart.TabIndex = 20;
            this.comboBoxStart.Tag = "";
            // 
            // comboBoxFinish
            // 
            this.comboBoxFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxFinish.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFinish.FormattingEnabled = true;
            this.comboBoxFinish.Items.AddRange(new object[] {
            "Не выбрано"});
            this.comboBoxFinish.Location = new System.Drawing.Point(96, 364);
            this.comboBoxFinish.Name = "comboBoxFinish";
            this.comboBoxFinish.Size = new System.Drawing.Size(173, 21);
            this.comboBoxFinish.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Выберете";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(658, 387);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxFinish);
            this.Controls.Add(this.comboBoxStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxDistance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.textBoxWay);
            this.Controls.Add(this.labelMatrix);
            this.Controls.Add(this.labelcount);
            this.Controls.Add(this.dataGridViewListVertices);
            this.Controls.Add(this.numericUpDownCountVertices);
            this.Controls.Add(this.dataGridViewMatrix);
            this.Controls.Add(this.my_button);
            this.MinimumSize = new System.Drawing.Size(593, 232);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пошук шляху в графі що не проходить через задану множину вершин";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountVertices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListVertices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button my_button;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.NumericUpDown numericUpDownCountVertices;
        private System.Windows.Forms.DataGridView dataGridViewListVertices;
        private System.Windows.Forms.Label labelcount;
        private System.Windows.Forms.Label labelMatrix;
        private System.Windows.Forms.TextBox textBoxWay;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDistance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFinish;
        private System.Windows.Forms.ComboBox comboBoxStart;
        private System.Windows.Forms.Label label2;
    }
}

