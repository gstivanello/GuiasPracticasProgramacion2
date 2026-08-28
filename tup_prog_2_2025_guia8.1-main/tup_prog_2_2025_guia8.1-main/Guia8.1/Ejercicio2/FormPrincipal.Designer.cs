namespace Ejercicio2
{
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
            dtpFechaEvento = new DateTimePicker();
            tbNombreEvento = new TextBox();
            btnAltaEvento = new Button();
            label1 = new Label();
            label2 = new Label();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            lbxVerEventos = new ListBox();
            btnImportar = new Button();
            btnExportar = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dtpFechaEvento
            // 
            dtpFechaEvento.Format = DateTimePickerFormat.Short;
            dtpFechaEvento.Location = new Point(160, 43);
            dtpFechaEvento.Name = "dtpFechaEvento";
            dtpFechaEvento.Size = new Size(208, 26);
            dtpFechaEvento.TabIndex = 0;
            // 
            // tbNombreEvento
            // 
            tbNombreEvento.Location = new Point(160, 75);
            tbNombreEvento.Multiline = true;
            tbNombreEvento.Name = "tbNombreEvento";
            tbNombreEvento.Size = new Size(208, 75);
            tbNombreEvento.TabIndex = 1;
            // 
            // btnAltaEvento
            // 
            btnAltaEvento.Location = new Point(389, 43);
            btnAltaEvento.Name = "btnAltaEvento";
            btnAltaEvento.Size = new Size(181, 80);
            btnAltaEvento.TabIndex = 2;
            btnAltaEvento.Text = "(1)Alta Evento";
            btnAltaEvento.UseVisualStyleBackColor = true;
            btnAltaEvento.Click += btnAltaEvento_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 43);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 3;
            label1.Text = "Fecha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 78);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 4;
            label2.Text = "Nombre Evento";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbxVerEventos
            // 
            lbxVerEventos.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbxVerEventos.FormattingEnabled = true;
            lbxVerEventos.Location = new Point(11, 47);
            lbxVerEventos.Name = "lbxVerEventos";
            lbxVerEventos.Size = new Size(357, 180);
            lbxVerEventos.TabIndex = 5;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(389, 49);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(181, 80);
            btnImportar.TabIndex = 6;
            btnImportar.Text = "(2)Importar Asistentes/Expositores";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(389, 135);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(181, 80);
            btnExportar.TabIndex = 7;
            btnExportar.Text = "(3) Exportar Tecnicos y Expositores";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbNombreEvento);
            groupBox1.Controls.Add(dtpFechaEvento);
            groupBox1.Controls.Add(btnAltaEvento);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(582, 156);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Evento Nuevo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(lbxVerEventos);
            groupBox2.Controls.Add(btnImportar);
            groupBox2.Controls.Add(btnExportar);
            groupBox2.Location = new Point(12, 174);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(582, 237);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Administracion de Eventos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 22);
            label3.Name = "label3";
            label3.Size = new Size(427, 20);
            label3.TabIndex = 8;
            label3.Text = "Seleccione un evento del listado y realice alguna operación:";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 416);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaEvento;
        private System.Windows.Forms.TextBox tbNombreEvento;
        private System.Windows.Forms.Button btnAltaEvento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ListBox lbxVerEventos;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
    }
}

