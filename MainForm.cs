using Licitatii.Models;

namespace Licitatii
{
    public partial class MainForm : Form
    {
        ContextLicitatii ctx;
        public MainForm()
        {
            InitializeComponent();
            ctx = new ContextLicitatii();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            licitatieBindingSource.DataSource = ctx.Licitatii.ToList();
            candidatBindingSource.DataSource = ctx.Candidati.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctx.Licitatii.Add(new Licitatie() { Nume = "Test", ValoareStart = 0, ValoareFinala = 100, DataInceput = DateTime.Now, EsteFinalizata = false });
            ctx.SaveChanges();
            licitatieBindingSource.DataSource = ctx.Licitatii.ToList();
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
                    licitatieBindingSource.DataSource = ctx.Licitatii.ToList();
                }
            }
        }

        private void btnAdaugaCandidat_Click(object sender, EventArgs e)
        {
            AddCandidatPopup addCandidatPopup = new AddCandidatPopup(null, ctx);
            if(addCandidatPopup.ShowDialog() == DialogResult.OK)
            {
                candidatBindingSource.DataSource = ctx.Candidati.ToList();
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
                    candidatBindingSource.DataSource = ctx.Candidati.ToList();
                }
            }
        }

        private void dataGridCandidati_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridCandidati.Rows[e.RowIndex];

                Candidat candidat = row.DataBoundItem as Candidat;
                if(candidat != null)
                {
                    AddCandidatPopup addCandidatPopup = new AddCandidatPopup(candidat, ctx);
                    if (addCandidatPopup.ShowDialog() == DialogResult.OK)
                    {
                        candidatBindingSource.ResetBindings(false);
                    }
                }
            }
        }
    }
}
