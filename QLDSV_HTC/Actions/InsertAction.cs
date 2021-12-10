using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLDSV_HTC.Actions
{
    public class InsertAction : Action
    {
        BindingSource binding;
        object[] data;

        public InsertAction(BindingSource binding)
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
            int pos = Find();
            if (pos > -1)
                binding.RemoveAt(pos);
        }

        public void Redo()
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
    }
}
