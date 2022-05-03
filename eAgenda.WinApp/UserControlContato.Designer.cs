namespace eAgenda.WinApp
{
    partial class UserControlContato
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listContatos = new System.Windows.Forms.ListBox();
            this.btnExcluirContato = new System.Windows.Forms.Button();
            this.btnEditarContato = new System.Windows.Forms.Button();
            this.btnInserirContato = new System.Windows.Forms.Button();
            this.btnVisualizar = new System.Windows.Forms.Button();
            this.tvwContatosOrdenados = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(-148, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "Contatos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(54, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 30);
            this.label2.TabIndex = 26;
            this.label2.Text = "Contatos";
            // 
            // listContatos
            // 
            this.listContatos.BackColor = System.Drawing.Color.Gainsboro;
            this.listContatos.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.listContatos.FormattingEnabled = true;
            this.listContatos.ItemHeight = 19;
            this.listContatos.Location = new System.Drawing.Point(218, 81);
            this.listContatos.Name = "listContatos";
            this.listContatos.Size = new System.Drawing.Size(834, 327);
            this.listContatos.TabIndex = 25;
            this.listContatos.DoubleClick += new System.EventHandler(this.btnEditarContato_Click);
            // 
            // btnExcluirContato
            // 
            this.btnExcluirContato.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExcluirContato.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluirContato.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnExcluirContato.Location = new System.Drawing.Point(14, 237);
            this.btnExcluirContato.Name = "btnExcluirContato";
            this.btnExcluirContato.Size = new System.Drawing.Size(170, 46);
            this.btnExcluirContato.TabIndex = 22;
            this.btnExcluirContato.Text = "Excluir";
            this.btnExcluirContato.UseVisualStyleBackColor = false;
            this.btnExcluirContato.Click += new System.EventHandler(this.btnExcluirContato_Click);
            // 
            // btnEditarContato
            // 
            this.btnEditarContato.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditarContato.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditarContato.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnEditarContato.Location = new System.Drawing.Point(14, 176);
            this.btnEditarContato.Name = "btnEditarContato";
            this.btnEditarContato.Size = new System.Drawing.Size(170, 44);
            this.btnEditarContato.TabIndex = 21;
            this.btnEditarContato.Text = "Editar";
            this.btnEditarContato.UseVisualStyleBackColor = false;
            this.btnEditarContato.Click += new System.EventHandler(this.btnEditarContato_Click);
            // 
            // btnInserirContato
            // 
            this.btnInserirContato.BackColor = System.Drawing.Color.Gainsboro;
            this.btnInserirContato.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInserirContato.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnInserirContato.Location = new System.Drawing.Point(14, 112);
            this.btnInserirContato.Name = "btnInserirContato";
            this.btnInserirContato.Size = new System.Drawing.Size(170, 46);
            this.btnInserirContato.TabIndex = 20;
            this.btnInserirContato.Text = "Inserir";
            this.btnInserirContato.UseVisualStyleBackColor = false;
            this.btnInserirContato.Click += new System.EventHandler(this.btnInserirContato_Click);
            // 
            // btnVisualizar
            // 
            this.btnVisualizar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnVisualizar.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVisualizar.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnVisualizar.Location = new System.Drawing.Point(14, 302);
            this.btnVisualizar.Name = "btnVisualizar";
            this.btnVisualizar.Size = new System.Drawing.Size(170, 46);
            this.btnVisualizar.TabIndex = 27;
            this.btnVisualizar.Text = "Visualizar";
            this.btnVisualizar.UseVisualStyleBackColor = false;
            this.btnVisualizar.Click += new System.EventHandler(this.btnVisualizar_Click);
            // 
            // tvwContatosOrdenados
            // 
            this.tvwContatosOrdenados.Location = new System.Drawing.Point(218, 81);
            this.tvwContatosOrdenados.Name = "tvwContatosOrdenados";
            this.tvwContatosOrdenados.Size = new System.Drawing.Size(834, 327);
            this.tvwContatosOrdenados.TabIndex = 28;
            this.tvwContatosOrdenados.Visible = false;
            // 
            // UserControlContato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnVisualizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExcluirContato);
            this.Controls.Add(this.btnEditarContato);
            this.Controls.Add(this.btnInserirContato);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listContatos);
            this.Controls.Add(this.tvwContatosOrdenados);
            this.Name = "UserControlContato";
            this.Size = new System.Drawing.Size(1090, 658);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listContatos;
        private System.Windows.Forms.Button btnExcluirContato;
        private System.Windows.Forms.Button btnEditarContato;
        private System.Windows.Forms.Button btnInserirContato;
        private System.Windows.Forms.Button btnVisualizar;
        private System.Windows.Forms.TreeView tvwContatosOrdenados;
    }
}
