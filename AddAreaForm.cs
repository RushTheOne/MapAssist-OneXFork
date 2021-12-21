using MapAssist.Settings;
using MapAssist.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapAssist
{
    public partial class AddAreaForm : Form
    {
        public string listToAddTo;
        public AddAreaForm()
        {
            InitializeComponent();
        }

        private void AddAreaForm_Load(object sender, EventArgs e)
        {
            lstAreas.Items.Clear();
            foreach(var area in Enum.GetValues(typeof(Area)).Cast<Area>()){
                if (area != Area.None)
                {
                    lstAreas.Items.Add(AreaExtensions.Name(area));
                }
            }
        }

        private void btnAddArea_Click(object sender, EventArgs e)
        {
            var formParent = (ConfigEditor)Owner;
            var list = formParent.Controls.Find(listToAddTo, true).FirstOrDefault() as ListBox;
            var areaToAdd = (Area)lstAreas.SelectedIndex;
            var areaName = areaToAdd.NameInternal();
            if (!list.Items.Contains(areaName))
            {
                list.Items.Add(areaName);
                switch (listToAddTo)
                {
                    case "lstHidden":
                        MapAssistConfiguration.Loaded.HiddenAreas = MapAssistConfiguration.Loaded.HiddenAreas.Append(areaToAdd).ToArray();
                        break;
                    case "lstPrefetch":
                        MapAssistConfiguration.Loaded.PrefetchAreas = MapAssistConfiguration.Loaded.PrefetchAreas.Append(areaToAdd).ToArray();
                        break;
                }
                Close();
            }
        }
    }
}
