namespace M03.UF5._AC3
{
    partial class Form1
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
            groupBoxGestio = new GroupBox();
            textBoxTotal = new TextBox();
            lblTotal = new Label();
            textBoxConsumDomesticPerCapita = new TextBox();
            lblConsum = new Label();
            textBoxActivitatsEconomiques = new TextBox();
            lblActivitats = new Label();
            textBoxDomesticXarxa = new TextBox();
            lblDomesticXarxa = new Label();
            textBoxPoblacio = new TextBox();
            comboBoxComarca = new ComboBox();
            lblPoblacio = new Label();
            lblComarca = new Label();
            comboBoxAny = new ComboBox();
            lblAny = new Label();
            groupBoxEstadistiques = new GroupBox();
            lblConsumMesBaix = new Label();
            lblConsumMesAlt = new Label();
            lblConsumMitja = new Label();
            lblPoblacioMajor = new Label();
            buttonGuardar = new Button();
            buttonNetejar = new Button();
            dataGridView1 = new DataGridView();
            labelResultPoblacio = new Label();
            labelResultConsumDomesticMitja = new Label();
            labelResultConsumMesAlt = new Label();
            labelResultConsumMesBaix = new Label();
            groupBoxGestio.SuspendLayout();
            groupBoxEstadistiques.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBoxGestio
            // 
            groupBoxGestio.Controls.Add(textBoxTotal);
            groupBoxGestio.Controls.Add(lblTotal);
            groupBoxGestio.Controls.Add(textBoxConsumDomesticPerCapita);
            groupBoxGestio.Controls.Add(lblConsum);
            groupBoxGestio.Controls.Add(textBoxActivitatsEconomiques);
            groupBoxGestio.Controls.Add(lblActivitats);
            groupBoxGestio.Controls.Add(textBoxDomesticXarxa);
            groupBoxGestio.Controls.Add(lblDomesticXarxa);
            groupBoxGestio.Controls.Add(textBoxPoblacio);
            groupBoxGestio.Controls.Add(comboBoxComarca);
            groupBoxGestio.Controls.Add(lblPoblacio);
            groupBoxGestio.Controls.Add(lblComarca);
            groupBoxGestio.Controls.Add(comboBoxAny);
            groupBoxGestio.Controls.Add(lblAny);
            groupBoxGestio.Location = new Point(12, 12);
            groupBoxGestio.Name = "groupBoxGestio";
            groupBoxGestio.Size = new Size(485, 228);
            groupBoxGestio.TabIndex = 0;
            groupBoxGestio.TabStop = false;
            groupBoxGestio.Text = "Gestió de dades demogràfiques de regions";
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(319, 182);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.Size = new Size(139, 23);
            textBoxTotal.TabIndex = 14;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotal.Location = new Point(319, 164);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(34, 15);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "Total";
            // 
            // textBoxConsumDomesticPerCapita
            // 
            textBoxConsumDomesticPerCapita.Location = new Point(319, 129);
            textBoxConsumDomesticPerCapita.Name = "textBoxConsumDomesticPerCapita";
            textBoxConsumDomesticPerCapita.Size = new Size(139, 23);
            textBoxConsumDomesticPerCapita.TabIndex = 12;
            // 
            // lblConsum
            // 
            lblConsum.AutoSize = true;
            lblConsum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConsum.Location = new Point(319, 96);
            lblConsum.Name = "lblConsum";
            lblConsum.Size = new Size(108, 30);
            lblConsum.TabIndex = 11;
            lblConsum.Text = "Consum domèstic \r\nper càpita\r\n";
            // 
            // textBoxActivitatsEconomiques
            // 
            textBoxActivitatsEconomiques.Location = new Point(125, 129);
            textBoxActivitatsEconomiques.Name = "textBoxActivitatsEconomiques";
            textBoxActivitatsEconomiques.Size = new Size(139, 23);
            textBoxActivitatsEconomiques.TabIndex = 10;
            // 
            // lblActivitats
            // 
            lblActivitats.AutoSize = true;
            lblActivitats.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblActivitats.Location = new Point(125, 96);
            lblActivitats.Name = "lblActivitats";
            lblActivitats.Size = new Size(140, 30);
            lblActivitats.TabIndex = 9;
            lblActivitats.Text = "Activitats econòmiques \r\ni fonts pròpies";
            // 
            // textBoxDomesticXarxa
            // 
            textBoxDomesticXarxa.Location = new Point(6, 129);
            textBoxDomesticXarxa.Name = "textBoxDomesticXarxa";
            textBoxDomesticXarxa.Size = new Size(100, 23);
            textBoxDomesticXarxa.TabIndex = 8;
            // 
            // lblDomesticXarxa
            // 
            lblDomesticXarxa.AutoSize = true;
            lblDomesticXarxa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDomesticXarxa.Location = new Point(6, 96);
            lblDomesticXarxa.Name = "lblDomesticXarxa";
            lblDomesticXarxa.Size = new Size(95, 15);
            lblDomesticXarxa.TabIndex = 7;
            lblDomesticXarxa.Text = "Domèstic Xarxa";
            // 
            // textBoxPoblacio
            // 
            textBoxPoblacio.Location = new Point(211, 52);
            textBoxPoblacio.Name = "textBoxPoblacio";
            textBoxPoblacio.Size = new Size(100, 23);
            textBoxPoblacio.TabIndex = 2;
            // 
            // comboBoxComarca
            // 
            comboBoxComarca.FormattingEnabled = true;
            comboBoxComarca.Location = new Point(109, 52);
            comboBoxComarca.Name = "comboBoxComarca";
            comboBoxComarca.Size = new Size(80, 23);
            comboBoxComarca.TabIndex = 6;
            comboBoxComarca.Click += comboBoxComarca_Click;
            // 
            // lblPoblacio
            // 
            lblPoblacio.AutoSize = true;
            lblPoblacio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPoblacio.Location = new Point(211, 34);
            lblPoblacio.Name = "lblPoblacio";
            lblPoblacio.Size = new Size(53, 15);
            lblPoblacio.TabIndex = 5;
            lblPoblacio.Text = "Població";
            // 
            // lblComarca
            // 
            lblComarca.AutoSize = true;
            lblComarca.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblComarca.Location = new Point(109, 34);
            lblComarca.Name = "lblComarca";
            lblComarca.Size = new Size(55, 15);
            lblComarca.TabIndex = 4;
            lblComarca.Text = "Comarca";
            // 
            // comboBoxAny
            // 
            comboBoxAny.FormattingEnabled = true;
            comboBoxAny.Location = new Point(6, 52);
            comboBoxAny.Name = "comboBoxAny";
            comboBoxAny.Size = new Size(80, 23);
            comboBoxAny.TabIndex = 1;
            comboBoxAny.Click += comboBoxAny_Click;
            // 
            // lblAny
            // 
            lblAny.AutoSize = true;
            lblAny.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAny.Location = new Point(6, 34);
            lblAny.Name = "lblAny";
            lblAny.Size = new Size(28, 15);
            lblAny.TabIndex = 2;
            lblAny.Text = "Any";
            // 
            // groupBoxEstadistiques
            // 
            groupBoxEstadistiques.Controls.Add(labelResultConsumMesBaix);
            groupBoxEstadistiques.Controls.Add(labelResultConsumMesAlt);
            groupBoxEstadistiques.Controls.Add(labelResultConsumDomesticMitja);
            groupBoxEstadistiques.Controls.Add(labelResultPoblacio);
            groupBoxEstadistiques.Controls.Add(lblConsumMesBaix);
            groupBoxEstadistiques.Controls.Add(lblConsumMesAlt);
            groupBoxEstadistiques.Controls.Add(lblConsumMitja);
            groupBoxEstadistiques.Controls.Add(lblPoblacioMajor);
            groupBoxEstadistiques.Location = new Point(503, 12);
            groupBoxEstadistiques.Name = "groupBoxEstadistiques";
            groupBoxEstadistiques.Size = new Size(285, 152);
            groupBoxEstadistiques.TabIndex = 1;
            groupBoxEstadistiques.TabStop = false;
            groupBoxEstadistiques.Text = "Estadístiques";
            // 
            // lblConsumMesBaix
            // 
            lblConsumMesBaix.AutoSize = true;
            lblConsumMesBaix.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConsumMesBaix.Location = new Point(6, 124);
            lblConsumMesBaix.Name = "lblConsumMesBaix";
            lblConsumMesBaix.Size = new Size(218, 15);
            lblConsumMesBaix.TabIndex = 7;
            lblConsumMesBaix.Text = "Consum domèstic per càpita més baix:";
            // 
            // lblConsumMesAlt
            // 
            lblConsumMesAlt.AutoSize = true;
            lblConsumMesAlt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConsumMesAlt.Location = new Point(6, 94);
            lblConsumMesAlt.Name = "lblConsumMesAlt";
            lblConsumMesAlt.Size = new Size(209, 15);
            lblConsumMesAlt.TabIndex = 6;
            lblConsumMesAlt.Text = "Consum domèstic per càpita més alt:";
            // 
            // lblConsumMitja
            // 
            lblConsumMitja.AutoSize = true;
            lblConsumMitja.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConsumMitja.Location = new Point(6, 64);
            lblConsumMitja.Name = "lblConsumMitja";
            lblConsumMitja.Size = new Size(139, 15);
            lblConsumMitja.TabIndex = 4;
            lblConsumMitja.Text = "Consum domèstic mitjà:";
            // 
            // lblPoblacioMajor
            // 
            lblPoblacioMajor.AutoSize = true;
            lblPoblacioMajor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPoblacioMajor.Location = new Point(6, 34);
            lblPoblacioMajor.Name = "lblPoblacioMajor";
            lblPoblacioMajor.Size = new Size(134, 15);
            lblPoblacioMajor.TabIndex = 2;
            lblPoblacioMajor.Text = "Població > 20000 hab. :";
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(422, 246);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 2;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonNetejar
            // 
            buttonNetejar.Location = new Point(341, 246);
            buttonNetejar.Name = "buttonNetejar";
            buttonNetejar.Size = new Size(75, 23);
            buttonNetejar.TabIndex = 3;
            buttonNetejar.Text = "Netejar";
            buttonNetejar.UseVisualStyleBackColor = true;
            buttonNetejar.Click += buttonNetejar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 307);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(776, 131);
            dataGridView1.TabIndex = 4;
            // 
            // labelResultPoblacio
            // 
            labelResultPoblacio.AutoSize = true;
            labelResultPoblacio.Font = new Font("Segoe UI", 9F);
            labelResultPoblacio.ForeColor = SystemColors.HotTrack;
            labelResultPoblacio.Location = new Point(146, 34);
            labelResultPoblacio.Name = "labelResultPoblacio";
            labelResultPoblacio.Size = new Size(27, 15);
            labelResultPoblacio.TabIndex = 15;
            labelResultPoblacio.Text = "S/N";
            // 
            // labelResultConsumDomesticMitja
            // 
            labelResultConsumDomesticMitja.AutoSize = true;
            labelResultConsumDomesticMitja.Font = new Font("Segoe UI", 9F);
            labelResultConsumDomesticMitja.ForeColor = SystemColors.HotTrack;
            labelResultConsumDomesticMitja.Location = new Point(146, 64);
            labelResultConsumDomesticMitja.Name = "labelResultConsumDomesticMitja";
            labelResultConsumDomesticMitja.Size = new Size(27, 15);
            labelResultConsumDomesticMitja.TabIndex = 16;
            labelResultConsumDomesticMitja.Text = "S/N";
            // 
            // labelResultConsumMesAlt
            // 
            labelResultConsumMesAlt.AutoSize = true;
            labelResultConsumMesAlt.Font = new Font("Segoe UI", 9F);
            labelResultConsumMesAlt.ForeColor = SystemColors.HotTrack;
            labelResultConsumMesAlt.Location = new Point(221, 94);
            labelResultConsumMesAlt.Name = "labelResultConsumMesAlt";
            labelResultConsumMesAlt.Size = new Size(27, 15);
            labelResultConsumMesAlt.TabIndex = 17;
            labelResultConsumMesAlt.Text = "S/N";
            // 
            // labelResultConsumMesBaix
            // 
            labelResultConsumMesBaix.AutoSize = true;
            labelResultConsumMesBaix.Font = new Font("Segoe UI", 9F);
            labelResultConsumMesBaix.ForeColor = SystemColors.HotTrack;
            labelResultConsumMesBaix.Location = new Point(230, 124);
            labelResultConsumMesBaix.Name = "labelResultConsumMesBaix";
            labelResultConsumMesBaix.Size = new Size(27, 15);
            labelResultConsumMesBaix.TabIndex = 18;
            labelResultConsumMesBaix.Text = "S/N";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(buttonNetejar);
            Controls.Add(buttonGuardar);
            Controls.Add(groupBoxEstadistiques);
            Controls.Add(groupBoxGestio);
            Name = "Form1";
            Text = "Gestió de dades demogràfiques  de regions";
            Load += Form1_Load;
            groupBoxGestio.ResumeLayout(false);
            groupBoxGestio.PerformLayout();
            groupBoxEstadistiques.ResumeLayout(false);
            groupBoxEstadistiques.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxGestio;
        private GroupBox groupBoxEstadistiques;
        private ComboBox comboBoxComarca;
        private Label lblPoblacio;
        private Label lblComarca;
        private ComboBox comboBoxAny;
        private Label lblAny;
        private Label lblConsum;
        private TextBox textBoxActivitatsEconomiques;
        private Label lblActivitats;
        private TextBox textBoxDomesticXarxa;
        private Label lblDomesticXarxa;
        private TextBox textBoxPoblacio;
        private TextBox textBoxTotal;
        private Label lblTotal;
        private TextBox textBoxConsumDomesticPerCapita;
        private Label lblPoblacioMajor;
        private Label lblConsumMesBaix;
        private Label lblConsumMesAlt;
        private Label lblConsumMitja;
        private Button buttonGuardar;
        private Button buttonNetejar;
        private DataGridView dataGridView1;
        private Label labelResultConsumMesAlt;
        private Label labelResultConsumDomesticMitja;
        private Label labelResultPoblacio;
        private Label labelResultConsumMesBaix;
    }
}
