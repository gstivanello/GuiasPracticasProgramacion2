namespace Ejercicio2;

partial class FormPrincipal
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
        groupBox1 = new GroupBox();
        label5 = new Label();
        label2 = new Label();
        label1 = new Label();
        tbMotivo = new TextBox();
        tbNombrePersona = new TextBox();
        btnRegistrarReclamo = new Button();
        groupBox2 = new GroupBox();
        label3 = new Label();
        lbxVerReclamos = new ListBox();
        button2 = new Button();
        groupBox3 = new GroupBox();
        label4 = new Label();
        lbxVerOrdensAEjecutar = new ListBox();
        btnEjecutarOrden = new Button();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(tbMotivo);
        groupBox1.Controls.Add(tbNombrePersona);
        groupBox1.Controls.Add(btnRegistrarReclamo);
        groupBox1.Location = new Point(13, 13);
        groupBox1.Margin = new Padding(4, 5, 4, 5);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(4, 5, 4, 5);
        groupBox1.Size = new Size(315, 297);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Recepción de reclamos";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(18, 38);
        label5.Margin = new Padding(4, 0, 4, 0);
        label5.Name = "label5";
        label5.Size = new Size(137, 20);
        label5.TabIndex = 5;
        label5.Text = "Datos del reclamo";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(18, 111);
        label2.Margin = new Padding(4, 0, 4, 0);
        label2.Name = "label2";
        label2.Size = new Size(55, 20);
        label2.TabIndex = 4;
        label2.Text = "Motivo";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(8, 71);
        label1.Margin = new Padding(4, 0, 4, 0);
        label1.Name = "label1";
        label1.Size = new Size(65, 20);
        label1.TabIndex = 3;
        label1.Text = "Nombre";
        // 
        // tbMotivo
        // 
        tbMotivo.Location = new Point(84, 108);
        tbMotivo.Margin = new Padding(4, 5, 4, 5);
        tbMotivo.Multiline = true;
        tbMotivo.Name = "tbMotivo";
        tbMotivo.ScrollBars = ScrollBars.Both;
        tbMotivo.Size = new Size(211, 100);
        tbMotivo.TabIndex = 2;
        // 
        // tbNombrePersona
        // 
        tbNombrePersona.Location = new Point(84, 68);
        tbNombrePersona.Margin = new Padding(4, 5, 4, 5);
        tbNombrePersona.Name = "tbNombrePersona";
        tbNombrePersona.Size = new Size(211, 26);
        tbNombrePersona.TabIndex = 1;
        // 
        // btnRegistrarReclamo
        // 
        btnRegistrarReclamo.Location = new Point(101, 225);
        btnRegistrarReclamo.Margin = new Padding(4, 5, 4, 5);
        btnRegistrarReclamo.Name = "btnRegistrarReclamo";
        btnRegistrarReclamo.Size = new Size(147, 62);
        btnRegistrarReclamo.TabIndex = 0;
        btnRegistrarReclamo.Text = "Registrar Reclamo";
        btnRegistrarReclamo.UseVisualStyleBackColor = true;
        btnRegistrarReclamo.Click += btnRegistrarReclamo_Click;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(label3);
        groupBox2.Controls.Add(lbxVerReclamos);
        groupBox2.Controls.Add(button2);
        groupBox2.Location = new Point(336, 15);
        groupBox2.Margin = new Padding(4, 5, 4, 5);
        groupBox2.Name = "groupBox2";
        groupBox2.Padding = new Padding(4, 5, 4, 5);
        groupBox2.Size = new Size(244, 295);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Planificar Trabajo";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(14, 36);
        label3.Margin = new Padding(4, 0, 4, 0);
        label3.Name = "label3";
        label3.Size = new Size(133, 20);
        label3.TabIndex = 4;
        label3.Text = "Lista de reclamos";
        // 
        // lbxVerReclamos
        // 
        lbxVerReclamos.FormattingEnabled = true;
        lbxVerReclamos.ItemHeight = 20;
        lbxVerReclamos.Location = new Point(18, 69);
        lbxVerReclamos.Name = "lbxVerReclamos";
        lbxVerReclamos.Size = new Size(213, 144);
        lbxVerReclamos.TabIndex = 2;
        // 
        // button2
        // 
        button2.Location = new Point(54, 228);
        button2.Margin = new Padding(4, 5, 4, 5);
        button2.Name = "button2";
        button2.Size = new Size(133, 57);
        button2.TabIndex = 1;
        button2.Text = "Crear Orden De Trabajo";
        button2.UseVisualStyleBackColor = true;
        button2.Click += btnResolverReclamo_Click;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(label4);
        groupBox3.Controls.Add(lbxVerOrdensAEjecutar);
        groupBox3.Controls.Add(btnEjecutarOrden);
        groupBox3.Location = new Point(588, 15);
        groupBox3.Margin = new Padding(4, 5, 4, 5);
        groupBox3.Name = "groupBox3";
        groupBox3.Padding = new Padding(4, 5, 4, 5);
        groupBox3.Size = new Size(250, 295);
        groupBox3.TabIndex = 2;
        groupBox3.TabStop = false;
        groupBox3.Text = "Ordenes de trabajos";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(8, 36);
        label4.Margin = new Padding(4, 0, 4, 0);
        label4.Name = "label4";
        label4.Size = new Size(152, 20);
        label4.TabIndex = 5;
        label4.Text = "Trabajos ejecutados";
        // 
        // lbxVerOrdensAEjecutar
        // 
        lbxVerOrdensAEjecutar.FormattingEnabled = true;
        lbxVerOrdensAEjecutar.ItemHeight = 20;
        lbxVerOrdensAEjecutar.Location = new Point(7, 69);
        lbxVerOrdensAEjecutar.Name = "lbxVerOrdensAEjecutar";
        lbxVerOrdensAEjecutar.Size = new Size(235, 144);
        lbxVerOrdensAEjecutar.TabIndex = 3;
        // 
        // btnEjecutarOrden
        // 
        btnEjecutarOrden.Location = new Point(61, 227);
        btnEjecutarOrden.Margin = new Padding(4, 5, 4, 5);
        btnEjecutarOrden.Name = "btnEjecutarOrden";
        btnEjecutarOrden.Size = new Size(136, 58);
        btnEjecutarOrden.TabIndex = 2;
        btnEjecutarOrden.Text = "Ejecutar Orden de Trabajo";
        btnEjecutarOrden.UseVisualStyleBackColor = true;
        btnEjecutarOrden.Click += btnEjecutarOrden_Click;
        // 
        // FormPrincipal
        // 
        AutoScaleDimensions = new SizeF(9F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(842, 312);
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 5, 4, 5);
        Name = "FormPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Ejercicio2";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnRegistrarReclamo;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox tbMotivo;
    private System.Windows.Forms.TextBox tbNombrePersona;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Button btnEjecutarOrden;
    private System.Windows.Forms.ListBox lbxVerReclamos;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ListBox lbxVerOrdensAEjecutar;
}

