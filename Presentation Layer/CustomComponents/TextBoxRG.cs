using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class TextBoxRG : TextBox
    {
        private int _maxLength = 12;
        public TextBoxRG()
        {
            InitializeComponent();
            this.MaxLength = this._maxLength;
        }

        public TextBoxRG(IContainer container)
        {
            container.Add(this);
            InitializeComponent();

        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            bool isControl = char.IsControl(e.KeyChar);
            if (!char.IsDigit(e.KeyChar) && !isControl)
            {
                e.Handled = true;
            }
            int firstPoint = 2;
            int secondPoint = 6;
            int hyphen = 10;
            if (!isControl)
            {
                if (this.Text.Length == firstPoint || this.Text.Length == secondPoint)
                {
                    this.Text += ".";
                }
                if (this.Text.Length == hyphen)
                {
                    this.Text += "-";
                }
            }
            this.SelectionStart = this.TextLength;
            base.OnKeyPress(e);
        }
        /*protected override void OnTextChanged(EventArgs e)
        {
            int firstPoint = 1;
            int secondPoint = 5;
            if (this.Text.Length >= firstPoint || this.Text.Length >= secondPoint)
            {
                this.Text += ".";
            }
            this.SelectionStart = this.TextLength;
            base.OnTextChanged(e);
        }*/
    }
}
