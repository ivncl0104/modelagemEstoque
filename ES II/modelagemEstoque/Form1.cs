﻿using System;
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
            listview_prod.Items.Add(item);
            txt_ID_produto.Clear();
            txt_nome_prod.Clear();
            txt_qtde_produto.Clear();
            



            
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
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
