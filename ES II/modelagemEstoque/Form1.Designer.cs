
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
            this.freezer = new System.Windows.Forms.ColumnHeader();
            this.data_compra_prod = new System.Windows.Forms.DateTimePicker();
            this.data_vencimento_prod = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_exportar = new System.Windows.Forms.Button();
            this.ativo = new System.Windows.Forms.ColumnHeader();
            this.ativo_check = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(-752, -218);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(826, 169);
            this.listBox1.TabIndex = 0;
            // 
            // btn_alterar
            // 
            this.btn_alterar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_alterar.BackgroundImage")));
            this.btn_alterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_alterar.Location = new System.Drawing.Point(901, 445);
            this.btn_alterar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(30, 31);
            this.btn_alterar.TabIndex = 2;
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.AutoSize = true;
            this.btn_adicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_adicionar.BackgroundImage")));
            this.btn_adicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_adicionar.Location = new System.Drawing.Point(829, 446);
            this.btn_adicionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(30, 31);
            this.btn_adicionar.TabIndex = 4;
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_excluir.BackgroundImage")));
            this.btn_excluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_excluir.Location = new System.Drawing.Point(865, 444);
            this.btn_excluir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(30, 31);
            this.btn_excluir.TabIndex = 5;
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(495, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "Amanita 🍄 ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ID_produto
            // 
            this.txt_ID_produto.Location = new System.Drawing.Point(56, 449);
            this.txt_ID_produto.Name = "txt_ID_produto";
            this.txt_ID_produto.Size = new System.Drawing.Size(50, 21);
            this.txt_ID_produto.TabIndex = 16;
            // 
            // txt_nome_prod
            // 
            this.txt_nome_prod.Location = new System.Drawing.Point(111, 449);
            this.txt_nome_prod.Name = "txt_nome_prod";
            this.txt_nome_prod.Size = new System.Drawing.Size(131, 21);
            this.txt_nome_prod.TabIndex = 17;
            // 
            // txt_qtde_produto
            // 
            this.txt_qtde_produto.Location = new System.Drawing.Point(247, 449);
            this.txt_qtde_produto.Name = "txt_qtde_produto";
            this.txt_qtde_produto.Size = new System.Drawing.Size(86, 21);
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
            this.freezer,
            this.ativo});
            this.listview_prod.FullRowSelect = true;
            this.listview_prod.HideSelection = false;
            this.listview_prod.Location = new System.Drawing.Point(56, 93);
            this.listview_prod.MultiSelect = false;
            this.listview_prod.Name = "listview_prod";
            this.listview_prod.Size = new System.Drawing.Size(1194, 254);
            this.listview_prod.TabIndex = 22;
            this.listview_prod.UseCompatibleStateImageBehavior = false;
            this.listview_prod.View = System.Windows.Forms.View.Details;
            this.listview_prod.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // list_id_prod
            // 
            this.list_id_prod.Text = "ID";
            this.list_id_prod.Width = 80;
            // 
            // list_nome_prod
            // 
            this.list_nome_prod.Text = "NOME DO PRODUTO";
            this.list_nome_prod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_nome_prod.Width = 300;
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
            this.list_data_compra_prod.Width = 250;
            // 
            // list_data_vencimento_prod
            // 
            this.list_data_vencimento_prod.Text = "VENCIMENTO";
            this.list_data_vencimento_prod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.list_data_vencimento_prod.Width = 250;
            // 
            // freezer
            // 
            this.freezer.Text = "FREEZER";
            this.freezer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.freezer.Width = 90;
            // 
            // data_compra_prod
            // 
            this.data_compra_prod.Location = new System.Drawing.Point(338, 449);
            this.data_compra_prod.Name = "data_compra_prod";
            this.data_compra_prod.Size = new System.Drawing.Size(200, 21);
            this.data_compra_prod.TabIndex = 23;
            // 
            // data_vencimento_prod
            // 
            this.data_vencimento_prod.Location = new System.Drawing.Point(544, 450);
            this.data_vencimento_prod.Name = "data_vencimento_prod";
            this.data_vencimento_prod.Size = new System.Drawing.Size(200, 21);
            this.data_vencimento_prod.TabIndex = 24;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBox1.Location = new System.Drawing.Point(761, 452);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 19);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Freezer";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Nome";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 431);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 33;
            this.label4.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(339, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "Data de Aquisição";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 35;
            this.label6.Text = "Data de Validade";
            // 
            // btn_exportar
            // 
            this.btn_exportar.Location = new System.Drawing.Point(963, 450);
            this.btn_exportar.Name = "btn_exportar";
            this.btn_exportar.Size = new System.Drawing.Size(125, 27);
            this.btn_exportar.TabIndex = 37;
            this.btn_exportar.Text = "Exportar";
            this.btn_exportar.UseVisualStyleBackColor = true;
            this.btn_exportar.Click += new System.EventHandler(this.btn_exportar_Click);
            // 
            // ativo
            // 
            this.ativo.Text = "ATIVO?";
            this.ativo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ativo.Width = 90;
            // 
            // ativo_check
            // 
            this.ativo_check.AutoSize = true;
            this.ativo_check.Location = new System.Drawing.Point(761, 482);
            this.ativo_check.Name = "ativo_check";
            this.ativo_check.Size = new System.Drawing.Size(54, 19);
            this.ativo_check.TabIndex = 38;
            this.ativo_check.Text = "Ativo";
            this.ativo_check.UseVisualStyleBackColor = true;
            this.ativo_check.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1446, 664);
            this.Controls.Add(this.ativo_check);
            this.Controls.Add(this.btn_exportar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.data_vencimento_prod);
            this.Controls.Add(this.data_compra_prod);
            this.Controls.Add(this.listview_prod);
            this.Controls.Add(this.txt_qtde_produto);
            this.Controls.Add(this.txt_nome_prod);
            this.Controls.Add(this.txt_ID_produto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Amanita 🍄";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_alterar;
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
        private System.Windows.Forms.ColumnHeader freezer;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_exportar;
        private System.Windows.Forms.ColumnHeader ativo;
        private System.Windows.Forms.CheckBox ativo_check;
    }
}

