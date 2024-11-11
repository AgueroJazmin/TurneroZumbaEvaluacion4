namespace TurneroZumbaEvaluacion4.FE
{
    partial class frmAMBturnero
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.lblTurnos = new System.Windows.Forms.Label();
            this.lblHorarios = new System.Windows.Forms.Label();
            this.lblSalida = new System.Windows.Forms.Label();
            this.btmAgendar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbDias = new System.Windows.Forms.ComboBox();
            this.cbTurnos = new System.Windows.Forms.ComboBox();
            this.cbHorarios = new System.Windows.Forms.ComboBox();
            this.btmCancelar = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Bell MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(127, 49);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(584, 42);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Doble Giro Gym - Turnero Zumba";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(44, 136);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(53, 17);
            this.lblNombre.TabIndex = 21;
            this.lblNombre.Text = "Nombre";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDias.Location = new System.Drawing.Point(45, 279);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(33, 17);
            this.lblDias.TabIndex = 22;
            this.lblDias.Text = "Dias";
            // 
            // lblTurnos
            // 
            this.lblTurnos.AutoSize = true;
            this.lblTurnos.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnos.Location = new System.Drawing.Point(45, 353);
            this.lblTurnos.Name = "lblTurnos";
            this.lblTurnos.Size = new System.Drawing.Size(48, 17);
            this.lblTurnos.TabIndex = 23;
            this.lblTurnos.Text = "Turnos";
            // 
            // lblHorarios
            // 
            this.lblHorarios.AutoSize = true;
            this.lblHorarios.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarios.Location = new System.Drawing.Point(45, 422);
            this.lblHorarios.Name = "lblHorarios";
            this.lblHorarios.Size = new System.Drawing.Size(57, 17);
            this.lblHorarios.TabIndex = 24;
            this.lblHorarios.Text = "Horarios";
            // 
            // lblSalida
            // 
            this.lblSalida.AutoSize = true;
            this.lblSalida.Location = new System.Drawing.Point(508, 137);
            this.lblSalida.Name = "lblSalida";
            this.lblSalida.Size = new System.Drawing.Size(97, 13);
            this.lblSalida.TabIndex = 25;
            this.lblSalida.Text = "Turnos Agendados";
            this.lblSalida.Click += new System.EventHandler(this.lblSalida_Click);
            // 
            // btmAgendar
            // 
            this.btmAgendar.Location = new System.Drawing.Point(48, 497);
            this.btmAgendar.Name = "btmAgendar";
            this.btmAgendar.Size = new System.Drawing.Size(75, 23);
            this.btmAgendar.TabIndex = 26;
            this.btmAgendar.Text = "Agendar";
            this.btmAgendar.UseVisualStyleBackColor = true;
            this.btmAgendar.Click += new System.EventHandler(this.btmAgendar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(47, 163);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(151, 20);
            this.txtNombre.TabIndex = 27;
            // 
            // cbDias
            // 
            this.cbDias.FormattingEnabled = true;
            this.cbDias.Location = new System.Drawing.Point(48, 304);
            this.cbDias.Name = "cbDias";
            this.cbDias.Size = new System.Drawing.Size(121, 21);
            this.cbDias.TabIndex = 28;
            this.cbDias.SelectedIndexChanged += new System.EventHandler(this.cbDias_SelectedIndexChanged);
            // 
            // cbTurnos
            // 
            this.cbTurnos.FormattingEnabled = true;
            this.cbTurnos.Location = new System.Drawing.Point(48, 379);
            this.cbTurnos.Name = "cbTurnos";
            this.cbTurnos.Size = new System.Drawing.Size(121, 21);
            this.cbTurnos.TabIndex = 29;
            this.cbTurnos.SelectedIndexChanged += new System.EventHandler(this.cbTurnos_SelectedIndexChanged);
            // 
            // cbHorarios
            // 
            this.cbHorarios.FormattingEnabled = true;
            this.cbHorarios.Location = new System.Drawing.Point(48, 447);
            this.cbHorarios.Name = "cbHorarios";
            this.cbHorarios.Size = new System.Drawing.Size(121, 21);
            this.cbHorarios.TabIndex = 30;
            // 
            // btmCancelar
            // 
            this.btmCancelar.Location = new System.Drawing.Point(155, 497);
            this.btmCancelar.Name = "btmCancelar";
            this.btmCancelar.Size = new System.Drawing.Size(75, 23);
            this.btmCancelar.TabIndex = 31;
            this.btmCancelar.Text = "Cancelar";
            this.btmCancelar.UseVisualStyleBackColor = true;
            this.btmCancelar.Click += new System.EventHandler(this.btmCancelar_Click);
            // 
            // DGV
            // 
            this.DGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(270, 163);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(581, 357);
            this.DGV.TabIndex = 32;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(47, 234);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(151, 20);
            this.txtDNI.TabIndex = 34;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Font = new System.Drawing.Font("Bell MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.Location = new System.Drawing.Point(44, 207);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(33, 17);
            this.lblDNI.TabIndex = 33;
            this.lblDNI.Text = "DNI";
            // 
            // frmAMBturnero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(875, 632);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.btmCancelar);
            this.Controls.Add(this.cbHorarios);
            this.Controls.Add(this.cbTurnos);
            this.Controls.Add(this.cbDias);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btmAgendar);
            this.Controls.Add(this.lblSalida);
            this.Controls.Add(this.lblHorarios);
            this.Controls.Add(this.lblTurnos);
            this.Controls.Add(this.lblDias);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmAMBturnero";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.Label lblTurnos;
        private System.Windows.Forms.Label lblHorarios;
        private System.Windows.Forms.Label lblSalida;
        private System.Windows.Forms.Button btmAgendar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbDias;
        private System.Windows.Forms.ComboBox cbTurnos;
        private System.Windows.Forms.ComboBox cbHorarios;
        private System.Windows.Forms.Button btmCancelar;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label lblDNI;
    }
}

