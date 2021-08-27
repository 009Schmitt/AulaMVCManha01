
namespace AulaMVCManha01.View
{
    partial class Exec02
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
            this.dgVagas = new System.Windows.Forms.DataGridView();
            this.NumeroVagaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlacaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraEntradaCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbVagasLivres = new System.Windows.Forms.ComboBox();
            this.cbPlacas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoraEntrada = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.rbSim = new System.Windows.Forms.RadioButton();
            this.rbNao = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoraSaida = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEncerrar = new System.Windows.Forms.Button();
            this.txtPlaca = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgVagas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVagas
            // 
            this.dgVagas.AllowUserToAddRows = false;
            this.dgVagas.AllowUserToDeleteRows = false;
            this.dgVagas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVagas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroVagaCol,
            this.PlacaCol,
            this.HoraEntradaCol});
            this.dgVagas.Location = new System.Drawing.Point(12, 12);
            this.dgVagas.Name = "dgVagas";
            this.dgVagas.ReadOnly = true;
            this.dgVagas.RowTemplate.Height = 50;
            this.dgVagas.Size = new System.Drawing.Size(760, 262);
            this.dgVagas.TabIndex = 0;
            // 
            // NumeroVagaCol
            // 
            this.NumeroVagaCol.HeaderText = "Vaga";
            this.NumeroVagaCol.Name = "NumeroVagaCol";
            this.NumeroVagaCol.ReadOnly = true;
            this.NumeroVagaCol.Width = 110;
            // 
            // PlacaCol
            // 
            this.PlacaCol.HeaderText = "Placa";
            this.PlacaCol.Name = "PlacaCol";
            this.PlacaCol.ReadOnly = true;
            this.PlacaCol.Width = 180;
            // 
            // HoraEntradaCol
            // 
            this.HoraEntradaCol.HeaderText = "HoraEntrada";
            this.HoraEntradaCol.Name = "HoraEntradaCol";
            this.HoraEntradaCol.ReadOnly = true;
            this.HoraEntradaCol.Width = 250;
            // 
            // cbVagasLivres
            // 
            this.cbVagasLivres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVagasLivres.FormattingEnabled = true;
            this.cbVagasLivres.Location = new System.Drawing.Point(12, 319);
            this.cbVagasLivres.Name = "cbVagasLivres";
            this.cbVagasLivres.Size = new System.Drawing.Size(221, 47);
            this.cbVagasLivres.TabIndex = 1;
            // 
            // cbPlacas
            // 
            this.cbPlacas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlacas.FormattingEnabled = true;
            this.cbPlacas.Location = new System.Drawing.Point(350, 319);
            this.cbPlacas.Name = "cbPlacas";
            this.cbPlacas.Size = new System.Drawing.Size(234, 47);
            this.cbPlacas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vagas Livres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Placas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "HoraEntrada";
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.Location = new System.Drawing.Point(12, 411);
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.Size = new System.Drawing.Size(221, 47);
            this.txtHoraEntrada.TabIndex = 6;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(12, 554);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(213, 64);
            this.btnEntrar.TabIndex = 8;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 385);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 39);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lavou?";
            // 
            // rbSim
            // 
            this.rbSim.AutoSize = true;
            this.rbSim.Location = new System.Drawing.Point(472, 383);
            this.rbSim.Name = "rbSim";
            this.rbSim.Size = new System.Drawing.Size(58, 43);
            this.rbSim.TabIndex = 9;
            this.rbSim.TabStop = true;
            this.rbSim.Text = "S";
            this.rbSim.UseVisualStyleBackColor = true;
            // 
            // rbNao
            // 
            this.rbNao.AutoSize = true;
            this.rbNao.Location = new System.Drawing.Point(536, 383);
            this.rbNao.Name = "rbNao";
            this.rbNao.Size = new System.Drawing.Size(60, 43);
            this.rbNao.TabIndex = 10;
            this.rbNao.TabStop = true;
            this.rbNao.Text = "N";
            this.rbNao.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 39);
            this.label5.TabIndex = 11;
            this.label5.Text = "HoraSaida";
            // 
            // txtHoraSaida
            // 
            this.txtHoraSaida.Location = new System.Drawing.Point(350, 480);
            this.txtHoraSaida.Name = "txtHoraSaida";
            this.txtHoraSaida.Size = new System.Drawing.Size(234, 47);
            this.txtHoraSaida.TabIndex = 12;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(350, 554);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(234, 64);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Location = new System.Drawing.Point(717, 280);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(55, 330);
            this.btnEncerrar.TabIndex = 14;
            this.btnEncerrar.Text = "ENCERRAR";
            this.btnEncerrar.UseVisualStyleBackColor = true;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // txtPlaca
            // 
            this.txtPlaca.Location = new System.Drawing.Point(12, 501);
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.Size = new System.Drawing.Size(221, 47);
            this.txtPlaca.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 39);
            this.label6.TabIndex = 15;
            this.label6.Text = "Placa";
            // 
            // Exec02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 621);
            this.Controls.Add(this.txtPlaca);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnEncerrar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtHoraSaida);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbNao);
            this.Controls.Add(this.rbSim);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtHoraEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPlacas);
            this.Controls.Add(this.cbVagasLivres);
            this.Controls.Add(this.dgVagas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Exec02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exec02";
            this.Load += new System.EventHandler(this.Exec02_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVagas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVagas;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroVagaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlacaCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraEntradaCol;
        private System.Windows.Forms.ComboBox cbVagasLivres;
        private System.Windows.Forms.ComboBox cbPlacas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoraEntrada;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbSim;
        private System.Windows.Forms.RadioButton rbNao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoraSaida;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEncerrar;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.Label label6;
    }
}