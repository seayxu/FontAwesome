using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FontAwesomeNet;

namespace FontAwesomeNet.Sample
{
    public partial class FormSample : Form
    {
        public FormSample()
        {
            InitializeComponent();
            this.cmbFontAwesomeType.SelectedIndexChanged+=new EventHandler(cmbFontAwesomeType_SelectedIndexChanged);
        }

        private void FormSample_Load(object sender, EventArgs e)
        {
            string[] names = FontAwesome.TypeDict.Select(v => v.Key).ToArray();
            this.cmbFontAwesomeType.Items.AddRange(names);
            string[] colorNames = Enum.GetNames(typeof(KnownColor));
            this.cmbForeColor.Items.AddRange(colorNames);
            this.cmbBackColor.Items.AddRange(colorNames);
            this.cmbBorderColor.Items.AddRange(colorNames);
            this.cmbFontAwesomeType.SelectedIndex = 0;
        }

        private void cmbFontAwesomeType_SelectedIndexChanged(object sender,EventArgs e)
        {
            if (this.cmbFontAwesomeType.SelectedIndex<0)
            {
                return;
            }
            FontAwesome.IconSize = (int)this.nudIconSize.Value;
            if (this.cmbBackColor.SelectedIndex>-1)
            {
                FontAwesome.BackColer = Color.FromName(this.cmbBackColor.Text); 
            }
            if (this.cmbBorderColor.SelectedIndex > -1)
            {
                FontAwesome.BorderColer = Color.FromName(this.cmbBorderColor.Text); 
            }
            if (this.cmbForeColor.SelectedIndex > -1)
            {
                FontAwesome.ForeColer = Color.FromName(this.cmbForeColor.Text); 
            }
            FontAwesome.BorderVisible = this.cbShowBorder.Checked == true;

            int val = FontAwesome.TypeDict[this.cmbFontAwesomeType.Text];
            Bitmap bmp = FontAwesome.GetImage(val);//f188
            this.panel1.BackgroundImage = bmp;
            this.Icon = FontAwesome.GetIcon(val);//f188;
        }
    }
}
