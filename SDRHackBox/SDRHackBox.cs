/*
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 *
 * Author(s):
 *  - Shane Feek <shane.feek@gmail.com>
 */

using System;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimS.Telnet;


namespace SDRHackBox
{
    public partial class SDRHackBox : Form
    {
        Client tc;
        bool connected = false;
        bool ready = false;
        bool memoryscanning = false;
        bool sweepscanning = false;
        Stopwatch sw;
        long ms = Stopwatch.Frequency / 1000;
        long tm;
        Random random = new Random();

        public SDRHackBox()
        {
            InitializeComponent();

            btnConnect.Text = "Connect SDR#";
            txtMemories.Enabled = true;
            cmbMode.Text = "WFM";
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "Connect SDR#")
            {
                btnConnect.Text = "Connecting...";
                Application.DoEvents();
                try
                {
                    await TelnetGet();
                }
                catch
                {
                    MessageBox.Show("Error Connecting to SDR#", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (btnConnect.Text == "Disconnect SDR#")
            {
                btnConnect.Text = "Connect SDR#";
                connected = false;
                ready = false;
            }
        }

        public async Task TelnetGet()
        {
            using (tc = new Client("localhost", 3382, new System.Threading.CancellationToken()))
            {
                if (tc.IsConnected) connected = true;

                while (connected)
                {
                    string s = await tc.TerminatedReadAsync("}", TimeSpan.FromMilliseconds(500));

                    if (s == String.Empty) continue;

                    if (s.Contains("Net Remote")) { ready = true; btnConnect.Text = "Disconnect SDR#"; }
                    if (s.Contains("Error")) connected = false;
                    
                    //Console.WriteLine(s);
                }

                ready = false;
                btnConnect.Text = "Connect SDR#";
            }
        }

        private void btnMemoryScan_Click(object sender, EventArgs e)
        {
            if (btnMemoryScan.Text == "Start Memory Scan")
            {
                if (sweepscanning) return;
                if (txtMemories.Lines.Count() < 1) return;
                if (!ready) return;

                long ds = ms * trkBarDelay.Value * 30;
                int rt = trkBarDelay.Value * 10; // 30% randomization
                long evt = ms * 100;
                long ev = 0;
                long st = 0;

                double[] freqs = new double[txtMemories.Lines.Count()];

                int c = 0;
                foreach (string line in txtMemories.Lines)
                {
                    if (line != String.Empty)
                    {
                        try
                        {
                            freqs[c] = Convert.ToDouble(line) * 1e6;
                            c++;
                        }
                        catch
                        { }
                    }
                }

                memoryscanning = true;
                btnMemoryScan.Text = "Stop Memory Scan";
                txtMemories.Enabled = false;

                sw = Stopwatch.StartNew();

                int l = 0;

                string mode = String.Format("{{\"Command\": \"Set\", \"Method\": \"DetectorType\", \"Value\": \"{0}\"}}", cmbMode.Text);
                tc.WriteLine(mode);

                if (c==1) { SetFrequency(freqs[0]); return; }

                while (memoryscanning)
                {
                    tm = sw.ElapsedTicks;

                    if (st < tm)
                    {
                        if (chkRandom.Checked)
                        {
                            SetFrequency(freqs[random.Next(0, c)]);
                        }
                        else
                        {
                            SetFrequency(freqs[l]);
                            l++;
                            if (l >= c) l = 0;
                        }

                        if (chkRandomTiming.Checked)
                        {
                            st = tm + ds + random.Next(0, rt) * ms;
                        }
                        else
                            st = tm + ds;
                    }

                    if (ev < tm)
                    {
                        Application.DoEvents();
                        ds = ms * trkBarDelay.Value * 30;
                        rt = rt = trkBarDelay.Value * 10; // 30% randomization
                        ev = tm + evt;
                    }

                }

                txtMemories.Enabled = true;
                memoryscanning = false;
                sw.Stop();
            }

            if (btnMemoryScan.Text == "Stop Memory Scan")
            {
                memoryscanning = false;
                btnMemoryScan.Text = "Start Memory Scan";
                txtMemories.Enabled = true;
            }
        }

        private void SetFrequency(double f)
        {
            if (f == 0) return;

            string freq = String.Format("{{\"Command\": \"Set\", \"Method\": \"Frequency\", \"Value\": {0}}}", f);

            lblFrequency.Text = String.Format("{0:g} MHz", f / 1e6);

            //Console.WriteLine(freq);

            tc.WriteLine(freq);
        }

        private void btnSweepScan_Click(object sender, EventArgs e)
        {
            if (memoryscanning) return;
            if (!ready) return;

            if (btnSweepScan.Text == "Start Sweep Scan")
            {
                sweepscanning = true;

                long ds = ms * trkBarDelay.Value * 30;
                int rt = trkBarDelay.Value * 10; // 30% randomization
                long evt = ms * 100;
                long ev = 0;
                long st = 0;
                double f;

                double start, stop, step;

                try
                {
                    start = Convert.ToDouble(txtStartFreq.Text) * 1e6;
                    stop = Convert.ToDouble(txtStopFreq.Text) * 1e6;
                    step = Convert.ToDouble(txtStepFreq.Text) * 1e6;
                }
                catch
                {
                    return;
                }

                if (step < 0) return;
                if (start >= stop) return;

                f = start;
                sw = Stopwatch.StartNew();

                btnSweepScan.Text = "Stop Sweep Scan";

                string mode = String.Format("{{\"Command\": \"Set\", \"Method\": \"DetectorType\", \"Value\": \"{0}\"}}", cmbMode.Text);
                tc.WriteLine(mode);

                while (sweepscanning)
                {
                    tm = sw.ElapsedTicks;

                    if (st < tm)
                    {
                        SetFrequency(f);
                        f += step;
                        if (f > stop) f = start;

                        if (chkRandomTiming.Checked)
                        {
                            st = tm + ds + random.Next(0, rt) * ms;
                        }
                        else
                            st = tm + ds;
                    }

                    if (ev < tm)
                    {
                        Application.DoEvents();
                        ds = ms * trkBarDelay.Value * 30;
                        rt = trkBarDelay.Value * 10; // 30% randomization
                        ev = tm + evt;
                    }
                }
                sw.Stop();
            }

            if (btnSweepScan.Text == "Stop Sweep Scan")
            {
                sweepscanning = false;
                btnSweepScan.Text = "Start Sweep Scan";
            }
        }
    }
}
