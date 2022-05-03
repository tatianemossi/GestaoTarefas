namespace GestaoTarefas.WinApp
{
    partial class CadastroCompromissos
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
            this.cboxContato = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtHoraInicial = new System.Windows.Forms.DateTimePicker();
            this.dtHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cboxContato
            // 
            this.cboxContato.FormattingEnabled = true;
            this.cboxContato.Location = new System.Drawing.Point(167, 185);
            this.cboxContato.Name = "cboxContato";
            this.cboxContato.Size = new System.Drawing.Size(347, 27);
            this.cboxContato.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label5.Location = new System.Drawing.Point(8, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Selecione o Contato:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label4.Location = new System.Drawing.Point(52, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Horário Final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label3.Location = new System.Drawing.Point(48, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Horário Início:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnCancelar.Location = new System.Drawing.Point(353, 241);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 67);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.White;
            this.btnGravar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGravar.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnGravar.Location = new System.Drawing.Point(223, 241);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(124, 67);
            this.btnGravar.TabIndex = 6;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtLocal
            // 
            this.txtLocal.BackColor = System.Drawing.Color.White;
            this.txtLocal.Location = new System.Drawing.Point(167, 47);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(347, 26);
            this.txtLocal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(99, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 19);
            this.label2.TabIndex = 21;
            this.label2.Text = "Data:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(99, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Local:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label6.Location = new System.Drawing.Point(80, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 19);
            this.label6.TabIndex = 32;
            this.label6.Text = "Assunto:";
            // 
            // txtAssunto
            // 
            this.txtAssunto.BackColor = System.Drawing.Color.White;
            this.txtAssunto.Location = new System.Drawing.Point(167, 15);
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(347, 26);
            this.txtAssunto.TabIndex = 0;
            // 
            // dtData
            // 
            this.dtData.CustomFormat = "dd/mm/yyyy";
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.Location = new System.Drawing.Point(167, 86);
            this.dtData.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(200, 26);
            this.dtData.TabIndex = 2;
            this.dtData.Value = new System.DateTime(2022, 5, 3, 11, 17, 16, 0);
            // 
            // dtHoraInicial
            // 
            this.dtHoraInicial.CustomFormat = "";
            this.dtHoraInicial.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraInicial.Location = new System.Drawing.Point(167, 121);
            this.dtHoraInicial.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtHoraInicial.Name = "dtHoraInicial";
            this.dtHoraInicial.Size = new System.Drawing.Size(200, 26);
            this.dtHoraInicial.TabIndex = 3;
            this.dtHoraInicial.Value = new System.DateTime(2022, 5, 3, 0, 0, 0, 0);
            // 
            // dtHoraFinal
            // 
            this.dtHoraFinal.CustomFormat = "";
            this.dtHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHoraFinal.Location = new System.Drawing.Point(167, 153);
            this.dtHoraFinal.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dtHoraFinal.Name = "dtHoraFinal";
            this.dtHoraFinal.Size = new System.Drawing.Size(200, 26);
            this.dtHoraFinal.TabIndex = 4;
            // 
            // CadastroCompromissos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 325);
            this.Controls.Add(this.dtHoraFinal);
            this.Controls.Add(this.dtHoraInicial);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboxContato);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroCompromissos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Compromissos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxContato;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dtHoraInicial;
        private System.Windows.Forms.DateTimePicker dtHoraFinal;
    }
}