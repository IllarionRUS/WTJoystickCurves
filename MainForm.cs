using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace WTJoystickCurves
{
    public partial class MainForm : Form
    {
        private const string PROF_PATH = @"{0}\My Games\WarThunder\Saves\profile.config.blk";
        private Profile wtProfile;
        public MainForm()
        {
            InitializeComponent();
            var profilePath = String.Format(PROF_PATH, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
            wtProfile = new Profile(profilePath);
            if (wtProfile.Initialized)
            {
                curvePitch.YPoints = wtProfile.GetLinearitySliders("elevator");
                curveRoll.YPoints = wtProfile.GetLinearitySliders("ailerons");
                curveYaw.YPoints = wtProfile.GetLinearitySliders("rudder");
                checkPitch.Checked = wtProfile.GetSliderCheckState("elevator");
                checkRoll.Checked = wtProfile.GetSliderCheckState("ailerons");
                checkYaw.Checked = wtProfile.GetSliderCheckState("rudder");
            }
            else
            {
                MessageBox.Show(String.Format("Can't read from file: {0}", profilePath));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (wtProfile.Initialized)
            {
                wtProfile.SetLinearitySliders("elevator", curvePitch.YPoints);
                wtProfile.SetLinearitySliders("ailerons", curveRoll.YPoints);
                wtProfile.SetLinearitySliders("rudder", curveYaw.YPoints);

                wtProfile.SetSliderCheckState("elevator", checkPitch.Checked);
                wtProfile.SetSliderCheckState("ailerons", checkRoll.Checked);
                wtProfile.SetSliderCheckState("rudder", checkYaw.Checked);

                if (wtProfile.Save())
                    MessageBox.Show("Settings saved!");
                else
                    MessageBox.Show("Error! Can't save settings!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            curvePitch.YPoints = new float[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            curveRoll.YPoints = new float[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            curveYaw.YPoints = new float[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        }
        public static void ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            var errorMsg = e.Exception.Message + "\n\nStack Trace:\n" + e.Exception.StackTrace;
            MessageBox.Show(errorMsg);
        }

    }
}
