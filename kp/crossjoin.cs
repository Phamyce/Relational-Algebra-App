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
    public partial class crossjoin : Form
    {
        List<DataGridView> dgw = new List<DataGridView>();
        List<int> cb = new List<int>();

        public crossjoin(List<DataGridView> dgww)
        {
            InitializeComponent();
            dgw = dgww;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void crossjoin_Load(object sender, EventArgs e)
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

        private string crossjoinName_create()
        {
            string crossjoin_name = "";
            for (int i = 0; i < cb.Count; i++)
            {
                crossjoin_name += dgw[cb[i]].Name;
                if (cb.Count - i != 1)
                {
                    crossjoin_name += " × ";
                }
            }
            return crossjoin_name;
        }

        public string get_crossjoinName()
        {
            return this.crossjoinName_create();
        }
        
        private DataTable crossjoinQuery()
        {
            //проверить чтобы не было одинаковых атрибутов
            //...
            DataTable dt_res = new DataTable();
            if (cb.Count == 2)
            {
                DataTable dtA = (DataTable)dgw[cb[0]].DataSource;
                DataTable dtB = (DataTable)dgw[cb[1]].DataSource;
                var result = from dt1 in dtA.AsEnumerable() from dt2 in dtB.AsEnumerable() select new { dt1, dt2 };
                foreach (DataColumn col in dtA.Columns)
                {
                    dt_res.Columns.Add(col.ColumnName, typeof(object));
                }
                foreach (DataColumn col in dtB.Columns)
                {
                    dt_res.Columns.Add(col.ColumnName, typeof(object));
                }
                foreach (var row in result)
                {
                    var newRow = dt_res.NewRow();
                    newRow.ItemArray = row.dt1.ItemArray.Union(row.dt2.ItemArray).ToArray();
                    dt_res.Rows.Add(newRow);
                }
            }
            return dt_res;
        }

        public DataTable get_DataTable()
        {
            return this.crossjoinQuery();
        }
    }
}
