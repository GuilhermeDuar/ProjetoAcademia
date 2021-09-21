using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class TextBoxCPF : TextBox
    {
        private int _maxLength = 14;
        public TextBoxCPF()
        {
            InitializeComponent();
            this.MaxLength = this._maxLength;
        }

        public TextBoxCPF(IContainer container)
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
            int firstPoint = 3;
            int secondPoint = 7;
            int hifen = 11;
            if (!isControl)
            {
                if (this.Text.Length == firstPoint || this.Text.Length == secondPoint)
                {
                    this.Text += ".";
                }
                if (this.Text.Length == hifen)
                {
                    this.Text += "-";
                }
            }
            this.SelectionStart = this.TextLength;
            base.OnKeyPress(e);
        }
        /*protected override void OnTextChanged(EventArgs e)
        {
            int firstPoint = 3;
            int secondPoint = 7;
            int hyphen = 11;
                if (this.Text.Length >= firstPoint || this.Text.Length >= secondPoint)
                {
                    this.Text += ".";
                }
                if (this.Text.Length >= hyphen)
                {
                    this.Text += "-";
                }
            this.SelectionStart = this.TextLength;
            base.OnTextChanged(e);
        }*/
    }
}
