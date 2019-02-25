namespace YazilimSinamaProje
{
    partial class YetkiliForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            this.cmbCalID = new System.Windows.Forms.ComboBox();
            this.tblCalisanlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stok_yonetim_sistemiDataSet6 = new YazilimSinamaProje.stok_yonetim_sistemiDataSet6();
            this.stok_yonetim_sistemiDataSet5 = new YazilimSinamaProje.stok_yonetim_sistemiDataSet5();
            this.tblDepartmanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblDepartmanTableAdapter = new YazilimSinamaProje.stok_yonetim_sistemiDataSet5TableAdapters.tblDepartmanTableAdapter();
            this.cmbDepartmanID = new System.Windows.Forms.ComboBox();
            this.tblCalisanlarTableAdapter = new YazilimSinamaProje.stok_yonetim_sistemiDataSet6TableAdapters.tblCalisanlarTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCalisanlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_yonetim_sistemiDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_yonetim_sistemiDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(118, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(824, 370);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(384, 388);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(248, 50);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Departman Çalışanlarını Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnRaporla_Click);
            // 
            // cmbCalID
            // 
            this.cmbCalID.DataSource = this.tblCalisanlarBindingSource;
            this.cmbCalID.DisplayMember = "calisanID";
            this.cmbCalID.FormattingEnabled = true;
            this.cmbCalID.Location = new System.Drawing.Point(384, 400);
            this.cmbCalID.Name = "cmbCalID";
            this.cmbCalID.Size = new System.Drawing.Size(121, 21);
            this.cmbCalID.TabIndex = 2;
            // 
            // tblCalisanlarBindingSource
            // 
            this.tblCalisanlarBindingSource.DataMember = "tblCalisanlar";
            this.tblCalisanlarBindingSource.DataSource = this.stok_yonetim_sistemiDataSet6;
            // 
            // stok_yonetim_sistemiDataSet6
            // 
            this.stok_yonetim_sistemiDataSet6.DataSetName = "stok_yonetim_sistemiDataSet6";
            this.stok_yonetim_sistemiDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stok_yonetim_sistemiDataSet5
            // 
            this.stok_yonetim_sistemiDataSet5.DataSetName = "stok_yonetim_sistemiDataSet5";
            this.stok_yonetim_sistemiDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDepartmanBindingSource
            // 
            this.tblDepartmanBindingSource.DataMember = "tblDepartman";
            this.tblDepartmanBindingSource.DataSource = this.stok_yonetim_sistemiDataSet5;
            // 
            // tblDepartmanTableAdapter
            // 
            this.tblDepartmanTableAdapter.ClearBeforeFill = true;
            // 
            // cmbDepartmanID
            // 
            this.cmbDepartmanID.DataSource = this.tblCalisanlarBindingSource;
            this.cmbDepartmanID.DisplayMember = "depatmanID";
            this.cmbDepartmanID.FormattingEnabled = true;
            this.cmbDepartmanID.Location = new System.Drawing.Point(511, 400);
            this.cmbDepartmanID.Name = "cmbDepartmanID";
            this.cmbDepartmanID.Size = new System.Drawing.Size(121, 21);
            this.cmbDepartmanID.TabIndex = 3;
            // 
            // tblCalisanlarTableAdapter
            // 
            this.tblCalisanlarTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(384, 388);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // YetkiliForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 450);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbDepartmanID);
            this.Controls.Add(this.cmbCalID);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "YetkiliForm";
            this.Text = "YetkiliForm";
            this.Load += new System.EventHandler(this.YetkiliForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCalisanlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_yonetim_sistemiDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stok_yonetim_sistemiDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblDepartmanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.ComboBox cmbCalID;
        private stok_yonetim_sistemiDataSet5 stok_yonetim_sistemiDataSet5;
        private System.Windows.Forms.BindingSource tblDepartmanBindingSource;
        private stok_yonetim_sistemiDataSet5TableAdapters.tblDepartmanTableAdapter tblDepartmanTableAdapter;
        private System.Windows.Forms.ComboBox cmbDepartmanID;
        private stok_yonetim_sistemiDataSet6 stok_yonetim_sistemiDataSet6;
        private System.Windows.Forms.BindingSource tblCalisanlarBindingSource;
        private stok_yonetim_sistemiDataSet6TableAdapters.tblCalisanlarTableAdapter tblCalisanlarTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}