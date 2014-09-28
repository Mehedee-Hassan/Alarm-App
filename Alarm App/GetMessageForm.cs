using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm_App
{
    public partial class GetMessageForm : Form
    {
        public GetMessageForm()
        {
            InitializeComponent();
        }

        public string GetMessageToShow()
        {
            return inputMessageTextBox.Text;
        }

     

        private void okButton_Click(object sender, EventArgs e)
        {

            AlarmForm.SetInputMessage(inputMessageTextBox.Text);

            this.Visible = false;
        }
    }
}
