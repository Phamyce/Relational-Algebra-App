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
    public partial class naturaljoin : Form
    {
        List<DataGridView> dgw = new List<DataGridView>();
        List<int> cb = new List<int>();
        string commonColumn = "";
        public naturaljoin(List<DataGridView> dgww)
        {
            InitializeComponent();
            dgw = dgww;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void naturaljoin_Load(object sender, EventArgs e)
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
                List<string> temp1 = new List<string>();
                List<string> temp2 = new List<string>();
                for (int i = 0; i < dgw[0].ColumnCount; i++)
                {
                    temp1.Add(dgw[0].Columns[i].Name);
                }
                for (int i = 0; i < dgw[1].ColumnCount; i++)
                {
                    temp2.Add(dgw[1].Columns[i].Name);
                }
                temp1.ToArray();
                temp2.ToArray();
                var c = temp1.Intersect(temp2);
                commonColumn = string.Join("", c);
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

        private string naturaljoinName_create()
        {
            string naturaljoin_name = "";
            for (int i = 0; i < cb.Count; i++)
            {
                naturaljoin_name += dgw[cb[i]].Name;
                if (cb.Count - i != 1)
                {
                    naturaljoin_name += " ⨝ ";
                }
            }
            return naturaljoin_name;
        }

        public string get_naturaljoinName()
        {
            return this.naturaljoinName_create();
        }

        private DataTable naturaljoinQuery()
        {
            DataTable dt_res = new DataTable();
            if (cb.Count == 2)
            {
                DataTable dtA = (DataTable)dgw[cb[0]].DataSource;
                DataTable dtB = (DataTable)dgw[cb[1]].DataSource;
                var result = from dt1 in dtA.AsEnumerable()
                             join dt2 in dtB.AsEnumerable() on dt1[commonColumn] equals dt2[commonColumn]
                             select new { dt1, dt2 };

                foreach (DataColumn col in dtA.Columns)
                {
                    dt_res.Columns.Add(col.ColumnName, typeof(object));
                }

                foreach (DataColumn col in dtB.Columns)
                {
                    if (!(col.ColumnName.Equals(commonColumn)))
                    {
                        dt_res.Columns.Add(col.ColumnName, typeof(object));
                    }
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
            return this.naturaljoinQuery();
        }
    }
}
