namespace Riesgo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dtgvRiesgo = new System.Windows.Forms.DataGridView();
            this.btnagregar = new System.Windows.Forms.Button();
            this.btnborrar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.lbname = new System.Windows.Forms.Label();
            this.txtdescripción = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbim = new System.Windows.Forms.Label();
            this.lbprob = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbmitigación = new System.Windows.Forms.RichTextBox();
            this.lstbImpacto = new System.Windows.Forms.ListBox();
            this.lstbProbabilidad = new System.Windows.Forms.ListBox();
            this.lblInformation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRiesgo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvRiesgo
            // 
            this.dtgvRiesgo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRiesgo.Location = new System.Drawing.Point(12, 288);
            this.dtgvRiesgo.Name = "dtgvRiesgo";
            this.dtgvRiesgo.RowHeadersWidth = 51;
            this.dtgvRiesgo.RowTemplate.Height = 24;
            this.dtgvRiesgo.Size = new System.Drawing.Size(895, 309);
            this.dtgvRiesgo.TabIndex = 0;
            this.dtgvRiesgo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvRiesgo_CellClick);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(12, 244);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(97, 38);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(129, 244);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(97, 38);
            this.btnborrar.TabIndex = 3;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            this.btnborrar.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(32, 108);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(265, 22);
            this.txtnombre.TabIndex = 4;
            // 
            // lbname
            // 
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(29, 89);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(66, 16);
            this.lbname.TabIndex = 5;
            this.lbname.Text = "NOMBRE";
            // 
            // txtdescripción
            // 
            this.txtdescripción.Location = new System.Drawing.Point(437, 69);
            this.txtdescripción.Name = "txtdescripción";
            this.txtdescripción.Size = new System.Drawing.Size(470, 22);
            this.txtdescripción.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Desc";
            // 
            // lbim
            // 
            this.lbim.AutoSize = true;
            this.lbim.Location = new System.Drawing.Point(29, 133);
            this.lbim.Name = "lbim";
            this.lbim.Size = new System.Drawing.Size(55, 16);
            this.lbim.TabIndex = 8;
            this.lbim.Text = "Impacto";
            // 
            // lbprob
            // 
            this.lbprob.AutoSize = true;
            this.lbprob.Location = new System.Drawing.Point(328, 133);
            this.lbprob.Name = "lbprob";
            this.lbprob.Size = new System.Drawing.Size(85, 16);
            this.lbprob.TabIndex = 9;
            this.lbprob.Text = "Probabilidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(613, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mitigación";
            // 
            // rtbmitigación
            // 
            this.rtbmitigación.Location = new System.Drawing.Point(616, 152);
            this.rtbmitigación.Name = "rtbmitigación";
            this.rtbmitigación.Size = new System.Drawing.Size(291, 130);
            this.rtbmitigación.TabIndex = 11;
            this.rtbmitigación.Text = "";
            // 
            // lstbImpacto
            // 
            this.lstbImpacto.FormattingEnabled = true;
            this.lstbImpacto.ItemHeight = 16;
            this.lstbImpacto.Items.AddRange(new object[] {
            "1- Muy bajo",
            "2- Bajo",
            "3- Medio",
            "4- Alto",
            "5- Muy alto"});
            this.lstbImpacto.Location = new System.Drawing.Point(32, 152);
            this.lstbImpacto.Name = "lstbImpacto";
            this.lstbImpacto.Size = new System.Drawing.Size(120, 20);
            this.lstbImpacto.TabIndex = 12;
            // 
            // lstbProbabilidad
            // 
            this.lstbProbabilidad.FormattingEnabled = true;
            this.lstbProbabilidad.ItemHeight = 16;
            this.lstbProbabilidad.Items.AddRange(new object[] {
            "1- Muy bajo",
            "2- Bajo",
            "3- Medio",
            "4- Alto",
            "5- Muy alto"});
            this.lstbProbabilidad.Location = new System.Drawing.Point(331, 152);
            this.lstbProbabilidad.Name = "lstbProbabilidad";
            this.lstbProbabilidad.Size = new System.Drawing.Size(120, 20);
            this.lstbProbabilidad.TabIndex = 13;
            // 
            // lblInformation
            // 
            this.lblInformation.AutoSize = true;
            this.lblInformation.Location = new System.Drawing.Point(12, 197);
            this.lblInformation.Name = "lblInformation";
            this.lblInformation.Size = new System.Drawing.Size(44, 16);
            this.lblInformation.TabIndex = 14;
            this.lblInformation.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(32, 50);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(265, 22);
            this.txtId.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnBuscar
            // 
            this.btnBuscar.AccessibleDescription = "";
            this.btnBuscar.Location = new System.Drawing.Point(248, 244);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(97, 38);
            this.btnBuscar.TabIndex = 17;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.AccessibleDescription = "";
            this.btnModificar.Location = new System.Drawing.Point(364, 244);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(97, 38);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.AccessibleDescription = "";
            this.btnlimpiar.Location = new System.Drawing.Point(479, 244);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(97, 38);
            this.btnlimpiar.TabIndex = 19;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 596);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblInformation);
            this.Controls.Add(this.lstbProbabilidad);
            this.Controls.Add(this.lstbImpacto);
            this.Controls.Add(this.rtbmitigación);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbprob);
            this.Controls.Add(this.lbim);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdescripción);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.dtgvRiesgo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRiesgo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvRiesgo;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Button btnborrar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.TextBox txtdescripción;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbim;
        private System.Windows.Forms.Label lbprob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbmitigación;
        private System.Windows.Forms.ListBox lstbImpacto;
        private System.Windows.Forms.ListBox lstbProbabilidad;
        private System.Windows.Forms.Label lblInformation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnlimpiar;
    }
}

