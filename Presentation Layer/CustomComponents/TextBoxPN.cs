using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer.CustomComponents
{
    public partial class TextBoxPN : TextBox
    {
        private int _maxLength = 14;
        public TextBoxPN()
        {
            InitializeComponent();
            this.MaxLength = this._maxLength;
        }

        public TextBoxPN(IContainer container)
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
            int firstParentheses = 0;
            int secondParentheses = 3;
            if (!isControl)
            {
                if (this.Text.Length == firstParentheses) 
                {
                    this.Text += "(";
                }
                if (this.Text.Length == secondParentheses)
                {
                    this.Text += ")";
                }
                if (this.Text.Length > 4)
                {
                    if (this.Text[4] == '9' && this.Text.Length == 9)
                    {
                        this.Text += "-";
                    }
                    if (this.Text[4] != '9' && this.Text.Length == 8)
                    {
                        this.Text += "-";
                    }
                }
            }
            this.SelectionStart = this.TextLength;
            base.OnKeyPress(e);
        }
        /*protected override void OnTextChanged(EventArgs e)
        {
            int firstParentheses = 0;
            int secondParentheses = 3;
            if (this.Text.Length == firstParentheses)
            {
                this.Text += "(";
            }
            if (this.Text.Length == secondParentheses)
            {
                this.Text += ")";
            }
            if (this.Text.Length > 4)
            {
                if (this.Text[4] == '9' && this.Text.Length == 9)
                {
                    this.Text += "-";
                }
                if (this.Text[4] != '9' && this.Text.Length == 8)
                {
                    this.Text += "-";
                }
            }
            this.SelectionStart = this.TextLength;
            base.OnTextChanged(e);
        }*/
    }
}
