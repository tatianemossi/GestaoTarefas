namespace eAgenda.WinApp
{
    partial class CadastroItensTarefa
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtTituloItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listItensTarefa = new System.Windows.Forms.ListBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTituloTarefa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnCancelar.Location = new System.Drawing.Point(297, 265);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 44);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.White;
            this.btnGravar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnGravar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGravar.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnGravar.Location = new System.Drawing.Point(192, 265);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(99, 44);
            this.btnGravar.TabIndex = 3;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = false;
            // 
            // txtTituloItem
            // 
            this.txtTituloItem.Location = new System.Drawing.Point(80, 71);
            this.txtTituloItem.Name = "txtTituloItem";
            this.txtTituloItem.Size = new System.Drawing.Size(181, 26);
            this.txtTituloItem.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(26, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Título";
            // 
            // listItensTarefa
            // 
            this.listItensTarefa.FormattingEnabled = true;
            this.listItensTarefa.ItemHeight = 19;
            this.listItensTarefa.Location = new System.Drawing.Point(26, 103);
            this.listItensTarefa.Name = "listItensTarefa";
            this.listItensTarefa.Size = new System.Drawing.Size(361, 156);
            this.listItensTarefa.TabIndex = 2;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.White;
            this.btnAdicionar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdicionar.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionar.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnAdicionar.Location = new System.Drawing.Point(273, 69);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(114, 28);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(26, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tarefa";
            // 
            // labelTituloTarefa
            // 
            this.labelTituloTarefa.AutoSize = true;
            this.labelTituloTarefa.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTituloTarefa.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.labelTituloTarefa.Location = new System.Drawing.Point(90, 28);
            this.labelTituloTarefa.Name = "labelTituloTarefa";
            this.labelTituloTarefa.Size = new System.Drawing.Size(114, 19);
            this.labelTituloTarefa.TabIndex = 13;
            this.labelTituloTarefa.Text = "[Título Tarefa]";
            // 
            // CadastroItensTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 324);
            this.Controls.Add(this.labelTituloTarefa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.listItensTarefa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTituloItem);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGravar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadastroItensTarefa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Itens da Tarefa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTituloItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listItensTarefa;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTituloTarefa;
        public System.Windows.Forms.Button btnGravar;
    }
}