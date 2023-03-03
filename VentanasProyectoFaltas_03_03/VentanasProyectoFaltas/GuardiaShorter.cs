using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanasProyectoFaltas
{
    public class GuardiaShorter : IComparer
    {
        private int ColumnToSort;
        private SortOrder OrderOfSort;
        private CaseInsensitiveComparer ObjectCompare;

        public GuardiaShorter()
        {
            ColumnToSort = 0;

            OrderOfSort = SortOrder.None;
           
            ObjectCompare = new CaseInsensitiveComparer();
        }

        public int Compare(object x, object y)
        {
            int compareResult;
            ListViewItem listviewX, listviewY;
        
            listviewX = (ListViewItem)x;
            listviewY = (ListViewItem)y;

            compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text, listviewY.SubItems[ColumnToSort].Text);
           
           
                switch(OrderOfSort)
            {
                case SortOrder.Ascending:
                    return compareResult;
                case SortOrder.Descending:
                    return (-compareResult);
                default: return 0;
            }
           
        }

        public SortOrder Order
        {
            set
            {
                OrderOfSort = value;
            }
            get
            {
                return OrderOfSort;
            }
        }
    }
}
