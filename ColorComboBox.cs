using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SenhaMVC
{
    public class ColorComboBox : ComboBox
    {
        private Dictionary<int, Color> itemBackColors;

        public ColorComboBox() : base()
        {
            DrawMode = DrawMode.OwnerDrawFixed;
            itemBackColors = new Dictionary<int, Color>();
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            if (e.Index >= 0)
            {
                e.DrawBackground();

                Color backColor = itemBackColors.ContainsKey(e.Index) ? itemBackColors[e.Index] : BackColor;
                Color textColor = ForeColor;

                if(backColor != Color.Black)
                    textColor = Color.Black;

                if (backColor == Color.Black)
                    textColor = Color.White;


                using (Brush backBrush = new SolidBrush(backColor))
                using (Brush textBrush = new SolidBrush(textColor))
                {
                    e.Graphics.FillRectangle(backBrush, e.Bounds);
                    e.Graphics.DrawString(Items[e.Index].ToString(), e.Font, textBrush, e.Bounds.X, e.Bounds.Y);
                }

                e.DrawFocusRectangle();
            }
            else
            {
                base.OnDrawItem(e);
            }
        }

        protected override void OnSelectedIndexChanged(EventArgs e)
        {
            base.OnSelectedIndexChanged(e);

            if (SelectedIndex >= 0 && SelectedIndex < Items.Count)
            {
                Color backColor = itemBackColors.ContainsKey(SelectedIndex) ? itemBackColors[SelectedIndex] : BackColor;

                if (backColor == Color.Black)
                    ForeColor = Color.White;
                else
                    ForeColor = Color.Black;

                BackColor = backColor;
            }
        }

        public void SetItemBackColor(int index, Color backColor)
        {
            itemBackColors[index] = backColor;
            Invalidate();
        }

        public new void ItemsAdd(object item)
        {
            base.Items.Add(item);
            Invalidate();
        }
    }
}
