using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_HTC.Actions
{
    public class DeleteAction : Action
    {
        BindingSource binding;
        object[] data;

        public DeleteAction(BindingSource binding)
        {
            this.binding = binding;
            data = ((DataRowView)binding.Current).Row.ItemArray;
        }

        private int Find()
        {
            for (int i = 0; i < binding.Count; i++)
            {
                DataRowView row = (DataRowView)binding[i];
                if (row.Row.ItemArray.SequenceEqual(data))
                {
                    return i;
                }
            }
            return -1;
        }

        public void Undo()
        {
            binding.AddNew();
            DataRowView row = (DataRowView)binding.Current;
            for (int i = 0; i < data.Length; i++)
            {
                row[i] = data[i];
            }
            binding.EndEdit();
            binding.ResetCurrentItem();
        }

        public void Redo()
        {
            int pos = Find();
            if (pos > -1)
                binding.RemoveAt(pos);
        }
    }
}
