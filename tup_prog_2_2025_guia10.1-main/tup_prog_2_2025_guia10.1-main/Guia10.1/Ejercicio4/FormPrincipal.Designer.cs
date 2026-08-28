namespace Ejercicio4;

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
        btnVerTodosNodos = new Button();
        tbVer = new TextBox();
        cbxDesde = new ComboBox();
        cbxHasta = new ComboBox();
        btnCalcular = new Button();
        groupBox1 = new GroupBox();
        lbHijoDadoAncestro = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        pictureBox1 = new PictureBox();
        groupBox1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // btnVerTodosNodos
        // 
        btnVerTodosNodos.Location = new Point(261, 12);
        btnVerTodosNodos.Margin = new Padding(4, 5, 4, 5);
        btnVerTodosNodos.Name = "btnVerTodosNodos";
        btnVerTodosNodos.Size = new Size(316, 45);
        btnVerTodosNodos.TabIndex = 0;
        btnVerTodosNodos.Text = "Mostrar Todos los Nodos";
        btnVerTodosNodos.UseVisualStyleBackColor = true;
        btnVerTodosNodos.Click += btnVerTodosNodos_Click;
        // 
        // tbVer
        // 
        tbVer.Location = new Point(256, 271);
        tbVer.Multiline = true;
        tbVer.Name = "tbVer";
        tbVer.ReadOnly = true;
        tbVer.ScrollBars = ScrollBars.Both;
        tbVer.Size = new Size(321, 111);
        tbVer.TabIndex = 1;
        // 
        // cbxDesde
        // 
        cbxDesde.FormattingEnabled = true;
        cbxDesde.Location = new Point(161, 25);
        cbxDesde.Name = "cbxDesde";
        cbxDesde.Size = new Size(155, 28);
        cbxDesde.TabIndex = 2;
        // 
        // cbxHasta
        // 
        cbxHasta.FormattingEnabled = true;
        cbxHasta.Location = new Point(161, 67);
        cbxHasta.Name = "cbxHasta";
        cbxHasta.Size = new Size(155, 28);
        cbxHasta.TabIndex = 3;
        // 
        // btnCalcular
        // 
        btnCalcular.Location = new Point(106, 152);
        btnCalcular.Name = "btnCalcular";
        btnCalcular.Size = new Size(113, 42);
        btnCalcular.TabIndex = 4;
        btnCalcular.Text = "Calcular";
        btnCalcular.UseVisualStyleBackColor = true;
        btnCalcular.Click += btnCalcular_Click;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(lbHijoDadoAncestro);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(cbxDesde);
        groupBox1.Controls.Add(btnCalcular);
        groupBox1.Controls.Add(cbxHasta);
        groupBox1.Location = new Point(255, 65);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(322, 200);
        groupBox1.TabIndex = 5;
        groupBox1.TabStop = false;
        groupBox1.Text = "Probabilidad del hijo dado el ancestro";
        // 
        // lbHijoDadoAncestro
        // 
        lbHijoDadoAncestro.AutoSize = true;
        lbHijoDadoAncestro.BackColor = SystemColors.AppWorkspace;
        lbHijoDadoAncestro.Location = new Point(157, 108);
        lbHijoDadoAncestro.Name = "lbHijoDadoAncestro";
        lbHijoDadoAncestro.Size = new Size(109, 20);
        lbHijoDadoAncestro.TabIndex = 8;
        lbHijoDadoAncestro.Text = "                         ";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(41, 108);
        label3.Name = "label3";
        label3.Size = new Size(100, 20);
        label3.TabIndex = 7;
        label3.Text = "Probabilidad:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(12, 28);
        label2.Name = "label2";
        label2.Size = new Size(129, 20);
        label2.TabIndex = 6;
        label2.Text = "Evento ancestro:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(41, 70);
        label1.Name = "label1";
        label1.Size = new Size(94, 20);
        label1.TabIndex = 5;
        label1.Text = "Evento Hijo:";
        // 
        // pictureBox1
        // 
        pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        pictureBox1.Image = Ejercicio4_Probalidades.Properties.Resources.arbol;
        pictureBox1.InitialImage = null;
        pictureBox1.Location = new Point(12, 12);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(238, 236);
        pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
        pictureBox1.TabIndex = 6;
        pictureBox1.TabStop = false;
        // 
        // FormPrincipal
        // 
        AutoScaleDimensions = new SizeF(9F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(585, 385);
        Controls.Add(pictureBox1);
        Controls.Add(groupBox1);
        Controls.Add(tbVer);
        Controls.Add(btnVerTodosNodos);
        Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(4, 5, 4, 5);
        Name = "FormPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Ejercicio4";
        Load += FormPrincipal_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnVerTodosNodos;
    private System.Windows.Forms.TextBox tbVer;
    private System.Windows.Forms.ComboBox cbxDesde;
    private System.Windows.Forms.ComboBox cbxHasta;
    private System.Windows.Forms.Button btnCalcular;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lbHijoDadoAncestro;
    private System.Windows.Forms.Label label3;
    private PictureBox pictureBox1;
}

