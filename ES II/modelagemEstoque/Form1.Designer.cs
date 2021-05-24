
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.list_freezer = new System.Windows.Forms.ColumnHeader();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 425);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "ALTERAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(56, 425);
            this.btn_adicionar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(106, 32);
            this.btn_adicionar.TabIndex = 4;
            this.btn_adicionar.Text = "ADICIONAR";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(281, 425);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 32);
            this.button4.TabIndex = 5;
            this.button4.Text = "EXCLUIR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(189, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 44);
            this.label1.TabIndex = 6;
            this.label1.Text = "GERENCIADOR DE ESTOQUE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "NOME DO PRODUTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(397, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "DATA DE COMPRA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(304, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "QTDE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(558, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "VENCIMENTO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(189, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(249, 134);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // txt_ID_produto
            // 
            this.txt_ID_produto.Location = new System.Drawing.Point(56, 397);
            this.txt_ID_produto.Name = "txt_ID_produto";
            this.txt_ID_produto.Size = new System.Drawing.Size(70, 23);
            this.txt_ID_produto.TabIndex = 16;
            // 
            // txt_nome_prod
            // 
            this.txt_nome_prod.Location = new System.Drawing.Point(132, 397);
            this.txt_nome_prod.Name = "txt_nome_prod";
            this.txt_nome_prod.Size = new System.Drawing.Size(174, 23);
            this.txt_nome_prod.TabIndex = 17;
            // 
            // txt_qtde_produto
            // 
            this.txt_qtde_produto.Location = new System.Drawing.Point(323, 397);
            this.txt_qtde_produto.Name = "txt_qtde_produto";
            this.txt_qtde_produto.Size = new System.Drawing.Size(86, 23);
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
            this.list_freezer});
            this.listview_prod.FullRowSelect = true;
            this.listview_prod.HideSelection = false;
            this.listview_prod.HoverSelection = true;
            this.listview_prod.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.listview_prod.Location = new System.Drawing.Point(56, 135);
            this.listview_prod.Name = "listview_prod";
            this.listview_prod.Size = new System.Drawing.Size(822, 256);
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
            this.list_nome_prod.Text = "Nome";
            this.list_nome_prod.Width = 180;
            // 
            // list_qtde_prod
            // 
            this.list_qtde_prod.Text = "Quantidade";
            this.list_qtde_prod.Width = 120;
            // 
            // list_data_compra_prod
            // 
            this.list_data_compra_prod.Text = "Data de Compra";
            this.list_data_compra_prod.Width = 200;
            // 
            // list_data_vencimento_prod
            // 
            this.list_data_vencimento_prod.Text = "Data de vencimento";
            this.list_data_vencimento_prod.Width = 200;
            // 
            // data_compra_prod
            // 
            this.data_compra_prod.Location = new System.Drawing.Point(415, 397);
            this.data_compra_prod.Name = "data_compra_prod";
            this.data_compra_prod.Size = new System.Drawing.Size(200, 23);
            this.data_compra_prod.TabIndex = 23;
            // 
            // data_vencimento_prod
            // 
            this.data_vencimento_prod.Location = new System.Drawing.Point(621, 397);
            this.data_vencimento_prod.Name = "data_vencimento_prod";
            this.data_vencimento_prod.Size = new System.Drawing.Size(200, 23);
            this.data_vencimento_prod.TabIndex = 24;
            // 
            // list_freezer
            // 
            this.list_freezer.Text = "Freezer";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(841, 400);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 19);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Freezer";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1391, 629);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.data_vencimento_prod);
            this.Controls.Add(this.data_compra_prod);
            this.Controls.Add(this.listview_prod);
            this.Controls.Add(this.txt_qtde_produto);
            this.Controls.Add(this.txt_nome_prod);
            this.Controls.Add(this.txt_ID_produto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
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
        private System.Windows.Forms.ColumnHeader list_freezer;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

