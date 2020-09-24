using MySql.Data.MySqlClient;
using Org.BouncyCastle.Bcpg.OpenPgp;
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
        private static readonly MySqlConnection connection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=");
        private readonly MySqlCommand sql_send_mute = new MySqlCommand("UPDATE `demoanalis893`.`MuteTable` SET `SQL_IsMuted` = '1' WHERE `MuteTable`.`id` = 1;", connection);
        private readonly MySqlCommand sql_send_unmute = new MySqlCommand("UPDATE `demoanalis893`.`MuteTable` SET `SQL_IsMuted` = '0' WHERE `MuteTable`.`id` = 1;", connection);
        
        private GameWatcher gameWatcher = new GameWatcher();
        private List<AmongState> AS = new List<AmongState>();
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

            AmongState thd_temp = new AmongState();
            thd_temp.NameOf = "Start";
            thd_temp.Enable = true;

            thd_temp.Pan = gameWatcher.panel_CrewImp;
            thd_temp.Lab = label_start;
            thd_temp.Lab_o = label_start_o;

            thd_temp.Size = thd_temp.Pan.ClientSize;

            thd_temp.PxColors = new Color[4]; thd_temp.PxLocation = new Point[4];
            thd_temp.PxColors[0] = ColorTranslator.FromHtml("#8cffff"); thd_temp.PxLocation[0] = new Point(25, 112);
            thd_temp.PxColors[1] = ColorTranslator.FromHtml("#000000"); thd_temp.PxLocation[1] = new Point(147, 123);
            thd_temp.PxColors[2] = ColorTranslator.FromHtml("#8cffff"); thd_temp.PxLocation[2] = new Point(867, 122);
            thd_temp.PxColors[3] = ColorTranslator.FromHtml("#8cffff"); thd_temp.PxLocation[3] = new Point(968, 82);

            AS.Add(thd_temp);

            thd_temp = new AmongState();
            thd_temp.NameOf = "Start";
            thd_temp.Enable = true;

            thd_temp.Pan = gameWatcher.panel_CrewImp;
            thd_temp.Lab = label_start;
            thd_temp.Lab_o = label_start_o;

            thd_temp.Size = thd_temp.Pan.ClientSize;

            thd_temp.PxColors = new Color[4];                           thd_temp.PxLocation = new Point[4];
            thd_temp.PxColors[0] = ColorTranslator.FromHtml("#ff1919"); thd_temp.PxLocation[0] = new Point(74, 101);
            thd_temp.PxColors[1] = ColorTranslator.FromHtml("#000000"); thd_temp.PxLocation[1] = new Point(146, 124);
            thd_temp.PxColors[2] = ColorTranslator.FromHtml("#ff1919"); thd_temp.PxLocation[2] = new Point(820, 120);
            thd_temp.PxColors[3] = ColorTranslator.FromHtml("#ff1919"); thd_temp.PxLocation[3] = new Point(1064, 120);

            AS.Add(thd_temp);

            //-------------------------------------------------------------


            thd_temp = new AmongState();
            thd_temp.NameOf = "TabletCorner";

            thd_temp.Pan = gameWatcher.panel_TabletCorner;
            thd_temp.Lab = label_tabletcorner;
            thd_temp.Lab_o = label_tabletcorner_o;

            thd_temp.Size = thd_temp.Pan.ClientSize;

            thd_temp.PxColors = new Color[4];                           thd_temp.PxLocation = new Point[4];
            thd_temp.PxColors[0] = ColorTranslator.FromHtml("#b4bfcc"); thd_temp.PxLocation[0] = new Point(35, 2);
            thd_temp.PxColors[1] = ColorTranslator.FromHtml("#a2acb7"); thd_temp.PxLocation[1] = new Point(35, 10);
            thd_temp.PxColors[2] = ColorTranslator.FromHtml("#8f97a4"); thd_temp.PxLocation[2] = new Point(35, 24);
            thd_temp.PxColors[3] = ColorTranslator.FromHtml("#848b96"); thd_temp.PxLocation[3] = new Point(15, 15);

            AS.Add(thd_temp);

            //-------------------------------------------------------------
            thd_temp = new AmongState();
            thd_temp.NameOf = "End";

            thd_temp.Pan = gameWatcher.panel_WinDef;
            thd_temp.Lab = label_end;
            thd_temp.Lab_o = label_end_o;

            thd_temp.Size = thd_temp.Pan.ClientSize;

            thd_temp.PxColors = new Color[4];                           thd_temp.PxLocation = new Point[4];
            thd_temp.PxColors[0] = ColorTranslator.FromHtml("#008cff"); thd_temp.PxLocation[0] = new Point(359, 88);
            thd_temp.PxColors[1] = ColorTranslator.FromHtml("#000000"); thd_temp.PxLocation[1] = new Point(403, 93);
            thd_temp.PxColors[2] = ColorTranslator.FromHtml("#008cff"); thd_temp.PxLocation[2] = new Point(529, 69);
            thd_temp.PxColors[3] = ColorTranslator.FromHtml("#008cff"); thd_temp.PxLocation[3] = new Point(697, 69);

            AS.Add(thd_temp);

            thd_temp = new AmongState();
            thd_temp.NameOf = "End";

            thd_temp.Pan = gameWatcher.panel_WinDef;
            thd_temp.Lab = label_end;
            thd_temp.Lab_o = label_end_o;

            thd_temp.Size = thd_temp.Pan.ClientSize;

            thd_temp.PxColors = new Color[4];                           thd_temp.PxLocation = new Point[4];
            thd_temp.PxColors[0] = ColorTranslator.FromHtml("#ff0000"); thd_temp.PxLocation[0] = new Point(73, 75);
            thd_temp.PxColors[1] = ColorTranslator.FromHtml("#000000"); thd_temp.PxLocation[1] = new Point(261, 91);
            thd_temp.PxColors[2] = ColorTranslator.FromHtml("#ff0000"); thd_temp.PxLocation[2] = new Point(309, 95);
            thd_temp.PxColors[3] = ColorTranslator.FromHtml("#ff0000"); thd_temp.PxLocation[3] = new Point(611, 87);

            AS.Add(thd_temp);
        }

        private bool GetTextFromPanel(AmongState item)
        {
            Bitmap bmp;
            try
            {
                bmp = new Bitmap(item.Size.Width, item.Size.Height); //System.ArgumentException: 'Parameter is not valid.'
                Graphics g = Graphics.FromImage(bmp);
                g.CopyFromScreen(item.Pan.PointToScreen(new Point(0, 0)), new Point(0, 0), new Size(item.Size.Width, item.Size.Height));
            }
            catch (Exception) { return false; }

            for (int i = 0; i < item.PxLocation.Length; i++)
            {
                if (item.PxColors[i] != bmp.GetPixel(item.PxLocation[i].X, item.PxLocation[i].Y))
                {
                    /*
                    if (item.NameOf == "End")
                    {
                        timer_tester.Stop();
                        DialogResult dr = MessageBox.Show(
                                (item.PxColors[0] == bmp.GetPixel(item.PxLocation[0].X, item.PxLocation[0].Y)).ToString() + "\n" +
                                (item.PxColors[1] == bmp.GetPixel(item.PxLocation[1].X, item.PxLocation[1].Y)).ToString() + "\n" +
                                (item.PxColors[2] == bmp.GetPixel(item.PxLocation[2].X, item.PxLocation[2].Y)).ToString() + "\n" +
                                (item.PxColors[3] == bmp.GetPixel(item.PxLocation[3].X, item.PxLocation[3].Y)).ToString()

                            );
                        if (dr == DialogResult.OK)
                            timer_tester.Start();
                    }
                    */
                    return false;
                }
            }
            return true;

            /*
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
            */
        }

        private void timer_start_Tick(object sender, EventArgs e)
        {
            
            foreach (var item in AS)
            {
                if (item.Enable)
                {
                    item.Lab.BackColor = Color.Yellow;

                    /*
                    try
                    {
                        this.Cursor = new Cursor(Cursor.Current.Handle);
                        if (
                            item.Pan.Location.X < Cursor.Position.X && item.Pan.Location.Y < Cursor.Position.Y &&
                            (item.Pan.Location.X + item.Size.Width) > Cursor.Position.X && (item.Pan.Location.Y + item.Size.Height) > Cursor.Position.Y
                            )
                        {
                            string op = (Cursor.Position.X - item.Pan.Location.X).ToString() + "; " + (Cursor.Position.Y - item.Pan.Location.Y).ToString();

                            Bitmap bmp = new Bitmap(item.Size.Width, item.Size.Height); //System.ArgumentException: 'Parameter is not valid.'
                            Graphics g = Graphics.FromImage(bmp);
                            g.CopyFromScreen(item.Pan.PointToScreen(new Point(0, 0)), new Point(0, 0), new Size(item.Size.Width, item.Size.Height));
                            Color fnd = bmp.GetPixel(Cursor.Position.X - item.Pan.Location.X, Cursor.Position.Y - item.Pan.Location.Y);
                            op += " | R:" + fnd.R.ToString() + " | G:" + fnd.G.ToString() + " | B:" + fnd.B.ToString();
                            item.Lab_o.Text = op;
                        }
                    }
                    catch (Exception) {}
                    */
                    
                    if (GetTextFromPanel(item) || item.Force)
                    {
                        item.Lab.BackColor = Color.Green;
                        if (item.ForceOff)
                        {
                            item.Lab.Update();
                            Thread.Sleep(2000);
                            item.ForceOff = false;
                        }
                        try
                        {
                            if (item.NameOf == "Start" && (Mute == false || item.Force))
                            {
                                sql_send_mute.ExecuteNonQuery();
                                Mute = true;
                                SetEnable("Start",false);
                                SetEnable("TabletCorner",true);
                                SetEnable("End",true);
                            }

                            else if (item.NameOf == "End" && (Mute == true || item.Force))
                            {
                                sql_send_unmute.ExecuteNonQuery();
                                Mute = false;
                                SetEnable("Start",true);
                                SetEnable("TabletCorner",false);
                                SetEnable("End",false);
                            }
                            else if(item.NameOf == "TabletCorner" && (Mute == true || item.Force))
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
                item.Force = false;
            }
        }

        private void SetEnable(string Name, bool enable)
        {
            foreach (var item in AS.FindAll(x => x.NameOf == Name))
            {
                item.Enable = enable;
            }
        }

        private void label_ShowClick(object sender, EventArgs e)
        {
            foreach (var item in AS)
            {
                if (((Control)sender).Name == item.Lab.Name)
                {
                    item.Force = true;
                    item.ForceOff = true;
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

        private void button_enable_Click(object sender, EventArgs e)
        {
            timer_tester.Enabled = !timer_tester.Enabled;
            button_enable.BackColor = timer_tester.Enabled ? Color.Lime : Color.Red;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(0, 400);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label_refreshvalue.Text = (trackBar1.Value < 10 ? 10 : trackBar1.Value).ToString();
            timer_tester.Interval = trackBar1.Value < 10 ? 10 : trackBar1.Value;
        }
    }
    public class AmongState
    {
        public string NameOf;
        public bool Force = false;
        public bool ForceOff = false;
        public bool Enable = false;

        public Label Lab;
        public Label Lab_o;
        public Panel Pan;

        public Size Size;

        public Color[] PxColors;
        public Point[] PxLocation;
    }
}

