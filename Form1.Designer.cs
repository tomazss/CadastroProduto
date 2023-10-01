namespace CadastroProduto
{
    partial class FormProduto
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
            dataGridProdutos = new DataGridView();
            btnCadastrar = new Button();
            btnAlterar = new Button();
            btnExcluir = new Button();
            label1 = new Label();
            textNome = new TextBox();
            textId = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridProdutos).BeginInit();
            SuspendLayout();
            // 
            // dataGridProdutos
            // 
            dataGridProdutos.AllowUserToAddRows = false;
            dataGridProdutos.AllowUserToDeleteRows = false;
            dataGridProdutos.AllowUserToOrderColumns = true;
            dataGridProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridProdutos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridProdutos.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridProdutos.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridProdutos.Location = new Point(98, 124);
            dataGridProdutos.Name = "dataGridProdutos";
            dataGridProdutos.RowTemplate.Height = 25;
            dataGridProdutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridProdutos.Size = new Size(258, 150);
            dataGridProdutos.TabIndex = 0;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(12, 124);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 1;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnAlterar
            // 
            btnAlterar.Location = new Point(12, 192);
            btnAlterar.Name = "btnAlterar";
            btnAlterar.Size = new Size(75, 23);
            btnAlterar.TabIndex = 2;
            btnAlterar.Text = "Alterar";
            btnAlterar.UseVisualStyleBackColor = true;
            btnAlterar.Click += btnAlterar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(12, 251);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 3;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 25);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 4;
            label1.Text = "Produto\r\n";
            // 
            // textNome
            // 
            textNome.Location = new Point(135, 22);
            textNome.Name = "textNome";
            textNome.PlaceholderText = "Digite o Nome para Cadastrar ou Alterar";
            textNome.Size = new Size(221, 23);
            textNome.TabIndex = 5;
            // 
            // textId
            // 
            textId.Location = new Point(170, 70);
            textId.Name = "textId";
            textId.PlaceholderText = "Digite o ID prara Excluir ou Alterar";
            textId.Size = new Size(187, 23);
            textId.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 78);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 7;
            label2.Text = "ID";
            // 
            // FormProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 286);
            Controls.Add(label2);
            Controls.Add(textId);
            Controls.Add(textNome);
            Controls.Add(label1);
            Controls.Add(btnExcluir);
            Controls.Add(btnAlterar);
            Controls.Add(btnCadastrar);
            Controls.Add(dataGridProdutos);
            Name = "FormProduto";
            Text = "Form1";
            Load += FormProduto_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridProdutos;
        private Button btnCadastrar;
        private Button btnAlterar;
        private Button btnExcluir;
        private Label label1;
        private TextBox textNome;
        private TextBox textId;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnFiltro;
        private TextBox txtFiltro;
        private ComboBox cboFiltro;
    }
}