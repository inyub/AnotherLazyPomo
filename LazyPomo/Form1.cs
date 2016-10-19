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
using LazyPomo.Properties;

//using LazyPomo.Code;

namespace LazyPomo
{
    public partial class Form1 : Form
    {
        int slideMenu = 20;
        int slideDown = 20;
        bool editButton;
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
        int secPomoTotal = 1;
        int mouseX = 0;
        int mouseY = 0;
        bool mouseDown;
        bool checkTop = false;
        bool checkSound = true;


        public Form1()
        {
            InitializeComponent();
            //timerMin = int.Parse(txtEditPomo.Text);
            timerSec = 00;
            timeDivider = 360 / ((double)timerMin * 60);
            timeTicker = 0;
            
            timeRef = timerMin * 60;
            rtxtSave.Visible = false;
            pnlEditTimebox.Visible = false;

            this.txtEditPomo.Text = Settings.Default["Pomo"].ToString();
            this.txtEditLazy.Text = Settings.Default["Lazy"].ToString();
            this.timerMin = int.Parse(Settings.Default["PomoInt"].ToString());

            int checkZero = int.Parse(txtEditPomo.Text);
            if (checkZero < 10)
            {
                lblCountdownMin.Text = "0" + txtEditPomo.Text;
            }
            else
            {
                lblCountdownMin.Text = txtEditPomo.Text;
            }
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
            if (slideMenu == 20) // Open Main 
            {
                slideMenu = 42;
                pnlEditTimebox.Visible = false;
                this.tmMenuDown.Enabled = true;
                editButton = false;
            }
            else if (slideMenu == 80) //change
            {
                slideMenu = 42;
                pnlEditTimebox.Visible = false;
                this.tmMenuUp.Enabled = true;
                editButton = false;
            }
            else if (slideMenu == 42) //close
            {
                slideMenu = 20;
                this.tmMenuUp.Enabled = true;
                editButton = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {            
            if (slideMenu == 20) // Open Edit 
            {
                slideMenu = 80;
                pnlEditTimebox.Visible = true;
                this.tmMenuDown.Enabled = true;
                editButton = true;
            }
            else if (slideMenu == 42) //change
            {
                slideMenu = 80;
                pnlEditTimebox.Visible = true;
                this.tmMenuDown.Enabled = true;
                editButton = false;
            }
            else if (slideMenu == 80) //close
            {
                slideMenu = 20;
                this.tmMenuUp.Enabled = true;
                editButton = true;
            }
        }

        private void tmControl_Tick(object sender, EventArgs e)
        {
            if (slideDown < slideMenu)
            {
                if (editButton == true)
                {
                    slideDown = slideDown + 4;
                }
                else 
                {
                    slideDown = slideDown + 2;
                }
                
                if (slideDown == slideMenu)
                {
                    this.tmMenuDown.Enabled = false;
                }
            }          
            this.pnlTimer.Location = new System.Drawing.Point(0, slideDown);
            this.pnlMenuGradient.Location = new System.Drawing.Point(0, (slideDown - 5));
        }

        private void tmMenuUp_Tick(object sender, EventArgs e)
        {
            if (slideDown > slideMenu)
            {
                if (editButton == true)
                {
                    slideDown = slideDown - 4;
                }
                else
                {
                    slideDown = slideDown - 2;
                }
                if (slideDown == slideMenu)
                {
                    this.tmMenuUp.Enabled = false;
                }
            }
            this.pnlTimer.Location = new System.Drawing.Point(0, slideDown);
            this.pnlMenuGradient.Location = new System.Drawing.Point(0, (slideDown - 5));
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
                timerMin = int.Parse(Settings.Default["PomoInt"].ToString());
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
            timeRef = timerMin * 60;

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

            progressbarColor = Color.Gray;
            pbProgressbar.UpdateProgress(timeTicker, timeDivider, progressbarColor);

            lblCountdownMin.ForeColor = Color.Gray;
            lblCountdownSec.ForeColor = Color.Gray;
            lblCountDownDivider.ForeColor = Color.Gray;

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
            else if (lazy)
            {
                timerMin = int.Parse(txtEditPomo.Text);
                timerSec = 00;
                timeDivider = 360 / ((double)timerMin * 60);
                timeTicker = 0;
                timeRef = timerMin * 60;
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
                tmPomo.Enabled = false;
                lblCountdownMin.Text = "00";
                lblCountdownSec.Text = "00";
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
            timeTicker++;
            progressbarColor = Color.Red;
            pbProgressbar.UpdateProgress(timeTicker, timeDivider, progressbarColor);
            
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
            if (!pausePomo && lazy)
            {
               
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
        private void UpdateZerosLazy()
        {
            string lazyHourTotal;
            string lazyMinTotal = minLazyTotal.ToString();
            string lazySecTotal = secLazyTotal.ToString();


            if (hourLazyTotal < 10)
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
        private void tmLazyTotal_Tick(object sender, EventArgs e)
        {
            UpdateZerosLazy();
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
        }

        private void UpdateZerosPomo()
        {
            string pomoHourTotal;
            string pomoMinTotal = minPomoTotal.ToString();
            string pomoSecTotal = secPomoTotal.ToString();

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
        private void tmPomoTotal_Tick(object sender, EventArgs e)
        {
            UpdateZerosPomo();
           
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

        }


        // END Total Time

        //Start Always on Top
        private void btnPin_Click(object sender, EventArgs e)
        {
           
            if (checkTop == false)
            {
                this.TopMost = true;
                checkTop = true;
                this.btnPin.BackgroundImage = global::LazyPomo.Properties.Resources.pinOn;
            }
            else
            {
                this.TopMost = false;
                checkTop = false;
                this.btnPin.BackgroundImage = global::LazyPomo.Properties.Resources.pinOff1;
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
           
                string savedPomoTime = savedPomo.Substring(savedPomo.IndexOf('\n') + 1, savedPomo.LastIndexOf('\n') - savedPomo.IndexOf('\n'));
                string savedPomoTimeNumbers = savedPomoTime.Substring(savedPomoTime.LastIndexOf(' ') + 1, savedPomoTime.Length - savedPomoTime.LastIndexOf(' ') - 1);
                string savedPomoTimeHour = savedPomoTimeNumbers.Substring(0, savedPomoTimeNumbers.IndexOf(':'));//get hours
                string savedPomoTimeMinutes = savedPomoTimeNumbers.Substring(savedPomoTimeNumbers.IndexOf(':') + 1, savedPomoTimeNumbers.LastIndexOf(':') - savedPomoTimeNumbers.IndexOf(':') - 1);//get minutes
                string savedPomoTimeSeconds = savedPomoTimeNumbers.Substring(savedPomoTimeNumbers.LastIndexOf(':') + 1, savedPomoTimeNumbers.Length - savedPomoTimeNumbers.LastIndexOf(':') - 1);
                int.TryParse(savedPomoTimeHour, out hourPomoTotal);
                int.TryParse(savedPomoTimeMinutes, out minPomoTotal);
                int.TryParse(savedPomoTimeSeconds, out secPomoTotal);
                UpdateZerosPomo();
                

                //get Lazy Time
                string savedLazyTime = savedPomo.Substring(savedPomo.LastIndexOf('\n') + 1, savedPomo.Length - savedPomo.LastIndexOf('\n') - 1);
                string savedLazyTimeNumbers = savedLazyTime.Substring(savedLazyTime.LastIndexOf(' ') + 1, savedLazyTime.Length - savedLazyTime.LastIndexOf(' ') - 1);
                string savedLazyTimeHour = savedLazyTimeNumbers.Substring(0, savedLazyTimeNumbers.IndexOf(':'));//get hours
                string savedLazyTimeMinutes = savedLazyTimeNumbers.Substring(savedLazyTimeNumbers.IndexOf(':') + 1, savedLazyTimeNumbers.LastIndexOf(':') - savedLazyTimeNumbers.IndexOf(':') - 1);//get minutes
                string savedLazyTimeSeconds = savedLazyTimeNumbers.Substring(savedLazyTimeNumbers.LastIndexOf(':') + 1, savedLazyTimeNumbers.Length - savedLazyTimeNumbers.LastIndexOf(':') - 1);
                int.TryParse(savedLazyTimeHour, out hourLazyTotal);
                int.TryParse(savedLazyTimeMinutes, out minLazyTotal);
                int.TryParse(savedLazyTimeSeconds, out secLazyTotal);
                UpdateZerosLazy();

                MessageBox.Show("Save File Loaded", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // this.btnStartPause.Parent = pnlFooter;
            //btnStartPause.BackColor = Color.Transparent;

        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {            
            Settings.Default["Pomo"] = txtEditPomo.Text;
            Settings.Default["Lazy"] = txtEditLazy.Text;
            Settings.Default["PomoInt"] = int.Parse(txtEditPomo.Text);
            Settings.Default["LazyInt"] = int.Parse(txtEditLazy.Text);
            Settings.Default.Save();
        }

        private void btnOpen_MouseHover(object sender, EventArgs e)
        {
            this.btnOpen.ForeColor = System.Drawing.SystemColors.Control;
        }

        private void btnOpen_MouseLeave(object sender, EventArgs e)
        {
            this.btnOpen.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        }

        private void btnAbout_MouseHover(object sender, EventArgs e)
        {
            this.btnAbout.ForeColor = System.Drawing.SystemColors.Control;
        }

        private void btnAbout_MouseLeave(object sender, EventArgs e)
        {
            this.btnAbout.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
        }

        private void btnPin_MouseHover(object sender, EventArgs e)
        {
           
                this.btnPin.BackgroundImage = global::LazyPomo.Properties.Resources.pinHover;
         
        }

        private void btnPin_MouseLeave(object sender, EventArgs e)
        {
            if (checkTop == false)
            {
                this.btnPin.BackgroundImage = global::LazyPomo.Properties.Resources.pinOff1;
            }
            else
            {
                this.btnPin.BackgroundImage = global::LazyPomo.Properties.Resources.pinOn;
            }
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            if (checkSound == false)
            {
                checkSound = true;
                this.btnSound.BackgroundImage = global::LazyPomo.Properties.Resources.soundOn;
            }
            else
            {
                checkSound = false;
                this.btnSound.BackgroundImage = global::LazyPomo.Properties.Resources.soundOff;
            }
        }

        private void btnSound_MouseHover(object sender, EventArgs e)
        {
            this.btnSound.BackgroundImage = global::LazyPomo.Properties.Resources.soundHover;
        }

        private void btnSound_MouseLeave(object sender, EventArgs e)
        {
            if (checkSound == false)
            {
                this.btnSound.BackgroundImage = global::LazyPomo.Properties.Resources.soundOff;
            }
            else
            {
                this.btnSound.BackgroundImage = global::LazyPomo.Properties.Resources.soundOn;
            }
        }
    }
}
