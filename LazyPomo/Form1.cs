using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        int hourLazyTotal;
        int hourPomoTotal;
        int timerMin;
        int timerSec;
        int timeRef;
        
        int mouseX = 0;
        int mouseY = 0;
        bool mouseDown;


        public Form1()
        {
            InitializeComponent();
            timerMin = int.Parse(txtEditPomo.Text);
            timerSec = 00;
            timeDivider = 360 / ((double)timerMin * 60);
            timeTicker = 0;
            
            timeRef = timerMin * 60;

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


        // START Total Time
        private void tmLazyTotal_Tick(object sender, EventArgs e)
        {
            hourLazyTotal++;
            lblLazyTotal.Text = "tick " + hourLazyTotal;
        }

        private void tmPomoTotal_Tick(object sender, EventArgs e)
        {
            hourPomoTotal++;
            lblPomoTotal.Text = "tick " + hourPomoTotal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // END Total Time
    }
}
