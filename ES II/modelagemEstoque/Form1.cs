using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modelagemEstoque
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ID_produto.Text))
                return;
            ListViewItem item = new ListViewItem(txt_ID_produto.Text);
            item.SubItems.Add(txt_nome_prod.Text);
            item.SubItems.Add(txt_qtde_produto.Text);
            item.SubItems.Add(data_compra_prod.Value.ToString("D"));
            item.SubItems.Add(data_vencimento_prod.Value.ToString("D"));
            if (checkBox1.Checked)
                item.SubItems.Add("Sim");
            else
                item.SubItems.Add("Não");
            listview_prod.Items.Add(item);
            txt_ID_produto.Clear();
            txt_nome_prod.Clear();
            txt_qtde_produto.Clear();
            checkBox1.Checked = false;








        }

        private void button1_Click(object sender, EventArgs e)
        {
            //altera o produto selecionado
            listview_prod.SelectedItems[0].SubItems[0].Text = (txt_ID_produto.Text);
            listview_prod.SelectedItems[0].SubItems[1].Text = (txt_nome_prod.Text);
            listview_prod.SelectedItems[0].SubItems[2].Text = (txt_qtde_produto.Text);
            listview_prod.SelectedItems[0].SubItems[3].Text = (data_compra_prod.Value.ToString("D"));
            listview_prod.SelectedItems[0].SubItems[4].Text = (data_vencimento_prod.Value.ToString("D"));
            if (checkBox1.Checked)
                listview_prod.SelectedItems[0].SubItems[5].Text = ("Sim");
            else
                listview_prod.SelectedItems[0].SubItems[5].Text = ("Não");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
