namespace facturando
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnguardar = new Button();
            dataGridView1 = new DataGridView();
            item = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            descripcion = new DataGridViewTextBoxColumn();
            PU = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(657, 432);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(75, 23);
            btnguardar.TabIndex = 0;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { item, cantidad, descripcion, PU, Total });
            dataGridView1.Location = new Point(22, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(583, 150);
            dataGridView1.TabIndex = 1;
            // 
            // item
            // 
            item.HeaderText = "item";
            item.Name = "item";
            // 
            // cantidad
            // 
            cantidad.HeaderText = "cantidad";
            cantidad.Name = "cantidad";
            // 
            // descripcion
            // 
            descripcion.HeaderText = "descripcion";
            descripcion.Name = "descripcion";
            // 
            // PU
            // 
            PU.HeaderText = "PU";
            PU.Name = "PU";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(22, 229);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(583, 150);
            dataGridView2.TabIndex = 2;
            dataGridView2.CellEndEdit += dataGridView2_CellEndEdit;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 539);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(btnguardar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnguardar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn item;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn descripcion;
        private DataGridViewTextBoxColumn PU;
        private DataGridViewTextBoxColumn Total;
        private DataGridView dataGridView2;
    }
}