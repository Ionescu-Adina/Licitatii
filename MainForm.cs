using GraphicsControl;
using Licitatii.Models;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Licitatii
{
    public partial class MainForm : Form
    {
        ContextLicitatii ctx;
        int _indexLicitatie = 0;
        public MainForm()
        {
            InitializeComponent();
            ctx = new ContextLicitatii();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            licitatieBindingSource.DataSource = ctx.Licitatii.Include(l => l.Oferte).ToList();
            toolStripStatusNumarLicitatii.Text = $"Numar licitatii: {ctx.Licitatii.Count()}";
            candidatBindingSource.DataSource = ctx.Candidati.Include(c => c.Oferte).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddLicitatie addForm = new AddLicitatie(ctx, null);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                licitatieBindingSource.DataSource = ctx.Licitatii.Include(l => l.Oferte).ToList();
                toolStripStatusNumarLicitatii.Text = $"Numar licitatii: {ctx.Licitatii.Count()}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sunteti sigur ca doriti sa stergeti licitatiile selectate?", "Confirmare", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGridLicitatii.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow gridRow in dataGridLicitatii.SelectedRows)
                    {
                        Licitatie l = gridRow.DataBoundItem as Licitatie;
                        if (l != null)
                        {
                            ctx.Licitatii.Remove(l);
                        }
                    }
                    ctx.SaveChanges();
                    licitatieBindingSource.DataSource = ctx.Licitatii.Include(l => l.Oferte).ToList();
                    toolStripStatusNumarLicitatii.Text = $"Numar licitatii: {ctx.Licitatii.Count()}";
                }
            }
        }

        private void btnAdaugaCandidat_Click(object sender, EventArgs e)
        {
            AddCandidatPopup addCandidatPopup = new AddCandidatPopup(null, ctx);
            if (addCandidatPopup.ShowDialog() == DialogResult.OK)
            {
                candidatBindingSource.DataSource = ctx.Candidati.Include(c => c.Oferte).ToList();
            }
        }

        private void btnStergeCandidat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sunteti sigur ca doriti sa stergeti candidatii selectati?", "Confirmare", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGridCandidati.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow gridRow in dataGridCandidati.SelectedRows)
                    {
                        Candidat l = gridRow.DataBoundItem as Candidat;
                        if (l != null)
                        {
                            ctx.Candidati.Remove(l);
                        }
                    }
                    ctx.SaveChanges();
                    candidatBindingSource.DataSource = ctx.Candidati.Include(c => c.Oferte).ToList();
                }
            }
        }

        private void dataGridCandidati_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridCandidati.Rows[e.RowIndex];

                Candidat candidat = row.DataBoundItem as Candidat;
                if (candidat != null)
                {
                    AddCandidatPopup addCandidatPopup = new AddCandidatPopup(candidat, ctx);
                    if (addCandidatPopup.ShowDialog() == DialogResult.OK)
                    {
                        candidatBindingSource.DataSource = ctx.Candidati.Include(c => c.Oferte).ToList();
                    }
                }
            }
        }

        private void dataGridLicitatii_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridLicitatii.Rows[e.RowIndex];

                Licitatie licitatie = row.DataBoundItem as Licitatie;
                if (licitatie != null)
                {
                    AddLicitatie addForm = new AddLicitatie(ctx, licitatie);
                    if (addForm.ShowDialog() == DialogResult.OK)
                    {
                        licitatieBindingSource.DataSource = ctx.Licitatii.Include(l => l.Oferte).ToList();
                    }
                }

            }
        }

        private void serializeazaLicitatiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FileStream stream = File.Create("Licitatii.json"))
            {
                JsonSerializerOptions options = new()
                {
                    ReferenceHandler = ReferenceHandler.Preserve,
                    WriteIndented = true
                };
                JsonSerializer.Serialize(stream, ctx.Licitatii.Include(l => l.Oferte).ToList(), options);
            }
        }

        private void deserializeazaLicitatiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FileStream stream = File.OpenRead("Licitatii.json"))
            {
                JsonSerializerOptions options = new()
                {
                    ReferenceHandler = ReferenceHandler.Preserve
                };
                List<Licitatie> licitatii = JsonSerializer.Deserialize<List<Licitatie>>(stream, options);
                if (licitatii != null)
                {
                    ctx.Licitatii.RemoveRange(ctx.Licitatii);
                    ctx.Licitatii.AddRange(licitatii);
                    ctx.SaveChanges();
                    licitatieBindingSource.DataSource = ctx.Licitatii.Include(l => l.Oferte).ToList();
                    toolStripStatusNumarLicitatii.Text = $"Numar licitatii: {ctx.Licitatii.Count()}";
                }
            }
        }

        private void genereazaRaportTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File | *.txt";
            saveFileDialog.Title = "Save as text file";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = File.CreateText(saveFileDialog.FileName))
                {
                    sw.WriteLine("Nume,ValoareStart,ValoareFinala,DataInceput,DataFinal");

                    foreach (Licitatie licitatie in ctx.Licitatii.ToList())
                    {
                        sw.WriteLine("\"{0}\", \"{1}\", \"{2}\", \"{3}\", \"{4}\""
                                    , licitatie.Nume.Replace("\"", "\"\"")
                                    , licitatie.ValoareStart.ToString().Replace("\"", "\"\"")
                                    , licitatie.ValoareFinala.ToString().Replace("\"", "\"\"")
                                    , licitatie.DataInceput.ToShortDateString().Replace("\"", "\"\"")
                                    , licitatie.DataFinal.ToShortDateString());
                    }
                }
            }
        }

        private void printeazaDocumentulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDocument.Print();
        }

        private void setariPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;

            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font font = new Font("Microsoft Sans Serif", 24);

            var pageSettings = e.PageSettings;

            var printAreaHeight = e.MarginBounds.Height;

            var printAreaWidth = e.MarginBounds.Width;

            var marginLeft = 0;

            var marginTop = pageSettings.Margins.Top;


            if (pageSettings.Landscape)
            {
                var intTemp = printAreaHeight;
                printAreaHeight = printAreaWidth;
                printAreaWidth = intTemp;
            }

            const int rowHeight = 40;
            var columnWidth = printAreaWidth / 3;

            StringFormat fmt = new StringFormat(StringFormatFlags.LineLimit);
            fmt.Trimming = StringTrimming.EllipsisCharacter;

            var currentY = marginTop;
            while (_indexLicitatie < ctx.Licitatii.Count())
            {
                var currentX = marginLeft;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);

                e.Graphics.DrawString(
                    ctx.Licitatii.ElementAt(_indexLicitatie).Nume,
                    font,
                    Brushes.Black,
                    new RectangleF(currentX, currentY, columnWidth, rowHeight),
                    fmt);
                //Update the horizontal drawing coordinate
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                     ctx.Licitatii.ElementAt(_indexLicitatie).ValoareStart.ToString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                     ctx.Licitatii.ElementAt(_indexLicitatie).DataInceput.ToShortDateString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);
                currentX += columnWidth;

                e.Graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);
                e.Graphics.DrawString(
                     ctx.Licitatii.ElementAt(_indexLicitatie).DataFinal.ToShortDateString(),
                    font,
                    Brushes.Black,
                    currentX,
                    currentY,
                    fmt);


                //Update the participant index
                _indexLicitatie++;
                //Update the vertifcal drawing coordinate
                currentY += rowHeight;

                // HasMorePages tells the printing module whether another PrintPage event should be fired.
                if (currentY + rowHeight > printAreaHeight)
                {
                    e.HasMorePages = true;
                    break;
                }
            }
        }

        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            _indexLicitatie = 0;
        }

        private void previzualizeazaPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while trying to load the document for Print Preview. Make sure you currently have access to a printer. A printer must be connected and accessible for Print Preview to work.");
            }
        }

        private void copiazaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void copiazaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (dataGridLicitatii.SelectedRows.Count != 1)
            {
                return;
            }
            Licitatie licitatieSelectata = dataGridLicitatii.SelectedRows[0].DataBoundItem as Licitatie;
            if (licitatieSelectata != null)
            {
                Clipboard.SetText(licitatieSelectata.LicitatieId.ToString());
            }
        }

        private void lipesteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                int idLicitatie = Int32.Parse(Clipboard.GetText());
                Licitatie licitatieCopiata = ctx.Licitatii.Include(l => l.Oferte).FirstOrDefault(l => l.LicitatieId == idLicitatie);
                if (licitatieCopiata != null)
                {
                    Licitatie clona = new Licitatie
                    {
                        Nume = licitatieCopiata.Nume + " - Copie",
                        ValoareStart = licitatieCopiata.ValoareStart,
                        ValoareFinala = licitatieCopiata.ValoareFinala,
                        DataInceput = licitatieCopiata.DataInceput,
                        DataFinal = licitatieCopiata.DataFinal,
                    };
                    ctx.Licitatii.Add(clona);
                }
                ctx.SaveChanges();
                licitatieBindingSource.DataSource = ctx.Licitatii.Include(l => l.Oferte).ToList();
                toolStripStatusNumarLicitatii.Text = $"Numar licitatii: {ctx.Licitatii.Count()}";
            }
            catch
            {
                return;
            }
        }

        private void dataGridLicitatii_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }
            contextMenuStrip1.Show(Cursor.Position);
        }
    }
}
