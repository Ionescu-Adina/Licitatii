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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dataGridLicitatii = new DataGridView();
            licitatieIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            numeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valoareStartDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valoareFinalaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataInceputDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            DataFinal = new DataGridViewTextBoxColumn();
            licitatieBindingSource = new BindingSource(components);
            contextLicitatiiBindingSource = new BindingSource(components);
            btnAdaugaLicitatie = new Button();
            btnStergeLicitatie = new Button();
            tabControlMain = new TabControl();
            tabPageLicitatii = new TabPage();
            statusStrip1 = new StatusStrip();
            toolStripStatusNumarLicitatii = new ToolStripStatusLabel();
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            genereazaRaportTextToolStripMenuItem = new ToolStripMenuItem();
            printeazaDocumentulToolStripMenuItem = new ToolStripMenuItem();
            previzualizeazaPrintToolStripMenuItem = new ToolStripMenuItem();
            setariPrintToolStripMenuItem = new ToolStripMenuItem();
            serializareJSONToolStripMenuItem = new ToolStripMenuItem();
            serializeazaLicitatiiToolStripMenuItem = new ToolStripMenuItem();
            deserializeazaLicitatiiToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            copiazaToolStripMenuItem = new ToolStripMenuItem();
            lipesteToolStripMenuItem = new ToolStripMenuItem();
            printDocument = new System.Drawing.Printing.PrintDocument();
            pageSetupDialog = new PageSetupDialog();
            printPreviewDialog = new PrintPreviewDialog();
            printDialog = new PrintDialog();
            ((System.ComponentModel.ISupportInitialize)dataGridLicitatii).BeginInit();
            ((System.ComponentModel.ISupportInitialize)licitatieBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)contextLicitatiiBindingSource).BeginInit();
            tabControlMain.SuspendLayout();
            tabPageLicitatii.SuspendLayout();
            statusStrip1.SuspendLayout();
            tabPageCandidati.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridCandidati).BeginInit();
            ((System.ComponentModel.ISupportInitialize)candidatBindingSource).BeginInit();
            menuStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
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
            dataGridLicitatii.BackgroundColor = Color.Moccasin;
            dataGridLicitatii.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridLicitatii.Columns.AddRange(new DataGridViewColumn[] { licitatieIdDataGridViewTextBoxColumn, numeDataGridViewTextBoxColumn, valoareStartDataGridViewTextBoxColumn, valoareFinalaDataGridViewTextBoxColumn, dataInceputDataGridViewTextBoxColumn, DataFinal });
            dataGridLicitatii.DataSource = licitatieBindingSource;
            dataGridLicitatii.Location = new Point(6, 37);
            dataGridLicitatii.Name = "dataGridLicitatii";
            dataGridLicitatii.Size = new Size(815, 434);
            dataGridLicitatii.TabIndex = 1;
            dataGridLicitatii.CellDoubleClick += dataGridLicitatii_CellDoubleClick;
            dataGridLicitatii.CellMouseDown += dataGridLicitatii_CellMouseDown;
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
            // DataFinal
            // 
            DataFinal.DataPropertyName = "DataFinal";
            DataFinal.HeaderText = "DataFinal";
            DataFinal.Name = "DataFinal";
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
            btnAdaugaLicitatie.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdaugaLicitatie.Location = new Point(743, 6);
            btnAdaugaLicitatie.Name = "btnAdaugaLicitatie";
            btnAdaugaLicitatie.Size = new Size(76, 25);
            btnAdaugaLicitatie.TabIndex = 2;
            btnAdaugaLicitatie.Text = "&Adauga";
            btnAdaugaLicitatie.UseVisualStyleBackColor = true;
            btnAdaugaLicitatie.Click += button1_Click;
            // 
            // btnStergeLicitatie
            // 
            btnStergeLicitatie.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnStergeLicitatie.Location = new Point(661, 6);
            btnStergeLicitatie.Name = "btnStergeLicitatie";
            btnStergeLicitatie.Size = new Size(76, 25);
            btnStergeLicitatie.TabIndex = 3;
            btnStergeLicitatie.Text = "Sterge";
            btnStergeLicitatie.UseVisualStyleBackColor = true;
            btnStergeLicitatie.Click += button2_Click;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageLicitatii);
            tabControlMain.Controls.Add(tabPageCandidati);
            tabControlMain.Location = new Point(3, 38);
            tabControlMain.Margin = new Padding(0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(835, 527);
            tabControlMain.TabIndex = 4;
            // 
            // tabPageLicitatii
            // 
            tabPageLicitatii.BackColor = Color.Thistle;
            tabPageLicitatii.Controls.Add(statusStrip1);
            tabPageLicitatii.Controls.Add(dataGridLicitatii);
            tabPageLicitatii.Controls.Add(btnAdaugaLicitatie);
            tabPageLicitatii.Controls.Add(btnStergeLicitatie);
            tabPageLicitatii.ForeColor = Color.Black;
            tabPageLicitatii.Location = new Point(4, 24);
            tabPageLicitatii.Name = "tabPageLicitatii";
            tabPageLicitatii.Padding = new Padding(3);
            tabPageLicitatii.Size = new Size(827, 499);
            tabPageLicitatii.TabIndex = 0;
            tabPageLicitatii.Text = "Licitatii";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusNumarLicitatii });
            statusStrip1.Location = new Point(3, 474);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(821, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusNumarLicitatii
            // 
            toolStripStatusNumarLicitatii.Name = "toolStripStatusNumarLicitatii";
            toolStripStatusNumarLicitatii.Size = new Size(0, 17);
            // 
            // tabPageCandidati
            // 
            tabPageCandidati.BackColor = Color.Thistle;
            tabPageCandidati.Controls.Add(dataGridCandidati);
            tabPageCandidati.Controls.Add(btnAdaugaCandidat);
            tabPageCandidati.Controls.Add(btnStergeCandidat);
            tabPageCandidati.Location = new Point(4, 24);
            tabPageCandidati.Margin = new Padding(0);
            tabPageCandidati.Name = "tabPageCandidati";
            tabPageCandidati.Size = new Size(827, 499);
            tabPageCandidati.TabIndex = 1;
            tabPageCandidati.Text = "Candidati";
            // 
            // dataGridCandidati
            // 
            dataGridCandidati.AllowUserToAddRows = false;
            dataGridCandidati.AllowUserToDeleteRows = false;
            dataGridCandidati.AllowUserToResizeColumns = false;
            dataGridCandidati.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridCandidati.AutoGenerateColumns = false;
            dataGridCandidati.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridCandidati.BackgroundColor = Color.Moccasin;
            dataGridCandidati.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridCandidati.Columns.AddRange(new DataGridViewColumn[] { candidatIdDataGridViewTextBoxColumn, numeDataGridViewTextBoxColumn1, varstaDataGridViewTextBoxColumn, adresaDataGridViewTextBoxColumn, numarOferteDataGridViewTextBoxColumn });
            dataGridCandidati.DataSource = candidatBindingSource;
            dataGridCandidati.Location = new Point(5, 37);
            dataGridCandidati.Name = "dataGridCandidati";
            dataGridCandidati.Size = new Size(815, 455);
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
            btnAdaugaCandidat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdaugaCandidat.Location = new Point(744, 6);
            btnAdaugaCandidat.Name = "btnAdaugaCandidat";
            btnAdaugaCandidat.Size = new Size(75, 25);
            btnAdaugaCandidat.TabIndex = 4;
            btnAdaugaCandidat.Text = "Adauga";
            btnAdaugaCandidat.UseVisualStyleBackColor = true;
            btnAdaugaCandidat.Click += btnAdaugaCandidat_Click;
            // 
            // btnStergeCandidat
            // 
            btnStergeCandidat.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnStergeCandidat.Location = new Point(663, 6);
            btnStergeCandidat.Name = "btnStergeCandidat";
            btnStergeCandidat.Size = new Size(75, 25);
            btnStergeCandidat.TabIndex = 3;
            btnStergeCandidat.Text = "Sterge";
            btnStergeCandidat.UseVisualStyleBackColor = true;
            btnStergeCandidat.Click += btnStergeCandidat_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, serializareJSONToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(838, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { genereazaRaportTextToolStripMenuItem, printeazaDocumentulToolStripMenuItem, previzualizeazaPrintToolStripMenuItem, setariPrintToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // genereazaRaportTextToolStripMenuItem
            // 
            genereazaRaportTextToolStripMenuItem.Name = "genereazaRaportTextToolStripMenuItem";
            genereazaRaportTextToolStripMenuItem.Size = new Size(190, 22);
            genereazaRaportTextToolStripMenuItem.Text = "Genereaza raport text";
            genereazaRaportTextToolStripMenuItem.Click += genereazaRaportTextToolStripMenuItem_Click;
            // 
            // printeazaDocumentulToolStripMenuItem
            // 
            printeazaDocumentulToolStripMenuItem.Name = "printeazaDocumentulToolStripMenuItem";
            printeazaDocumentulToolStripMenuItem.Size = new Size(190, 22);
            printeazaDocumentulToolStripMenuItem.Text = "&Printeaza documentul";
            printeazaDocumentulToolStripMenuItem.Click += printeazaDocumentulToolStripMenuItem_Click;
            // 
            // previzualizeazaPrintToolStripMenuItem
            // 
            previzualizeazaPrintToolStripMenuItem.Name = "previzualizeazaPrintToolStripMenuItem";
            previzualizeazaPrintToolStripMenuItem.Size = new Size(190, 22);
            previzualizeazaPrintToolStripMenuItem.Text = "Previzualizeaza print";
            previzualizeazaPrintToolStripMenuItem.Click += previzualizeazaPrintToolStripMenuItem_Click;
            // 
            // setariPrintToolStripMenuItem
            // 
            setariPrintToolStripMenuItem.Name = "setariPrintToolStripMenuItem";
            setariPrintToolStripMenuItem.Size = new Size(190, 22);
            setariPrintToolStripMenuItem.Text = "Setari print";
            setariPrintToolStripMenuItem.Click += setariPrintToolStripMenuItem_Click;
            // 
            // serializareJSONToolStripMenuItem
            // 
            serializareJSONToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { serializeazaLicitatiiToolStripMenuItem, deserializeazaLicitatiiToolStripMenuItem });
            serializareJSONToolStripMenuItem.Name = "serializareJSONToolStripMenuItem";
            serializareJSONToolStripMenuItem.Size = new Size(102, 20);
            serializareJSONToolStripMenuItem.Text = "Serializare JSON";
            // 
            // serializeazaLicitatiiToolStripMenuItem
            // 
            serializeazaLicitatiiToolStripMenuItem.Name = "serializeazaLicitatiiToolStripMenuItem";
            serializeazaLicitatiiToolStripMenuItem.Size = new Size(187, 22);
            serializeazaLicitatiiToolStripMenuItem.Text = "Serializeaza Licitatii";
            serializeazaLicitatiiToolStripMenuItem.Click += serializeazaLicitatiiToolStripMenuItem_Click;
            // 
            // deserializeazaLicitatiiToolStripMenuItem
            // 
            deserializeazaLicitatiiToolStripMenuItem.Name = "deserializeazaLicitatiiToolStripMenuItem";
            deserializeazaLicitatiiToolStripMenuItem.Size = new Size(187, 22);
            deserializeazaLicitatiiToolStripMenuItem.Text = "Deserializeaza Licitatii";
            deserializeazaLicitatiiToolStripMenuItem.Click += deserializeazaLicitatiiToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { copiazaToolStripMenuItem, lipesteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(117, 48);
            // 
            // copiazaToolStripMenuItem
            // 
            copiazaToolStripMenuItem.Name = "copiazaToolStripMenuItem";
            copiazaToolStripMenuItem.Size = new Size(116, 22);
            copiazaToolStripMenuItem.Text = "Copiaza";
            copiazaToolStripMenuItem.Click += copiazaToolStripMenuItem_Click_1;
            // 
            // lipesteToolStripMenuItem
            // 
            lipesteToolStripMenuItem.Name = "lipesteToolStripMenuItem";
            lipesteToolStripMenuItem.Size = new Size(116, 22);
            lipesteToolStripMenuItem.Text = "Lipeste";
            lipesteToolStripMenuItem.Click += lipesteToolStripMenuItem_Click;
            // 
            // printDocument
            // 
            printDocument.BeginPrint += printDocument_BeginPrint;
            printDocument.PrintPage += printDocument_PrintPage;
            // 
            // pageSetupDialog
            // 
            pageSetupDialog.Document = printDocument;
            // 
            // printPreviewDialog
            // 
            printPreviewDialog.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.Enabled = true;
            printPreviewDialog.Icon = (Icon)resources.GetObject("printPreviewDialog.Icon");
            printPreviewDialog.Name = "printPreviewDialog";
            printPreviewDialog.Visible = false;
            // 
            // printDialog
            // 
            printDialog.Document = printDocument;
            printDialog.UseEXDialog = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(838, 566);
            Controls.Add(tabControlMain);
            Controls.Add(menuStrip1);
            Location = new Point(854, 605);
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(854, 605);
            MinimumSize = new Size(854, 605);
            Name = "MainForm";
            Text = "Licitatii";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridLicitatii).EndInit();
            ((System.ComponentModel.ISupportInitialize)licitatieBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)contextLicitatiiBindingSource).EndInit();
            tabControlMain.ResumeLayout(false);
            tabPageLicitatii.ResumeLayout(false);
            tabPageLicitatii.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabPageCandidati.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridCandidati).EndInit();
            ((System.ComponentModel.ISupportInitialize)candidatBindingSource).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridLicitatii;
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
        private DataGridViewTextBoxColumn licitatieIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valoareStartDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valoareFinalaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataInceputDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn DataFinal;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusNumarLicitatii;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem genereazaRaportTextToolStripMenuItem;
        private ToolStripMenuItem serializareJSONToolStripMenuItem;
        private ToolStripMenuItem serializeazaLicitatiiToolStripMenuItem;
        private ToolStripMenuItem deserializeazaLicitatiiToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem printeazaDocumentulToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocument;
        private PageSetupDialog pageSetupDialog;
        private ToolStripMenuItem previzualizeazaPrintToolStripMenuItem;
        private ToolStripMenuItem setariPrintToolStripMenuItem;
        private PrintPreviewDialog printPreviewDialog;
        private PrintDialog printDialog;
        private ToolStripMenuItem copiazaToolStripMenuItem;
        private ToolStripMenuItem lipesteToolStripMenuItem;
    }
}
