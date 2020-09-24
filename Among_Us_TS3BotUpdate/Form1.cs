using MySql.Data.MySqlClient;
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
        private bool Mute = false;
        private static MySqlConnection connection = new MySqlConnection("datasource=5.189.148.170;port=3306;username=demoanalis893;password=EbY7a7aWuLy5AqA");
        private MySqlCommand sql_send_mute = new MySqlCommand("UPDATE `demoanalis893`.`MuteTable` SET `SQL_IsMuted` = '1' WHERE `MuteTable`.`id` = 1;", connection);
        private MySqlCommand sql_send_unmute = new MySqlCommand("UPDATE `demoanalis893`.`MuteTable` SET `SQL_IsMuted` = '0' WHERE `MuteTable`.`id` = 1;", connection);
        
        private GameWatcher gameWatcher = new GameWatcher();
        private List<AmongState> AS = new List<AmongState>();
        private Color[] PxLookFor = new Color[4];
        public Form1()
        {
            try
            {
                connection.Open();
                sql_send_unmute.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
            }

            

            InitializeComponent();

            gameWatcher.Show();

            PxLookFor[0] = ColorTranslator.FromHtml("#b4bfcc");
            PxLookFor[1] = ColorTranslator.FromHtml("#a2acb7");
            PxLookFor[2] = ColorTranslator.FromHtml("#8f97a4");
            PxLookFor[3] = ColorTranslator.FromHtml("#848b96");

            AmongState thd_temp = new AmongState();
            thd_temp.NameOf = "Start";
            thd_temp.Enable = true;
            thd_temp.Pan = gameWatcher.panel_CrewImp;
            thd_temp.Lab = label_start;
            thd_temp.Lab_o = label_start_o;
            thd_temp.Size = thd_temp.Pan.ClientSize;

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
            thd_temp.Pan = gameWatcher.panel_TabletCorner;
            thd_temp.Lab = label_tabletcorner;
            thd_temp.Lab_o = label_tabletcorner_o;
            thd_temp.Size = thd_temp.Pan.ClientSize;

            thd_temp.Px = true;
            thd_temp.PxColors = new Color[4];

            AS.Add(thd_temp);



            //-------------------------------------------------------------
            thd_temp = new AmongState();
            thd_temp.NameOf = "End";
            thd_temp.Pan = gameWatcher.panel_WinDef;
            thd_temp.Lab = label_end;
            thd_temp.Lab_o = label_end_o;
            thd_temp.Size = thd_temp.Pan.ClientSize;

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
                    item.Force = true;
                    Thread.Sleep(2000);
                    /*
                    MessageBox.Show(GetTextFromPanel(item).ToString());
                    item.Pan.BackColor = Color.White;
                    Thread CallBack = new Thread(() => {
                        Thread.Sleep(2000);
                        item.Pan.BackColor = Color.Lime;
                    });
                    CallBack.Start();
                    */
                }
            }
        }

        private bool GetTextFromPanel(AmongState item)
        {
            try
            {
                item.Bmp = new Bitmap(item.Size.Width, item.Size.Height); //System.ArgumentException: 'Parameter is not valid.'
                Graphics g = Graphics.FromImage(item.Bmp);
                g.CopyFromScreen(item.Pan.PointToScreen(new Point(0, 0)), new Point(0, 0), new Size(item.Size.Width, item.Size.Height));
            }
            catch (Exception) {}

            if (item.Px)
            {
                item.PxColors[0] = item.Bmp.GetPixel(35, 2); //180, 191, 204     b4bfcc
                item.PxColors[1] = item.Bmp.GetPixel(35, 10); //162, 172, 183    a2acb7
                item.PxColors[2] = item.Bmp.GetPixel(35, 24); //143, 151, 164    8f97a4
                item.PxColors[3] = item.Bmp.GetPixel(15, 15); //132, 139, 150    848b96

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
                    Page page = item.Engine.Process(item.Bmp, PageSegMode.Auto);
                    foreach (var element in item.LookFor)
                    {
                        item.Lab_o.Text = page.GetText(); //System.AccessViolationException: 'Attempted to read or write protected memory. This is often an indication that other memory is corrupt.
                        if (item.Lab_o.Text.Contains(element))
                            return true;
                    }
                    return false;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            
        }

        private void timer_start_Tick(object sender, EventArgs e)
        {
            
            foreach (var item in AS)
            {
                if (item.Enable)
                {
                    item.Lab.BackColor = Color.Yellow;
                    if (GetTextFromPanel(item) || item.Force)
                    {
                        item.Force = false;
                        item.Lab.BackColor = Color.Green;
                        try
                        {
                            if (item.NameOf == "Start" && Mute == false)
                            {
                                sql_send_mute.ExecuteNonQuery();
                                Mute = true;
                                AS[0].Enable = false;
                                AS[1].Enable = true;
                                AS[2].Enable = true;
                            }

                            else if (item.NameOf == "End" && Mute == true)
                            {
                                sql_send_unmute.ExecuteNonQuery();
                                Mute = false;
                                AS[0].Enable = true;
                                AS[1].Enable = false;
                                AS[2].Enable = false;
                            }
                            else if(item.NameOf == "TabletCorner" && Mute == true)
                            {
                                sql_send_unmute.ExecuteNonQuery();
                                Mute = false;
                            }
                        }catch (Exception) {}
                    }
                    else if (item.NameOf == "TabletCorner" && Mute == false)
                    {
                        sql_send_mute.ExecuteNonQuery();
                        Mute = true;
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
        public bool Force = false;

        public bool Px = false;

        public List<string> LookFor;

        public Label Lab;
        public Label Lab_o;
        public Panel Pan;

        public bool Enable = false;

        public Size Size;
        public Bitmap Bmp;

        public TesseractEngine Engine;

        public Color[] PxColors;
    }
}

