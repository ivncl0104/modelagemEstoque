using System;
using System.IO;
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
            if (ativo_check.Checked)
                item.SubItems.Add("Sim");
            else
                item.SubItems.Add("Não");
            listview_prod.Items.Add(item);
            txt_ID_produto.Clear();
            txt_nome_prod.Clear();
            txt_qtde_produto.Clear();
            checkBox1.Checked = false;
            ativo_check.Checked = false;








        }

        private void button1_Click(object sender, EventArgs e)
        {
            //altera o produto selecionado
            if (txt_ID_produto.Text != "")
            {
                listview_prod.SelectedItems[0].SubItems[0].Text = (txt_ID_produto.Text);
            }
            if (txt_nome_prod.Text != "")
            {
                listview_prod.SelectedItems[0].SubItems[1].Text = (txt_nome_prod.Text);
            }
            if (txt_qtde_produto.Text != "")
            {
                listview_prod.SelectedItems[0].SubItems[2].Text = (txt_qtde_produto.Text);
            }
            listview_prod.SelectedItems[0].SubItems[3].Text = (data_compra_prod.Value.ToString("D"));
            listview_prod.SelectedItems[0].SubItems[4].Text = (data_vencimento_prod.Value.ToString("D"));
            if (checkBox1.Checked)
                listview_prod.SelectedItems[0].SubItems[5].Text = ("Sim");
            else
                listview_prod.SelectedItems[0].SubItems[5].Text = ("Não");
            if (ativo_check.Checked)
                listview_prod.SelectedItems[0].SubItems[6].Text = ("Sim");
            else
                listview_prod.SelectedItems[0].SubItems[6].Text = ("Não");
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

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            listview_prod.Items.RemoveAt(listview_prod.SelectedIndices[0]);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private async void btn_exportar_Click(object sender, EventArgs e)
        {
            //salvar
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Text Documents | *.txt ", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (TextWriter tw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create), Encoding.UTF8))
                    {
                        await tw.WriteLineAsync("#ID \t#Nome \t\t#Quantidade \t#Data Aquisição \t\t\t\t#Data Validade \t\t\t#Freezer  #Ativo ");
                        foreach (ListViewItem item in listview_prod.Items)
                        {
                            await tw.WriteLineAsync("#" + item.SubItems[0].Text + " \t#" + item.SubItems[1].Text + " \t#" + item.SubItems[2].Text+ " \t\t#" + item.SubItems[3].Text + " \t#" + item.SubItems[4].Text + " \t#" + item.SubItems[5].Text + " \t#" + item.SubItems[6].Text); 
                        }
                        MessageBox.Show("Salvo com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
        
    

