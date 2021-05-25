
namespace modelagemEstoque
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ID_produto = new System.Windows.Forms.TextBox();
            this.txt_nome_prod = new System.Windows.Forms.TextBox();
            this.txt_qtde_produto = new System.Windows.Forms.TextBox();
            this.listview_prod = new System.Windows.Forms.ListView();
            this.list_id_prod = new System.Windows.Forms.ColumnHeader();
            this.list_nome_prod = new System.Windows.Forms.ColumnHeader();
            this.list_qtde_prod = new System.Windows.Forms.ColumnHeader();
            this.list_data_compra_prod = new System.Windows.Forms.ColumnHeader();
            this.list_data_vencimento_prod = new System.Windows.Forms.ColumnHeader();
            this.data_compra_prod = new System.Windows.Forms.DateTimePicker();
            this.data_vencimento_prod = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.list_codigodebarras = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_desativar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(-859, -291);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(943, 224);
            this.listBox1.TabIndex = 0;
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_alterar.BackgroundImage")));
            this.btn_alterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_alterar.Location = new System.Drawing.Point(1006, 171);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(34, 41);
            this.btn_alterar.TabIndex = 2;
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_filtrar.Location = new System.Drawing.Point(890, 364);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(110, 29);
            this.btn_filtrar.TabIndex = 3;
            this.btn_filtrar.Text = "FILTRAR";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.AutoSize = true;
            this.btn_adicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_adicionar.BackgroundImage")));
            this.btn_adicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_adicionar.Location = new System.Drawing.Point(1006, 124);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(34, 41);
            this.btn_adicionar.TabIndex = 4;
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_excluir.BackgroundImage")));
            this.btn_excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_excluir.Location = new System.Drawing.Point(1006, 218);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(34, 41);
            this.btn_excluir.TabIndex = 5;
            this.btn_excluir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(692, 54);
            this.label1.TabIndex = 6;
            this.label1.Text = "GERENCIADOR DE ESTOQUE";
            // 
            // txt_ID_produto
            // 
            this.txt_ID_produto.Location = new System.Drawing.Point(64, 366);
            this.txt_ID_produto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_ID_produto.Name = "txt_ID_produto";
            this.txt_ID_produto.Size = new System.Drawing.Size(57, 27);
            this.txt_ID_produto.TabIndex = 16;
            // 
            // txt_nome_prod
            // 
            this.txt_nome_prod.Location = new System.Drawing.Point(141, 366);
            this.txt_nome_prod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_nome_prod.Name = "txt_nome_prod";
            this.txt_nome_prod.Size = new System.Drawing.Size(149, 27);
            this.txt_nome_prod.TabIndex = 17;
            // 
            // txt_qtde_produto
            // 
            this.txt_qtde_produto.Location = new System.Drawing.Point(308, 366);
            this.txt_qtde_produto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_qtde_produto.Name = "txt_qtde_produto";
            this.txt_qtde_produto.Size = new System.Drawing.Size(98, 27);
            this.txt_qtde_produto.TabIndex = 18;
            // 
            // listview_prod
            // 
            this.listview_prod.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_id_prod,
            this.list_nome_prod,
            this.list_qtde_prod,
            this.list_data_compra_prod,
            this.list_data_vencimento_prod,
            this.list_codigodebarras});
            this.listview_prod.FullRowSelect = true;
            this.listview_prod.HideSelection = false;
            this.listview_prod.Location = new System.Drawing.Point(64, 124);
            this.listview_prod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listview_prod.MultiSelect = false;
            this.listview_prod.Name = "listview_prod";
            this.listview_prod.Size = new System.Drawing.Size(936, 234);
            this.listview_prod.TabIndex = 22;
            this.listview_prod.UseCompatibleStateImageBehavior = false;
            this.listview_prod.View = System.Windows.Forms.View.Details;
            this.listview_prod.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // list_id_prod
            // 
            this.list_id_prod.Text = "ID";
            // 
            // list_nome_prod
            // 
            this.list_nome_prod.Text = "NOME DO PRODUTO";
            this.list_nome_prod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_nome_prod.Width = 180;
            // 
            // list_qtde_prod
            // 
            this.list_qtde_prod.Text = "QUANTIDADE";
            this.list_qtde_prod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_qtde_prod.Width = 120;
            // 
            // list_data_compra_prod
            // 
            this.list_data_compra_prod.Text = "DATA DE AQUISIÇÃO";
            this.list_data_compra_prod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_data_compra_prod.Width = 200;
            // 
            // list_data_vencimento_prod
            // 
            this.list_data_vencimento_prod.Text = "VENCIMENTO";
            this.list_data_vencimento_prod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_data_vencimento_prod.Width = 200;
            // 
            // data_compra_prod
            // 
            this.data_compra_prod.Location = new System.Drawing.Point(422, 366);
            this.data_compra_prod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data_compra_prod.Name = "data_compra_prod";
            this.data_compra_prod.Size = new System.Drawing.Size(228, 27);
            this.data_compra_prod.TabIndex = 23;
            // 
            // data_vencimento_prod
            // 
            this.data_vencimento_prod.Location = new System.Drawing.Point(656, 366);
            this.data_vencimento_prod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.data_vencimento_prod.Name = "data_vencimento_prod";
            this.data_vencimento_prod.Size = new System.Drawing.Size(228, 27);
            this.data_vencimento_prod.TabIndex = 24;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(64, 448);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(936, 250);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // list_codigodebarras
            // 
            this.list_codigodebarras.Tag = "";
            this.list_codigodebarras.Text = "CÓDIGO DE BARRAS";
            this.list_codigodebarras.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(64, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(280, 41);
            this.label2.TabIndex = 26;
            this.label2.Text = "PRODUTO COMUM";
            // 
            // btn_desativar
            // 
            this.btn_desativar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_desativar.BackgroundImage")));
            this.btn_desativar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_desativar.Location = new System.Drawing.Point(1006, 265);
            this.btn_desativar.Name = "btn_desativar";
            this.btn_desativar.Size = new System.Drawing.Size(34, 40);
            this.btn_desativar.TabIndex = 27;
            this.btn_desativar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1652, 885);
            this.Controls.Add(this.btn_desativar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.data_vencimento_prod);
            this.Controls.Add(this.data_compra_prod);
            this.Controls.Add(this.listview_prod);
            this.Controls.Add(this.txt_qtde_produto);
            this.Controls.Add(this.txt_nome_prod);
            this.Controls.Add(this.txt_ID_produto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ID_produto;
        private System.Windows.Forms.TextBox txt_nome_prod;
        private System.Windows.Forms.TextBox txt_qtde_produto;
        private System.Windows.Forms.ListView listview_prod;
        private System.Windows.Forms.ColumnHeader list_id_prod;
        private System.Windows.Forms.ColumnHeader list_nome_prod;
        private System.Windows.Forms.ColumnHeader list_qtde_prod;
        private System.Windows.Forms.ColumnHeader list_data_compra_prod;
        private System.Windows.Forms.ColumnHeader list_data_vencimento_prod;
        private System.Windows.Forms.DateTimePicker data_compra_prod;
        private System.Windows.Forms.DateTimePicker data_vencimento_prod;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader list_codigodebarras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_desativar;
    }
}

