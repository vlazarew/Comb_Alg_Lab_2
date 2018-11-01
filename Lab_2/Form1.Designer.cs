namespace Lab_2
{
    partial class MainForm
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
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.dataGridViewMatrix = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxMatrix = new System.Windows.Forms.GroupBox();
            this.groupBoxTools = new System.Windows.Forms.GroupBox();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.labelColumns = new System.Windows.Forms.Label();
            this.textBoxColumns = new System.Windows.Forms.TextBox();
            this.labelRows = new System.Windows.Forms.Label();
            this.textBoxRows = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRectangle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).BeginInit();
            this.groupBoxMatrix.SuspendLayout();
            this.groupBoxTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRun
            // 
            this.buttonRun.Location = new System.Drawing.Point(190, 258);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(175, 47);
            this.buttonRun.TabIndex = 0;
            this.buttonRun.Text = "Запустить";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(9, 258);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(175, 47);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(8, 138);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(249, 13);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "Фрагмент с суммой наиболее близкой у нулю: ";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(263, 135);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 3;
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.AllowUserToAddRows = false;
            this.dataGridViewMatrix.AllowUserToDeleteRows = false;
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.ColumnHeadersVisible = false;
            this.dataGridViewMatrix.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridViewMatrix.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.RowHeadersVisible = false;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(387, 292);
            this.dataGridViewMatrix.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // groupBoxMatrix
            // 
            this.groupBoxMatrix.Controls.Add(this.dataGridViewMatrix);
            this.groupBoxMatrix.Location = new System.Drawing.Point(12, 12);
            this.groupBoxMatrix.Name = "groupBoxMatrix";
            this.groupBoxMatrix.Size = new System.Drawing.Size(399, 317);
            this.groupBoxMatrix.TabIndex = 5;
            this.groupBoxMatrix.TabStop = false;
            this.groupBoxMatrix.Text = "Матрица";
            // 
            // groupBoxTools
            // 
            this.groupBoxTools.Controls.Add(this.label1);
            this.groupBoxTools.Controls.Add(this.textBoxRectangle);
            this.groupBoxTools.Controls.Add(this.buttonAccept);
            this.groupBoxTools.Controls.Add(this.labelColumns);
            this.groupBoxTools.Controls.Add(this.textBoxColumns);
            this.groupBoxTools.Controls.Add(this.labelRows);
            this.groupBoxTools.Controls.Add(this.textBoxRows);
            this.groupBoxTools.Controls.Add(this.labelResult);
            this.groupBoxTools.Controls.Add(this.textBoxResult);
            this.groupBoxTools.Controls.Add(this.buttonRun);
            this.groupBoxTools.Controls.Add(this.buttonClear);
            this.groupBoxTools.Location = new System.Drawing.Point(417, 12);
            this.groupBoxTools.Name = "groupBoxTools";
            this.groupBoxTools.Size = new System.Drawing.Size(371, 311);
            this.groupBoxTools.TabIndex = 6;
            this.groupBoxTools.TabStop = false;
            this.groupBoxTools.Text = "Панель управления";
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(57, 70);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(271, 47);
            this.buttonAccept.TabIndex = 8;
            this.buttonAccept.Text = "Подтвердить изменение размера матрицы";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // labelColumns
            // 
            this.labelColumns.AutoSize = true;
            this.labelColumns.Location = new System.Drawing.Point(8, 19);
            this.labelColumns.Name = "labelColumns";
            this.labelColumns.Size = new System.Drawing.Size(166, 13);
            this.labelColumns.TabIndex = 6;
            this.labelColumns.Text = "Укажите количество столбцов:";
            // 
            // textBoxColumns
            // 
            this.textBoxColumns.Location = new System.Drawing.Point(180, 16);
            this.textBoxColumns.Name = "textBoxColumns";
            this.textBoxColumns.Size = new System.Drawing.Size(100, 20);
            this.textBoxColumns.TabIndex = 7;
            this.textBoxColumns.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxColumns_KeyPress);
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Location = new System.Drawing.Point(8, 47);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(148, 13);
            this.labelRows.TabIndex = 4;
            this.labelRows.Text = "Укажите количество строк:";
            // 
            // textBoxRows
            // 
            this.textBoxRows.Location = new System.Drawing.Point(180, 44);
            this.textBoxRows.Name = "textBoxRows";
            this.textBoxRows.Size = new System.Drawing.Size(100, 20);
            this.textBoxRows.TabIndex = 5;
            this.textBoxRows.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxColumns_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Полученный прямоуголник:";
            // 
            // textBoxRectangle
            // 
            this.textBoxRectangle.Location = new System.Drawing.Point(162, 161);
            this.textBoxRectangle.Multiline = true;
            this.textBoxRectangle.Name = "textBoxRectangle";
            this.textBoxRectangle.ReadOnly = true;
            this.textBoxRectangle.Size = new System.Drawing.Size(202, 67);
            this.textBoxRectangle.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.groupBoxTools);
            this.Controls.Add(this.groupBoxMatrix);
            this.Name = "MainForm";
            this.Text = "13с. Поиск прямоугольного фрагмента с наиболее близкой к нулю суммой в двухмерной" +
    " матрице";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix)).EndInit();
            this.groupBoxMatrix.ResumeLayout(false);
            this.groupBoxTools.ResumeLayout(false);
            this.groupBoxTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.DataGridView dataGridViewMatrix;
        private System.Windows.Forms.GroupBox groupBoxMatrix;
        private System.Windows.Forms.GroupBox groupBoxTools;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Label labelColumns;
        private System.Windows.Forms.TextBox textBoxColumns;
        private System.Windows.Forms.Label labelRows;
        private System.Windows.Forms.TextBox textBoxRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxRectangle;
    }
}

