﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSimulator
{
    public partial class Form_Kitchen : Form
    {
        Form_Customer form_customer;
        RichTextBox text_table;
        RichTextBox text_bill;
        Dictionary<string, List<string>> order;
        public Form_Kitchen(Form_Customer form_customer, RichTextBox text_table, RichTextBox text_bill, Dictionary<string, List<string>> order)
        {
            InitializeComponent();
            this.form_customer = form_customer;
            this.text_table = text_table;
            this.text_bill = text_bill;
            this.order = order;
        }
        
        //public Form_Kitchen()
        //{
        //
        //}

        private void EditRecipe(object sender, EventArgs e)
        {
            new Form_Recipe().Show();
        }

        private void Serve(object sender, EventArgs e)
        {
            text_table.Text += text_holding.Text + "\n";
            //text_bill.Text += 
        }

        private void MakeDish(object sender, EventArgs e)
        {
            new Form_MakeDish().Show();
        }
    }
}
