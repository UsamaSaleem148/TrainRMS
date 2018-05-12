namespace RMS
{
    partial class TrainTimings
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
            this.components = new System.ComponentModel.Container();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rMSDataSet = new RMS.RMSDataSet();
            this.trainTimingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainTimingsTableAdapter = new RMS.RMSDataSetTableAdapters.TrainTimingsTableAdapter();
            this.rMSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainTableAdapter = new RMS.RMSDataSetTableAdapters.TrainTableAdapter();
            this.trainTimingsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainTimingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainTimingsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 165);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Select Train";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(150, 155);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(356, 29);
            this.metroComboBox1.TabIndex = 1;
            this.metroComboBox1.UseSelectable = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(904, 319);
            this.dataGridView1.TabIndex = 2;
            // 
            // rMSDataSet
            // 
            this.rMSDataSet.DataSetName = "RMSDataSet";
            this.rMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trainTimingsBindingSource
            // 
            this.trainTimingsBindingSource.DataMember = "TrainTimings";
            this.trainTimingsBindingSource.DataSource = this.rMSDataSet;
            // 
            // trainTimingsTableAdapter
            // 
            this.trainTimingsTableAdapter.ClearBeforeFill = true;
            // 
            // rMSDataSetBindingSource
            // 
            this.rMSDataSetBindingSource.DataSource = this.rMSDataSet;
            this.rMSDataSetBindingSource.Position = 0;
            // 
            // trainBindingSource
            // 
            this.trainBindingSource.DataMember = "Train";
            this.trainBindingSource.DataSource = this.rMSDataSetBindingSource;
            // 
            // trainTableAdapter
            // 
            this.trainTableAdapter.ClearBeforeFill = true;
            // 
            // trainTimingsBindingSource1
            // 
            this.trainTimingsBindingSource1.DataMember = "TrainTimings";
            this.trainTimingsBindingSource1.DataSource = this.rMSDataSetBindingSource;
            // 
            // TrainTimings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 570);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "TrainTimings";
            this.Text = "Railway Management System";
            this.Load += new System.EventHandler(this.TrainTimings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainTimingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rMSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainTimingsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RMSDataSet rMSDataSet;
        private System.Windows.Forms.BindingSource trainTimingsBindingSource;
        private RMSDataSetTableAdapters.TrainTimingsTableAdapter trainTimingsTableAdapter;
        private System.Windows.Forms.BindingSource rMSDataSetBindingSource;
        private System.Windows.Forms.BindingSource trainBindingSource;
        private RMSDataSetTableAdapters.TrainTableAdapter trainTableAdapter;
        private System.Windows.Forms.BindingSource trainTimingsBindingSource1;
    }
}