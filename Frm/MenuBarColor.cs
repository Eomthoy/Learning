using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Frm
{
    class MenuBarColor : ProfessionalColorTable
    {
        Color ManuBarCommonColor = Color.SlateGray;
        Color SelectedHighlightColor = Color.BurlyWood;
        Color MenuBorderColor = Color.DimGray;
        Color MenuItemBorderColor = Color.DimGray;
        /// <summary> 
        /// Initialize a new instance of the Visual Studio MenuBarColor class. 
        /// </summary> 
        public MenuBarColor()
        {
        }
        #region
        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return ManuBarCommonColor;
            }
        }
        public override Color MenuItemPressedGradientEnd
        {
            get
            {
                return ManuBarCommonColor;
            }
        }
        public override Color MenuItemPressedGradientMiddle
        {
            get
            {
                return ManuBarCommonColor;
            }
        }
        public override Color ButtonSelectedHighlight
        {
            get
            {
                return ManuBarCommonColor;
            }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return ManuBarCommonColor;
            }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return ManuBarCommonColor;
            }
        }
        public override Color MenuBorder
        {
            get
            {
                return MenuBorderColor;
            }
        }
        public override Color MenuItemBorder
        {
            get
            {
                return MenuItemBorderColor;
            }
        }
        #endregion
    }
    class MenuItemRenderer : ToolStripProfessionalRenderer
    {
        //Font textFont = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        private Color menuItemSelectedColor { get; set; }
        private Color menuItemBorderColor { get; set; }
        /// <summary> 
        /// Initialize a new instance of the Visual Studio MenuBarRenderer class. 
        /// </summary> 
        public MenuItemRenderer()
        : base(new MenuBarColor())
        {
            this.menuItemBorderColor = Color.FromArgb(24, 144, 255);
            this.menuItemSelectedColor = Color.White;
        }
        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            if (e.Item.IsOnDropDown)
            {
                if (e.Item.Selected)
                {
                    e.TextColor = Color.FromArgb(24, 144, 255);
                }
                else
                {
                    e.TextColor = Color.Black;
                }
            }
            base.OnRenderItemText(e);
        }
        #region Backgrounds
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item.IsOnDropDown)
            {
                if (e.Item.Selected == true && e.Item.Enabled)
                {
                    DrawMenuDropDownItemHighlight(e);
                }
            }
            else
            {
                base.OnRenderMenuItemBackground(e);
            }
        }
        #endregion
        #region DrawMenuDropDownItemHighlight
        private void DrawMenuDropDownItemHighlight(ToolStripItemRenderEventArgs e)
        {
            Rectangle rect = new Rectangle();
            rect = new Rectangle(2, 0, (int)e.Graphics.VisibleClipBounds.Width - 4, (int)e.Graphics.VisibleClipBounds.Height - 1);
            using (SolidBrush brush = new SolidBrush(menuItemSelectedColor))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
            using (Pen pen = new Pen(menuItemBorderColor))
            {
                e.Graphics.DrawRectangle(pen, rect);
            }
        }
        #endregion
    }
}
