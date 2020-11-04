using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArWallpaper_Configuration_Tool
{
    public partial class MainForm : Form
    {
        string cfgPath = "data/config.cfg";
        float f = 500;
        struct Configuration
        {
            public string modelPath;
            public decimal videoCaptureDevice;
            public string cascadePath;
            public decimal cameraFar;
            public decimal cameraNear;
            public string cameraRatio;
            public decimal minFaceSize;
            public float f;
            public string eyesGap;
            public string ppcm;
            public bool drawWireframe;
            public bool projectionMode;
            public bool lockZ;
        }
        Configuration defaults;
        Configuration GetCurrentConfiguration() {
            Configuration current;
            current.modelPath = modelPath.Text;
            current.videoCaptureDevice = videoCaptureDevice.Value;
            current.cascadePath = faceCascadePath.Text;
            current.cameraFar = cameraFar.Value;
            current.cameraNear = cameraNear.Value;
            current.cameraRatio = cameraRatio.Text;
            current.minFaceSize = minFaceSize.Value;
            current.f = f;
            current.eyesGap = eyesGap.Text;
            current.ppcm = ppcm.Text;
            current.drawWireframe = drawWireframe.Checked;
            current.projectionMode = projectionMode.Checked;
            current.lockZ = lockZ.Checked;
            return current;
        }
        void LoadConfiguration(Configuration conf) {
            modelPath.Text = conf.modelPath;
            videoCaptureDevice.Value = conf.videoCaptureDevice;
            faceCascadePath.Text = conf.cascadePath;
            cameraFar.Value = conf.cameraFar;
            cameraNear.Value = conf.cameraNear;
            cameraRatio.Text = conf.cameraRatio;
            minFaceSize.Value = conf.minFaceSize;
            f = conf.f;
            eyesGap.Text = conf.eyesGap;
            ppcm.Text = conf.ppcm;
            drawWireframe.Checked = conf.drawWireframe;
            projectionMode.Checked = conf.projectionMode;
            lockZ.Checked = conf.lockZ;
        }
        bool ReadConfig(string cfgPath)
        {
            string currentLine;
            string currentProperty;
            string[] splitted;
            Dictionary<string, string> cfg = new Dictionary<string, string>();
            try
            {
                System.IO.StreamReader cfgFile = new System.IO.StreamReader(@cfgPath);
                while ((currentLine = cfgFile.ReadLine()) != null)
                {
                    currentLine = currentLine.Replace(" ", "");
                    splitted = currentLine.Split('=');
                    if (splitted.Length != 2)
                        return false;
                    cfg.Add(splitted[0], splitted[1]);
                }
                cfgFile.Close();
            }
            catch (IOException) {
                return false;
            }
            //setting modelPath value
            if (!cfg.TryGetValue("modelPath", out currentLine))
                return false;
            modelPath.Text = currentLine;
            //setting videoCaptureDevice value
            if (!cfg.TryGetValue("videoCaptureDevice", out currentLine))
                return false;
            int tmpInt;
            float tmpFloat;
            if (!Int32.TryParse(currentLine, out tmpInt))
                return false;
            videoCaptureDevice.Value = tmpInt;
            //setting face_cascade_name value
            if (!cfg.TryGetValue("cascadePath", out currentLine))
                return false;
            faceCascadePath.Text = currentLine;
            //setting far_ value
            if (!cfg.TryGetValue("cameraFar", out currentLine))
                return false;
            if (!Int32.TryParse(currentLine, out tmpInt))
                return false;
            cameraFar.Value = tmpInt;
            //setting near_ value
            if (!cfg.TryGetValue("cameraNear", out currentLine))
                return false;
            if (!Int32.TryParse(currentLine, out tmpInt))
                return false;
            cameraNear.Value = tmpInt;
            //setting camRatio value
            if (!cfg.TryGetValue("cameraRatio", out currentLine))
                return false;
            if (!float.TryParse(currentLine, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.CultureInfo.InvariantCulture, out tmpFloat))
                return false;
            cameraRatio.Text = currentLine;
            //setting minFaceSize value
            if (!cfg.TryGetValue("minFaceSize", out currentLine))
                return false;
            if (!Int32.TryParse(currentLine, out tmpInt))
                return false;
            minFaceSize.Value = tmpInt;
            //setting f value
            if (!cfg.TryGetValue("f", out currentLine))
                return false;
            if (!float.TryParse(currentLine, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.CultureInfo.InvariantCulture, out f))
                return false;
            //setting eyesGap value
            if (!cfg.TryGetValue("eyesGapInCm", out currentLine))
                return false;
            if (!float.TryParse(currentLine, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.CultureInfo.InvariantCulture, out tmpFloat))
                return false;
            eyesGap.Text = currentLine;
            //setting pixelNbrPerCm value
            System.Diagnostics.Debug.WriteLine(cfg.TryGetValue("pixelPerCm", out currentLine));
            if (!cfg.TryGetValue("pixelPerCm", out currentLine))
                return false;
            if (!float.TryParse(currentLine, System.Globalization.NumberStyles.AllowDecimalPoint, System.Globalization.CultureInfo.InvariantCulture, out tmpFloat))
                return false;
            ppcm.Text = currentLine;
            //setting drawWireframe value
            if (!cfg.TryGetValue("drawWireframe", out currentLine))
                return false;
            currentLine = currentLine.ToLower();
            if (currentLine == "true" || currentLine == "1")
                drawWireframe.Checked = true;
            else if (currentLine == "false" || currentLine == "0")
                drawWireframe.Checked = false;
            else
                return false;
            //setting bProjectionMode value
            if (!cfg.TryGetValue("projectionMode", out currentLine))
                return false;
            currentLine = currentLine.ToLower();
            if (currentLine == "true" || currentLine == "1")
                projectionMode.Checked = true;
            else if (currentLine == "false" || currentLine == "0")
                projectionMode.Checked = false;
            else
                return false;
            //setting lockZ value
            if (!cfg.TryGetValue("lockZ", out currentLine))
                return false;
            currentLine = currentLine.ToLower();
            if (currentLine == "true" || currentLine == "1")
                lockZ.Checked = true;
            else if (currentLine == "false" || currentLine == "0")
                lockZ.Checked = false;
            else
                return false;
            return true;
        }

        bool WriteConfig(string cfgPath, Configuration conf) {
            try
            {
                System.IO.StreamWriter cfgFile = new System.IO.StreamWriter(@cfgPath);
                cfgFile.Write("modelPath           =  " + conf.modelPath + "\n");
                cfgFile.Write("videoCaptureDevice  =  " + conf.videoCaptureDevice + "\n");
                cfgFile.Write("cascadePath         =  " + conf.cascadePath + "\n");
                cfgFile.Write("cameraFar           =  " + conf.cameraFar + "\n");
                cfgFile.Write("cameraNear          =  " + conf.cameraNear + "\n");
                cfgFile.Write("cameraRatio         =  " + conf.cameraRatio + "\n");
                cfgFile.Write("minFaceSize         =  " + conf.minFaceSize + "\n");
                cfgFile.Write("f                   =  " + conf.f + "\n");
                cfgFile.Write("eyesGapInCm         =  " + conf.eyesGap + "\n");
                cfgFile.Write("pixelPerCm          =  " + conf.ppcm + "\n");
                cfgFile.Write("drawWireframe       =  " + conf.drawWireframe + "\n");
                cfgFile.Write("projectionMode      =  " + conf.projectionMode + "\n");
                cfgFile.Write("lockZ               =  " + conf.lockZ);
                cfgFile.Close();
            }
            catch (IOException)
            {
                return false;
            }
            return true;
        }
        public MainForm()
        {
            InitializeComponent();
            defaults = GetCurrentConfiguration();
            if (!ReadConfig(cfgPath)) {
                MessageBox.Show("Could not load configuration file.\nSome (possibly all) data was not loaded.");
            }
        }

        private void ppcm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void eyesGap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cameraRatio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            LoadConfiguration(defaults);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!WriteConfig(cfgPath, GetCurrentConfiguration()))
            {
                MessageBox.Show("Could not save configuration file.");
            }
        }
    }
}
