namespace PlaceMyBet_Desktop.PresentationLayer
{
    partial class UsuariosApuestasViewer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.Campo_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Campo_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Campo_Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Campo_Edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Campo_Administrador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVerApuestas = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbSeleccionado = new System.Windows.Forms.TextBox();
            this.lbSeleccionado = new MetroFramework.Controls.MetroLabel();
            this.dgvApuestas = new System.Windows.Forms.DataGridView();
            this.Campo_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Campo_TipoMercado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Campo_Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Campo_Cuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Campo_Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Campo_IdMercado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTodasApuestas = new System.Windows.Forms.Button();
            this.lbUsuarios = new System.Windows.Forms.Label();
            this.lbApuestas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEditarEvento = new System.Windows.Forms.Button();
            this.btnNuevoUsuario = new System.Windows.Forms.Button();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEliminarEvento = new System.Windows.Forms.Button();
            this.valDelete = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApuestas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUsuarios.ColumnHeadersHeight = 30;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Campo_Email,
            this.Campo_Nombre,
            this.Campo_Apellidos,
            this.Campo_Edad,
            this.Campo_Administrador});
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvUsuarios.Location = new System.Drawing.Point(18, 40);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvUsuarios.RowHeadersVisible = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(556, 176);
            this.dgvUsuarios.TabIndex = 9;
            this.dgvUsuarios.SelectionChanged += new System.EventHandler(this.dgvUsuarios_SelectionChanged);
            // 
            // Campo_Email
            // 
            this.Campo_Email.HeaderText = "Usuario";
            this.Campo_Email.Name = "Campo_Email";
            this.Campo_Email.ReadOnly = true;
            this.Campo_Email.Width = 86;
            // 
            // Campo_Nombre
            // 
            this.Campo_Nombre.HeaderText = "Nombre";
            this.Campo_Nombre.Name = "Campo_Nombre";
            this.Campo_Nombre.ReadOnly = true;
            this.Campo_Nombre.Width = 87;
            // 
            // Campo_Apellidos
            // 
            this.Campo_Apellidos.HeaderText = "Apellidos";
            this.Campo_Apellidos.Name = "Campo_Apellidos";
            this.Campo_Apellidos.ReadOnly = true;
            this.Campo_Apellidos.Width = 98;
            // 
            // Campo_Edad
            // 
            this.Campo_Edad.HeaderText = "Edad";
            this.Campo_Edad.Name = "Campo_Edad";
            this.Campo_Edad.ReadOnly = true;
            this.Campo_Edad.Width = 69;
            // 
            // Campo_Administrador
            // 
            this.Campo_Administrador.HeaderText = "Administrador";
            this.Campo_Administrador.Name = "Campo_Administrador";
            this.Campo_Administrador.ReadOnly = true;
            this.Campo_Administrador.Width = 128;
            // 
            // btnVerApuestas
            // 
            this.btnVerApuestas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.btnVerApuestas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerApuestas.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnVerApuestas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnVerApuestas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnVerApuestas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerApuestas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerApuestas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVerApuestas.Location = new System.Drawing.Point(299, 37);
            this.btnVerApuestas.Name = "btnVerApuestas";
            this.btnVerApuestas.Size = new System.Drawing.Size(75, 59);
            this.btnVerApuestas.TabIndex = 28;
            this.btnVerApuestas.Text = "Ver Apuestas";
            this.btnVerApuestas.UseVisualStyleBackColor = false;
            this.btnVerApuestas.Click += new System.EventHandler(this.btnVerApuestas_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Controls.Add(this.tbSeleccionado);
            this.panel5.Controls.Add(this.btnVerApuestas);
            this.panel5.Controls.Add(this.lbSeleccionado);
            this.panel5.Location = new System.Drawing.Point(18, 222);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(392, 135);
            this.panel5.TabIndex = 31;
            // 
            // tbSeleccionado
            // 
            this.tbSeleccionado.BackColor = System.Drawing.Color.Azure;
            this.tbSeleccionado.Enabled = false;
            this.tbSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSeleccionado.ForeColor = System.Drawing.Color.Black;
            this.tbSeleccionado.Location = new System.Drawing.Point(3, 37);
            this.tbSeleccionado.Multiline = true;
            this.tbSeleccionado.Name = "tbSeleccionado";
            this.tbSeleccionado.Size = new System.Drawing.Size(290, 70);
            this.tbSeleccionado.TabIndex = 24;
            // 
            // lbSeleccionado
            // 
            this.lbSeleccionado.AutoSize = true;
            this.lbSeleccionado.Location = new System.Drawing.Point(3, 15);
            this.lbSeleccionado.Name = "lbSeleccionado";
            this.lbSeleccionado.Size = new System.Drawing.Size(137, 19);
            this.lbSeleccionado.TabIndex = 12;
            this.lbSeleccionado.Text = "Usuario Seleccionado:";
            // 
            // dgvApuestas
            // 
            this.dgvApuestas.AllowUserToAddRows = false;
            this.dgvApuestas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvApuestas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvApuestas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgvApuestas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvApuestas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApuestas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvApuestas.ColumnHeadersHeight = 30;
            this.dgvApuestas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvApuestas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Campo_Id,
            this.Campo_TipoMercado,
            this.Campo_Tipo,
            this.Campo_Cuota,
            this.Campo_Cantidad,
            this.Campo_IdMercado,
            this.dataGridViewTextBoxColumn1});
            this.dgvApuestas.EnableHeadersVisualStyles = false;
            this.dgvApuestas.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvApuestas.Location = new System.Drawing.Point(13, 40);
            this.dgvApuestas.MultiSelect = false;
            this.dgvApuestas.Name = "dgvApuestas";
            this.dgvApuestas.ReadOnly = true;
            this.dgvApuestas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvApuestas.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvApuestas.RowHeadersVisible = false;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.White;
            this.dgvApuestas.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvApuestas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvApuestas.Size = new System.Drawing.Size(872, 277);
            this.dgvApuestas.TabIndex = 32;
            // 
            // Campo_Id
            // 
            this.Campo_Id.HeaderText = "ID Apuesta";
            this.Campo_Id.Name = "Campo_Id";
            this.Campo_Id.ReadOnly = true;
            this.Campo_Id.Width = 108;
            // 
            // Campo_TipoMercado
            // 
            this.Campo_TipoMercado.HeaderText = "Tipo Mercado";
            this.Campo_TipoMercado.Name = "Campo_TipoMercado";
            this.Campo_TipoMercado.ReadOnly = true;
            this.Campo_TipoMercado.Width = 129;
            // 
            // Campo_Tipo
            // 
            this.Campo_Tipo.HeaderText = "Apuesta a Over";
            this.Campo_Tipo.Name = "Campo_Tipo";
            this.Campo_Tipo.ReadOnly = true;
            this.Campo_Tipo.Width = 139;
            // 
            // Campo_Cuota
            // 
            this.Campo_Cuota.HeaderText = "Cuota";
            this.Campo_Cuota.Name = "Campo_Cuota";
            this.Campo_Cuota.ReadOnly = true;
            this.Campo_Cuota.Width = 72;
            // 
            // Campo_Cantidad
            // 
            this.Campo_Cantidad.HeaderText = "Cantidad Apostada";
            this.Campo_Cantidad.Name = "Campo_Cantidad";
            this.Campo_Cantidad.ReadOnly = true;
            this.Campo_Cantidad.Width = 165;
            // 
            // Campo_IdMercado
            // 
            this.Campo_IdMercado.HeaderText = "ID Mercado";
            this.Campo_IdMercado.Name = "Campo_IdMercado";
            this.Campo_IdMercado.ReadOnly = true;
            this.Campo_IdMercado.Width = 112;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Usuario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 86;
            // 
            // btnTodasApuestas
            // 
            this.btnTodasApuestas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.btnTodasApuestas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTodasApuestas.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnTodasApuestas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnTodasApuestas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnTodasApuestas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTodasApuestas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTodasApuestas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTodasApuestas.Location = new System.Drawing.Point(325, 8);
            this.btnTodasApuestas.Name = "btnTodasApuestas";
            this.btnTodasApuestas.Size = new System.Drawing.Size(166, 29);
            this.btnTodasApuestas.TabIndex = 29;
            this.btnTodasApuestas.Text = "Todas las Apuestas";
            this.btnTodasApuestas.UseVisualStyleBackColor = false;
            this.btnTodasApuestas.Click += new System.EventHandler(this.btnTodasApuestas_Click);
            // 
            // lbUsuarios
            // 
            this.lbUsuarios.AutoSize = true;
            this.lbUsuarios.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuarios.ForeColor = System.Drawing.Color.Black;
            this.lbUsuarios.Location = new System.Drawing.Point(18, 12);
            this.lbUsuarios.Name = "lbUsuarios";
            this.lbUsuarios.Size = new System.Drawing.Size(128, 25);
            this.lbUsuarios.TabIndex = 33;
            this.lbUsuarios.Text = "USUARIOS";
            // 
            // lbApuestas
            // 
            this.lbApuestas.AutoSize = true;
            this.lbApuestas.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbApuestas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApuestas.ForeColor = System.Drawing.Color.Black;
            this.lbApuestas.Location = new System.Drawing.Point(13, 12);
            this.lbApuestas.Name = "lbApuestas";
            this.lbApuestas.Size = new System.Drawing.Size(132, 25);
            this.lbApuestas.TabIndex = 34;
            this.lbApuestas.Text = "APUESTAS";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnEliminarEvento);
            this.panel1.Controls.Add(this.btnEditarEvento);
            this.panel1.Controls.Add(this.btnNuevoUsuario);
            this.panel1.Controls.Add(this.checkBoxAdmin);
            this.panel1.Controls.Add(this.lbUsuarios);
            this.panel1.Controls.Add(this.dgvUsuarios);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 370);
            this.panel1.TabIndex = 35;
            // 
            // btnEditarEvento
            // 
            this.btnEditarEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.btnEditarEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarEvento.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnEditarEvento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEditarEvento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnEditarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarEvento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEditarEvento.Location = new System.Drawing.Point(416, 287);
            this.btnEditarEvento.Name = "btnEditarEvento";
            this.btnEditarEvento.Size = new System.Drawing.Size(82, 59);
            this.btnEditarEvento.TabIndex = 36;
            this.btnEditarEvento.Text = "EDITAR";
            this.btnEditarEvento.UseVisualStyleBackColor = false;
            this.btnEditarEvento.Click += new System.EventHandler(this.btnEditarEvento_Click);
            // 
            // btnNuevoUsuario
            // 
            this.btnNuevoUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.btnNuevoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoUsuario.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnNuevoUsuario.FlatAppearance.BorderSize = 3;
            this.btnNuevoUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnNuevoUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnNuevoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNuevoUsuario.Location = new System.Drawing.Point(416, 222);
            this.btnNuevoUsuario.Name = "btnNuevoUsuario";
            this.btnNuevoUsuario.Size = new System.Drawing.Size(75, 59);
            this.btnNuevoUsuario.TabIndex = 35;
            this.btnNuevoUsuario.Text = "NUEVO";
            this.btnNuevoUsuario.UseVisualStyleBackColor = false;
            this.btnNuevoUsuario.Click += new System.EventHandler(this.btnNuevoUsuario_Click);
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Location = new System.Drawing.Point(161, 17);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(78, 17);
            this.checkBoxAdmin.TabIndex = 34;
            this.checkBoxAdmin.Text = "Solo admin";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            this.checkBoxAdmin.CheckedChanged += new System.EventHandler(this.checkBoxAdmin_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbApuestas);
            this.panel2.Controls.Add(this.dgvApuestas);
            this.panel2.Controls.Add(this.btnTodasApuestas);
            this.panel2.Location = new System.Drawing.Point(12, 407);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 391);
            this.panel2.TabIndex = 36;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalir.Location = new System.Drawing.Point(884, 25);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 74);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEliminarEvento
            // 
            this.btnEliminarEvento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(255)))), ((int)(((byte)(236)))));
            this.btnEliminarEvento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarEvento.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnEliminarEvento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnEliminarEvento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnEliminarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEvento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarEvento.Location = new System.Drawing.Point(504, 259);
            this.btnEliminarEvento.Name = "btnEliminarEvento";
            this.btnEliminarEvento.Size = new System.Drawing.Size(82, 59);
            this.btnEliminarEvento.TabIndex = 37;
            this.btnEliminarEvento.Text = "ELIMINAR";
            this.btnEliminarEvento.UseVisualStyleBackColor = false;
            this.btnEliminarEvento.Click += new System.EventHandler(this.btnEliminarEvento_Click);
            // 
            // valDelete
            // 
            this.valDelete.AutoSize = true;
            this.valDelete.BackColor = System.Drawing.Color.Crimson;
            this.valDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valDelete.Location = new System.Drawing.Point(620, 250);
            this.valDelete.Name = "valDelete";
            this.valDelete.Size = new System.Drawing.Size(211, 13);
            this.valDelete.TabIndex = 75;
            this.valDelete.Text = "no puedes borrar el usuario logeado";
            this.valDelete.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(613, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "el grid no actualiza automaticamente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(613, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 20);
            this.label2.TabIndex = 77;
            this.label2.Text = "cuando se hace un cambio";
            // 
            // UsuariosApuestasViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(990, 810);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valDelete);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UsuariosApuestasViewer";
            this.Text = "GESTOR DE USUARIOS Y APUESTAS";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvApuestas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo_Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo_Edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo_Administrador;
        private System.Windows.Forms.Button btnVerApuestas;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbSeleccionado;
        private MetroFramework.Controls.MetroLabel lbSeleccionado;
        private System.Windows.Forms.DataGridView dgvApuestas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo_TipoMercado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo_Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo_Cuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Campo_IdMercado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnTodasApuestas;
        private System.Windows.Forms.Label lbUsuarios;
        private System.Windows.Forms.Label lbApuestas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private System.Windows.Forms.Button btnNuevoUsuario;
        private System.Windows.Forms.Button btnEditarEvento;
        private System.Windows.Forms.Button btnEliminarEvento;
        private System.Windows.Forms.Label valDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}