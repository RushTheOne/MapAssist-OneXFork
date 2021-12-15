using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MapAssist.Settings;

namespace MapAssist
{
    public partial class ConfigEditor : Form
    {
        public ConfigEditor()
        {
            InitializeComponent();
            opacity.Value = (int)(MapAssistConfiguration.Loaded.RenderingConfiguration.Opacity * 100f);
            lblOpacity.Text = $"Map Opacity: {opacity.Value}%";

            iconOpacity.Value = (int)(MapAssistConfiguration.Loaded.RenderingConfiguration.IconOpacity * 100f);
            lblIconOpacity.Text = $"Icon Opacity: {iconOpacity.Value}%";

            mapSize.Value = MapAssistConfiguration.Loaded.RenderingConfiguration.Size;
            lblMapSize.Text = $"Map Size (non-overlay mode): {mapSize.Value}%";

            mapZoom.Value = (int)((4 - MapAssistConfiguration.Loaded.RenderingConfiguration.ZoomLevel) * 100f);
            lblZoom.Text = $"Map Zoom (overlay mode): {Math.Round((mapZoom.Value / 100f), 2)}";

            chkOverlayMode.Checked = MapAssistConfiguration.Loaded.RenderingConfiguration.OverlayMode;
            chkToggleViaMap.Checked = MapAssistConfiguration.Loaded.RenderingConfiguration.ToggleViaInGameMap;
            chkToggleViaPanels.Checked = MapAssistConfiguration.Loaded.RenderingConfiguration.ToggleViaInGamePanels;
            chkOverlayMode.Checked = MapAssistConfiguration.Loaded.RenderingConfiguration.OverlayMode;
            cboPosition.SelectedIndex = cboPosition.FindStringExact(MapAssistConfiguration.Loaded.RenderingConfiguration.Position.ToString());

            buffSize.Value = (int)(MapAssistConfiguration.Loaded.RenderingConfiguration.BuffSize * 100f);
            lblBuffSize.Text = $"Buff Icon Size: {buffSize.Value}%";
            cboBuffPosition.SelectedIndex = cboBuffPosition.FindStringExact(MapAssistConfiguration.Loaded.RenderingConfiguration.BuffPosition.ToString());
        }

        private void opacity_Scroll(object sender, EventArgs e)
        {
            lblOpacity.Text = $"Map Opacity: {opacity.Value}%";
            if (opacity.Value > 0)
            {
                MapAssistConfiguration.Loaded.RenderingConfiguration.Opacity = (float)Math.Round(opacity.Value / 100f, 2);
            } else
            {
                MapAssistConfiguration.Loaded.RenderingConfiguration.Opacity = 0;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconOpacity_Scroll(object sender, EventArgs e)
        {
            lblIconOpacity.Text = $"Icon Opacity: {iconOpacity.Value}%";
            if (iconOpacity.Value > 0)
            {
                MapAssistConfiguration.Loaded.RenderingConfiguration.IconOpacity = (float)Math.Round(iconOpacity.Value / 100f, 2);
            }
            else
            {
                MapAssistConfiguration.Loaded.RenderingConfiguration.IconOpacity = 0;
            }
        }
        private void mapSize_Scroll(object sender, EventArgs e)
        {
            lblMapSize.Text = $"Map Size (non-overlay mode): {mapSize.Value}%";
            MapAssistConfiguration.Loaded.RenderingConfiguration.Size = mapSize.Value;
        }

        private void mapZoom_Scroll(object sender, EventArgs e)
        {
            lblZoom.Text = $"Map Zoom (overlay mode): {Math.Round((mapZoom.Value / 100f), 2)}";
            MapAssistConfiguration.Loaded.RenderingConfiguration.ZoomLevel = (float)Math.Round(4 - (mapZoom.Value / 100f), 2);
        }
        private void buffSize_Scroll(object sender, EventArgs e)
        {
            lblBuffSize.Text = $"Buff Icon Size: {buffSize.Value}%";
            if (buffSize.Value > 0)
            {
                MapAssistConfiguration.Loaded.RenderingConfiguration.BuffSize = (float)Math.Round(buffSize.Value / 100f, 2);
            } else
            {
                MapAssistConfiguration.Loaded.RenderingConfiguration.BuffSize = 0;
            }
        }

        private void chkOverlayMode_CheckedChanged(object sender, EventArgs e)
        {
            MapAssistConfiguration.Loaded.RenderingConfiguration.OverlayMode = chkOverlayMode.Checked;
        }

        private void ConfigEditor_Load(object sender, EventArgs e)
        {

        }

        private void cboPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            MapAssistConfiguration.Loaded.RenderingConfiguration.Position = (MapPosition)cboPosition.SelectedIndex;
        }

        private void chkToggleViaMap_CheckedChanged(object sender, EventArgs e)
        {
            MapAssistConfiguration.Loaded.RenderingConfiguration.ToggleViaInGameMap = chkToggleViaMap.Checked;
        }

        private void chkToggleViaPanels_CheckedChanged(object sender, EventArgs e)
        {
            MapAssistConfiguration.Loaded.RenderingConfiguration.ToggleViaInGamePanels = chkToggleViaPanels.Checked;
        }

        private void cboBuffPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            MapAssistConfiguration.Loaded.RenderingConfiguration.BuffPosition = (BuffPosition)cboBuffPosition.SelectedIndex;
        }
    }
}
