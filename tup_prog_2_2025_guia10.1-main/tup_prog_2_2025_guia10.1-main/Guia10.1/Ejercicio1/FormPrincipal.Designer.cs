namespace Ejercicio1;

partial class FormPrincipal
{
    /// <summary>
    /// Variable del diseñador requerida.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén utilizando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
    /// el contenido del método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
        btnPreparar = new Button();
        btnRecibir = new Button();
        gbDeposito = new GroupBox();
        lbxVerSectorCarga = new ListBox();
        groupBox1 = new GroupBox();
        label4 = new Label();
        tbNombre = new TextBox();
        tbDireccion = new TextBox();
        label5 = new Label();
        label1 = new Label();
        tbDNI = new TextBox();
        groupBox2 = new GroupBox();
        btnIniciarReparto = new Button();
        label8 = new Label();
        groupBox3 = new GroupBox();
        lbDireccion = new Label();
        label3 = new Label();
        lbDNI = new Label();
        label6 = new Label();
        label2 = new Label();
        lbNombre = new Label();
        lbxListadoAEntregar = new ListBox();
        btnReparto = new Button();
        gbDeposito.SuspendLayout();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        SuspendLayout();
        // 
        // btnPreparar
        // 
        btnPreparar.Location = new Point(81, 284);
        btnPreparar.Name = "btnPreparar";
        btnPreparar.Size = new Size(143, 63);
        btnPreparar.TabIndex = 6;
        btnPreparar.Text = "Preparar camión";
        btnPreparar.UseVisualStyleBackColor = true;
        btnPreparar.Click += btnPreparar_Click;
        // 
        // btnRecibir
        // 
        btnRecibir.Location = new Point(57, 283);
        btnRecibir.Name = "btnRecibir";
        btnRecibir.Size = new Size(164, 63);
        btnRecibir.TabIndex = 4;
        btnRecibir.Text = "Recibir Correspondencia";
        btnRecibir.UseVisualStyleBackColor = true;
        btnRecibir.Click += btnRecibir_Click;
        // 
        // gbDeposito
        // 
        gbDeposito.Controls.Add(lbxVerSectorCarga);
        gbDeposito.Controls.Add(btnPreparar);
        gbDeposito.Location = new Point(272, 4);
        gbDeposito.Name = "gbDeposito";
        gbDeposito.Size = new Size(289, 356);
        gbDeposito.TabIndex = 18;
        gbDeposito.TabStop = false;
        gbDeposito.Text = "Paquetes en el Sector de embarque";
        // 
        // lbxVerSectorCarga
        // 
        lbxVerSectorCarga.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lbxVerSectorCarga.FormattingEnabled = true;
        lbxVerSectorCarga.Location = new Point(15, 35);
        lbxVerSectorCarga.Name = "lbxVerSectorCarga";
        lbxVerSectorCarga.Size = new Size(255, 244);
        lbxVerSectorCarga.TabIndex = 21;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(tbNombre);
        groupBox1.Controls.Add(tbDireccion);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(tbDNI);
        groupBox1.Controls.Add(btnRecibir);
        groupBox1.Location = new Point(12, 4);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(254, 356);
        groupBox1.TabIndex = 19;
        groupBox1.TabStop = false;
        groupBox1.Text = "Sector de atención al cliente";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(25, 107);
        label4.Name = "label4";
        label4.Size = new Size(65, 20);
        label4.TabIndex = 26;
        label4.Text = "Nombre";
        // 
        // tbNombre
        // 
        tbNombre.Location = new Point(96, 104);
        tbNombre.Multiline = true;
        tbNombre.Name = "tbNombre";
        tbNombre.Size = new Size(144, 57);
        tbNombre.TabIndex = 2;
        // 
        // tbDireccion
        // 
        tbDireccion.Location = new Point(96, 171);
        tbDireccion.Multiline = true;
        tbDireccion.Name = "tbDireccion";
        tbDireccion.Size = new Size(144, 87);
        tbDireccion.TabIndex = 3;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(15, 174);
        label5.Name = "label5";
        label5.Size = new Size(75, 20);
        label5.TabIndex = 23;
        label5.Text = "Direccion";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(53, 78);
        label1.Name = "label1";
        label1.Size = new Size(37, 20);
        label1.TabIndex = 21;
        label1.Text = "DNI";
        // 
        // tbDNI
        // 
        tbDNI.Location = new Point(96, 72);
        tbDNI.Name = "tbDNI";
        tbDNI.Size = new Size(144, 26);
        tbDNI.TabIndex = 1;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(btnIniciarReparto);
        groupBox2.Controls.Add(label8);
        groupBox2.Controls.Add(groupBox3);
        groupBox2.Controls.Add(lbxListadoAEntregar);
        groupBox2.Controls.Add(btnReparto);
        groupBox2.Location = new Point(567, 4);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(266, 356);
        groupBox2.TabIndex = 23;
        groupBox2.TabStop = false;
        groupBox2.Text = "Tarea de reparto";
        // 
        // btnIniciarReparto
        // 
        btnIniciarReparto.Location = new Point(20, 145);
        btnIniciarReparto.Name = "btnIniciarReparto";
        btnIniciarReparto.Size = new Size(108, 55);
        btnIniciarReparto.TabIndex = 30;
        btnIniciarReparto.Text = "Iniciar Reparto";
        btnIniciarReparto.UseVisualStyleBackColor = true;
        btnIniciarReparto.Click += btnIniciarReparto_Click;
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Location = new Point(2, 219);
        label8.Name = "label8";
        label8.Size = new Size(138, 20);
        label8.TabIndex = 29;
        label8.Text = "Listado a entregar";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(lbDireccion);
        groupBox3.Controls.Add(label3);
        groupBox3.Controls.Add(lbDNI);
        groupBox3.Controls.Add(label6);
        groupBox3.Controls.Add(label2);
        groupBox3.Controls.Add(lbNombre);
        groupBox3.Location = new Point(20, 25);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new Size(240, 114);
        groupBox3.TabIndex = 24;
        groupBox3.TabStop = false;
        groupBox3.Text = "Próximo a entregar";
        // 
        // lbDireccion
        // 
        lbDireccion.AutoSize = true;
        lbDireccion.BackColor = SystemColors.ControlLight;
        lbDireccion.Location = new Point(89, 77);
        lbDireccion.Name = "lbDireccion";
        lbDireccion.Size = new Size(77, 20);
        lbDireccion.TabIndex = 21;
        lbDireccion.Text = "                 ";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(-4, 77);
        label3.Name = "label3";
        label3.Size = new Size(75, 20);
        label3.TabIndex = 27;
        label3.Text = "Direccion";
        // 
        // lbDNI
        // 
        lbDNI.AutoSize = true;
        lbDNI.BackColor = SystemColors.ControlLight;
        lbDNI.Location = new Point(89, 22);
        lbDNI.Name = "lbDNI";
        lbDNI.Size = new Size(77, 20);
        lbDNI.TabIndex = 18;
        lbDNI.Text = "                 ";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(6, 47);
        label6.Name = "label6";
        label6.Size = new Size(65, 20);
        label6.TabIndex = 28;
        label6.Text = "Nombre";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(26, 22);
        label2.Name = "label2";
        label2.Size = new Size(37, 20);
        label2.TabIndex = 22;
        label2.Text = "DNI";
        // 
        // lbNombre
        // 
        lbNombre.AutoSize = true;
        lbNombre.BackColor = SystemColors.ControlLight;
        lbNombre.Location = new Point(89, 47);
        lbNombre.Name = "lbNombre";
        lbNombre.Size = new Size(77, 20);
        lbNombre.TabIndex = 19;
        lbNombre.Text = "                 ";
        // 
        // lbxListadoAEntregar
        // 
        lbxListadoAEntregar.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        lbxListadoAEntregar.FormattingEnabled = true;
        lbxListadoAEntregar.Location = new Point(6, 242);
        lbxListadoAEntregar.Name = "lbxListadoAEntregar";
        lbxListadoAEntregar.Size = new Size(254, 100);
        lbxListadoAEntregar.TabIndex = 9;
        // 
        // btnReparto
        // 
        btnReparto.Enabled = false;
        btnReparto.Location = new Point(144, 145);
        btnReparto.Name = "btnReparto";
        btnReparto.Size = new Size(114, 55);
        btnReparto.TabIndex = 7;
        btnReparto.Text = "Entregar paquete";
        btnReparto.UseVisualStyleBackColor = true;
        btnReparto.Click += btnReparto_Click;
        // 
        // FormPrincipal
        // 
        AutoScaleDimensions = new SizeF(9F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(837, 363);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Controls.Add(gbDeposito);
        Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 5, 4, 5);
        Name = "FormPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Ejercicio 1";
        Load += FormPrincipal_Load;
        gbDeposito.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button btnPreparar;
    private System.Windows.Forms.Button btnRecibir;
    private System.Windows.Forms.GroupBox gbDeposito;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tbDNI;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button btnReparto;
    private System.Windows.Forms.TextBox tbDireccion;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label lbNombre;
    private System.Windows.Forms.Label lbDNI;
    private System.Windows.Forms.ListBox lbxListadoAEntregar;
    private System.Windows.Forms.ListBox lbxVerSectorCarga;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox tbNombre;
    private System.Windows.Forms.Label lbDireccion;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button btnIniciarReparto;
}

