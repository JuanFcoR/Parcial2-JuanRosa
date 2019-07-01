namespace Parcial2_JuanRosa.UI.Registros
{
    partial class rInscripcion
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
            this.FechaIngresoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MontoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EstudainteIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PrecioCreditosNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AgregarButton = new System.Windows.Forms.Button();
            this.EstudianteComboBox = new System.Windows.Forms.ComboBox();
            this.AsignaturaComboBox = new System.Windows.Forms.ComboBox();
            this.RemoverButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MontoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudainteIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioCreditosNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaIngresoDateTimePicker
            // 
            this.FechaIngresoDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaIngresoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaIngresoDateTimePicker.Location = new System.Drawing.Point(146, 54);
            this.FechaIngresoDateTimePicker.Name = "FechaIngresoDateTimePicker";
            this.FechaIngresoDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.FechaIngresoDateTimePicker.TabIndex = 33;
            this.FechaIngresoDateTimePicker.ValueChanged += new System.EventHandler(this.FechaIngresoDateTimePicker_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(7, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Fecha de Inscripcion";
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::Parcial2_JuanRosa.Properties.Resources.borrar;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(215, 452);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(57, 51);
            this.EliminarButton.TabIndex = 31;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::Parcial2_JuanRosa.Properties.Resources.Save_37110;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(113, 452);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(57, 51);
            this.GuardarButton.TabIndex = 30;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::Parcial2_JuanRosa.Properties.Resources.new_page_document_16676__1_;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(15, 452);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(57, 51);
            this.NuevoButton.TabIndex = 29;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::Parcial2_JuanRosa.Properties.Resources.buscar__1_;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(270, 9);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(74, 33);
            this.BuscarButton.TabIndex = 28;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(7, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Monto";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(7, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Precio de Creditos";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(7, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "InscripcionId";
            // 
            // MontoNumericUpDown
            // 
            this.MontoNumericUpDown.Location = new System.Drawing.Point(146, 130);
            this.MontoNumericUpDown.Name = "MontoNumericUpDown";
            this.MontoNumericUpDown.Size = new System.Drawing.Size(306, 20);
            this.MontoNumericUpDown.TabIndex = 24;
            this.MontoNumericUpDown.ValueChanged += new System.EventHandler(this.BalanceNumericUpDown_ValueChanged);
            // 
            // EstudainteIdNumericUpDown
            // 
            this.EstudainteIdNumericUpDown.Location = new System.Drawing.Point(146, 17);
            this.EstudainteIdNumericUpDown.Name = "EstudainteIdNumericUpDown";
            this.EstudainteIdNumericUpDown.Size = new System.Drawing.Size(77, 20);
            this.EstudainteIdNumericUpDown.TabIndex = 23;
            this.EstudainteIdNumericUpDown.ValueChanged += new System.EventHandler(this.EstudainteIdNumericUpDown_ValueChanged);
            // 
            // PrecioCreditosNumericUpDown
            // 
            this.PrecioCreditosNumericUpDown.Location = new System.Drawing.Point(146, 92);
            this.PrecioCreditosNumericUpDown.Name = "PrecioCreditosNumericUpDown";
            this.PrecioCreditosNumericUpDown.Size = new System.Drawing.Size(306, 20);
            this.PrecioCreditosNumericUpDown.TabIndex = 34;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 212);
            this.dataGridView1.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(12, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 36;
            this.label5.Text = "EstdianteId";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label6.Location = new System.Drawing.Point(185, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "AsignaturaId";
            // 
            // AgregarButton
            // 
            this.AgregarButton.Location = new System.Drawing.Point(400, 174);
            this.AgregarButton.Name = "AgregarButton";
            this.AgregarButton.Size = new System.Drawing.Size(52, 23);
            this.AgregarButton.TabIndex = 38;
            this.AgregarButton.Text = "+";
            this.AgregarButton.UseVisualStyleBackColor = true;
            // 
            // EstudianteComboBox
            // 
            this.EstudianteComboBox.FormattingEnabled = true;
            this.EstudianteComboBox.Location = new System.Drawing.Point(96, 176);
            this.EstudianteComboBox.Name = "EstudianteComboBox";
            this.EstudianteComboBox.Size = new System.Drawing.Size(83, 21);
            this.EstudianteComboBox.TabIndex = 39;
            // 
            // AsignaturaComboBox
            // 
            this.AsignaturaComboBox.FormattingEnabled = true;
            this.AsignaturaComboBox.Location = new System.Drawing.Point(270, 176);
            this.AsignaturaComboBox.Name = "AsignaturaComboBox";
            this.AsignaturaComboBox.Size = new System.Drawing.Size(105, 21);
            this.AsignaturaComboBox.TabIndex = 40;
            // 
            // RemoverButton
            // 
            this.RemoverButton.Location = new System.Drawing.Point(323, 452);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(129, 23);
            this.RemoverButton.TabIndex = 41;
            this.RemoverButton.Text = "Remover Fila";
            this.RemoverButton.UseVisualStyleBackColor = true;
            // 
            // rInscripcion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 509);
            this.Controls.Add(this.RemoverButton);
            this.Controls.Add(this.AsignaturaComboBox);
            this.Controls.Add(this.EstudianteComboBox);
            this.Controls.Add(this.AgregarButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PrecioCreditosNumericUpDown);
            this.Controls.Add(this.FechaIngresoDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MontoNumericUpDown);
            this.Controls.Add(this.EstudainteIdNumericUpDown);
            this.Name = "rInscripcion";
            this.Text = "Inscripcion";
            ((System.ComponentModel.ISupportInitialize)(this.MontoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EstudainteIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioCreditosNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker FechaIngresoDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown MontoNumericUpDown;
        private System.Windows.Forms.NumericUpDown EstudainteIdNumericUpDown;
        private System.Windows.Forms.NumericUpDown PrecioCreditosNumericUpDown;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AgregarButton;
        private System.Windows.Forms.ComboBox EstudianteComboBox;
        private System.Windows.Forms.ComboBox AsignaturaComboBox;
        private System.Windows.Forms.Button RemoverButton;
    }
}