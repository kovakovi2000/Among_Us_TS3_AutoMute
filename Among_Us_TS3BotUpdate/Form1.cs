using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace Among_Us_TS3BotUpdate
{
    
    public partial class Form1 : Form
    {
        private GameWatcher gameWatcher = new GameWatcher();
        private static int AwaitMils = 200;
        private List<AmongState> AS = new List<AmongState>();
        //private TesseractEngine engine = new TesseractEngine("./tessdata", "eng", EngineMode.Default);
        public Form1()
        {
            InitializeComponent();
            
            gameWatcher.Show();

            AmongState thd_temp = new AmongState();
            thd_temp.NameOf = "Start";
            thd_temp.State = false;
            thd_temp.Pan = gameWatcher.panel_CrewImp;
            thd_temp.Lab = label_start;
            thd_temp.FoundVars = new List<string>();

            thd_temp.LookFor = new List<string>();
            thd_temp.LookFor.Add("crewmate");
            thd_temp.LookFor.Add("Brewmate");
            thd_temp.LookFor.Add("Crewmate"); 
            thd_temp.LookFor.Add("Crewma t8");



            AS.Add(thd_temp);

            //-------------------------------------------------------------



            thd_temp = new AmongState();
            thd_temp.NameOf = "VoteStart";
            thd_temp.State = false;
            thd_temp.Pan = gameWatcher.panel_VoteProcEnd;
            thd_temp.Lab = label_vote_start;
            thd_temp.FoundVars = new List<string>();
            AS.Add(thd_temp);

            thd_temp = new AmongState();
            thd_temp.NameOf = "VoteUnder";
            thd_temp.State = false;
            thd_temp.Pan = gameWatcher.panel_VoteProcEnd;
            thd_temp.Lab = label_vote_under;
            thd_temp.FoundVars = new List<string>();
            AS.Add(thd_temp);

            thd_temp = new AmongState();
            thd_temp.NameOf = "VoteEnd";
            thd_temp.State = false;
            thd_temp.Pan = gameWatcher.panel_VoteProcEnd;
            thd_temp.Lab = label_vote_end;
            thd_temp.FoundVars = new List<string>();
            AS.Add(thd_temp);



            //-------------------------------------------------------------
            thd_temp = new AmongState();
            thd_temp.NameOf = "End";
            thd_temp.State = false;
            thd_temp.Pan = gameWatcher.panel_WinDef;
            thd_temp.Lab = label_end;
            thd_temp.FoundVars = new List<string>();

            thd_temp.LookFor = new List<string>();
            thd_temp.LookFor.Add("UICTDI\"!");
            thd_temp.LookFor.Add("UiCtOf‘U");
            thd_temp.LookFor.Add("Uictoru");

            AS.Add(thd_temp);

            AS[0].Enable = false;
            AS[1].Enable = false;
            AS[2].Enable = false;
            AS[3].Enable = false;
            AS[4].Enable = false;
            timer_tester.Start();
        }

        private void ShowButton(object sender)
        {
            foreach (var item in AS)
            {
                string ctrlName = ((Control)sender).Name;
                if (ctrlName == item.Lab.Name)
                {
                    MessageBox.Show(GetTextFromPanel(item));
                    item.Pan.BackColor = Color.White;
                    Thread CallBack = new Thread(() => {
                        Thread.Sleep(2000);
                        item.Pan.BackColor = Color.Lime;
                    });
                    CallBack.Start();
                }
            }
        }

        private string GetTextFromPanel(AmongState item)
        {
            try
            {
                Bitmap img = capturearea(item.Pan);
                item.Engine = new TesseractEngine("./tessdata", "eng", EngineMode.Default);
                Page page = item.Engine.Process(img, PageSegMode.Auto);
                return page.GetText();
            }
            catch (Exception)
            {
                return "";
                throw;
            }
            
        }

        private Bitmap capturearea(Control control)
        {
            Size size = control.ClientSize;
            Bitmap tmpBmp = new Bitmap(size.Width, size.Height);
            Graphics g = Graphics.FromImage(tmpBmp);
            g.CopyFromScreen(control.PointToScreen(new Point(0, 0)), new Point(0, 0), new Size(size.Width, size.Height));
            return tmpBmp;
        }

        private void SaveData()
        {
            foreach (var item in AS)
            {
                if (!item.Enable)
                    continue;

                using (StreamWriter sr = new StreamWriter(@"fnd\" + DateTime.Now.ToString("MM-dd_HH-mm-ss")+ "_" + item.NameOf + ".txt"))
                {
                    foreach (var element in item.FoundVars)
                    {
                        if (element != "") sr.WriteLine(element);
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void timer_start_Tick(object sender, EventArgs e)
        {
            foreach (var item in AS)
            {
                if (item.Enable)
                {
                    item.Lab.BackColor = Color.Yellow;
                    item.FoundVars.Add(GetTextFromPanel(item));
                }
                else
                    item.Lab.BackColor = Color.White;
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void label_start_Click(object sender, EventArgs e)
        {
            ShowButton(sender);
        }

        private void label_vote_start_Click(object sender, EventArgs e)
        {
            ShowButton(sender);
        }

        private void label_vote_under_Click(object sender, EventArgs e)
        {
            ShowButton(sender);
        }

        private void label_vote_end_Click(object sender, EventArgs e)
        {
            ShowButton(sender);
        }

        private void label_end_Click(object sender, EventArgs e)
        {
            ShowButton(sender);
        }
    }
    public class AmongState
    {
        public string NameOf;
        public bool State;

        public List<string> FoundVars;
        public List<string> LookFor;

        public Label Lab;
        public Panel Pan;

        public bool Enable;

        public TesseractEngine Engine;
    }
}

