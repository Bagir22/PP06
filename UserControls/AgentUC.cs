using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PopryzhenokPP06
{
    public partial class AgentUC : UserControl
    {
        int agentId;
        public AgentUC(int id)
        {
            InitializeComponent();
            agentId = id;
        }

        private void AgentUC_Load(object sender, EventArgs e)
        {

        }

        public delegate void CallFormMethod(object obj);
        public event CallFormMethod agentEditOrDelete;
        public delegate void selectAgent(AgentUC obj, int id);
        public event selectAgent agentMouseDown;
        private void AgentUC_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            editAgentsForm editAgentsForm = new editAgentsForm(this.agentId);
            if (editAgentsForm.ShowDialog() == DialogResult.Cancel)
            { agentEditOrDelete(this);}
        }
        private void productSaleBtn_Click(object sender, EventArgs e)
        {
            productSaleForm productSaleForm = new productSaleForm(this.agentId);
            if (productSaleForm.ShowDialog() == DialogResult.Cancel)
            { agentEditOrDelete(this);}
        }

        private void AgentUC_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 1)
            {
                if (this.BorderStyle == BorderStyle.FixedSingle)
                {
                    this.BorderStyle = BorderStyle.Fixed3D;
                    this.BackColor = Color.LightBlue;                 
                }
                else if (this.BorderStyle == BorderStyle.Fixed3D)
                {
                    try
                    {
                        if (Convert.ToInt32(this.agentDiscount.
                            Text.Split(' ')[0]) >= 25)
                            this.BackColor = System.Drawing.ColorTranslator.FromHtml("#46B29D");
                        else
                            this.BackColor = Color.White;
                    }
                    catch { }
                    this.BorderStyle = BorderStyle.FixedSingle;
                }
                agentMouseDown(this, agentId);
            }
        }       
    }
}
