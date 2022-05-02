namespace GestaoTarefas.WinApp
{
    partial class UserControlCompromisso
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
            this.btnVisualizarPassados = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listCompromissos = new System.Windows.Forms.ListBox();
            this.btnExcluirCompromisso = new System.Windows.Forms.Button();
            this.btnEditarCompromisso = new System.Windows.Forms.Button();
            this.btnInserirCompromisso = new System.Windows.Forms.Button();
            this.tvwContatosOrdenados = new System.Windows.Forms.TreeView();
            this.btnVisualizarFuturos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVisualizarPassados
            // 
            this.btnVisualizarPassados.BackColor = System.Drawing.Color.Gainsboro;
            this.btnVisualizarPassados.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVisualizarPassados.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnVisualizarPassados.Location = new System.Drawing.Point(16, 304);
            this.btnVisualizarPassados.Name = "btnVisualizarPassados";
            this.btnVisualizarPassados.Size = new System.Drawing.Size(170, 46);
            this.btnVisualizarPassados.TabIndex = 34;
            this.btnVisualizarPassados.Text = "Visualizar Passados";
            this.btnVisualizarPassados.UseVisualStyleBackColor = false;
            this.btnVisualizarPassados.Click += new System.EventHandler(this.btnVisualizarCompromissos_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label2.Location = new System.Drawing.Point(29, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 30);
            this.label2.TabIndex = 33;
            this.label2.Text = "Compromissos";
            // 
            // listCompromissos
            // 
            this.listCompromissos.BackColor = System.Drawing.Color.Gainsboro;
            this.listCompromissos.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.listCompromissos.FormattingEnabled = true;
            this.listCompromissos.ItemHeight = 19;
            this.listCompromissos.Location = new System.Drawing.Point(220, 83);
            this.listCompromissos.Name = "listCompromissos";
            this.listCompromissos.Size = new System.Drawing.Size(834, 327);
            this.listCompromissos.TabIndex = 32;
            // 
            // btnExcluirCompromisso
            // 
            this.btnExcluirCompromisso.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExcluirCompromisso.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluirCompromisso.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnExcluirCompromisso.Location = new System.Drawing.Point(16, 239);
            this.btnExcluirCompromisso.Name = "btnExcluirCompromisso";
            this.btnExcluirCompromisso.Size = new System.Drawing.Size(170, 46);
            this.btnExcluirCompromisso.TabIndex = 31;
            this.btnExcluirCompromisso.Text = "Excluir";
            this.btnExcluirCompromisso.UseVisualStyleBackColor = false;
            this.btnExcluirCompromisso.Click += new System.EventHandler(this.btnExcluirCompromisso_Click);
            // 
            // btnEditarCompromisso
            // 
            this.btnEditarCompromisso.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditarCompromisso.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditarCompromisso.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnEditarCompromisso.Location = new System.Drawing.Point(16, 178);
            this.btnEditarCompromisso.Name = "btnEditarCompromisso";
            this.btnEditarCompromisso.Size = new System.Drawing.Size(170, 44);
            this.btnEditarCompromisso.TabIndex = 30;
            this.btnEditarCompromisso.Text = "Editar";
            this.btnEditarCompromisso.UseVisualStyleBackColor = false;
            this.btnEditarCompromisso.Click += new System.EventHandler(this.btnEditarCompromisso_Click);
            // 
            // btnInserirCompromisso
            // 
            this.btnInserirCompromisso.BackColor = System.Drawing.Color.Gainsboro;
            this.btnInserirCompromisso.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInserirCompromisso.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnInserirCompromisso.Location = new System.Drawing.Point(16, 114);
            this.btnInserirCompromisso.Name = "btnInserirCompromisso";
            this.btnInserirCompromisso.Size = new System.Drawing.Size(170, 46);
            this.btnInserirCompromisso.TabIndex = 29;
            this.btnInserirCompromisso.Text = "Inserir";
            this.btnInserirCompromisso.UseVisualStyleBackColor = false;
            this.btnInserirCompromisso.Click += new System.EventHandler(this.btnInserirCompromisso_Click);
            // 
            // tvwContatosOrdenados
            // 
            this.tvwContatosOrdenados.Location = new System.Drawing.Point(220, 83);
            this.tvwContatosOrdenados.Name = "tvwContatosOrdenados";
            this.tvwContatosOrdenados.Size = new System.Drawing.Size(834, 327);
            this.tvwContatosOrdenados.TabIndex = 35;
            this.tvwContatosOrdenados.Visible = false;
            // 
            // btnVisualizarFuturos
            // 
            this.btnVisualizarFuturos.BackColor = System.Drawing.Color.Gainsboro;
            this.btnVisualizarFuturos.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVisualizarFuturos.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnVisualizarFuturos.Location = new System.Drawing.Point(16, 364);
            this.btnVisualizarFuturos.Name = "btnVisualizarFuturos";
            this.btnVisualizarFuturos.Size = new System.Drawing.Size(170, 46);
            this.btnVisualizarFuturos.TabIndex = 36;
            this.btnVisualizarFuturos.Text = "Visualizar Futuros";
            this.btnVisualizarFuturos.UseVisualStyleBackColor = false;
            this.btnVisualizarFuturos.Click += new System.EventHandler(this.btnVisualizarFuturos_Click);
            // 
            // UserControlCompromisso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnVisualizarFuturos);
            this.Controls.Add(this.btnVisualizarPassados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listCompromissos);
            this.Controls.Add(this.btnExcluirCompromisso);
            this.Controls.Add(this.btnEditarCompromisso);
            this.Controls.Add(this.btnInserirCompromisso);
            this.Controls.Add(this.tvwContatosOrdenados);
            this.Enabled = false;
            this.Name = "UserControlCompromisso";
            this.Size = new System.Drawing.Size(1090, 658);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVisualizarPassados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listCompromissos;
        private System.Windows.Forms.Button btnExcluirCompromisso;
        private System.Windows.Forms.Button btnEditarCompromisso;
        private System.Windows.Forms.Button btnInserirCompromisso;
        private System.Windows.Forms.TreeView tvwContatosOrdenados;
        private System.Windows.Forms.Button btnVisualizarFuturos;
    }
}
