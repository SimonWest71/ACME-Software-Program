﻿namespace Movie_InterfaceAPI
{
	partial class Main
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
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SearchTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MoviesFLP = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MultipleCb = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchPanel
            // 
            this.SearchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchPanel.Controls.Add(this.SearchBtn);
            this.SearchPanel.Controls.Add(this.SearchTb);
            this.SearchPanel.Location = new System.Drawing.Point(481, 12);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(311, 34);
            this.SearchPanel.TabIndex = 0;
            // 
            // SearchBtn
            // 
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Image = global::Movie_InterfaceAPI.Properties.Resources.icons8_search_22;
            this.SearchBtn.Location = new System.Drawing.Point(274, 3);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(29, 25);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // SearchTb
            // 
            this.SearchTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.SearchTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTb.ForeColor = System.Drawing.Color.White;
            this.SearchTb.Location = new System.Drawing.Point(8, 7);
            this.SearchTb.Name = "SearchTb";
            this.SearchTb.Size = new System.Drawing.Size(252, 17);
            this.SearchTb.TabIndex = 0;
            this.SearchTb.Text = "Search for movie title...";
            this.SearchTb.Enter += new System.EventHandler(this.SearchTb_Enter);
            this.SearchTb.Leave += new System.EventHandler(this.SearchTb_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "OMDB Movie Browser";
            // 
            // MoviesFLP
            // 
            this.MoviesFLP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MoviesFLP.AutoScroll = true;
            this.MoviesFLP.Location = new System.Drawing.Point(12, 93);
            this.MoviesFLP.Name = "MoviesFLP";
            this.MoviesFLP.Size = new System.Drawing.Size(780, 375);
            this.MoviesFLP.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 1);
            this.panel1.TabIndex = 3;
            // 
            // MultipleCb
            // 
            this.MultipleCb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MultipleCb.AutoSize = true;
            this.MultipleCb.Checked = true;
            this.MultipleCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MultipleCb.ForeColor = System.Drawing.Color.White;
            this.MultipleCb.Location = new System.Drawing.Point(693, 53);
            this.MultipleCb.Name = "MultipleCb";
            this.MultipleCb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MultipleCb.Size = new System.Drawing.Size(99, 17);
            this.MultipleCb.TabIndex = 4;
            this.MultipleCb.Text = "Search Multiple";
            this.MultipleCb.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Created by Richard Jacobs, Simon West, Alisdair Keay, Diogo Ribeiro and Jason Mal" +
    "colm";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(804, 480);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MultipleCb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MoviesFLP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchPanel);
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OMDB Movie Browser (v.012)";
            this.Load += new System.EventHandler(this.Main_Load);
            this.SearchPanel.ResumeLayout(false);
            this.SearchPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel SearchPanel;
		private System.Windows.Forms.Button SearchBtn;
		private System.Windows.Forms.TextBox SearchTb;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FlowLayoutPanel MoviesFLP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox MultipleCb;
        private System.Windows.Forms.Label label2;
    }
}

