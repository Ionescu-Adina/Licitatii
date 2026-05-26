using Licitatii.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Licitatii
{
    public partial class AddCandidatPopup : Form
    {
        Candidat _candidat;

        ContextLicitatii _ctx;

        bool isEditMode;
        public AddCandidatPopup(Candidat candidat, ContextLicitatii context)
        {
            InitializeComponent();
            _candidat = candidat;
            _ctx = context;
            if (_candidat == null)
            {
                isEditMode = false;
            }
            else
            {
                isEditMode = true;
            }
        }

        private void AddCandidatPopup_Load(object sender, EventArgs e)
        {
            if (_candidat != null)
            {
                ofertaBindingSource.DataSource = _ctx.Oferte.Where(o => o.CandidatId == _candidat.CandidatId).ToList();
                textBox1.Text = _candidat.Nume;
                textBox2.Text = _candidat.Varsta.ToString();
                textBox3.Text = _candidat.Adresa;
                comboBoxSelectLicitatie.DataSource = _ctx.Licitatii.Where(l => l.DataFinal > DateTime.Now).ToList();
                comboBoxSelectLicitatie.DisplayMember = "Nume";
                comboBoxSelectLicitatie.ValueMember = "LicitatieId";

                userControlProfileCard1.LoadControlData(_candidat.Nume,
                    _ctx.Oferte.Where(o => o.CandidatId == _candidat.CandidatId).Select(o => o.LicitatieId).Distinct().Count(),
                    _ctx.Oferte.Where(o => o.CandidatId == _candidat.CandidatId).Count());
            }
            else
            {
                groupBox2.Visible = false;
                groupBox3.Visible = false;
                comboBoxSelectLicitatie.Visible = false;
                textBoxValoareLicitatie.Visible = false;
                textBoxSumaOferita.Visible = false;
                dataGridOferteCandidat.Visible = false;
                userControlProfileCard1.Visible = false;
            }
        }

        private void comboBoxSelectLicitatie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelectLicitatie.SelectedItem != null)
            {
                Licitatie licitatie = comboBoxSelectLicitatie.SelectedItem as Licitatie;
                if (licitatie == null)
                {
                    return;
                }
                else
                {
                    List<Oferta> oferte = _ctx.Oferte.Where(o => o.LicitatieId == licitatie.LicitatieId).ToList();
                    if (oferte.Count > 0)
                    {
                        textBoxValoareLicitatie.Text = oferte.Max(o => o.SumaOferita).ToString();
                    }
                    else
                    {
                        textBoxValoareLicitatie.Text = "0";
                    }
                }
            }
        }

        private void btnAdaugaOferta_Click(object sender, EventArgs e)
        {
            Licitatie licitatie = comboBoxSelectLicitatie.SelectedItem as Licitatie;
            if (licitatie == null)
            {
                return;
            }
            decimal valoareOferta = Decimal.Parse(textBoxSumaOferita.Text);
            Oferta oferta = new Oferta
            {
                CandidatId = _candidat.CandidatId,
                Candidat = _candidat,
                LicitatieId = licitatie.LicitatieId,
                Licitatie = licitatie,
                SumaOferita = valoareOferta,
                DataOferta = DateTime.Now
            };
            _ctx.Oferte.Add(oferta);
            _ctx.SaveChanges();
            ofertaBindingSource.DataSource = _ctx.Oferte.Where(o => o.CandidatId == _candidat.CandidatId).ToList();
            MessageBox.Show("Oferta adaugata cu succes!", "Informatie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                MessageBox.Show("The form contains errors!",
                    "Error",
                      MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }
            if (_candidat == null)
            {
                Candidat candidat = new Candidat
                {
                    Nume = textBox1.Text,
                    Varsta = Int32.Parse(textBox2.Text),
                    Adresa = textBox3.Text
                };
                _ctx.Candidati.Add(candidat);
            }
            else
            {
                _candidat.Nume = textBox1.Text;
                _candidat.Varsta = Int32.Parse(textBox2.Text);
                _candidat.Adresa = textBox3.Text;
            }
            _ctx.SaveChanges();
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private bool EsteVarstaValida()
        {
            int varsta;
            if (Int32.TryParse(textBox2.Text, out varsta))
            {
                return varsta > 0;
            }
            return false;
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (!EsteVarstaValida())
            {
                errorProvider.SetError(textBox2, "Varsta trebuie sa fie un numar intreg pozitiv.");
                e.Cancel = true;
            }
        }

        private void textBox2_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }
    }
}
