using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_HTC.Actions
{
    public static class Finder
    {
        public static int Find(this BindingSource source, params Key[] keys)
        {
            PropertyDescriptor[] properties = new PropertyDescriptor[keys.Length];

            ITypedList typedList = source as ITypedList;

            if (source.Count <= 0) return -1;

            PropertyDescriptorCollection props;

            if (typedList != null) // obtain the PropertyDescriptors from the list
            {
                props = typedList.GetItemProperties(null);
            }
            else // use the TypeDescriptor on the first element of the list
            {
                props = TypeDescriptor.GetProperties(source[0]);
            }

            for (int i = 0; i < keys.Length; i++)
            {
                properties[i] = props.Find(keys[i].PropertyName, true); // will throw if the property isn't found
            }

            for (int i = 0; i < source.Count; i++)
            {
                object row = source[i];
                bool match = true;

                for (int p = 0; p < keys.Length; p++)
                {
                    if (properties[p].GetValue(row).ToString() != keys[p].Value.ToString())
                    {
                        match = false;
                        break;
                    }
                }
                if (match) return i;
            }

            return -1;
        }
    }
}
