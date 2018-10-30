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
            this.groupBoxMatrix = new System.Windows.Forms.GroupBox();
            this.groupBoxTools = new System.Windows.Forms.GroupBox();
            this.labelRows = new System.Windows.Forms.Label();
            this.textBoxRows = new System.Windows.Forms.TextBox();
            this.labelColumns = new System.Windows.Forms.Label();
            this.textBoxColumns = new System.Windows.Forms.TextBox();
            this.buttonAccept = new System.Windows.Forms.Button();
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
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(9, 258);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(175, 47);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(6, 230);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(249, 13);
            this.labelResult.TabIndex = 2;
            this.labelResult.Text = "Фрагмент с суммой наиболее близкой у нулю: ";
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(261, 227);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(100, 20);
            this.textBoxResult.TabIndex = 3;
            // 
            // dataGridViewMatrix
            // 
            this.dataGridViewMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix.ColumnHeadersVisible = false;
            this.dataGridViewMatrix.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewMatrix.Name = "dataGridViewMatrix";
            this.dataGridViewMatrix.RowHeadersVisible = false;
            this.dataGridViewMatrix.Size = new System.Drawing.Size(387, 292);
            this.dataGridViewMatrix.TabIndex = 4;
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
    }
}

