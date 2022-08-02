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
    public partial class pageListUC : UserControl
    {
        private int _currentPage;
        public int _countPages;

        public delegate void CallFormMethod(object obj, int page);
        public event CallFormMethod onLinkLabelClick;
        public pageListUC(int currentPage, int countPage)
        {
            InitializeComponent();
            _currentPage = currentPage;
            _countPages = countPage;
            int step = 12;
            for (int i = 1; i < _countPages + 1; i++)
            {
                LinkLabel linkLabel = new LinkLabel
                {                    
                    Text = i.ToString(),
                    Name = i.ToString(),
                    Font = new System.Drawing.Font("Comic Sans MS",
                        8, System.Drawing.FontStyle.Regular,
                        System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                    Location = new Point(step, 2),
                    LinkColor = Color.Black,                   
                    Visible = true,
                    Size = new System.Drawing.Size(16, 17),                        
                };
                linkLabel.BringToFront();
                linkLabel.Click += new EventHandler(lebel_Click);
                this.Controls.Add(linkLabel);
                step += 16;
            }
            this.Size = new Size(this.Width += 145, this.Size.Height);
        }

        private void lebel_Click(object sender, EventArgs e)
        {        
            int page = Convert.ToInt32(sender.ToString().Split(':')[1]);
            onLinkLabelClick(sender, page);
        }

        private void pageListUC_Load(object sender, EventArgs e)
        {
            
        }

        private void ForwardLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_currentPage != _countPages)
            {
                ++_currentPage;
                onLinkLabelClick(this,_currentPage);
            }                
        }

        private void BackLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_currentPage != 1)
            {
                --_currentPage;
                onLinkLabelClick(this, _currentPage);
            }                         
        }
    }
}
