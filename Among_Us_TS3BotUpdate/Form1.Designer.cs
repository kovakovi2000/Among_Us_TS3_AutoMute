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
            this.label_vote_start = new System.Windows.Forms.Label();
            this.label_vote_under = new System.Windows.Forms.Label();
            this.label_vote_end = new System.Windows.Forms.Label();
            this.label_end = new System.Windows.Forms.Label();
            this.timer_tester = new System.Windows.Forms.Timer(this.components);
            this.button_save = new System.Windows.Forms.Button();
            this.label_tabletcorner = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_state
            // 
            this.label_state.AutoSize = true;
            this.label_state.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_state.Location = new System.Drawing.Point(12, 9);
            this.label_state.Name = "label_state";
            this.label_state.Size = new System.Drawing.Size(216, 26);
            this.label_state.TabIndex = 0;
            this.label_state.Text = "State: Waiting for start...";
            // 
            // label_start
            // 
            this.label_start.AutoSize = true;
            this.label_start.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_start.Location = new System.Drawing.Point(381, 9);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(64, 26);
            this.label_start.TabIndex = 0;
            this.label_start.Text = "START";
            this.label_start.Click += new System.EventHandler(this.label_start_Click);
            // 
            // label_vote_start
            // 
            this.label_vote_start.AutoSize = true;
            this.label_vote_start.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_vote_start.Location = new System.Drawing.Point(361, 35);
            this.label_vote_start.Name = "label_vote_start";
            this.label_vote_start.Size = new System.Drawing.Size(108, 26);
            this.label_vote_start.TabIndex = 0;
            this.label_vote_start.Text = "VOTE START";
            this.label_vote_start.Click += new System.EventHandler(this.label_vote_start_Click);
            // 
            // label_vote_under
            // 
            this.label_vote_under.AutoSize = true;
            this.label_vote_under.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_vote_under.Location = new System.Drawing.Point(359, 61);
            this.label_vote_under.Name = "label_vote_under";
            this.label_vote_under.Size = new System.Drawing.Size(110, 26);
            this.label_vote_under.TabIndex = 0;
            this.label_vote_under.Text = "VOTE UNDER";
            this.label_vote_under.Click += new System.EventHandler(this.label_vote_under_Click);
            // 
            // label_vote_end
            // 
            this.label_vote_end.AutoSize = true;
            this.label_vote_end.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_vote_end.Location = new System.Drawing.Point(371, 87);
            this.label_vote_end.Name = "label_vote_end";
            this.label_vote_end.Size = new System.Drawing.Size(88, 26);
            this.label_vote_end.TabIndex = 0;
            this.label_vote_end.Text = "VOTE END";
            this.label_vote_end.Click += new System.EventHandler(this.label_vote_end_Click);
            // 
            // label_end
            // 
            this.label_end.AutoSize = true;
            this.label_end.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_end.Location = new System.Drawing.Point(391, 113);
            this.label_end.Name = "label_end";
            this.label_end.Size = new System.Drawing.Size(44, 26);
            this.label_end.TabIndex = 0;
            this.label_end.Text = "END";
            this.label_end.Click += new System.EventHandler(this.label_end_Click);
            // 
            // timer_tester
            // 
            this.timer_tester.Tick += new System.EventHandler(this.timer_start_Tick);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(174, 38);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 23);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_tabletcorner
            // 
            this.label_tabletcorner.AutoSize = true;
            this.label_tabletcorner.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_tabletcorner.Location = new System.Drawing.Point(374, 137);
            this.label_tabletcorner.Name = "label_tabletcorner";
            this.label_tabletcorner.Size = new System.Drawing.Size(71, 26);
            this.label_tabletcorner.TabIndex = 0;
            this.label_tabletcorner.Text = "TABLET";
            this.label_tabletcorner.Click += new System.EventHandler(this.label_end_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 172);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label_tabletcorner);
            this.Controls.Add(this.label_end);
            this.Controls.Add(this.label_vote_end);
            this.Controls.Add(this.label_vote_under);
            this.Controls.Add(this.label_vote_start);
            this.Controls.Add(this.label_start);
            this.Controls.Add(this.label_state);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_state;
        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Label label_vote_start;
        private System.Windows.Forms.Label label_vote_under;
        private System.Windows.Forms.Label label_vote_end;
        private System.Windows.Forms.Label label_end;
        private System.Windows.Forms.Timer timer_tester;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_tabletcorner;
    }
}

