using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace QLDSV_HTC.Actions
{
    public class InsertAction : Action
    {
        BindingSource binding;
        object[] data;
        bool ignoreFirstColumn;

        public InsertAction(BindingSource binding, bool ignoreFirstColumn = false) 
        {
            this.binding = binding;
            data = ((DataRowView)binding.Current).Row.ItemArray;
            this.ignoreFirstColumn = ignoreFirstColumn;
        }

        private int Find()
        {
            for (int i = 0; i < binding.Count; i++)
            {
                DataRowView row = (DataRowView)binding[i];
                object[] r = row.Row.ItemArray;
                int startIndex = ignoreFirstColumn ? 1 : 0;
                bool isEqual = true;
                for (int j = startIndex; j < data.Length; j++)
                {
                    if (r[j].ToString() != data[j].ToString())
                    {
                        isEqual = false;
                        break;
                    }
                }
                if (isEqual) return i;
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
            int startIndex = ignoreFirstColumn ? 1 : 0;
            for (int i = startIndex; i < data.Length; i++)
            {
                row[i] = data[i];
            }
            binding.EndEdit();
            binding.ResetCurrentItem();
        }
    }
}
