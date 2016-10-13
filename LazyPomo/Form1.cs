using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//using LazyPomo.Code;

namespace LazyPomo
{
    public partial class Form1 : Form
    {

        int slideDown = 20;
        int timeTicker = 0;
        double timeDivider = 0.0666;
        Color progressbarColor;
        bool lazy = true;
        bool pausePomo = true;

        int timerMin;
        int timerSec;
        int timeRef;
        int counter = 0;

        int hourLazyTotal;
        int minLazyTotal;
        int secLazyTotal;

        int hourPomoTotal;
        int minPomoTotal;
        int secPomoTotal;

        int mouseX = 0;
        int mouseY = 0;
        bool mouseDown;
        bool checkTop = false;


        public Form1()
        {
            InitializeComponent();
            timerMin = int.Parse(txtEditPomo.Text);
            timerSec = 00;
            timeDivider = 360 / ((double)timerMin * 60);
            timeTicker = 0;
            
            timeRef = timerMin * 60;
            rtxtSave.Visible = false;
            pnlEditTimebox.Visible = false;
        }

        // Movable and Closable Window START
        private void pnlMenu_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void pnlMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 120;
                mouseY = MousePosition.Y - 10;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void pnlMenu_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult resultClose = MessageBox.Show("Close LazyPomo?",
                    "Exit",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);
            if (resultClose == DialogResult.Yes)
            {
                this.Close();
            }
                
        }
        // Movable and Closable Window END

        // Menu Slide START
        private void btnMain_Click(object sender, EventArgs e)
        {
           
            if (slideDown == 20 || slideDown < 20)
            {
                pnlEditTimebox.Visible = false;
                this.tmMenuDown.Enabled = true;                
            }
            else if (slideDown > 20 && pnlEditTimebox.Visible == true)
            {
                pnlEditTimebox.Visible = false;
            }
            else
            {
                this.tmMenuUp.Enabled = true;
            }      
        }

        private void tmControl_Tick(object sender, EventArgs e)
        {
            if (slideDown == 40 )
            {
                this.tmMenuDown.Enabled = false;
            }
            slideDown++;
            this.pnlTimer.Location = new System.Drawing.Point(0, slideDown);
        }

        private void tmMenuUp_Tick(object sender, EventArgs e)
        {
            if (slideDown <= 21 )
            {
                this.tmMenuUp.Enabled = false;
                pnlEditTimebox.Visible = false;
            }
            slideDown--;
            this.pnlTimer.Location = new System.Drawing.Point(0, slideDown);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (slideDown == 20 || slideDown < 20)
            {
                pnlEditTimebox.Visible = true;
                this.tmMenuDown.Enabled = true;
            }
            else if (slideDown > 20 && pnlEditTimebox.Visible == false)
            {
                pnlEditTimebox.Visible = true;
            }
            else
            {
                this.tmMenuUp.Enabled = true;                              
            }
        }

        // Menu Slide END

        private void Pomo()
        {
            tmLazy.Enabled = false;
            tmLazyTotal.Enabled = false;
            tmPomo.Enabled = true;
            tmPomoTotal.Enabled = true;          

            if (timeTicker == timeRef)
             {
                timerMin = int.Parse(txtEditPomo.Text);
                timerSec = 00;
                timeDivider = 360 / ((double)timerMin * 60);
                timeTicker = 0;
                timeRef = timerMin * 60;
            }
            lazy = false;
            pausePomo = false;
            btnStartPause.Text = "Pause";
        }
        private void Lazy()
        {
            timerMin = int.Parse(txtEditLazy.Text);
            timerSec = 00;
            timeDivider = 360 / ((double)timerMin * 60);
            timeTicker = 0;

            tmLazy.Enabled = true;
            tmLazyTotal.Enabled = true;
            tmPomo.Enabled = false;
            tmPomoTotal.Enabled = false;

            lazy = true;
            pausePomo = true;
            btnStartPause.Text = "Start";
        }
        private void Pause()
        {
            tmLazy.Enabled = false;
            tmLazyTotal.Enabled = true;
            tmPomo.Enabled = false;
            tmPomoTotal.Enabled = false;
            pausePomo = true;
            btnStartPause.Text = "Go on";
        }

        // InterAction
        // Start BUTTON
        private void btnStartPause_Click(object sender, EventArgs e)
        {

            if (pausePomo && !lazy)
            {
                Pomo();
            }
            else if (pausePomo && lazy)
            {
                timerMin = int.Parse(txtEditPomo.Text);
                Pomo();
            }
            else
            {
                Pause();
            }
            /*
           if (lazy)
              {
                  btnStartPause.Text = "Pause";
                  tmLazyTotal.Enabled = false;
                  tmLazy.Enabled = false;
                  tmPomo.Enabled = true;
                  tmPomoTotal.Enabled = true;
                  lazy = false;
              }

             else
              {
                  lazy = true;
                  tmPomo.Enabled = false;
                  tmPomoTotal.Enabled = false;
                  tmLazyTotal.Enabled = true;
                  btnStartPause.Text = "Continue";
              }
              */
            /*
            if (tmPomo.Enabled == false)
            {
                progressbarColor = Color.LimeGreen;
                this.tmPomo.Enabled = true;
                this.btnStartPause.Text = "Pause";
                timeDivider = 0.066;

                if (timeTicker == 1500)
                {
                    progressbarColor = Color.Red;
                    timeTicker = 0;
                    tmLazy.Enabled = true;
                    timeDivider = 0.333;
                }

            }
           else
            {
                this.tmPomo.Enabled = false;
                this.tmLazy.Enabled = true;
                this.btnStartPause.Text = "Pomo";               
            }
            */

            /*
            Task.Run(() =>
            {
                for (int num = 0; num <= 100; num++)
                {
                    new System.Threading.Thread(new System.Threading.ParameterizedThreadStart(this.ProgressUpgrade)).Start(num);
                    System.Threading.Thread.Sleep(40);
                }
            });*/

        }

        public void ProgressUpgrade(object progress)
        {
            pbProgressbar.Invoke((MethodInvoker)delegate { pbProgressbar.UpdateProgress(Convert.ToInt32(progress), timeDivider, progressbarColor); });
        }

      private void UpdateCountDownLabel()
        {
            
            if (timerMin < 10)
            {
                lblCountdownMin.Text = "0" + timerMin;
            }
            else
            {
                lblCountdownMin.Text = timerMin.ToString();
            }
            if (timerSec < 10)
            {
                lblCountdownSec.Text = "0" + timerSec;
            }
            else
            {
                lblCountdownSec.Text = timerSec.ToString();
            }
            
        }

        // START POMO TICK
        private void tmPomo_Tick(object sender, EventArgs e)
        {
            timeTicker++;
            progressbarColor = Color.LimeGreen;
            pbProgressbar.UpdateProgress(timeTicker, timeDivider, progressbarColor);

            lblCountdownMin.ForeColor = Color.LimeGreen;
            lblCountdownSec.ForeColor = Color.LimeGreen;
            lblCountDownDivider.ForeColor = Color.LimeGreen;

            if (timeTicker == timeRef)
            {
                lblCountdownMin.Text = "00";
                lblCountdownSec.Text = "00";
                tmPomo.Enabled = false;
                counter = counter + 1;
                lblPomoCount.Text = counter.ToString() + " Pomo Sessions";
                DialogResult resultPomoOver = MessageBox.Show("Well done! Now take a break.\n Or press 'No' to start another Pomo Session",
                    "Take a break.",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation);
                if (resultPomoOver == DialogResult.Yes)
                {
                    Lazy();
                    /*timeTicker = 0;
                    timerMin = int.Parse(txtEditLazy.Text);
                    double temp = 100 / ((double)timerMin * 60);
                    timeDivider = temp;
                    timerSec = 0;
                    tmLazy.Enabled = true;
                    tmLazyTotal.Enabled = true;
                    tmPomoTotal.Enabled = false;
                    lazy = true;
                    btnStartPause.Text = "Pomo!";*/
                }
                if (resultPomoOver == DialogResult.No)
                {
                    Pomo();
                }
            }

            if (timerSec == 00)
            {
                timerMin--;
                timerSec = 59;
                lblCountdownSec.Text = "59";

            }
            else
            {
                timerSec--;

            }

            UpdateCountDownLabel();



        }
        // END POMO TICK

        // START LAZY TICK
        private void tmLazy_Tick(object sender, EventArgs e)
        {     
            progressbarColor = Color.Red;
            pbProgressbar.UpdateProgress(timeTicker, timeDivider, progressbarColor);
            timeTicker++;
            lblCountdownMin.ForeColor = Color.Red;
            lblCountdownSec.ForeColor = Color.Red;
            lblCountDownDivider.ForeColor = Color.Red;


            if (timeTicker == timeRef)
            {
                lblCountdownMin.Text = "00";
                lblCountdownSec.Text = "00";
                tmLazy.Enabled = false;
               DialogResult resultLazyOver =  MessageBox.Show("Let's have another Pomo.",
                    "Work work.",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation);

                if (resultLazyOver == DialogResult.Yes)
                {
                    Pomo();
                   /* timeTicker = 0;
                    timerMin = int.Parse(txtEditPomo.Text);
                    timerSec = 0;
                    tmPomo.Enabled = true;
                    tmPomoTotal.Enabled = true;
                    tmLazyTotal.Enabled = false;
                    lazy = false;*/
                }
                else
                {
                    Pause();
                    /*tmPomoTotal.Enabled = false;
                    tmLazyTotal.Enabled = true;*/
                }
                
            }

            if (timerSec == 00)
            {
                timerMin--;
                timerSec = 59;
                lblCountdownSec.Text = "59";
                return;
            }
            else
            {
                timerSec--;
            }            
            UpdateCountDownLabel();
        }
        // END LAZY TICK


        // Total Time 





        // START Total Time
        private void tmLazyTotal_Tick(object sender, EventArgs e)
        {
            string lazyHourTotal;
            string lazyMinTotal = minLazyTotal.ToString();
            string lazySecTotal = secLazyTotal.ToString();
            secLazyTotal++;
            if (secLazyTotal == 60)
            {
                secLazyTotal = 0;
                minLazyTotal++;

                if (minLazyTotal == 60)
                {
                    minLazyTotal = 0;
                    hourLazyTotal++;
                }
                
            }

            if (hourLazyTotal <10 )
            {
                 lazyHourTotal = "0" + hourLazyTotal.ToString();
            }
            else
            {
                lazyHourTotal = hourLazyTotal.ToString();
            }
            if (minLazyTotal < 10)
            {
                lazyMinTotal = "0" + minLazyTotal.ToString();
            }
            else
            {
                lazyMinTotal = minLazyTotal.ToString();
            }
            if (secLazyTotal < 10)
            {
                lazySecTotal = "0" + secLazyTotal.ToString();
            }
            else
            {
                lazySecTotal = secLazyTotal.ToString();
            }
            lblLazyTotal.Text = lazyHourTotal + ":" + lazyMinTotal + ":" + lazySecTotal;
            
        }

        private void tmPomoTotal_Tick(object sender, EventArgs e)
        {
            string pomoHourTotal;
            string pomoMinTotal = minPomoTotal.ToString();
            string pomoSecTotal = secPomoTotal.ToString();
            secPomoTotal++;
            if (secPomoTotal == 60)
            {
                secPomoTotal = 0;
                minPomoTotal++;

                if (minPomoTotal == 60)
                {
                    minPomoTotal = 0;
                    hourLazyTotal++;
                }

            }

            if (hourLazyTotal < 10)
            {
                pomoHourTotal = "0" + hourPomoTotal.ToString();
            }
            else
            {
                pomoHourTotal = hourLazyTotal.ToString();
            }
            if (minPomoTotal < 10)
            {
                pomoMinTotal = "0" + minPomoTotal.ToString();
            }
            else
            {
                pomoMinTotal = minPomoTotal.ToString();
            }
            if (secPomoTotal < 10)
            {
                pomoSecTotal = "0" + secPomoTotal.ToString();
            }
            else
            {
                pomoSecTotal = secPomoTotal.ToString();
            }
            lblPomoTotal.Text = pomoHourTotal + ":" + pomoMinTotal + ":" + pomoSecTotal;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // END Total Time

        //Start Always on Top 
        private void btnPin_Click(object sender, EventArgs e)
        {
            if (checkTop == false)
            {
                this.TopMost = true;
                checkTop = true;
            }
            else
            {
                this.TopMost = false;
                checkTop = false;
            }
        }


        //End Always on Top


        private void btnSave_Click(object sender, EventArgs e)
        {
            rtxtSave.Text = lblPomoCount.Text + "\r\n " + lblPomoTotal.Text + "\r\n " + lblLazyTotal.Text;
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                    sw.Write(rtxtSave.Text);
                    sw.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Form1", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rtxtSave.Text = File.ReadAllText(openFileDialog1.FileName);
                string savedPomo = rtxtSave.Text;
                //get Pomo Count
                string savedPomoCount = savedPomo.Substring(0, savedPomo.IndexOf('\n'));
                string savedPomoCountNumber = savedPomoCount.Substring(0, savedPomoCount.IndexOf(' '));
                int.TryParse(savedPomoCountNumber, out counter);
                lblPomoCount.Text = counter.ToString() + " Pomo Sessions";
                //get Pomo Time
                /*
                string savedPomoTime = savedPomo.Substring(savedPomo.IndexOf('\n') + 1, savedPomo.LastIndexOf('\n') - savedPomo.IndexOf('\n'));
                string savedPomoTimeNumbers = savedPomoTime.Substring(savedPomoTime.LastIndexOf(' ') + 1, savedPomoTime.Length - savedPomoTime.LastIndexOf(' ') - 1);
                string savedPomoTimeHour = savedPomoTimeNumbers.Substring(0, savedPomoTimeNumbers.IndexOf(':'));//get hours
                string savedPomoTimeMinutes = savedPomoTimeNumbers.Substring(savedPomoTimeNumbers.IndexOf(':') + 1, savedPomoTimeNumbers.LastIndexOf(':') - savedPomoTimeNumbers.IndexOf(':') - 1);//get minutes
                string savedPomoTimeSeconds = savedPomoTimeNumbers.Substring(savedPomoTimeNumbers.LastIndexOf(':') + 1, savedPomoTimeNumbers.Length - savedPomoTimeNumbers.LastIndexOf(':') - 1);
                int.TryParse(savedPomoTimeHour, out h);
                int.TryParse(savedPomoTimeMinutes, out m);
                int.TryParse(savedPomoTimeSeconds, out s);
                if (s < 10)
                {

                    if (m < 10)
                    {
                        lblPomoTotal.Text = "Total Pomo Time  " + h + ":0" + m + ":0" + s;
                    }
                    else
                    {
                        lblPomoTotal.Text = "Total Pomo Time  " + h + ":" + m + ":0" + s;
                    }
                }

                else
                {
                    if (m < 10)
                    {
                        lblPomoTimeAll.Text = "Total Pomo Time  " + h + ":0" + m + ":" + s;
                    }
                    else
                    {
                        lblPomoTimeAll.Text = "Total Pomo Time  " + h + ":" + m + ":" + s;
                    }
                }

                //get Lazy Time
                string savedLazyTime = savedPomo.Substring(savedPomo.LastIndexOf('\n') + 1, savedPomo.Length - savedPomo.LastIndexOf('\n') - 1);
                string savedLazyTimeNumbers = savedLazyTime.Substring(savedLazyTime.LastIndexOf(' ') + 1, savedLazyTime.Length - savedLazyTime.LastIndexOf(' ') - 1);
                string savedLazyTimeHour = savedLazyTimeNumbers.Substring(0, savedLazyTimeNumbers.IndexOf(':'));//get hours
                string savedLazyTimeMinutes = savedLazyTimeNumbers.Substring(savedLazyTimeNumbers.IndexOf(':') + 1, savedLazyTimeNumbers.LastIndexOf(':') - savedLazyTimeNumbers.IndexOf(':') - 1);//get minutes
                string savedLazyTimeSeconds = savedLazyTimeNumbers.Substring(savedLazyTimeNumbers.LastIndexOf(':') + 1, savedLazyTimeNumbers.Length - savedLazyTimeNumbers.LastIndexOf(':') - 1);
                int.TryParse(savedLazyTimeHour, out hL_a);
                int.TryParse(savedLazyTimeMinutes, out mL_a);
                int.TryParse(savedLazyTimeSeconds, out sL_a);
                if (sL_a < 10)
                {
                    if (mL_a < 10)
                    {
                        lblLazyTimeAll.Text = "Total Lazy Time  " + hL_a + ":0" + mL_a + ":0" + sL_a;
                    }
                    else
                    {
                        lblLazyTimeAll.Text = "Total Lazy Time  " + hL_a + ":" + mL_a + ":0" + sL_a;
                    }
                }

                else
                {
                    if (mL_a < 10)
                    {
                        lblLazyTimeAll.Text = "Total Lazy Time  " + hL_a + ":0" + mL_a + ":" + sL_a;
                    }
                    else
                    {
                        lblLazyTimeAll.Text = "Total Lazy Time  " + hL_a + ":" + mL_a + ":" + sL_a;
                    }
                }
                */
                MessageBox.Show("Save File Loaded", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
