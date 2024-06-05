using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace kp
{
    public partial class selection : Form
    {
        List<DataGridView> dgw = new List<DataGridView>();
        int cb = 0;
        string tb = "";

        public selection(List<DataGridView> dgww)
        {
            InitializeComponent();
            dgw = dgww;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void selection_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dgw.Count; i++)
            {
                comboBox_tables.Items.Add(dgw[i].Name);
            }
            textBox_condition.Enabled = false;
        }

        private void comboBox_tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox tables = (ComboBox)sender;
            int resultIndex = comboBox_tables.SelectedIndex;
            if (resultIndex != -1)
            {
                label_tables.ForeColor = SystemColors.ControlText;
                textBox_condition.Enabled = true;
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            cb = comboBox_tables.SelectedIndex;
            tb = textBox_condition.Text;

            if (cb != -1 && tb != "")
            {
                string pattern = "(and|or|<|>|<=|>=|=|!=)";
                if (Regex.IsMatch(tb, pattern) == false)
                {
                    MessageBox.Show("Условие неверно");
                }

                else
                {
                    this.Close();
                }
            }
            else if (cb == -1)
            {
                label_tables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            }
            else if (tb == "")
            {
                label_condition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            }
        }

        private string selectionName_create()
        {
            string selection_name = "σ ";
            selection_name += tb;
            selection_name += " ";
            selection_name += "(";
            selection_name += dgw[cb].Name;
            selection_name += ")";
            return selection_name;
        }

        public string get_selectionName()
        {
            return this.selectionName_create();
        }

        private DataTable selectionQuery()
        {
            DataTable dt_res = new DataTable();
            if (cb != -1 && tb != "")
            {
                DataTable dt = (DataTable)dgw[cb].DataSource;

                foreach (DataColumn col in dt.Columns)
                {
                    dt_res.Columns.Add(col.ColumnName, typeof(object));
                }

                var result = dt.Select(tb);

                foreach (var row in result)
                {
                    var newRow = dt_res.NewRow();
                    newRow.ItemArray = row.ItemArray.ToArray();
                    dt_res.Rows.Add(newRow);
                }
            }
            return dt_res;
        }

        public DataTable get_DataTable()
        {
            return this.selectionQuery();
        }

        private void textBox_condition_TextChanged(object sender, EventArgs e)
        {
            label_condition.ForeColor = SystemColors.ControlText;
        }
    }
}
