namespace GerarArquivosXml_ou_Json
{
    partial class frmGerarArquivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerarArquivos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pctBarra = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pctIcone = new System.Windows.Forms.PictureBox();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXML = new System.Windows.Forms.Button();
            this.btnJSON = new System.Windows.Forms.Button();
            this.btnImportarTXT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBarra
            // 
            this.pctBarra.Image = ((System.Drawing.Image)(resources.GetObject("pctBarra.Image")));
            this.pctBarra.Location = new System.Drawing.Point(1, 1);
            this.pctBarra.Name = "pctBarra";
            this.pctBarra.Size = new System.Drawing.Size(1136, 50);
            this.pctBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBarra.TabIndex = 58;
            this.pctBarra.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(635, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(294, 23);
            this.lblTitulo.TabIndex = 60;
            this.lblTitulo.Text = "Gerar arquivos XML ou JSON";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pctIcone
            // 
            this.pctIcone.BackColor = System.Drawing.Color.Transparent;
            this.pctIcone.Image = ((System.Drawing.Image)(resources.GetObject("pctIcone.Image")));
            this.pctIcone.Location = new System.Drawing.Point(12, 6);
            this.pctIcone.Name = "pctIcone";
            this.pctIcone.Size = new System.Drawing.Size(32, 32);
            this.pctIcone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pctIcone.TabIndex = 61;
            this.pctIcone.TabStop = false;
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToAddRows = false;
            this.dgvAlunos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAlunos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.Email,
            this.Telefone,
            this.CPF});
            this.dgvAlunos.Location = new System.Drawing.Point(12, 60);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.ReadOnly = true;
            this.dgvAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlunos.Size = new System.Drawing.Size(912, 332);
            this.dgvAlunos.TabIndex = 297;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 300;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 250;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 150;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Width = 150;
            // 
            // btnXML
            // 
            this.btnXML.Location = new System.Drawing.Point(738, 399);
            this.btnXML.Name = "btnXML";
            this.btnXML.Size = new System.Drawing.Size(91, 25);
            this.btnXML.TabIndex = 303;
            this.btnXML.TabStop = false;
            this.btnXML.Text = "Gerar &XML";
            this.btnXML.UseVisualStyleBackColor = true;
            this.btnXML.Click += new System.EventHandler(this.btnXML_Click);
            // 
            // btnJSON
            // 
            this.btnJSON.Location = new System.Drawing.Point(834, 399);
            this.btnJSON.Name = "btnJSON";
            this.btnJSON.Size = new System.Drawing.Size(91, 25);
            this.btnJSON.TabIndex = 302;
            this.btnJSON.TabStop = false;
            this.btnJSON.Text = "Gerar &JSON";
            this.btnJSON.UseVisualStyleBackColor = true;
            this.btnJSON.Click += new System.EventHandler(this.btnJSON_Click);
            // 
            // btnImportarTXT
            // 
            this.btnImportarTXT.Location = new System.Drawing.Point(12, 399);
            this.btnImportarTXT.Name = "btnImportarTXT";
            this.btnImportarTXT.Size = new System.Drawing.Size(108, 25);
            this.btnImportarTXT.TabIndex = 304;
            this.btnImportarTXT.TabStop = false;
            this.btnImportarTXT.Text = "Importar TXT";
            this.btnImportarTXT.UseVisualStyleBackColor = true;
            this.btnImportarTXT.Click += new System.EventHandler(this.btnImportarTXT_Click);
            // 
            // frmGerarArquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 431);
            this.Controls.Add(this.btnImportarTXT);
            this.Controls.Add(this.btnXML);
            this.Controls.Add(this.btnJSON);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.pctIcone);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.pctBarra);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGerarArquivos";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerar arquivos";
            this.Load += new System.EventHandler(this.frmGerarArquivos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGerarArquivos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pctBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctIcone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox pctBarra;
        internal System.Windows.Forms.Label lblTitulo;
        internal System.Windows.Forms.PictureBox pctIcone;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.Button btnXML;
        private System.Windows.Forms.Button btnJSON;
        private System.Windows.Forms.Button btnImportarTXT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
    }
}

