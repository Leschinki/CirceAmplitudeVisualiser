using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CirceAmplitudeVisualiser
{
    public partial class Form1 : Form
    {
        public const int POINTSCOUNT = 360;
        private PointF[] points = new PointF[POINTSCOUNT];
        int currentPoint = 0;
        public Form1()
        {
            InitializeComponent();
            setup();
            _timer.Enabled = true;
        }

        private void setup()
        {
            MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.Active);
            _cbDevice.Items.AddRange(devices.ToArray());
            if (_cbDevice.Items.Count > 0)
                _cbDevice.SelectedIndex = 0;
        }
        public static PointF PointOnCircle(float radius, float angleInDegrees, PointF origin)
        {
            // Convert from degrees to radians via multiplication by PI/180        
            float x = (float)(radius * Math.Cos(angleInDegrees * Math.PI / 180F)) + origin.X;
            float y = (float)(radius * Math.Sin(angleInDegrees * Math.PI / 180F)) + origin.Y;

            return new PointF(x, y);
        }

        private void OnPanelPaint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            Pen pen = new Pen(Brushes.Blue, 3);
            for(int i = 0; i < POINTSCOUNT; i++)
            {
                gr.DrawLine(pen, points[i], points[(i + 1) % 360]);
            }
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            _timer.Enabled = false;
            Point middle = new Point(_panel.Width / 2, _panel.Height / 2);
            float volume = ((MMDevice)(_cbDevice.SelectedItem)).AudioMeterInformation.MasterPeakValue * 10000 * _trbMulti.Value + 50 * _trbMulti.Value;
            label1.Text = volume.ToString();
            currentPoint %= POINTSCOUNT;
            points[currentPoint++] = PointOnCircle(volume, currentPoint * (360/POINTSCOUNT), middle);
            _panel.Invalidate();
            _timer.Enabled = true;
        }

        private void OnPanelResize(object sender, EventArgs e)
        {
            Array.Clear(points, 0, POINTSCOUNT);
            _panel.Invalidate();
        }
    }
}
