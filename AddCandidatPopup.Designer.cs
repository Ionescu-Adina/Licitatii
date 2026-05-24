namespace Licitatii
{
    partial class AddCandidatPopup
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            btnAdaugaOferta = new Button();
            textBoxSumaOferita = new TextBox();
            textBoxValoareLicitatie = new TextBox();
            comboBoxSelectLicitatie = new ComboBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            dataGridOferteCandidat = new DataGridView();
            ofertaIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            NumeLicitatie = new DataGridViewTextBoxColumn();
            sumaOferitaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataOfertaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ofertaBindingSource = new BindingSource(components);
            btnOK = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOferteCandidat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ofertaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 78);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Varsta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 39);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 1;
            label2.Text = "Nume";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 116);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 4;
            label5.Text = "Adresa";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 147);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informatii personale";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(61, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(61, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(61, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 23);
            textBox1.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnAdaugaOferta);
            groupBox2.Controls.Add(textBoxSumaOferita);
            groupBox2.Controls.Add(textBoxValoareLicitatie);
            groupBox2.Controls.Add(comboBoxSelectLicitatie);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 168);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 77);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Adauga Oferta";
            // 
            // btnAdaugaOferta
            // 
            btnAdaugaOferta.Location = new Point(676, 38);
            btnAdaugaOferta.Name = "btnAdaugaOferta";
            btnAdaugaOferta.Size = new Size(94, 23);
            btnAdaugaOferta.TabIndex = 4;
            btnAdaugaOferta.Text = "Adauga Oferta";
            btnAdaugaOferta.UseVisualStyleBackColor = true;
            btnAdaugaOferta.Click += btnAdaugaOferta_Click;
            // 
            // textBoxSumaOferita
            // 
            textBoxSumaOferita.Location = new Point(502, 38);
            textBoxSumaOferita.Name = "textBoxSumaOferita";
            textBoxSumaOferita.Size = new Size(137, 23);
            textBoxSumaOferita.TabIndex = 3;
            // 
            // textBoxValoareLicitatie
            // 
            textBoxValoareLicitatie.Enabled = false;
            textBoxValoareLicitatie.Location = new Point(279, 38);
            textBoxValoareLicitatie.Name = "textBoxValoareLicitatie";
            textBoxValoareLicitatie.ReadOnly = true;
            textBoxValoareLicitatie.Size = new Size(160, 23);
            textBoxValoareLicitatie.TabIndex = 2;
            // 
            // comboBoxSelectLicitatie
            // 
            comboBoxSelectLicitatie.FormattingEnabled = true;
            comboBoxSelectLicitatie.Location = new Point(61, 38);
            comboBoxSelectLicitatie.Name = "comboBoxSelectLicitatie";
            comboBoxSelectLicitatie.Size = new Size(150, 23);
            comboBoxSelectLicitatie.TabIndex = 1;
            comboBoxSelectLicitatie.SelectedIndexChanged += comboBoxSelectLicitatie_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 46);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridOferteCandidat);
            groupBox3.Location = new Point(12, 251);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(776, 187);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Oferte";
            // 
            // dataGridOferteCandidat
            // 
            dataGridOferteCandidat.AllowUserToAddRows = false;
            dataGridOferteCandidat.AllowUserToDeleteRows = false;
            dataGridOferteCandidat.AllowUserToResizeColumns = false;
            dataGridOferteCandidat.AllowUserToResizeRows = false;
            dataGridOferteCandidat.AutoGenerateColumns = false;
            dataGridOferteCandidat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridOferteCandidat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOferteCandidat.Columns.AddRange(new DataGridViewColumn[] { ofertaIdDataGridViewTextBoxColumn, NumeLicitatie, sumaOferitaDataGridViewTextBoxColumn, dataOfertaDataGridViewTextBoxColumn });
            dataGridOferteCandidat.DataSource = ofertaBindingSource;
            dataGridOferteCandidat.Location = new Point(6, 22);
            dataGridOferteCandidat.Name = "dataGridOferteCandidat";
            dataGridOferteCandidat.Size = new Size(764, 159);
            dataGridOferteCandidat.TabIndex = 0;
            // 
            // ofertaIdDataGridViewTextBoxColumn
            // 
            ofertaIdDataGridViewTextBoxColumn.DataPropertyName = "OfertaId";
            ofertaIdDataGridViewTextBoxColumn.HeaderText = "OfertaId";
            ofertaIdDataGridViewTextBoxColumn.Name = "ofertaIdDataGridViewTextBoxColumn";
            // 
            // NumeLicitatie
            // 
            NumeLicitatie.DataPropertyName = "NumeLicitatie";
            NumeLicitatie.HeaderText = "Licitatie";
            NumeLicitatie.Name = "NumeLicitatie";
            NumeLicitatie.ReadOnly = true;
            // 
            // sumaOferitaDataGridViewTextBoxColumn
            // 
            sumaOferitaDataGridViewTextBoxColumn.DataPropertyName = "SumaOferita";
            sumaOferitaDataGridViewTextBoxColumn.HeaderText = "SumaOferita";
            sumaOferitaDataGridViewTextBoxColumn.Name = "sumaOferitaDataGridViewTextBoxColumn";
            // 
            // dataOfertaDataGridViewTextBoxColumn
            // 
            dataOfertaDataGridViewTextBoxColumn.DataPropertyName = "DataOferta";
            dataOfertaDataGridViewTextBoxColumn.HeaderText = "DataOferta";
            dataOfertaDataGridViewTextBoxColumn.Name = "dataOfertaDataGridViewTextBoxColumn";
            // 
            // ofertaBindingSource
            // 
            ofertaBindingSource.DataSource = typeof(Models.Oferta);
            // 
            // btnOK
            // 
            btnOK.Location = new Point(632, 482);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 8;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(713, 482);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddCandidatPopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 514);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AddCandidatPopup";
            Text = "AddCandidatPopup";
            Load += AddCandidatPopup_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridOferteCandidat).EndInit();
            ((System.ComponentModel.ISupportInitialize)ofertaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label5;
        private GroupBox groupBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Label label3;
        private ComboBox comboBoxSelectLicitatie;
        private TextBox textBoxValoareLicitatie;
        private TextBox textBoxSumaOferita;
        private Button btnAdaugaOferta;
        private GroupBox groupBox3;
        private DataGridView dataGridOferteCandidat;
        private BindingSource ofertaBindingSource;
        private Button btnOK;
        private Button btnCancel;
        private DataGridViewTextBoxColumn ofertaIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn NumeLicitatie;
        private DataGridViewTextBoxColumn sumaOferitaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataOfertaDataGridViewTextBoxColumn;
    }
}