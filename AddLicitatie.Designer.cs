namespace Licitatii
{
    partial class AddLicitatie
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
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxNumeLicitatie = new TextBox();
            textBoxValoareStart = new TextBox();
            dateTimePickerDataInceput = new DateTimePicker();
            dateTimePickerDataFinalizare = new DateTimePicker();
            btnCancel = new Button();
            btnOK = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 30);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nume";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 90);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Valoare Start";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 151);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 3;
            label4.Text = "Data Inceput";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 215);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 4;
            label5.Text = "Data Finalizare";
            // 
            // textBoxNumeLicitatie
            // 
            textBoxNumeLicitatie.Location = new Point(130, 27);
            textBoxNumeLicitatie.Name = "textBoxNumeLicitatie";
            textBoxNumeLicitatie.Size = new Size(242, 23);
            textBoxNumeLicitatie.TabIndex = 5;
            // 
            // textBoxValoareStart
            // 
            textBoxValoareStart.Location = new Point(130, 87);
            textBoxValoareStart.Name = "textBoxValoareStart";
            textBoxValoareStart.Size = new Size(242, 23);
            textBoxValoareStart.TabIndex = 6;
            // 
            // dateTimePickerDataInceput
            // 
            dateTimePickerDataInceput.Location = new Point(130, 145);
            dateTimePickerDataInceput.Name = "dateTimePickerDataInceput";
            dateTimePickerDataInceput.Size = new Size(242, 23);
            dateTimePickerDataInceput.TabIndex = 8;
            // 
            // dateTimePickerDataFinalizare
            // 
            dateTimePickerDataFinalizare.Location = new Point(130, 209);
            dateTimePickerDataFinalizare.Name = "dateTimePickerDataFinalizare";
            dateTimePickerDataFinalizare.Size = new Size(242, 23);
            dateTimePickerDataFinalizare.TabIndex = 9;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.Location = new Point(297, 273);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOK.Location = new Point(216, 273);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 11;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // AddLicitatie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(399, 323);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Controls.Add(dateTimePickerDataFinalizare);
            Controls.Add(dateTimePickerDataInceput);
            Controls.Add(textBoxValoareStart);
            Controls.Add(textBoxNumeLicitatie);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximumSize = new Size(415, 362);
            MinimumSize = new Size(415, 362);
            Name = "AddLicitatie";
            Padding = new Padding(24);
            Text = "Adauga / Editeaza Licitatie";
            Load += AddLicitatie_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox textBoxNumeLicitatie;
        private TextBox textBoxValoareStart;
        private DateTimePicker dateTimePickerDataInceput;
        private DateTimePicker dateTimePickerDataFinalizare;
        private Button btnCancel;
        private Button btnOK;
    }
}