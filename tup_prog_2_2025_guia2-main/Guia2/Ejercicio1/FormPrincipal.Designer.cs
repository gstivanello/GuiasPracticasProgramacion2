namespace Ejercicio1
{
    partial class FormPrincipal
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
            btnAgregar = new Button();
            btnListar = new Button();
            btnVer = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            lbxPersonas = new ListBox();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(337, 67);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(131, 41);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(337, 20);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(131, 41);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(337, 114);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(131, 41);
            btnVer.TabIndex = 3;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(337, 161);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(131, 41);
            btnModificar.TabIndex = 4;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(337, 208);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(131, 41);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lbxPersonas
            // 
            lbxPersonas.FormattingEnabled = true;
            lbxPersonas.ItemHeight = 21;
            lbxPersonas.Location = new Point(12, 7);
            lbxPersonas.Name = "lbxPersonas";
            lbxPersonas.Size = new Size(308, 256);
            lbxPersonas.TabIndex = 6;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 275);
            Controls.Add(lbxPersonas);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnVer);
            Controls.Add(btnListar);
            Controls.Add(btnAgregar);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregar;
        private Button btnListar;
        private Button btnVer;
        private Button btnModificar;
        private Button btnEliminar;
        private ListBox lbxPersonas;
    }
}
