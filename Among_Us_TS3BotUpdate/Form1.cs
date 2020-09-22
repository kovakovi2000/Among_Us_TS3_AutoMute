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
        private Color[] PxLookFor = new Color[4];
        public Form1()
        {
            InitializeComponent();
            
            gameWatcher.Show();

            PxLookFor[0] = ColorTranslator.FromHtml("#b4bfcc");
            PxLookFor[1] = ColorTranslator.FromHtml("#a2acb7");
            PxLookFor[2] = ColorTranslator.FromHtml("#8f97a4");
            PxLookFor[3] = ColorTranslator.FromHtml("#848b96");

            AmongState thd_temp = new AmongState();
            thd_temp.NameOf = "Start";
            thd_temp.State = false;
            thd_temp.Pan = gameWatcher.panel_CrewImp;
            thd_temp.Lab = label_start;
            thd_temp.Lab_o = label_start_o;

            thd_temp.LookFor = new List<string>();
            thd_temp.LookFor.Add("crewmate");
            thd_temp.LookFor.Add("Brewmate");
            thd_temp.LookFor.Add("Crewmate"); 
            thd_temp.LookFor.Add("Crewma t8");
            thd_temp.LookFor.Add("Impostor");



            AS.Add(thd_temp);

            //-------------------------------------------------------------



            thd_temp = new AmongState();
            thd_temp.NameOf = "TabletCorner";
            thd_temp.State = false;
            thd_temp.Pan = gameWatcher.panel_TabletCorner;
            thd_temp.Lab = label_tabletcorner;
            thd_temp.Lab_o = label_tabletcorner_o;
            thd_temp.Px = true;
            thd_temp.PxColors = new Color[4];

            AS.Add(thd_temp);



            //-------------------------------------------------------------
            thd_temp = new AmongState();
            thd_temp.NameOf = "End";
            thd_temp.State = false;
            thd_temp.Pan = gameWatcher.panel_WinDef;
            thd_temp.Lab = label_end;
            thd_temp.Lab_o = label_end_o;

            thd_temp.LookFor = new List<string>();
            thd_temp.LookFor.Add("UICTDI\"!");
            thd_temp.LookFor.Add("UiCtOf‘U");
            thd_temp.LookFor.Add("Uictoru");
            thd_temp.LookFor.Add("Defeat");

            AS.Add(thd_temp);
        }

        private void ShowButton(object sender)
        {
            foreach (var item in AS)
            {
                string ctrlName = ((Control)sender).Name;
                if (ctrlName == item.Lab.Name)
                {
                    MessageBox.Show(GetTextFromPanel(item).ToString());
                    item.Pan.BackColor = Color.White;
                    Thread CallBack = new Thread(() => {
                        Thread.Sleep(2000);
                        item.Pan.BackColor = Color.Lime;
                    });
                    CallBack.Start();
                }
            }
        }

        private bool GetTextFromPanel(AmongState item)
        {
            Bitmap img = capturearea(item.Pan);
            if (item.Px)
            {
                item.PxColors[0] = img.GetPixel(35, 2); //180, 191, 204     b4bfcc
                item.PxColors[1] = img.GetPixel(35, 10); //162, 172, 183    a2acb7
                item.PxColors[2] = img.GetPixel(35, 24); //143, 151, 164    8f97a4
                item.PxColors[3] = img.GetPixel(15, 15); //132, 139, 150    848b96

                for (int i = 0; i < item.PxColors.Length; i++)
                {
                    if (item.PxColors[i] != PxLookFor[i])
                        return false;
                }
                return true;
            }
            else
            {
                try
                {
                    item.Engine = new TesseractEngine("./tessdata", "eng", EngineMode.Default);
                    Page page = item.Engine.Process(img, PageSegMode.Auto);
                    foreach (var element in item.LookFor)
                    {
                        string p = page.GetText();
                        item.Lab_o.Text = p;
                        if (p.Contains(element))
                            return true;
                    }
                    return false;
                }
                catch (Exception)
                {
                    return false ;
                    throw;
                }
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

        private void timer_start_Tick(object sender, EventArgs e)
        {
            
            foreach (var item in AS)
            {
                if (item.Enable)
                {
                    item.Lab.BackColor = Color.Yellow;
                    if (GetTextFromPanel(item))
                    {
                        item.Lab.BackColor = Color.Green;
                    }
                }
                else
                    item.Lab.BackColor = Color.Black;

            }
        }

        private void label_ShowClick(object sender, EventArgs e)
        {
            ShowButton(sender);
        }

        private void button_enable_Click(object sender, EventArgs e)
        {
            timer_tester.Enabled = !timer_tester.Enabled;
            button_enable.BackColor = timer_tester.Enabled ? Color.Lime : Color.Red;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
    }
    public class AmongState
    {
        public string NameOf;
        public bool State = false;

        public bool Px = false;

        public List<string> LookFor;

        public Label Lab;
        public Label Lab_o;
        public Panel Pan;

        public bool Enable = true;

        public TesseractEngine Engine;

        public Color[] PxColors;
    }
}

