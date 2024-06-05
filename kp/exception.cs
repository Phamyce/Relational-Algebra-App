using System;
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
    public partial class exception : Form
    {
        List<DataGridView> dgw = new List<DataGridView>();
        List<int> cb = new List<int>();
        public exception(List<DataGridView> dgww)
        {
            InitializeComponent();
            dgw = dgww;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void exception_Load(object sender, EventArgs e)
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
        public List<int> get_arg()
        {
            return this.cb;
        }

        private void checkedListBox_tables_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_tables.ForeColor = SystemColors.ControlText;
        }

        private string exceptionName_create()
        {
            string exception_name = "";
            for (int i = 0; i < cb.Count; i++)
            {
                exception_name += dgw[cb[i]].Name;
                if (cb.Count - i != 1)
                {
                    exception_name += " − ";
                }
            }
            return exception_name;
        }
        
        public string get_exceptionName()
        {
            return this.exceptionName_create();
        }

        private DataTable exceptionQuery()
        {
            DataTable dt_res = new DataTable();
            if (cb.Count == 2)
            {
                DataTable dtA = (DataTable)dgw[cb[0]].DataSource;
                DataTable dtB = (DataTable)dgw[cb[1]].DataSource;
                dt_res = dtA.AsEnumerable().Except(dtB.AsEnumerable(), DataRowComparer.Default).CopyToDataTable();
            }
            return dt_res;
        }

        public DataTable get_DataTable()
        {
            return this.exceptionQuery();
        }
    }
}
