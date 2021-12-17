using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;
using MapAssist.Settings;
using MapAssist.Helpers;

namespace MapAssist
{
    public partial class ConfigEditor : Form
    {
        private PropertyInfo SelectedProperty;
        public ConfigEditor()
        {
            InitializeComponent();


            foreach (var element in MapAssistConfiguration.Loaded.MapConfiguration.GetType().GetProperties())
            {
                if (!(element.Name.Substring(element.Name.Length - 3, 3) == "REF"))
                {
                    cboRenderOption.Items.Add(element.Name);
                }
            }

            foreach (var element in Enum.GetNames(typeof(BuffPosition)))
            {
                cboBuffPosition.Items.Add(element);
            }

            foreach (var element in Enum.GetNames(typeof(MapPosition)))
            {
                cboPosition.Items.Add(element);
            }

            foreach (var element in Enum.GetNames(typeof(Shape)))
            {
                cboIconShape.Items.Add(element);
            }

            foreach (var element in Enum.GetNames(typeof(Languages.Language)))
            {
                cboLanguage.Items.Add(element);
            }

            cboLanguage.SelectedIndex = MapAssistConfiguration.Loaded.Language;

            opacity.Value = (int)(MapAssistConfiguration.Loaded.RenderingConfiguration.Opacity * 100f);
            lblOpacity.Text = $"Map Opacity: {opacity.Value}%";

            iconOpacity.Value = (int)(MapAssistConfiguration.Loaded.RenderingConfiguration.IconOpacity * 100f);
            lblIconOpacity.Text = $"Icon Opacity: {iconOpacity.Value}%";

            mapSize.Value = MapAssistConfiguration.Loaded.RenderingConfiguration.Size;
            lblMapSize.Text = $"Map Size (non-overlay mode): {mapSize.Value}";

            mapZoom.Value = (int)((4 - MapAssistConfiguration.Loaded.RenderingConfiguration.ZoomLevel) * 100f);
            lblZoom.Text = $"Map Zoom (overlay mode): {Math.Round((mapZoom.Value / 100f), 2)}";

            updateTime.Value = MapAssistConfiguration.Loaded.UpdateTime;
            lblUpdateTime.Text = $"Update Time: {updateTime.Value}ms";

            chkOverlayMode.Checked = MapAssistConfiguration.Loaded.RenderingConfiguration.OverlayMode;
            chkToggleViaMap.Checked = MapAssistConfiguration.Loaded.RenderingConfiguration.ToggleViaInGameMap;
            chkToggleViaPanels.Checked = MapAssistConfiguration.Loaded.RenderingConfiguration.ToggleViaInGamePanels;
            chkOverlayMode.Checked = MapAssistConfiguration.Loaded.RenderingConfiguration.OverlayMode;
            cboPosition.SelectedIndex = cboPosition.FindStringExact(MapAssistConfiguration.Loaded.RenderingConfiguration.Position.ToString());

            buffSize.Value = (int)(MapAssistConfiguration.Loaded.RenderingConfiguration.BuffSize * 100f);
            lblBuffSize.Text = $"Buff Icon Size: {buffSize.Value}%";
            cboBuffPosition.SelectedIndex = cboBuffPosition.FindStringExact(MapAssistConfiguration.Loaded.RenderingConfiguration.BuffPosition.ToString());

            chkGameInfo.Checked = MapAssistConfiguration.Loaded.GameInfo.Enabled;
            txtHuntIP.Text = MapAssistConfiguration.Loaded.HuntingIP;
            txtD2Path.Text = MapAssistConfiguration.Loaded.D2Path;

            chkClearPrefetch.Checked = MapAssistConfiguration.Loaded.ClearPrefetchedOnAreaChange;
            chkShowOverlayFPS.Checked = MapAssistConfiguration.Loaded.GameInfo.ShowOverlayFPS;

            txtToggleMapKey.Text = MapAssistConfiguration.Loaded.HotkeyConfiguration.ToggleKey.ToString();
            txtGameInfoKey.Text = MapAssistConfiguration.Loaded.HotkeyConfiguration.GameInfoKey.ToString();
            txtZoomInKey.Text = MapAssistConfiguration.Loaded.HotkeyConfiguration.ZoomInKey.ToString();
            txtZoomOutKey.Text = MapAssistConfiguration.Loaded.HotkeyConfiguration.ZoomOutKey.ToString();

            chkItemLogEnabled.Checked = MapAssistConfiguration.Loaded.ItemLog.Enabled;
            chkPlaySound.Checked = MapAssistConfiguration.Loaded.ItemLog.PlaySoundOnDrop;
            txtFilterFile.Text = MapAssistConfiguration.Loaded.ItemLog.FilterFileName;
            txtSoundFile.Text = MapAssistConfiguration.Loaded.ItemLog.SoundFile;
            txtDisplayForSeconds.Value = (decimal)MapAssistConfiguration.Loaded.ItemLog.DisplayForSeconds;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            MapAssistConfiguration.Loaded.Save();
            base.OnFormClosing(e);
        }
        private void IgnoreMouseWheel(object sender, EventArgs e)
        {
            ((HandledMouseEventArgs)e).Handled = true;
        }

        private void updateTime_Scroll(object sender, EventArgs e)
        {
            lblUpdateTime.Text = $"Update Time: {updateTime.Value}ms";
            MapAssistConfiguration.Loaded.UpdateTime = updateTime.Value;
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
            lblMapSize.Text = $"Map Size (non-overlay mode): {mapSize.Value}";
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

        private void chkGameInfo_CheckedChanged(object sender, EventArgs e)
        {
            MapAssistConfiguration.Loaded.GameInfo.Enabled = chkGameInfo.Checked;
        }

        private void txtHuntIP_TextChanged(object sender, EventArgs e)
        {
            MapAssistConfiguration.Loaded.HuntingIP = txtHuntIP.Text;
        }

        private void txtD2Path_TextChanged(object sender, EventArgs e)
        {
            MapAssistConfiguration.Loaded.D2Path = txtD2Path.Text;
        }

        private void chkClearPrefetch_CheckedChanged(object sender, EventArgs e)
        {
            MapAssistConfiguration.Loaded.ClearPrefetchedOnAreaChange = chkClearPrefetch.Checked;
        }

        private void chkShowOverlayFPS_CheckedChanged(object sender, EventArgs e)
        {
            MapAssistConfiguration.Loaded.GameInfo.ShowOverlayFPS = chkShowOverlayFPS.Checked;
        }

        private void cboRenderOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedProperty = MapAssistConfiguration.Loaded.MapConfiguration.GetType().GetProperty(cboRenderOption.Text + "REF");
            if (SelectedProperty != null)
            {
                tabDrawing.Visible = true;
            } else
            {
                return;
            }
            dynamic iconProp = SelectedProperty.GetValue(MapAssistConfiguration.Loaded.MapConfiguration, null);
            btnIconColor.BackColor = iconProp.IconColor;
            chkIcon.Checked = (iconProp.IconColor.A > 0);
            cboIconShape.SelectedIndex = cboIconShape.FindStringExact(Enum.GetName(typeof(Shape), iconProp.IconShape));
            iconSize.Value = (int)iconProp.IconSize * 10;
            iconThickness.Value = (int)iconProp.IconThickness * 10;
            lblIconSize.Text = $"Icon Size: {Math.Round(iconSize.Value / 10f, 2)}";
            lblIconThickness.Text = $"Icon Thickness: {Math.Round(iconThickness.Value / 10f, 2)}";
            if (SelectedProperty.PropertyType != typeof(PointOfInterestRendering) && SelectedProperty.PropertyType != typeof(PortalRendering))
            {
                tabDrawing.TabPages.Remove(tabLabel);
                tabDrawing.TabPages.Remove(tabLine);
            } else
            {
                tabDrawing.TabPages.Remove(tabLabel);
                tabDrawing.TabPages.Remove(tabLine);
                tabDrawing.TabPages.Insert(1, tabLabel);
                tabDrawing.TabPages.Insert(2, tabLine);
                btnLabelColor.BackColor = iconProp.LabelColor;
                chkLabel.Checked = (iconProp.LabelColor.A > 0);

                btnLineColor.BackColor = iconProp.LineColor;
                chkLine.Checked = (iconProp.LineColor.A > 0);
                lineArrowSize.Value = iconProp.ArrowHeadSize;
                lineThicknessSize.Value = (int)iconProp.LineThickness * 10;
                lblLineArrow.Text = $"Arrow Size: {lineArrowSize.Value}";
                lblLineThickness.Text = $"Line Thickness: {Math.Round(lineThicknessSize.Value / 10f, 2)}";
            }
        }

        private void btnIconColor_Click(object sender, EventArgs e)
        {
            var colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                var iconProp = SelectedProperty.PropertyType.GetProperty("IconColor");
                iconProp.SetValue(SelectedProperty.GetValue(MapAssistConfiguration.Loaded.MapConfiguration, null), colorDlg.Color, null);
                btnIconColor.BackColor = colorDlg.Color;
                chkIcon.Checked = (colorDlg.Color.A > 0);
            }
        }

        private void chkIcon_Clicked(object sender, EventArgs e)
        {
            var iconProp = SelectedProperty.PropertyType.GetProperty("IconColor");
            if (chkIcon.Checked)
            {
                iconProp.SetValue(SelectedProperty.GetValue(MapAssistConfiguration.Loaded.MapConfiguration, null), btnIconColor.BackColor, null);
            } else
            {
                iconProp.SetValue(SelectedProperty.GetValue(MapAssistConfiguration.Loaded.MapConfiguration, null), Color.Empty, null);
            }
        }

        private void cboIconShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            var iconProp = SelectedProperty.PropertyType.GetProperty("IconShape");
            iconProp.SetValue(SelectedProperty.GetValue(MapAssistConfiguration.Loaded.MapConfiguration, null), (MapPosition)cboIconShape.SelectedIndex, null);
        }

        private void iconSize_Scroll(object sender, EventArgs e)
        {
            var iconProp = SelectedProperty.PropertyType.GetProperty("IconSize");
            iconProp.SetValue(SelectedProperty.GetValue(MapAssistConfiguration.Loaded.MapConfiguration, null), iconSize.Value / 10f, null);
            lblIconSize.Text = $"Icon Size: {Math.Round(iconSize.Value / 10f, 2)}";
        }

        private void iconThickness_Scroll(object sender, EventArgs e)
        {
            var iconProp = SelectedProperty.PropertyType.GetProperty("IconThickness");
            iconProp.SetValue(SelectedProperty.GetValue(MapAssistConfiguration.Loaded.MapConfiguration, null), iconThickness.Value / 10f, null);
            lblIconThickness.Text = $"Icon Thickness: {Math.Round(iconThickness.Value / 10f, 2)}";
        }

        private void tabDrawing_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabDrawing.SelectedIndex > 0 && (SelectedProperty.PropertyType != typeof(PointOfInterestRendering) && SelectedProperty.PropertyType != typeof(PortalRendering)))
            {
                tabDrawing.SelectTab(0);
                MessageBox.Show("This property type does not support Labels or Lines.");
            }
        }

        private void chkLabel_Clicked(object sender, EventArgs e)
        {
            var labelPropColor = SelectedProperty.PropertyType.GetProperty("LabelColor");
            if (chkLabel.Checked)
            {
                labelPropColor.SetValue(SelectedProperty.GetValue(MapAssistConfiguration.Loaded.MapConfiguration, null), btnLabelColor.BackColor, null);
            } else
            {
                labelPropColor.SetValue(SelectedProperty.GetValue(MapAssistConfiguration.Loaded.MapConfiguration, null), Color.Empty, null);
            }
        }

        private void btnLabelColor_Click(object sender, EventArgs e)
        {
            var colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                var labelPropColor = SelectedProperty.PropertyType.GetProperty("LabelColor");
                labelPropColor.SetValue(SelectedProperty.GetValue(MapAssistConfiguration.Loaded.MapConfiguration, null), colorDlg.Color, null);
                btnLabelColor.BackColor = colorDlg.Color;
                chkLabel.Checked = (colorDlg.Color.A > 0);
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            dynamic labelProp = SelectedProperty.GetValue(MapAssistConfiguration.Loaded.MapConfiguration, null);
            var labelFont = labelProp.LabelFont;
            var labelSize = labelProp.LabelFontSize;
            if (labelFont == null)
            {
                labelFont = "Helvetica";
                labelSize = 16;
            }
            var fontDlg = new FontDialog();
            fontDlg.Font = new Font(labelFont, labelSize, FontStyle.Regular);
            if (fontDlg.ShowDialog() == DialogResult.OK)
            {
                var labelPropFont = SelectedProperty.PropertyType.GetProperty("LabelFont");
                var labelPropFontSize = SelectedProperty.PropertyType.GetProperty("LabelFontSize");
                labelPropFont.SetValue(SelectedProperty.GetValue(MapAssistConfiguration.Loaded.MapConfiguration, null), fontDlg.Font.Name, null);
                labelPropFontSize.SetValue(SelectedProperty.GetValue(MapAssistConfiguration.Loaded.MapConfiguration, null), fontDlg.Font.Size, null);
            }
        }

        private void chkLabel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkLine_Clicked(object sender, EventArgs e)
        {
            var lineProp = SelectedProperty.PropertyType.GetProperty("LineColor");
            if (chkLine.Checked)
            {
                lineProp.SetValue(SelectedProperty.GetValue(MapAssistConfiguration.Loaded.MapConfiguration, null), btnLineColor.BackColor, null);
            }
            else
            {
                lineProp.SetValue(SelectedProperty.GetValue(MapAssistConfiguration.Loaded.MapConfiguration, null), Color.Empty, null);
            }
        }

        private void btnLineColor_Click(object sender, EventArgs e)
        {
            var colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                var linePropColor = SelectedProperty.PropertyType.GetProperty("LineColor");
                linePropColor.SetValue(SelectedProperty.GetValue(MapAssistConfiguration.Loaded.MapConfiguration, null), colorDlg.Color, null);
                btnLineColor.BackColor = colorDlg.Color;
                chkLine.Checked = (colorDlg.Color.A > 0);
            }
        }

        private void lineArrowSize_Scroll(object sender, EventArgs e)
        {
            var iconProp = SelectedProperty.PropertyType.GetProperty("ArrowHeadSize");
            iconProp.SetValue(SelectedProperty.GetValue(MapAssistConfiguration.Loaded.MapConfiguration, null), lineArrowSize.Value, null);
            lblLineArrow.Text = $"Arrow Size: {lineArrowSize.Value}";
        }

        private void lineThicknessSize_Scroll(object sender, EventArgs e)
        {
            var iconProp = SelectedProperty.PropertyType.GetProperty("LineThickness");
            iconProp.SetValue(SelectedProperty.GetValue(MapAssistConfiguration.Loaded.MapConfiguration, null), lineThicknessSize.Value / 10f, null);
            lblLineThickness.Text = $"Line Thickness: {Math.Round(lineThicknessSize.Value / 10f, 2)}";
        }

        private void cboLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            MapAssistConfiguration.Loaded.Language = cboLanguage.SelectedIndex;
            PointOfInterestHandler.ReloadNamedPOIs();
        }

        private void txtToggleMapKey_TextChanged(object sender, EventArgs e)
        {
            MapAssistConfiguration.Loaded.HotkeyConfiguration.ToggleKey = txtToggleMapKey.Text.ToCharArray()[0];
        }

        private void txtGameInfoKey_TextChanged(object sender, EventArgs e)
        {
            MapAssistConfiguration.Loaded.HotkeyConfiguration.GameInfoKey = txtGameInfoKey.Text.ToCharArray()[0];
        }

        private void txtZoomInKey_TextChanged(object sender, EventArgs e)
        {
            MapAssistConfiguration.Loaded.HotkeyConfiguration.ZoomInKey = txtZoomInKey.Text.ToCharArray()[0];
        }

        private void txtZoomOutKey_TextChanged(object sender, EventArgs e)
        {
            MapAssistConfiguration.Loaded.HotkeyConfiguration.ZoomOutKey = txtZoomOutKey.Text.ToCharArray()[0];
        }

        private void chkItemLogEnabled_CheckedChanged(object sender, EventArgs e)
        {
            MapAssistConfiguration.Loaded.ItemLog.Enabled = chkItemLogEnabled.Checked;
        }

        private void txtFilterFile_TextChanged(object sender, EventArgs e)
        {
            MapAssistConfiguration.Loaded.ItemLog.FilterFileName = txtFilterFile.Text;
        }

        private void chkPlaySound_CheckedChanged(object sender, EventArgs e)
        {
            MapAssistConfiguration.Loaded.ItemLog.PlaySoundOnDrop = chkPlaySound.Checked;
        }

        private void txtSoundFile_TextChanged(object sender, EventArgs e)
        {
            MapAssistConfiguration.Loaded.ItemLog.SoundFile = txtSoundFile.Text;
        }

        private void txtSoundFile_LostFocus(object sender, EventArgs e)
        {
            AudioPlayer.LoadNewSound(true);
        }

        private void txtDisplayForSeconds_ValueChanged(object sender, EventArgs e)
        {
            MapAssistConfiguration.Loaded.ItemLog.DisplayForSeconds = (double)txtDisplayForSeconds.Value;
        }

        private void btnLogFont_Click(object sender, EventArgs e)
        {
            var labelFont = MapAssistConfiguration.Loaded.ItemLog.LabelFont;
            var labelSize = MapAssistConfiguration.Loaded.ItemLog.LabelFontSize;
            if (labelFont == null)
            {
                labelFont = "Helvetica";
                labelSize = 16;
            }
            var fontDlg = new FontDialog();
            fontDlg.Font = new Font(labelFont, labelSize, FontStyle.Regular);
            if (fontDlg.ShowDialog() == DialogResult.OK)
            {
                MapAssistConfiguration.Loaded.ItemLog.LabelFont = fontDlg.Font.Name;
                MapAssistConfiguration.Loaded.ItemLog.LabelFontSize = fontDlg.Font.Size;
            }
        }
    }
}
