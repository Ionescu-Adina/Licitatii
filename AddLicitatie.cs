using Licitatii.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Licitatii
{
    public partial class AddLicitatie : Form
    {
        ContextLicitatii _ctx;
        Licitatie _licitatie;
        public AddLicitatie(ContextLicitatii context, Licitatie licitatie)
        {
            _ctx = context;
            _licitatie = licitatie;
            InitializeComponent();
        }

        private void AddLicitatie_Load(object sender, EventArgs e)
        {
            if (_licitatie != null)
            {
                textBoxNumeLicitatie.Text = _licitatie.Nume;
                textBoxValoareStart.Text = _licitatie.ValoareStart.ToString();
                dateTimePickerDataInceput.Value = _licitatie.DataInceput;
                dateTimePickerDataFinalizare.Value = _licitatie.DataFinal;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(_licitatie == null)
            {
                _licitatie = new Licitatie()
                {
                    Nume = textBoxNumeLicitatie.Text,
                    ValoareStart = Decimal.Parse(textBoxValoareStart.Text),
                    DataInceput = dateTimePickerDataInceput.Value,
                    DataFinal = dateTimePickerDataFinalizare.Value
                };
                _ctx.Licitatii.Add(_licitatie);
            }
            else
            {
                _licitatie.Nume = textBoxNumeLicitatie.Text;
                _licitatie.ValoareStart = Decimal.Parse(textBoxValoareStart.Text);
                _licitatie.DataInceput = dateTimePickerDataInceput.Value;
                _licitatie.DataFinal = dateTimePickerDataFinalizare.Value;
            }
            _ctx.SaveChanges();
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
