using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace Mad_Max_Progress_Tracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initiallize values


            if (!backgroundWorker1.IsBusy) //if background worker is not busy
            {
                backgroundWorker1.RunWorkerAsync(); //run the background worker
            }
        }
          
        //Initalizing Game ID and Memory Values
        public Mem m = new Mem();
        public int pID = 0;

        //In-Game Values
        float scavTotalValue = 0;
        float campsDismantled = 0;
        float storyMissionsCompleted = 0;
        float wastelandMissionsCompleted = 0;

        //In-Game Addresses
        string SCAVENGING_LOCATIONS_COMPLETED = "base+0x01944730,0x30,0x40,0x18,0x2A0,0x120,0x30,0x1C";
        string CAMPS_DISMANTLED = "base+0x01944730,0x30,0x40,0x40,0x70,0xE8,0x8,0x69C";
        string STORY_MISSIONS_COMPLETED = "base+0x01944730,0x30,0x70,0xD8,0x10,0x298,0x90,0x6DC";
        string WASTELAND_MISSIONS_COMPLETED = "base+0x01944730,0x28,0x2E0,0x38,0x298,0x1E8,0x8,0x4BC";

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {
                pID = m.GetProcIdFromName("MadMax"); 
                //Get the process ID from the game              
                if (pID <= 0 || !m.OpenProcess(pID))
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        //set undetected
                        label1.Text = "Undetected";
                        label1.ForeColor = Color.Red;
                    
                        //reset all values
                        scavTotal.Text = "N/A";
                    }));
                }
                else
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        //set detected
                        label1.Text = "Detected - " + pID.ToString();
                        label1.ForeColor = Color.Green;

                        //
                        //set all values
                        //
                        
                        //Scavenging Locations
                        scavTotalValue = m.ReadFloat(SCAVENGING_LOCATIONS_COMPLETED);
                        scavTotal.Text = scavTotalValue.ToString();

                        //Camps Dismantled
                        campsDismantled = m.ReadFloat(CAMPS_DISMANTLED);
                        campsText.Text = campsDismantled.ToString();

                        //Story Missions Completed
                        storyMissionsCompleted = m.ReadFloat(STORY_MISSIONS_COMPLETED);
                        storyMissionsText.Text = storyMissionsCompleted.ToString();

                        //Wasteland Missions Completed
                        wastelandMissionsCompleted = m.ReadFloat(WASTELAND_MISSIONS_COMPLETED);
                        wastelandMissionsText.Text = wastelandMissionsCompleted.ToString();
                    }));
                }
            }

            

        }




        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
