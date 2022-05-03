namespace eAgenda.WinApp
{
    partial class UserControlTarefa
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
            this.listTarefas = new System.Windows.Forms.ListBox();
            this.btnAtualizarItens = new System.Windows.Forms.Button();
            this.btnCadastrarItens = new System.Windows.Forms.Button();
            this.btnExcluirTarefa = new System.Windows.Forms.Button();
            this.btnEditarTarefa = new System.Windows.Forms.Button();
            this.btnInserirTarefa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVisualizarPendentes = new System.Windows.Forms.Button();
            this.btnVisualizarConcluidas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listTarefas
            // 
            this.listTarefas.BackColor = System.Drawing.Color.Gainsboro;
            this.listTarefas.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.listTarefas.FormattingEnabled = true;
            this.listTarefas.ItemHeight = 19;
            this.listTarefas.Location = new System.Drawing.Point(220, 80);
            this.listTarefas.Name = "listTarefas";
            this.listTarefas.Size = new System.Drawing.Size(834, 327);
            this.listTarefas.TabIndex = 7;
            // 
            // btnAtualizarItens
            // 
            this.btnAtualizarItens.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAtualizarItens.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAtualizarItens.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnAtualizarItens.Location = new System.Drawing.Point(16, 274);
            this.btnAtualizarItens.Name = "btnAtualizarItens";
            this.btnAtualizarItens.Size = new System.Drawing.Size(170, 45);
            this.btnAtualizarItens.TabIndex = 4;
            this.btnAtualizarItens.Text = "Atualizar Itens";
            this.btnAtualizarItens.UseVisualStyleBackColor = false;
            this.btnAtualizarItens.Click += new System.EventHandler(this.btnAtualizarItens_Click);
            // 
            // btnCadastrarItens
            // 
            this.btnCadastrarItens.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCadastrarItens.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrarItens.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnCadastrarItens.Location = new System.Drawing.Point(16, 223);
            this.btnCadastrarItens.Name = "btnCadastrarItens";
            this.btnCadastrarItens.Size = new System.Drawing.Size(170, 45);
            this.btnCadastrarItens.TabIndex = 3;
            this.btnCadastrarItens.Text = "Cadastrar Itens";
            this.btnCadastrarItens.UseVisualStyleBackColor = false;
            this.btnCadastrarItens.Click += new System.EventHandler(this.btnCadastrarItens_Click);
            // 
            // btnExcluirTarefa
            // 
            this.btnExcluirTarefa.BackColor = System.Drawing.Color.Gainsboro;
            this.btnExcluirTarefa.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluirTarefa.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnExcluirTarefa.Location = new System.Drawing.Point(16, 171);
            this.btnExcluirTarefa.Name = "btnExcluirTarefa";
            this.btnExcluirTarefa.Size = new System.Drawing.Size(170, 46);
            this.btnExcluirTarefa.TabIndex = 2;
            this.btnExcluirTarefa.Text = "Excluir";
            this.btnExcluirTarefa.UseVisualStyleBackColor = false;
            this.btnExcluirTarefa.Click += new System.EventHandler(this.btnExcluirTarefa_Click);
            // 
            // btnEditarTarefa
            // 
            this.btnEditarTarefa.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEditarTarefa.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditarTarefa.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnEditarTarefa.Location = new System.Drawing.Point(16, 121);
            this.btnEditarTarefa.Name = "btnEditarTarefa";
            this.btnEditarTarefa.Size = new System.Drawing.Size(170, 44);
            this.btnEditarTarefa.TabIndex = 1;
            this.btnEditarTarefa.Text = "Editar";
            this.btnEditarTarefa.UseVisualStyleBackColor = false;
            this.btnEditarTarefa.Click += new System.EventHandler(this.btnEditarTarefa_Click);
            // 
            // btnInserirTarefa
            // 
            this.btnInserirTarefa.BackColor = System.Drawing.Color.Gainsboro;
            this.btnInserirTarefa.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInserirTarefa.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnInserirTarefa.Location = new System.Drawing.Point(16, 69);
            this.btnInserirTarefa.Name = "btnInserirTarefa";
            this.btnInserirTarefa.Size = new System.Drawing.Size(170, 46);
            this.btnInserirTarefa.TabIndex = 0;
            this.btnInserirTarefa.Text = "Inserir";
            this.btnInserirTarefa.UseVisualStyleBackColor = false;
            this.btnInserirTarefa.Click += new System.EventHandler(this.btnInserirTarefa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label1.Location = new System.Drawing.Point(56, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tarefas";
            // 
            // btnVisualizarPendentes
            // 
            this.btnVisualizarPendentes.BackColor = System.Drawing.Color.Gainsboro;
            this.btnVisualizarPendentes.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVisualizarPendentes.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnVisualizarPendentes.Location = new System.Drawing.Point(16, 325);
            this.btnVisualizarPendentes.Name = "btnVisualizarPendentes";
            this.btnVisualizarPendentes.Size = new System.Drawing.Size(170, 45);
            this.btnVisualizarPendentes.TabIndex = 5;
            this.btnVisualizarPendentes.Text = "Visualizar Pendentes";
            this.btnVisualizarPendentes.UseVisualStyleBackColor = false;
            this.btnVisualizarPendentes.Click += new System.EventHandler(this.btnVisualizarPendentes_Click);
            // 
            // btnVisualizarConcluidas
            // 
            this.btnVisualizarConcluidas.BackColor = System.Drawing.Color.Gainsboro;
            this.btnVisualizarConcluidas.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVisualizarConcluidas.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.btnVisualizarConcluidas.Location = new System.Drawing.Point(16, 376);
            this.btnVisualizarConcluidas.Name = "btnVisualizarConcluidas";
            this.btnVisualizarConcluidas.Size = new System.Drawing.Size(170, 45);
            this.btnVisualizarConcluidas.TabIndex = 6;
            this.btnVisualizarConcluidas.Text = "Visualizar Concluídas";
            this.btnVisualizarConcluidas.UseVisualStyleBackColor = false;
            this.btnVisualizarConcluidas.Click += new System.EventHandler(this.btnVisualizarConcluidas_Click);
            // 
            // UserControlTarefa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnVisualizarConcluidas);
            this.Controls.Add(this.btnVisualizarPendentes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listTarefas);
            this.Controls.Add(this.btnAtualizarItens);
            this.Controls.Add(this.btnCadastrarItens);
            this.Controls.Add(this.btnExcluirTarefa);
            this.Controls.Add(this.btnEditarTarefa);
            this.Controls.Add(this.btnInserirTarefa);
            this.Name = "UserControlTarefa";
            this.Size = new System.Drawing.Size(1106, 487);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listTarefas;
        private System.Windows.Forms.Button btnAtualizarItens;
        private System.Windows.Forms.Button btnCadastrarItens;
        private System.Windows.Forms.Button btnExcluirTarefa;
        private System.Windows.Forms.Button btnEditarTarefa;
        private System.Windows.Forms.Button btnInserirTarefa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVisualizarPendentes;
        private System.Windows.Forms.Button btnVisualizarConcluidas;
    }
}
