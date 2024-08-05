namespace _01_Tareas_pendientes
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_materia = new System.Windows.Forms.TextBox();
            this.txt_contenido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.F_entrega = new System.Windows.Forms.DateTimePicker();
            this.list_tareas = new System.Windows.Forms.ListBox();
            this.B_agregar = new System.Windows.Forms.Button();
            this.B_eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(632, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tareas Pendientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Materia:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contenido:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_materia
            // 
            this.txt_materia.Location = new System.Drawing.Point(216, 168);
            this.txt_materia.Name = "txt_materia";
            this.txt_materia.Size = new System.Drawing.Size(337, 26);
            this.txt_materia.TabIndex = 3;
            // 
            // txt_contenido
            // 
            this.txt_contenido.Location = new System.Drawing.Point(216, 230);
            this.txt_contenido.Multiline = true;
            this.txt_contenido.Name = "txt_contenido";
            this.txt_contenido.Size = new System.Drawing.Size(337, 278);
            this.txt_contenido.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 553);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Entrega:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // F_entrega
            // 
            this.F_entrega.Location = new System.Drawing.Point(216, 559);
            this.F_entrega.Name = "F_entrega";
            this.F_entrega.Size = new System.Drawing.Size(337, 26);
            this.F_entrega.TabIndex = 6;
            // 
            // list_tareas
            // 
            this.list_tareas.FormattingEnabled = true;
            this.list_tareas.ItemHeight = 20;
            this.list_tareas.Location = new System.Drawing.Point(692, 162);
            this.list_tareas.Name = "list_tareas";
            this.list_tareas.Size = new System.Drawing.Size(922, 464);
            this.list_tareas.TabIndex = 7;
            // 
            // B_agregar
            // 
            this.B_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_agregar.Location = new System.Drawing.Point(786, 671);
            this.B_agregar.Name = "B_agregar";
            this.B_agregar.Size = new System.Drawing.Size(214, 45);
            this.B_agregar.TabIndex = 8;
            this.B_agregar.Text = "Agregar";
            this.B_agregar.UseVisualStyleBackColor = true;
            this.B_agregar.Click += new System.EventHandler(this.B_agregar_Click);
            // 
            // B_eliminar
            // 
            this.B_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_eliminar.Location = new System.Drawing.Point(1345, 671);
            this.B_eliminar.Name = "B_eliminar";
            this.B_eliminar.Size = new System.Drawing.Size(214, 45);
            this.B_eliminar.TabIndex = 9;
            this.B_eliminar.Text = "Eliminar";
            this.B_eliminar.UseVisualStyleBackColor = true;
            this.B_eliminar.Click += new System.EventHandler(this.B_eliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1745, 780);
            this.Controls.Add(this.B_eliminar);
            this.Controls.Add(this.B_agregar);
            this.Controls.Add(this.list_tareas);
            this.Controls.Add(this.F_entrega);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_contenido);
            this.Controls.Add(this.txt_materia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_materia;
        private System.Windows.Forms.TextBox txt_contenido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker F_entrega;
        private System.Windows.Forms.ListBox list_tareas;
        private System.Windows.Forms.Button B_agregar;
        private System.Windows.Forms.Button B_eliminar;
    }
}

