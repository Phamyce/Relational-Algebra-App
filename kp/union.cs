﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kp
{
    public partial class union : Form
    {
        List<DataGridView> dgw = new List<DataGridView>();
        List<int> cb = new List<int>();
        public union(List<DataGridView> dgww)
        {
            InitializeComponent();
            dgw = dgww;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void binaryOperation_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dgw.Count; i++)
            {
                checkedListBox_tables.Items.Add(dgw[i].Name);
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            if (checkedListBox_tables.CheckedIndices.Count == 2)
            {
                for (int i = 0; i < checkedListBox_tables.CheckedIndices.Count; i++)
                {
                    cb.Add(checkedListBox_tables.CheckedIndices[i]);
                }
                this.Close();
            }
            else if (checkedListBox_tables.CheckedIndices.Count == 0 || checkedListBox_tables.CheckedIndices.Count > 2)
            {
                label_tables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            }
        }

        private void checkedListBox_tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_tables.ForeColor = SystemColors.ControlText;
        }

        private string unionName_create()
        {
            string union_name = "";
            for (int i = 0; i < cb.Count; i++)
            {
                union_name += dgw[cb[i]].Name;
                if (cb.Count - i != 1)
                {
                    union_name += " ∪ ";
                }
            }
            return union_name;
        }

        public string get_unionName()
        {
            return this.unionName_create();
        }

        private DataTable unionQuery()
        {
            DataTable dt_res = new DataTable();
            if (cb.Count == 2)
            {
                DataTable dtA = (DataTable)dgw[cb[0]].DataSource;
                DataTable dtB = (DataTable)dgw[cb[1]].DataSource;
                dt_res = dtA.AsEnumerable().Union(dtB.AsEnumerable(), DataRowComparer.Default).CopyToDataTable();
            }
            return dt_res;
        }

        public DataTable get_DataTable()
        {
            return this.unionQuery();
        }
    }
}
