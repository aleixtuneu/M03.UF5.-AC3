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
            components = new System.ComponentModel.Container();
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
            labelResultConsumMesBaix = new Label();
            labelResultConsumMesAlt = new Label();
            labelResultConsumDomesticMitja = new Label();
            labelResultPoblacio = new Label();
            lblConsumMesBaix = new Label();
            lblConsumMesAlt = new Label();
            lblConsumMitja = new Label();
            lblPoblacioMajor = new Label();
            buttonGuardar = new Button();
            buttonNetejar = new Button();
            dataGridView1 = new DataGridView();
            errorProviderPoblacio = new ErrorProvider(components);
            errorProviderDomesticXarxa = new ErrorProvider(components);
            errorProviderActivitatsEconomiques = new ErrorProvider(components);
            errorProviderConsumDomesticPerCapita = new ErrorProvider(components);
            errorProviderTotal = new ErrorProvider(components);
            errorProviderAny = new ErrorProvider(components);
            errorProviderComarca = new ErrorProvider(components);
            groupBoxGestio.SuspendLayout();
            groupBoxEstadistiques.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPoblacio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDomesticXarxa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderActivitatsEconomiques).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderConsumDomesticPerCapita).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderTotal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderAny).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderComarca).BeginInit();
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
            groupBoxGestio.Location = new Point(14, 16);
            groupBoxGestio.Margin = new Padding(3, 4, 3, 4);
            groupBoxGestio.Name = "groupBoxGestio";
            groupBoxGestio.Padding = new Padding(3, 4, 3, 4);
            groupBoxGestio.Size = new Size(554, 304);
            groupBoxGestio.TabIndex = 0;
            groupBoxGestio.TabStop = false;
            groupBoxGestio.Text = "Gestió de dades demogràfiques de regions";
            // 
            // textBoxTotal
            // 
            textBoxTotal.Location = new Point(365, 243);
            textBoxTotal.Margin = new Padding(3, 4, 3, 4);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.Size = new Size(158, 27);
            textBoxTotal.TabIndex = 14;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotal.Location = new Point(365, 219);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(44, 20);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "Total";
            // 
            // textBoxConsumDomesticPerCapita
            // 
            textBoxConsumDomesticPerCapita.Location = new Point(365, 172);
            textBoxConsumDomesticPerCapita.Margin = new Padding(3, 4, 3, 4);
            textBoxConsumDomesticPerCapita.Name = "textBoxConsumDomesticPerCapita";
            textBoxConsumDomesticPerCapita.Size = new Size(158, 27);
            textBoxConsumDomesticPerCapita.TabIndex = 12;
            // 
            // lblConsum
            // 
            lblConsum.AutoSize = true;
            lblConsum.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConsum.Location = new Point(365, 128);
            lblConsum.Name = "lblConsum";
            lblConsum.Size = new Size(138, 40);
            lblConsum.TabIndex = 11;
            lblConsum.Text = "Consum domèstic \r\nper càpita\r\n";
            // 
            // textBoxActivitatsEconomiques
            // 
            textBoxActivitatsEconomiques.Location = new Point(143, 172);
            textBoxActivitatsEconomiques.Margin = new Padding(3, 4, 3, 4);
            textBoxActivitatsEconomiques.Name = "textBoxActivitatsEconomiques";
            textBoxActivitatsEconomiques.Size = new Size(158, 27);
            textBoxActivitatsEconomiques.TabIndex = 10;
            // 
            // lblActivitats
            // 
            lblActivitats.AutoSize = true;
            lblActivitats.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblActivitats.Location = new Point(143, 128);
            lblActivitats.Name = "lblActivitats";
            lblActivitats.Size = new Size(177, 40);
            lblActivitats.TabIndex = 9;
            lblActivitats.Text = "Activitats econòmiques \r\ni fonts pròpies";
            // 
            // textBoxDomesticXarxa
            // 
            textBoxDomesticXarxa.Location = new Point(7, 172);
            textBoxDomesticXarxa.Margin = new Padding(3, 4, 3, 4);
            textBoxDomesticXarxa.Name = "textBoxDomesticXarxa";
            textBoxDomesticXarxa.Size = new Size(114, 27);
            textBoxDomesticXarxa.TabIndex = 8;
            // 
            // lblDomesticXarxa
            // 
            lblDomesticXarxa.AutoSize = true;
            lblDomesticXarxa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDomesticXarxa.Location = new Point(7, 128);
            lblDomesticXarxa.Name = "lblDomesticXarxa";
            lblDomesticXarxa.Size = new Size(119, 20);
            lblDomesticXarxa.TabIndex = 7;
            lblDomesticXarxa.Text = "Domèstic Xarxa";
            // 
            // textBoxPoblacio
            // 
            textBoxPoblacio.Location = new Point(241, 69);
            textBoxPoblacio.Margin = new Padding(3, 4, 3, 4);
            textBoxPoblacio.Name = "textBoxPoblacio";
            textBoxPoblacio.Size = new Size(114, 27);
            textBoxPoblacio.TabIndex = 2;
            // 
            // comboBoxComarca
            // 
            comboBoxComarca.FormattingEnabled = true;
            comboBoxComarca.Location = new Point(125, 69);
            comboBoxComarca.Margin = new Padding(3, 4, 3, 4);
            comboBoxComarca.Name = "comboBoxComarca";
            comboBoxComarca.Size = new Size(91, 28);
            comboBoxComarca.TabIndex = 6;
            // 
            // lblPoblacio
            // 
            lblPoblacio.AutoSize = true;
            lblPoblacio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPoblacio.Location = new Point(241, 45);
            lblPoblacio.Name = "lblPoblacio";
            lblPoblacio.Size = new Size(68, 20);
            lblPoblacio.TabIndex = 5;
            lblPoblacio.Text = "Població";
            // 
            // lblComarca
            // 
            lblComarca.AutoSize = true;
            lblComarca.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblComarca.Location = new Point(125, 45);
            lblComarca.Name = "lblComarca";
            lblComarca.Size = new Size(70, 20);
            lblComarca.TabIndex = 4;
            lblComarca.Text = "Comarca";
            // 
            // comboBoxAny
            // 
            comboBoxAny.FormattingEnabled = true;
            comboBoxAny.Location = new Point(7, 69);
            comboBoxAny.Margin = new Padding(3, 4, 3, 4);
            comboBoxAny.Name = "comboBoxAny";
            comboBoxAny.Size = new Size(91, 28);
            comboBoxAny.TabIndex = 1;
            // 
            // lblAny
            // 
            lblAny.AutoSize = true;
            lblAny.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAny.Location = new Point(7, 45);
            lblAny.Name = "lblAny";
            lblAny.Size = new Size(37, 20);
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
            groupBoxEstadistiques.Location = new Point(575, 16);
            groupBoxEstadistiques.Margin = new Padding(3, 4, 3, 4);
            groupBoxEstadistiques.Name = "groupBoxEstadistiques";
            groupBoxEstadistiques.Padding = new Padding(3, 4, 3, 4);
            groupBoxEstadistiques.Size = new Size(326, 203);
            groupBoxEstadistiques.TabIndex = 1;
            groupBoxEstadistiques.TabStop = false;
            groupBoxEstadistiques.Text = "Estadístiques";
            // 
            // labelResultConsumMesBaix
            // 
            labelResultConsumMesBaix.AutoSize = true;
            labelResultConsumMesBaix.Font = new Font("Segoe UI", 9F);
            labelResultConsumMesBaix.ForeColor = SystemColors.HotTrack;
            labelResultConsumMesBaix.Location = new Point(263, 165);
            labelResultConsumMesBaix.Name = "labelResultConsumMesBaix";
            labelResultConsumMesBaix.Size = new Size(34, 20);
            labelResultConsumMesBaix.TabIndex = 18;
            labelResultConsumMesBaix.Text = "S/N";
            // 
            // labelResultConsumMesAlt
            // 
            labelResultConsumMesAlt.AutoSize = true;
            labelResultConsumMesAlt.Font = new Font("Segoe UI", 9F);
            labelResultConsumMesAlt.ForeColor = SystemColors.HotTrack;
            labelResultConsumMesAlt.Location = new Point(253, 125);
            labelResultConsumMesAlt.Name = "labelResultConsumMesAlt";
            labelResultConsumMesAlt.Size = new Size(34, 20);
            labelResultConsumMesAlt.TabIndex = 17;
            labelResultConsumMesAlt.Text = "S/N";
            // 
            // labelResultConsumDomesticMitja
            // 
            labelResultConsumDomesticMitja.AutoSize = true;
            labelResultConsumDomesticMitja.Font = new Font("Segoe UI", 9F);
            labelResultConsumDomesticMitja.ForeColor = SystemColors.HotTrack;
            labelResultConsumDomesticMitja.Location = new Point(167, 85);
            labelResultConsumDomesticMitja.Name = "labelResultConsumDomesticMitja";
            labelResultConsumDomesticMitja.Size = new Size(34, 20);
            labelResultConsumDomesticMitja.TabIndex = 16;
            labelResultConsumDomesticMitja.Text = "S/N";
            // 
            // labelResultPoblacio
            // 
            labelResultPoblacio.AutoSize = true;
            labelResultPoblacio.Font = new Font("Segoe UI", 9F);
            labelResultPoblacio.ForeColor = SystemColors.HotTrack;
            labelResultPoblacio.Location = new Point(167, 45);
            labelResultPoblacio.Name = "labelResultPoblacio";
            labelResultPoblacio.Size = new Size(34, 20);
            labelResultPoblacio.TabIndex = 15;
            labelResultPoblacio.Text = "S/N";
            // 
            // lblConsumMesBaix
            // 
            lblConsumMesBaix.AutoSize = true;
            lblConsumMesBaix.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConsumMesBaix.Location = new Point(7, 165);
            lblConsumMesBaix.Name = "lblConsumMesBaix";
            lblConsumMesBaix.Size = new Size(277, 20);
            lblConsumMesBaix.TabIndex = 7;
            lblConsumMesBaix.Text = "Consum domèstic per càpita més baix:";
            // 
            // lblConsumMesAlt
            // 
            lblConsumMesAlt.AutoSize = true;
            lblConsumMesAlt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConsumMesAlt.Location = new Point(7, 125);
            lblConsumMesAlt.Name = "lblConsumMesAlt";
            lblConsumMesAlt.Size = new Size(266, 20);
            lblConsumMesAlt.TabIndex = 6;
            lblConsumMesAlt.Text = "Consum domèstic per càpita més alt:";
            // 
            // lblConsumMitja
            // 
            lblConsumMitja.AutoSize = true;
            lblConsumMitja.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConsumMitja.Location = new Point(7, 85);
            lblConsumMitja.Name = "lblConsumMitja";
            lblConsumMitja.Size = new Size(178, 20);
            lblConsumMitja.TabIndex = 4;
            lblConsumMitja.Text = "Consum domèstic mitjà:";
            // 
            // lblPoblacioMajor
            // 
            lblPoblacioMajor.AutoSize = true;
            lblPoblacioMajor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPoblacioMajor.Location = new Point(7, 45);
            lblPoblacioMajor.Name = "lblPoblacioMajor";
            lblPoblacioMajor.Size = new Size(174, 20);
            lblPoblacioMajor.TabIndex = 2;
            lblPoblacioMajor.Text = "Població > 20000 hab. :";
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(482, 328);
            buttonGuardar.Margin = new Padding(3, 4, 3, 4);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(86, 31);
            buttonGuardar.TabIndex = 2;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonNetejar
            // 
            buttonNetejar.Location = new Point(390, 328);
            buttonNetejar.Margin = new Padding(3, 4, 3, 4);
            buttonNetejar.Name = "buttonNetejar";
            buttonNetejar.Size = new Size(86, 31);
            buttonNetejar.TabIndex = 3;
            buttonNetejar.Text = "Netejar";
            buttonNetejar.UseVisualStyleBackColor = true;
            buttonNetejar.Click += buttonNetejar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 409);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(887, 175);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // errorProviderPoblacio
            // 
            errorProviderPoblacio.ContainerControl = this;
            // 
            // errorProviderDomesticXarxa
            // 
            errorProviderDomesticXarxa.ContainerControl = this;
            // 
            // errorProviderActivitatsEconomiques
            // 
            errorProviderActivitatsEconomiques.ContainerControl = this;
            // 
            // errorProviderConsumDomesticPerCapita
            // 
            errorProviderConsumDomesticPerCapita.ContainerControl = this;
            // 
            // errorProviderTotal
            // 
            errorProviderTotal.ContainerControl = this;
            // 
            // errorProviderAny
            // 
            errorProviderAny.ContainerControl = this;
            // 
            // errorProviderComarca
            // 
            errorProviderComarca.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dataGridView1);
            Controls.Add(buttonNetejar);
            Controls.Add(buttonGuardar);
            Controls.Add(groupBoxEstadistiques);
            Controls.Add(groupBoxGestio);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Gestió de dades demogràfiques  de regions";
            Load += Form1_Load;
            groupBoxGestio.ResumeLayout(false);
            groupBoxGestio.PerformLayout();
            groupBoxEstadistiques.ResumeLayout(false);
            groupBoxEstadistiques.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderPoblacio).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderDomesticXarxa).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderActivitatsEconomiques).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderConsumDomesticPerCapita).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderTotal).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderAny).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderComarca).EndInit();
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
        private ErrorProvider errorProviderPoblacio;
        private ErrorProvider errorProviderDomesticXarxa;
        private ErrorProvider errorProviderActivitatsEconomiques;
        private ErrorProvider errorProviderConsumDomesticPerCapita;
        private ErrorProvider errorProviderTotal;
        private ErrorProvider errorProviderAny;
        private ErrorProvider errorProviderComarca;
    }
}
