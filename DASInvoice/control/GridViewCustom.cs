using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DASInvoice.control
{
    public partial class GridViewCustom : DataGridView
    {
        protected override bool ProcessCmdKey(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            int icolumn = this.CurrentCell.ColumnIndex;
            int irow = this.CurrentCell.RowIndex;

            if (keyData == Keys.Enter)
            {
                if (icolumn == this.Columns.Count - 1)
                {
                    this.Rows.Add();
                    this.CurrentCell = this[0, irow + 1];
                }
                else
                {
                    this.CurrentCell = this[icolumn + 1, irow];
                }
                return true;
            }
            else
                return base.ProcessCmdKey(ref msg, keyData);
        }

        public GridViewCustom()
        {
            InitializeComponent();
        }
    }
}
