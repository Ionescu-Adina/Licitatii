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
            userControlProfileCard1 = new GraphicsControl.UserControlProfileCard();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            btnAdaugaOferta = new Button();
            textBoxSumaOferita = new TextBox();
            textBoxValoareLicitatie = new TextBox();
            comboBoxSelectLicitatie = new ComboBox();
            label3 = new Label();
            groupBox3 = new GroupBox();
            button1 = new Button();
            dataGridOferteCandidat = new DataGridView();
            ofertaIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            NumeLicitatie = new DataGridViewTextBoxColumn();
            sumaOferitaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataOfertaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ofertaBindingSource = new BindingSource(components);
            btnOK = new Button();
            btnCancel = new Button();
            errorProvider = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridOferteCandidat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ofertaBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
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
            label2.Location = new Point(15, 39);
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
            groupBox1.Controls.Add(userControlProfileCard1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(814, 147);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Informatii personale";
            // 
            // userControlProfileCard1
            // 
            userControlProfileCard1.BackColor = Color.Moccasin;
            userControlProfileCard1.BorderStyle = BorderStyle.FixedSingle;
            userControlProfileCard1.Location = new Point(558, 16);
            userControlProfileCard1.MaximumSize = new Size(250, 125);
            userControlProfileCard1.MinimumSize = new Size(250, 125);
            userControlProfileCard1.Name = "userControlProfileCard1";
            userControlProfileCard1.Padding = new Padding(15, 0, 15, 0);
            userControlProfileCard1.Size = new Size(250, 125);
            userControlProfileCard1.TabIndex = 8;
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
            textBox2.Validating += textBox2_Validating;
            textBox2.Validated += textBox2_Validated;
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
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btnAdaugaOferta);
            groupBox2.Controls.Add(textBoxSumaOferita);
            groupBox2.Controls.Add(textBoxValoareLicitatie);
            groupBox2.Controls.Add(comboBoxSelectLicitatie);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(12, 168);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(814, 77);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Adauga Oferta";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(438, 21);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 7;
            label7.Text = "Oferta ta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(229, 21);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 6;
            label6.Text = "Ultima oferta";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 21);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 5;
            label4.Text = "Licitatie";
            // 
            // btnAdaugaOferta
            // 
            btnAdaugaOferta.Anchor = AnchorStyles.Right;
            btnAdaugaOferta.Location = new Point(701, 40);
            btnAdaugaOferta.Name = "btnAdaugaOferta";
            btnAdaugaOferta.Size = new Size(95, 23);
            btnAdaugaOferta.TabIndex = 4;
            btnAdaugaOferta.Text = "Adauga Oferta";
            btnAdaugaOferta.UseVisualStyleBackColor = true;
            btnAdaugaOferta.Click += btnAdaugaOferta_Click;
            // 
            // textBoxSumaOferita
            // 
            textBoxSumaOferita.Location = new Point(438, 39);
            textBoxSumaOferita.Name = "textBoxSumaOferita";
            textBoxSumaOferita.Size = new Size(160, 23);
            textBoxSumaOferita.TabIndex = 3;
            // 
            // textBoxValoareLicitatie
            // 
            textBoxValoareLicitatie.Enabled = false;
            textBoxValoareLicitatie.Location = new Point(229, 40);
            textBoxValoareLicitatie.Name = "textBoxValoareLicitatie";
            textBoxValoareLicitatie.ReadOnly = true;
            textBoxValoareLicitatie.Size = new Size(160, 23);
            textBoxValoareLicitatie.TabIndex = 2;
            // 
            // comboBoxSelectLicitatie
            // 
            comboBoxSelectLicitatie.FormattingEnabled = true;
            comboBoxSelectLicitatie.Location = new Point(18, 40);
            comboBoxSelectLicitatie.Name = "comboBoxSelectLicitatie";
            comboBoxSelectLicitatie.Size = new Size(160, 23);
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
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(dataGridOferteCandidat);
            groupBox3.Location = new Point(12, 251);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(15, 3, 15, 3);
            groupBox3.Size = new Size(814, 259);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Oferte";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.Location = new Point(702, 18);
            button1.Name = "button1";
            button1.Size = new Size(95, 23);
            button1.TabIndex = 1;
            button1.Text = "Sterge Oferta";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridOferteCandidat
            // 
            dataGridOferteCandidat.AllowUserToAddRows = false;
            dataGridOferteCandidat.AllowUserToDeleteRows = false;
            dataGridOferteCandidat.AllowUserToResizeColumns = false;
            dataGridOferteCandidat.AllowUserToResizeRows = false;
            dataGridOferteCandidat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridOferteCandidat.AutoGenerateColumns = false;
            dataGridOferteCandidat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridOferteCandidat.BackgroundColor = Color.Moccasin;
            dataGridOferteCandidat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridOferteCandidat.Columns.AddRange(new DataGridViewColumn[] { ofertaIdDataGridViewTextBoxColumn, NumeLicitatie, sumaOferitaDataGridViewTextBoxColumn, dataOfertaDataGridViewTextBoxColumn });
            dataGridOferteCandidat.DataSource = ofertaBindingSource;
            dataGridOferteCandidat.GridColor = SystemColors.WindowText;
            dataGridOferteCandidat.Location = new Point(18, 47);
            dataGridOferteCandidat.Name = "dataGridOferteCandidat";
            dataGridOferteCandidat.Size = new Size(778, 192);
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
            btnOK.Location = new Point(670, 531);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 8;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(751, 531);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // AddCandidatPopup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(838, 566);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximumSize = new Size(854, 605);
            MinimumSize = new Size(854, 605);
            Name = "AddCandidatPopup";
            Text = "Adauga / Editeaza Candidat";
            Load += AddCandidatPopup_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridOferteCandidat).EndInit();
            ((System.ComponentModel.ISupportInitialize)ofertaBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
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
        private Label label7;
        private Label label6;
        private Label label4;
        private Button button1;
        private ErrorProvider errorProvider;
        private GraphicsControl.UserControlProfileCard userControlProfileCard1;
    }
}