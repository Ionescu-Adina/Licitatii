namespace Licitatii
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            dataGridLicitatii = new DataGridView();
            licitatieIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valoareStartDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valoareFinalaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataInceputDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            esteFinalizataDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            licitatieBindingSource = new BindingSource(components);
            contextLicitatiiBindingSource = new BindingSource(components);
            btnAdaugaLicitatie = new Button();
            btnStergeLicitatie = new Button();
            tabControlMain = new TabControl();
            tabPageLicitatii = new TabPage();
            tabPageCandidati = new TabPage();
            dataGridCandidati = new DataGridView();
            candidatIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            varstaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adresaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numarOferteDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            candidatBindingSource = new BindingSource(components);
            btnAdaugaCandidat = new Button();
            btnStergeCandidat = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridLicitatii).BeginInit();
            ((System.ComponentModel.ISupportInitialize)licitatieBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contextLicitatiiBindingSource).BeginInit();
            tabControlMain.SuspendLayout();
            tabPageLicitatii.SuspendLayout();
            tabPageCandidati.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCandidati).BeginInit();
            ((System.ComponentModel.ISupportInitialize)candidatBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridLicitatii
            // 
            dataGridLicitatii.AllowUserToAddRows = false;
            dataGridLicitatii.AllowUserToDeleteRows = false;
            dataGridLicitatii.AllowUserToResizeColumns = false;
            dataGridLicitatii.AllowUserToResizeRows = false;
            dataGridLicitatii.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridLicitatii.AutoGenerateColumns = false;
            dataGridLicitatii.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridLicitatii.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLicitatii.Columns.AddRange(new DataGridViewColumn[] { licitatieIdDataGridViewTextBoxColumn, numeDataGridViewTextBoxColumn, valoareStartDataGridViewTextBoxColumn, valoareFinalaDataGridViewTextBoxColumn, dataInceputDataGridViewTextBoxColumn, esteFinalizataDataGridViewCheckBoxColumn });
            dataGridLicitatii.DataSource = licitatieBindingSource;
            dataGridLicitatii.Location = new Point(0, 67);
            dataGridLicitatii.Name = "dataGridLicitatii";
            dataGridLicitatii.Size = new Size(777, 339);
            dataGridLicitatii.TabIndex = 1;
            // 
            // licitatieIdDataGridViewTextBoxColumn
            // 
            licitatieIdDataGridViewTextBoxColumn.DataPropertyName = "LicitatieId";
            licitatieIdDataGridViewTextBoxColumn.HeaderText = "LicitatieId";
            licitatieIdDataGridViewTextBoxColumn.Name = "licitatieIdDataGridViewTextBoxColumn";
            // 
            // numeDataGridViewTextBoxColumn
            // 
            numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            // 
            // valoareStartDataGridViewTextBoxColumn
            // 
            valoareStartDataGridViewTextBoxColumn.DataPropertyName = "ValoareStart";
            valoareStartDataGridViewTextBoxColumn.HeaderText = "ValoareStart";
            valoareStartDataGridViewTextBoxColumn.Name = "valoareStartDataGridViewTextBoxColumn";
            // 
            // valoareFinalaDataGridViewTextBoxColumn
            // 
            valoareFinalaDataGridViewTextBoxColumn.DataPropertyName = "ValoareFinala";
            valoareFinalaDataGridViewTextBoxColumn.HeaderText = "ValoareFinala";
            valoareFinalaDataGridViewTextBoxColumn.Name = "valoareFinalaDataGridViewTextBoxColumn";
            // 
            // dataInceputDataGridViewTextBoxColumn
            // 
            dataInceputDataGridViewTextBoxColumn.DataPropertyName = "DataInceput";
            dataInceputDataGridViewTextBoxColumn.HeaderText = "DataInceput";
            dataInceputDataGridViewTextBoxColumn.Name = "dataInceputDataGridViewTextBoxColumn";
            // 
            // esteFinalizataDataGridViewCheckBoxColumn
            // 
            esteFinalizataDataGridViewCheckBoxColumn.DataPropertyName = "EsteFinalizata";
            esteFinalizataDataGridViewCheckBoxColumn.HeaderText = "EsteFinalizata";
            esteFinalizataDataGridViewCheckBoxColumn.Name = "esteFinalizataDataGridViewCheckBoxColumn";
            // 
            // licitatieBindingSource
            // 
            licitatieBindingSource.DataSource = typeof(Models.Licitatie);
            // 
            // contextLicitatiiBindingSource
            // 
            contextLicitatiiBindingSource.DataSource = typeof(ContextLicitatii);
            // 
            // btnAdaugaLicitatie
            // 
            btnAdaugaLicitatie.Anchor = AnchorStyles.Right;
            btnAdaugaLicitatie.Location = new Point(696, 38);
            btnAdaugaLicitatie.Name = "btnAdaugaLicitatie";
            btnAdaugaLicitatie.Size = new Size(75, 23);
            btnAdaugaLicitatie.TabIndex = 2;
            btnAdaugaLicitatie.Text = "Adauga";
            btnAdaugaLicitatie.UseVisualStyleBackColor = true;
            btnAdaugaLicitatie.Click += button1_Click;
            // 
            // btnStergeLicitatie
            // 
            btnStergeLicitatie.Anchor = AnchorStyles.Right;
            btnStergeLicitatie.Location = new Point(615, 38);
            btnStergeLicitatie.Name = "btnStergeLicitatie";
            btnStergeLicitatie.Size = new Size(75, 23);
            btnStergeLicitatie.TabIndex = 3;
            btnStergeLicitatie.Text = "Sterge";
            btnStergeLicitatie.UseVisualStyleBackColor = true;
            btnStergeLicitatie.Click += button2_Click;
            // 
            // tabControlMain
            // 
            tabControlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlMain.Controls.Add(tabPageLicitatii);
            tabControlMain.Controls.Add(tabPageCandidati);
            tabControlMain.Location = new Point(12, 12);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(785, 434);
            tabControlMain.TabIndex = 4;
            // 
            // tabPageLicitatii
            // 
            tabPageLicitatii.Controls.Add(dataGridLicitatii);
            tabPageLicitatii.Controls.Add(btnAdaugaLicitatie);
            tabPageLicitatii.Controls.Add(btnStergeLicitatie);
            tabPageLicitatii.Location = new Point(4, 24);
            tabPageLicitatii.Name = "tabPageLicitatii";
            tabPageLicitatii.Padding = new Padding(3);
            tabPageLicitatii.Size = new Size(777, 406);
            tabPageLicitatii.TabIndex = 0;
            tabPageLicitatii.Text = "Licitatii";
            tabPageLicitatii.UseVisualStyleBackColor = true;
            // 
            // tabPageCandidati
            // 
            tabPageCandidati.Controls.Add(dataGridCandidati);
            tabPageCandidati.Controls.Add(btnAdaugaCandidat);
            tabPageCandidati.Controls.Add(btnStergeCandidat);
            tabPageCandidati.Location = new Point(4, 24);
            tabPageCandidati.Name = "tabPageCandidati";
            tabPageCandidati.Padding = new Padding(3);
            tabPageCandidati.Size = new Size(777, 406);
            tabPageCandidati.TabIndex = 1;
            tabPageCandidati.Text = "Candidati";
            tabPageCandidati.UseVisualStyleBackColor = true;
            // 
            // dataGridCandidati
            // 
            dataGridCandidati.AllowUserToAddRows = false;
            dataGridCandidati.AllowUserToDeleteRows = false;
            dataGridCandidati.AllowUserToResizeColumns = false;
            dataGridCandidati.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridCandidati.AutoGenerateColumns = false;
            dataGridCandidati.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCandidati.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCandidati.Columns.AddRange(new DataGridViewColumn[] { candidatIdDataGridViewTextBoxColumn, numeDataGridViewTextBoxColumn1, varstaDataGridViewTextBoxColumn, adresaDataGridViewTextBoxColumn, numarOferteDataGridViewTextBoxColumn });
            dataGridCandidati.DataSource = candidatBindingSource;
            dataGridCandidati.Location = new Point(1, 77);
            dataGridCandidati.Name = "dataGridCandidati";
            dataGridCandidati.Size = new Size(776, 329);
            dataGridCandidati.TabIndex = 5;
            dataGridCandidati.CellDoubleClick += dataGridCandidati_CellDoubleClick;
            // 
            // candidatIdDataGridViewTextBoxColumn
            // 
            candidatIdDataGridViewTextBoxColumn.DataPropertyName = "CandidatId";
            candidatIdDataGridViewTextBoxColumn.HeaderText = "CandidatId";
            candidatIdDataGridViewTextBoxColumn.Name = "candidatIdDataGridViewTextBoxColumn";
            // 
            // numeDataGridViewTextBoxColumn1
            // 
            numeDataGridViewTextBoxColumn1.DataPropertyName = "Nume";
            numeDataGridViewTextBoxColumn1.HeaderText = "Nume";
            numeDataGridViewTextBoxColumn1.Name = "numeDataGridViewTextBoxColumn1";
            // 
            // varstaDataGridViewTextBoxColumn
            // 
            varstaDataGridViewTextBoxColumn.DataPropertyName = "Varsta";
            varstaDataGridViewTextBoxColumn.HeaderText = "Varsta";
            varstaDataGridViewTextBoxColumn.Name = "varstaDataGridViewTextBoxColumn";
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            // 
            // numarOferteDataGridViewTextBoxColumn
            // 
            numarOferteDataGridViewTextBoxColumn.DataPropertyName = "NumarOferte";
            numarOferteDataGridViewTextBoxColumn.HeaderText = "NumarOferte";
            numarOferteDataGridViewTextBoxColumn.Name = "numarOferteDataGridViewTextBoxColumn";
            numarOferteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // candidatBindingSource
            // 
            candidatBindingSource.DataSource = typeof(Models.Candidat);
            // 
            // btnAdaugaCandidat
            // 
            btnAdaugaCandidat.Anchor = AnchorStyles.Right;
            btnAdaugaCandidat.Location = new Point(699, 48);
            btnAdaugaCandidat.Name = "btnAdaugaCandidat";
            btnAdaugaCandidat.Size = new Size(75, 23);
            btnAdaugaCandidat.TabIndex = 4;
            btnAdaugaCandidat.Text = "Adauga";
            btnAdaugaCandidat.UseVisualStyleBackColor = true;
            btnAdaugaCandidat.Click += btnAdaugaCandidat_Click;
            // 
            // btnStergeCandidat
            // 
            btnStergeCandidat.Anchor = AnchorStyles.Right;
            btnStergeCandidat.Location = new Point(618, 48);
            btnStergeCandidat.Name = "btnStergeCandidat";
            btnStergeCandidat.Size = new Size(75, 23);
            btnStergeCandidat.TabIndex = 3;
            btnStergeCandidat.Text = "Sterge";
            btnStergeCandidat.UseVisualStyleBackColor = true;
            btnStergeCandidat.Click += btnStergeCandidat_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControlMain);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridLicitatii).EndInit();
            ((System.ComponentModel.ISupportInitialize)licitatieBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)contextLicitatiiBindingSource).EndInit();
            tabControlMain.ResumeLayout(false);
            tabPageLicitatii.ResumeLayout(false);
            tabPageCandidati.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridCandidati).EndInit();
            ((System.ComponentModel.ISupportInitialize)candidatBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridLicitatii;
        private DataGridViewTextBoxColumn licitatieIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valoareStartDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valoareFinalaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataInceputDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn esteFinalizataDataGridViewCheckBoxColumn;
        private BindingSource licitatieBindingSource;
        private BindingSource contextLicitatiiBindingSource;
        private Button btnAdaugaLicitatie;
        private Button btnStergeLicitatie;
        private TabControl tabControlMain;
        private TabPage tabPageLicitatii;
        private TabPage tabPageCandidati;
        private Button btnStergeCandidat;
        private Button btnAdaugaCandidat;
        private DataGridView dataGridCandidati;
        private DataGridViewTextBoxColumn candidatIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn varstaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numarOferteDataGridViewTextBoxColumn;
        private BindingSource candidatBindingSource;
    }
}
