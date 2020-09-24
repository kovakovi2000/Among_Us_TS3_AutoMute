namespace Among_Us_TS3BotUpdate
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label_state = new System.Windows.Forms.Label();
            this.label_start = new System.Windows.Forms.Label();
            this.label_end = new System.Windows.Forms.Label();
            this.timer_tester = new System.Windows.Forms.Timer(this.components);
            this.label_tabletcorner = new System.Windows.Forms.Label();
            this.button_enable = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_start_o = new System.Windows.Forms.Label();
            this.label_tabletcorner_o = new System.Windows.Forms.Label();
            this.label_end_o = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label_refreshvalue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_state
            // 
            this.label_state.AutoSize = true;
            this.label_state.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_state.ForeColor = System.Drawing.Color.White;
            this.label_state.Location = new System.Drawing.Point(32, 33);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(216, 26);
            this.label_state.TabIndex = 0;
            this.label_state.Text = "State: Waiting for start...";
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_start.ForeColor = System.Drawing.Color.White;
            this.label_start.Location = new System.Drawing.Point(12, 59);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(64, 26);
            this.label_start.TabIndex = 0;
            this.label_start.Text = "START";
            this.label_start.Click += new System.EventHandler(this.label_ShowClick);
            // 
            // label_end
            // 
            this.label_end.AutoSize = true;
            this.label_end.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_end.ForeColor = System.Drawing.Color.White;
            this.label_end.Location = new System.Drawing.Point(12, 111);
            this.label_end.Name = "label_end";
            this.label_end.Size = new System.Drawing.Size(44, 26);
            this.label_end.TabIndex = 0;
            this.label_end.Text = "END";
            this.label_end.Click += new System.EventHandler(this.label_ShowClick);
            // 
            // timer_tester
            // 
            this.timer_tester.Tick += new System.EventHandler(this.timer_start_Tick);
            // 
            // label_tabletcorner
            // 
            this.label_tabletcorner.AutoSize = true;
            this.label_tabletcorner.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_tabletcorner.ForeColor = System.Drawing.Color.White;
            this.label_tabletcorner.Location = new System.Drawing.Point(12, 85);
            this.label_tabletcorner.Name = "label_tabletcorner";
            this.label_tabletcorner.Size = new System.Drawing.Size(71, 26);
            this.label_tabletcorner.TabIndex = 0;
            this.label_tabletcorner.Text = "TABLET";
            this.label_tabletcorner.Click += new System.EventHandler(this.label_ShowClick);
            // 
            // button_enable
            // 
            this.button_enable.BackColor = System.Drawing.Color.Black;
            this.button_enable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_enable.ForeColor = System.Drawing.Color.White;
            this.button_enable.Location = new System.Drawing.Point(105, 7);
            this.button_enable.Name = "button_enable";
            this.button_enable.Size = new System.Drawing.Size(75, 23);
            this.button_enable.TabIndex = 1;
            this.button_enable.Text = "button_enable";
            this.button_enable.UseVisualStyleBackColor = false;
            this.button_enable.Click += new System.EventHandler(this.button_enable_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(259, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(16, 16);
            this.panel1.TabIndex = 2;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // label_start_o
            // 
            this.label_start_o.AutoSize = true;
            this.label_start_o.ForeColor = System.Drawing.Color.White;
            this.label_start_o.Location = new System.Drawing.Point(93, 70);
            this.label_start_o.Name = "label_start_o";
            this.label_start_o.Size = new System.Drawing.Size(0, 13);
            this.label_start_o.TabIndex = 3;
            // 
            // label_tabletcorner_o
            // 
            this.label_tabletcorner_o.AutoSize = true;
            this.label_tabletcorner_o.ForeColor = System.Drawing.Color.White;
            this.label_tabletcorner_o.Location = new System.Drawing.Point(93, 96);
            this.label_tabletcorner_o.Name = "label_tabletcorner_o";
            this.label_tabletcorner_o.Size = new System.Drawing.Size(0, 13);
            this.label_tabletcorner_o.TabIndex = 3;
            // 
            // label_end_o
            // 
            this.label_end_o.AutoSize = true;
            this.label_end_o.ForeColor = System.Drawing.Color.White;
            this.label_end_o.Location = new System.Drawing.Point(93, 122);
            this.label_end_o.Name = "label_end_o";
            this.label_end_o.Size = new System.Drawing.Size(0, 13);
            this.label_end_o.TabIndex = 3;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 146);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(205, 45);
            this.trackBar1.TabIndex = 4;
            this.trackBar1.Value = 200;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label_refreshvalue
            // 
            this.label_refreshvalue.AutoSize = true;
            this.label_refreshvalue.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_refreshvalue.ForeColor = System.Drawing.Color.White;
            this.label_refreshvalue.Location = new System.Drawing.Point(222, 138);
            this.label_refreshvalue.Name = "label_refreshvalue";
            this.label_refreshvalue.Size = new System.Drawing.Size(45, 26);
            this.label_refreshvalue.TabIndex = 0;
            this.label_refreshvalue.Text = "200";
            this.label_refreshvalue.Click += new System.EventHandler(this.label_ShowClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(275, 168);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label_end_o);
            this.Controls.Add(this.label_tabletcorner_o);
            this.Controls.Add(this.label_start_o);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_enable);
            this.Controls.Add(this.label_tabletcorner);
            this.Controls.Add(this.label_refreshvalue);
            this.Controls.Add(this.label_end);
            this.Controls.Add(this.label_start);
            this.Controls.Add(this.label_state);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_state;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Label label_end;
        private System.Windows.Forms.Timer timer_tester;
        private System.Windows.Forms.Label label_tabletcorner;
        private System.Windows.Forms.Button button_enable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_start_o;
        private System.Windows.Forms.Label label_tabletcorner_o;
        private System.Windows.Forms.Label label_end_o;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label_refreshvalue;
    }
}

