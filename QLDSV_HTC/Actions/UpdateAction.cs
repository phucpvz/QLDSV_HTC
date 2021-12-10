using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_HTC.Actions
{
    public class UpdateAction : Action
    {
        BindingSource binding;
        object[] oldData;
        object[] newData;

        public UpdateAction(BindingSource binding, object[] oldData, object[] newData)
        {
            this.binding = binding;
            this.oldData = oldData;
            this.newData = newData;
        }

        private int Find(object[] data)
        {
            string key = data[0].ToString();
            for (int i = 0; i < binding.Count; i++)
            {
                DataRowView row = (DataRowView)binding[i];
                if (row.Row.ItemArray[0].ToString() == key)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Undo()
        {
            int pos = Find(newData);
            if (pos > -1)
            {
                DataRowView row = (DataRowView)binding[pos];
                DataTable t = row.Row.Table;
                for (int i = 0; i < newData.Length; i++)
                {
                    if (t.Columns[i].ReadOnly) continue;
                    row[i] = oldData[i];
                }
                binding.EndEdit();
                binding.ResetCurrentItem();
            }
        }

        public void Redo()
        {
            int pos = Find(oldData);
            if (pos > -1)
            {
                DataRowView row = (DataRowView)binding[pos];
                DataTable t = row.Row.Table;
                for (int i = 0; i < oldData.Length; i++)
                {
                    if (t.Columns[i].ReadOnly) continue;
                    row[i] = newData[i];
                }
                binding.EndEdit();
                binding.ResetCurrentItem();
            }
        }
    }
}
