using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public class Current_Theme
    {
        private static bool IsDarkModeActive;


        private static void SetPanel(Control component)
        {
            if (component.HasChildren)
            {
                foreach (var item in component.Controls.OfType<GroupBox>())
                {
                    SetPanel(item);
                }
            }
            var textBoxes = component.Controls.OfType<TextBox>();
            foreach (var item in textBoxes)
            {
                Panel panel = new Panel();
                panel.Location = new Point(item.Location.X, item.Location.Y + item.Size.Height);
                panel.Size = new Size(item.Width, 1);
                panel.Visible = true;
                panel.AutoSize = true;
                component.Controls.Add(panel);
            }
        }
        public static void SwitchCurrentTheme(Control component)
        {
            if (IsDarkModeActive)
            {
                IsDarkModeActive = false;
            }
            else
            {
                IsDarkModeActive = true;
            }
            if (component.HasChildren)
            {
                SetCurrentTheme(component);
            }
        }
        public static void SetCurrentTheme(Control component)
        {
            SetPanel(component);

            if (component.HasChildren)
            {
                foreach (Control item in component.Controls)
                {
                    SetCurrentTheme(item);
                }
            }
            if (component is Form)
            {
                if (!IsDarkModeActive)
                {
                    component.BackColor = Color.White;
                }
                else
                {
                    component.BackColor = Color.FromArgb(11, 11, 11);
                }
            }
            else if (component is Label || component is GroupBox || component is ToolStrip)
            {
                component.BackColor = Color.Transparent;
                if (!IsDarkModeActive)
                {
                    component.ForeColor = Color.Black;
                    if (component.Name == "Lbl_Error")
                    {
                        component.ForeColor = Color.FromArgb(207, 102, 121);
                    }
                    if (component.Name == "Lbl_Report")
                    {
                        component.ForeColor = Color.Lime;
                    }
                    if (component is ToolStrip)
                    {
                        ToolStrip tsp = (ToolStrip)component;
                        foreach (ToolStripItem item in tsp.Items)
                        {
                            if (item is ToolStripMenuItem)
                            {
                                ToolStripMenuItem dpd = (ToolStripMenuItem)item;
                                foreach (ToolStripItem itemChildren in dpd.DropDown.Items)
                                {
                                    ToolStripMenuItem dpdChildren = (ToolStripMenuItem)itemChildren;
                                    foreach (ToolStripItem itemGrandChildren in dpdChildren.DropDown.Items)
                                    {
                                        itemGrandChildren.ForeColor = Color.Black;
                                        itemGrandChildren.BackColor = Color.FromArgb(240, 240, 240);
                                    }
                                    itemChildren.ForeColor = Color.Black;
                                    itemChildren.BackColor = Color.FromArgb(240, 240, 240);
                                }
                                item.ForeColor = Color.Black;
                                item.BackColor = Color.FromArgb(233, 221, 255);
                            }
                            
                            item.ForeColor = Color.Black;
                            item.BackColor = Color.FromArgb(233, 221, 255);
                        }
                    }
                }
                else
                {
                    component.ForeColor = Color.White;
                    if (component.Name == "Lbl_Error")
                    {
                        component.ForeColor = Color.Red;
                    }
                    if (component.Name == "Lbl_Report")
                    {
                        component.ForeColor = Color.Lime;
                    }
                    if (component is ToolStrip)
                    {
                        ToolStrip tsp = (ToolStrip)component;
                        foreach (ToolStripItem item in tsp.Items)
                        {
                            if (item is ToolStripMenuItem)
                            {
                                ToolStripMenuItem dpd = (ToolStripMenuItem)item;
                                foreach (ToolStripItem itemChildren in dpd.DropDown.Items)
                                {
                                    ToolStripMenuItem dpdChildren = (ToolStripMenuItem)itemChildren;
                                    foreach (ToolStripItem itemGrandChildren in dpdChildren.DropDown.Items)
                                    {
                                        itemGrandChildren.ForeColor = Color.White;
                                        itemGrandChildren.BackColor = Color.FromArgb(18, 18, 18);
                                    }
                                    itemChildren.ForeColor = Color.White;
                                    itemChildren.BackColor = Color.FromArgb(18, 18, 18);
                                }
                                item.ForeColor = Color.White;
                                item.BackColor = Color.FromArgb(30, 30, 30);
                            }
                            item.ForeColor = Color.White;
                            item.BackColor = Color.FromArgb(30, 30, 30);
                        }
                    }
                }
            }
            else if (component is TextBox || component is DataGridView)
            {
                if (!IsDarkModeActive)
                {
                    component.BackColor = Color.White;
                    component.ForeColor = Color.Black;
                    if (component is TextBox)
                    {
                        TextBox t = (TextBox)component;
                        t.BorderStyle = BorderStyle.None;
                    }

                    if (component is DataGridView)
                    {
                        DataGridView g = (DataGridView)component;
                        g.BorderStyle = BorderStyle.None;
                        g.GridColor = Color.FromArgb(98, 0, 238);
                        g.BackgroundColor = Color.FromArgb(233, 221, 255);
                        g.ForeColor = Color.Black;
                    }
                }
                else
                {
                    component.BackColor = Color.FromArgb(20,20,20);
                    component.ForeColor = Color.White;
                    if (component is TextBox)
                    {
                        TextBox t = (TextBox)component;
                        t.BorderStyle = BorderStyle.None;
                    }

                    if (component is DataGridView)
                    {
                        DataGridView g = (DataGridView)component;
                        g.BorderStyle = BorderStyle.None;
                        g.GridColor = Color.FromArgb(20, 20, 20);
                        g.BackgroundColor = Color.FromArgb(20, 20, 20);
                        g.ForeColor = Color.Black;
                    }
                }
            }
            else if (component is Button)
            {
                Button button = (Button)component;
                button.FlatStyle = FlatStyle.Popup;
                if (!IsDarkModeActive)
                {
                    component.BackColor = Color.FromArgb(187, 134, 252);
                    component.ForeColor = Color.Black;
                }
                else
                {
                    component.BackColor = Color.FromArgb(98, 0, 238);
                    component.ForeColor = Color.White;
                }
            }
            else if (component is Panel)
            {
                if (!IsDarkModeActive)
                {
                    component.BackColor = Color.FromArgb(233, 221, 255);
                }
                else
                {
                    component.BackColor = Color.FromArgb(30, 30, 30);
                }
            }
        }
    }
}
