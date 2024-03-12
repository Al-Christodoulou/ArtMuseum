﻿namespace Ergasia3.Source.Frontend.DJockeyHall
{
	partial class DJHall
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( DJHall ) );
			ListViewGroup listViewGroup13 = new ListViewGroup( "TItle", HorizontalAlignment.Left );
			ListViewGroup listViewGroup14 = new ListViewGroup( "Artist", HorizontalAlignment.Left );
			ListViewGroup listViewGroup15 = new ListViewGroup( "Category", HorizontalAlignment.Left );
			this.panel6 = new Panel();
			this.panel5 = new Panel();
			this.panel15 = new Panel();
			this.SignUpLbl = new LinkLabel();
			this.label3 = new Label();
			this.panel7 = new Panel();
			this.panel4 = new Panel();
			this.panel3 = new Panel();
			this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
			this.songsListView = new ListView();
			this.columnHeader1 = new ColumnHeader();
			this.columnHeader2 = new ColumnHeader();
			this.columnHeader3 = new ColumnHeader();
			this.columnHeader4 = new ColumnHeader();
			this.panel2 = new Panel();
			this.panel20 = new Panel();
			this.label2 = new Label();
			this.panel1 = new Panel();
			this.panel9 = new Panel();
			this.nextSongBtn = new Button();
			this.prevSongBtn = new Button();
			this.pauseButton = new Button();
			this.panel16 = new Panel();
			this.panel14 = new Panel();
			this.label1 = new Label();
			this.Volume_scrollbar = new VScrollBar();
			this.panel11 = new Panel();
			this.panel21 = new Panel();
			this.DJAudioPbx = new PictureBox();
			this.panel8 = new Panel();
			this.panel12 = new Panel();
			this.panel17 = new Panel();
			this.label5 = new Label();
			this.BPM_textLbl = new Label();
			this.panel13 = new Panel();
			this.playingSongLbl = new TextBox();
			this.BuyBtn = new Button();
			this.panel10 = new Panel();
			this.panel6.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel15.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			(( System.ComponentModel.ISupportInitialize )this.mediaPlayer).BeginInit();
			this.panel2.SuspendLayout();
			this.panel20.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel16.SuspendLayout();
			this.panel14.SuspendLayout();
			this.panel11.SuspendLayout();
			this.panel21.SuspendLayout();
			(( System.ComponentModel.ISupportInitialize )this.DJAudioPbx).BeginInit();
			this.panel8.SuspendLayout();
			this.panel12.SuspendLayout();
			this.panel17.SuspendLayout();
			this.panel13.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel6
			// 
			this.panel6.BackColor = Color.MediumSlateBlue;
			this.panel6.Controls.Add( this.panel5 );
			this.panel6.Controls.Add( this.panel7 );
			this.panel6.ForeColor = SystemColors.ControlText;
			this.panel6.Location = new Point( 3, 3 );
			this.panel6.Name = "panel6";
			this.panel6.Size = new Size( 1096, 516 );
			this.panel6.TabIndex = 16;
			// 
			// panel5
			// 
			this.panel5.BackColor = Color.DarkSlateBlue;
			this.panel5.Controls.Add( this.panel15 );
			this.panel5.ForeColor = SystemColors.ControlText;
			this.panel5.Location = new Point( 3, 3 );
			this.panel5.Name = "panel5";
			this.panel5.Size = new Size( 1090, 56 );
			this.panel5.TabIndex = 33;
			// 
			// panel15
			// 
			this.panel15.BackColor = Color.MediumSlateBlue;
			this.panel15.Controls.Add( this.SignUpLbl );
			this.panel15.Controls.Add( this.label3 );
			this.panel15.ForeColor = SystemColors.ControlText;
			this.panel15.Location = new Point( 3, 3 );
			this.panel15.Name = "panel15";
			this.panel15.Size = new Size( 1084, 51 );
			this.panel15.TabIndex = 0;
			// 
			// SignUpLbl
			// 
			this.SignUpLbl.ActiveLinkColor = Color.Snow;
			this.SignUpLbl.AutoSize = true;
			this.SignUpLbl.BackColor = Color.MediumSlateBlue;
			this.SignUpLbl.Font = new Font( "Lucida Console", 16.2F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.SignUpLbl.ForeColor = SystemColors.ControlText;
			this.SignUpLbl.LinkColor = Color.DarkSlateBlue;
			this.SignUpLbl.Location = new Point( 8, 11 );
			this.SignUpLbl.Name = "SignUpLbl";
			this.SignUpLbl.Size = new Size( 30, 28 );
			this.SignUpLbl.TabIndex = 25;
			this.SignUpLbl.TabStop = true;
			this.SignUpLbl.Text = "?";
			this.SignUpLbl.VisitedLinkColor = Color.Snow;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = Color.MediumSlateBlue;
			this.label3.FlatStyle = FlatStyle.Flat;
			this.label3.Font = new Font( "Lucida Bright", 22.2F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.label3.ForeColor = Color.Snow;
			this.label3.Location = new Point( 493, 4 );
			this.label3.Name = "label3";
			this.label3.Size = new Size( 142, 42 );
			this.label3.TabIndex = 22;
			this.label3.Text = "DJ hall";
			this.label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panel7
			// 
			this.panel7.BackColor = Color.DarkSlateBlue;
			this.panel7.Controls.Add( this.panel4 );
			this.panel7.ForeColor = SystemColors.ControlText;
			this.panel7.Location = new Point( 3, 61 );
			this.panel7.Name = "panel7";
			this.panel7.Size = new Size( 1090, 452 );
			this.panel7.TabIndex = 16;
			// 
			// panel4
			// 
			this.panel4.BackColor = Color.MediumSlateBlue;
			this.panel4.Controls.Add( this.panel3 );
			this.panel4.Controls.Add( this.panel2 );
			this.panel4.Controls.Add( this.panel1 );
			this.panel4.ForeColor = SystemColors.ControlText;
			this.panel4.Location = new Point( 3, 3 );
			this.panel4.Name = "panel4";
			this.panel4.Size = new Size( 1084, 446 );
			this.panel4.TabIndex = 11;
			// 
			// panel3
			// 
			this.panel3.BackColor = Color.DarkSlateBlue;
			this.panel3.Controls.Add( this.mediaPlayer );
			this.panel3.Controls.Add( this.songsListView );
			this.panel3.ForeColor = SystemColors.ControlText;
			this.panel3.Location = new Point( 421, 3 );
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size( 659, 349 );
			this.panel3.TabIndex = 1;
			// 
			// mediaPlayer
			// 
			this.mediaPlayer.Enabled = true;
			this.mediaPlayer.Location = new Point( 203, 94 );
			this.mediaPlayer.Margin = new Padding( 3, 4, 3, 4 );
			this.mediaPlayer.Name = "mediaPlayer";
			this.mediaPlayer.OcxState = ( AxHost.State )resources.GetObject( "mediaPlayer.OcxState" );
			this.mediaPlayer.Size = new Size( 280, 164 );
			this.mediaPlayer.TabIndex = 2;
			// 
			// songsListView
			// 
			this.songsListView.BackColor = Color.MediumSlateBlue;
			this.songsListView.BorderStyle = BorderStyle.None;
			this.songsListView.Columns.AddRange( new ColumnHeader[] { this.columnHeader1, this.columnHeader2, this.columnHeader3, this.columnHeader4 } );
			this.songsListView.Font = new Font( "Lucida Bright", 10.8F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.songsListView.ForeColor = Color.Snow;
			this.songsListView.GridLines = true;
			listViewGroup13.Header = "TItle";
			listViewGroup13.Name = "Title";
			listViewGroup14.Header = "Artist";
			listViewGroup14.Name = "Artist";
			listViewGroup15.Header = "Category";
			listViewGroup15.Name = "Category";
			this.songsListView.Groups.AddRange( new ListViewGroup[] { listViewGroup13, listViewGroup14, listViewGroup15 } );
			this.songsListView.Location = new Point( 3, 3 );
			this.songsListView.Name = "songsListView";
			this.songsListView.Size = new Size( 652, 343 );
			this.songsListView.TabIndex = 1;
			this.songsListView.UseCompatibleStateImageBehavior = false;
			this.songsListView.View = View.Details;
			this.songsListView.SelectedIndexChanged += this.songsListView_SelIndexChanged;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Title";
			this.columnHeader1.Width = 174;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Artist";
			this.columnHeader2.Width = 174;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Category";
			this.columnHeader3.Width = 174;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Duration";
			this.columnHeader4.Width = 174;
			// 
			// panel2
			// 
			this.panel2.BackColor = Color.DarkSlateBlue;
			this.panel2.Controls.Add( this.panel20 );
			this.panel2.ForeColor = SystemColors.ControlText;
			this.panel2.Location = new Point( 420, 354 );
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size( 660, 88 );
			this.panel2.TabIndex = 1;
			// 
			// panel20
			// 
			this.panel20.BackColor = Color.MediumSlateBlue;
			this.panel20.Controls.Add( this.panel10 );
			this.panel20.Controls.Add( this.BuyBtn );
			this.panel20.Controls.Add( this.label2 );
			this.panel20.ForeColor = SystemColors.ControlText;
			this.panel20.Location = new Point( 3, 4 );
			this.panel20.Name = "panel20";
			this.panel20.Size = new Size( 654, 80 );
			this.panel20.TabIndex = 17;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.MediumSlateBlue;
			this.label2.FlatStyle = FlatStyle.Flat;
			this.label2.Font = new Font( "Lucida Bright", 10.8F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.label2.ForeColor = Color.DarkSlateBlue;
			this.label2.Location = new Point( 10, 9 );
			this.label2.Name = "label2";
			this.label2.Size = new Size( 431, 60 );
			this.label2.TabIndex = 24;
			this.label2.Text = "Sing with your friends and compete together,\r\nto see who is better, by pressing on the\r\nkaraoke button :) See you on the stage!";
			this.label2.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.BackColor = Color.DarkSlateBlue;
			this.panel1.Controls.Add( this.panel9 );
			this.panel1.Controls.Add( this.panel8 );
			this.panel1.ForeColor = SystemColors.ControlText;
			this.panel1.Location = new Point( 3, 3 );
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size( 416, 439 );
			this.panel1.TabIndex = 0;
			// 
			// panel9
			// 
			this.panel9.BackColor = Color.MediumSlateBlue;
			this.panel9.Controls.Add( this.nextSongBtn );
			this.panel9.Controls.Add( this.prevSongBtn );
			this.panel9.Controls.Add( this.pauseButton );
			this.panel9.Controls.Add( this.panel16 );
			this.panel9.Controls.Add( this.panel11 );
			this.panel9.ForeColor = SystemColors.ControlText;
			this.panel9.Location = new Point( 3, 67 );
			this.panel9.Name = "panel9";
			this.panel9.Size = new Size( 410, 368 );
			this.panel9.TabIndex = 64;
			// 
			// nextSongBtn
			// 
			this.nextSongBtn.BackColor = Color.DarkSlateBlue;
			this.nextSongBtn.Font = new Font( "Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.nextSongBtn.ForeColor = Color.Snow;
			this.nextSongBtn.Location = new Point( 304, 293 );
			this.nextSongBtn.Name = "nextSongBtn";
			this.nextSongBtn.Padding = new Padding( 5, 0, 0, 1 );
			this.nextSongBtn.Size = new Size( 85, 60 );
			this.nextSongBtn.TabIndex = 74;
			this.nextSongBtn.Text = ">>";
			this.nextSongBtn.UseVisualStyleBackColor = false;
			this.nextSongBtn.Click += this.nextSongBtn_Click;
			// 
			// prevSongBtn
			// 
			this.prevSongBtn.BackColor = Color.DarkSlateBlue;
			this.prevSongBtn.Font = new Font( "Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.prevSongBtn.ForeColor = Color.Snow;
			this.prevSongBtn.Location = new Point( 22, 293 );
			this.prevSongBtn.Name = "prevSongBtn";
			this.prevSongBtn.Padding = new Padding( 1, 0, 0, 1 );
			this.prevSongBtn.Size = new Size( 85, 60 );
			this.prevSongBtn.TabIndex = 73;
			this.prevSongBtn.Text = "<<";
			this.prevSongBtn.UseVisualStyleBackColor = false;
			this.prevSongBtn.Click += this.prevSongBtn_Click;
			// 
			// pauseButton
			// 
			this.pauseButton.BackColor = Color.DarkSlateBlue;
			this.pauseButton.Font = new Font( "Lucida Bright", 16.2F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.pauseButton.ForeColor = Color.Snow;
			this.pauseButton.Location = new Point( 133, 293 );
			this.pauseButton.Name = "pauseButton";
			this.pauseButton.Padding = new Padding( 9, 0, 0, 3 );
			this.pauseButton.Size = new Size( 145, 60 );
			this.pauseButton.TabIndex = 72;
			this.pauseButton.Text = "|>";
			this.pauseButton.UseVisualStyleBackColor = false;
			this.pauseButton.Click += this.pauseButton_Click;
			// 
			// panel16
			// 
			this.panel16.BackColor = Color.DarkSlateBlue;
			this.panel16.Controls.Add( this.panel14 );
			this.panel16.ForeColor = SystemColors.ControlText;
			this.panel16.Location = new Point( 3, 3 );
			this.panel16.Name = "panel16";
			this.panel16.Size = new Size( 91, 279 );
			this.panel16.TabIndex = 71;
			// 
			// panel14
			// 
			this.panel14.BackColor = Color.MediumSlateBlue;
			this.panel14.Controls.Add( this.label1 );
			this.panel14.Controls.Add( this.Volume_scrollbar );
			this.panel14.ForeColor = SystemColors.ControlText;
			this.panel14.Location = new Point( 3, 3 );
			this.panel14.Name = "panel14";
			this.panel14.Size = new Size( 85, 273 );
			this.panel14.TabIndex = 69;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.MediumSlateBlue;
			this.label1.FlatStyle = FlatStyle.Flat;
			this.label1.Font = new Font( "Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.label1.ForeColor = Color.Snow;
			this.label1.Location = new Point( 29, 235 );
			this.label1.Name = "label1";
			this.label1.Size = new Size( 28, 26 );
			this.label1.TabIndex = 65;
			this.label1.Text = "%";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// Volume_scrollbar
			// 
			this.Volume_scrollbar.Location = new Point( 22, 19 );
			this.Volume_scrollbar.Name = "Volume_scrollbar";
			this.Volume_scrollbar.Size = new Size( 41, 207 );
			this.Volume_scrollbar.TabIndex = 60;
			this.Volume_scrollbar.Value = 80;
			this.Volume_scrollbar.ValueChanged += this.BPM_scrollbar_ValueChanged;
			// 
			// panel11
			// 
			this.panel11.BackColor = Color.DarkSlateBlue;
			this.panel11.Controls.Add( this.panel21 );
			this.panel11.ForeColor = SystemColors.ControlText;
			this.panel11.Location = new Point( 95, 3 );
			this.panel11.Name = "panel11";
			this.panel11.Size = new Size( 312, 279 );
			this.panel11.TabIndex = 68;
			// 
			// panel21
			// 
			this.panel21.BackColor = Color.MediumSlateBlue;
			this.panel21.Controls.Add( this.DJAudioPbx );
			this.panel21.ForeColor = SystemColors.ControlText;
			this.panel21.Location = new Point( 3, 3 );
			this.panel21.Name = "panel21";
			this.panel21.Size = new Size( 306, 273 );
			this.panel21.TabIndex = 0;
			// 
			// DJAudioPbx
			// 
			this.DJAudioPbx.BackColor = Color.MediumSlateBlue;
			this.DJAudioPbx.ForeColor = SystemColors.ControlText;
			this.DJAudioPbx.Location = new Point( 3, 3 );
			this.DJAudioPbx.Name = "DJAudioPbx";
			this.DJAudioPbx.Size = new Size( 300, 267 );
			this.DJAudioPbx.SizeMode = PictureBoxSizeMode.CenterImage;
			this.DJAudioPbx.TabIndex = 0;
			this.DJAudioPbx.TabStop = false;
			// 
			// panel8
			// 
			this.panel8.BackColor = Color.MediumSlateBlue;
			this.panel8.Controls.Add( this.panel12 );
			this.panel8.ForeColor = SystemColors.ControlText;
			this.panel8.Location = new Point( 3, 3 );
			this.panel8.Name = "panel8";
			this.panel8.Size = new Size( 410, 64 );
			this.panel8.TabIndex = 63;
			// 
			// panel12
			// 
			this.panel12.BackColor = Color.DarkSlateBlue;
			this.panel12.Controls.Add( this.panel17 );
			this.panel12.Controls.Add( this.panel13 );
			this.panel12.ForeColor = SystemColors.ControlText;
			this.panel12.Location = new Point( 2, 3 );
			this.panel12.Name = "panel12";
			this.panel12.Size = new Size( 405, 59 );
			this.panel12.TabIndex = 17;
			// 
			// panel17
			// 
			this.panel17.BackColor = Color.MediumSlateBlue;
			this.panel17.Controls.Add( this.label5 );
			this.panel17.Controls.Add( this.BPM_textLbl );
			this.panel17.ForeColor = SystemColors.ControlText;
			this.panel17.Location = new Point( 304, 3 );
			this.panel17.Name = "panel17";
			this.panel17.Size = new Size( 97, 52 );
			this.panel17.TabIndex = 1;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = Color.MediumSlateBlue;
			this.label5.FlatStyle = FlatStyle.Flat;
			this.label5.Font = new Font( "Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.label5.ForeColor = Color.Snow;
			this.label5.Location = new Point( 59, 13 );
			this.label5.Name = "label5";
			this.label5.Size = new Size( 28, 26 );
			this.label5.TabIndex = 64;
			this.label5.Text = "%";
			this.label5.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// BPM_textLbl
			// 
			this.BPM_textLbl.AutoSize = true;
			this.BPM_textLbl.BackColor = Color.MediumSlateBlue;
			this.BPM_textLbl.FlatStyle = FlatStyle.Flat;
			this.BPM_textLbl.Font = new Font( "Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.BPM_textLbl.ForeColor = Color.DarkSlateBlue;
			this.BPM_textLbl.Location = new Point( 10, 13 );
			this.BPM_textLbl.Name = "BPM_textLbl";
			this.BPM_textLbl.Size = new Size( 54, 26 );
			this.BPM_textLbl.TabIndex = 46;
			this.BPM_textLbl.Text = "100";
			this.BPM_textLbl.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panel13
			// 
			this.panel13.BackColor = Color.MediumSlateBlue;
			this.panel13.Controls.Add( this.playingSongLbl );
			this.panel13.ForeColor = SystemColors.ControlText;
			this.panel13.Location = new Point( 3, 3 );
			this.panel13.Name = "panel13";
			this.panel13.Size = new Size( 299, 52 );
			this.panel13.TabIndex = 0;
			// 
			// playingSongLbl
			// 
			this.playingSongLbl.BackColor = Color.MediumSlateBlue;
			this.playingSongLbl.BorderStyle = BorderStyle.None;
			this.playingSongLbl.Font = new Font( "Lucida Bright", 10.8F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.playingSongLbl.ForeColor = Color.Snow;
			this.playingSongLbl.Location = new Point( 16, 16 );
			this.playingSongLbl.Name = "playingSongLbl";
			this.playingSongLbl.ReadOnly = true;
			this.playingSongLbl.Size = new Size( 270, 22 );
			this.playingSongLbl.TabIndex = 0;
			this.playingSongLbl.Text = "ArtistTitleCategory";
			// 
			// BuyBtn
			// 
			this.BuyBtn.BackColor = Color.DarkSlateBlue;
			this.BuyBtn.Font = new Font( "Lucida Calligraphy", 10.8F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.BuyBtn.ForeColor = Color.Snow;
			this.BuyBtn.Location = new Point( 498, 11 );
			this.BuyBtn.Name = "BuyBtn";
			this.BuyBtn.Size = new Size( 142, 56 );
			this.BuyBtn.TabIndex = 87;
			this.BuyBtn.Text = "Karaoke";
			this.BuyBtn.UseVisualStyleBackColor = false;
			// 
			// panel10
			// 
			this.panel10.BackColor = Color.DarkSlateBlue;
			this.panel10.Location = new Point( 465, 10 );
			this.panel10.Name = "panel10";
			this.panel10.Size = new Size( 5, 60 );
			this.panel10.TabIndex = 17;
			// 
			// DJHall
			// 
			this.AutoScaleDimensions = new SizeF( 8F, 20F );
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.DarkSlateBlue;
			this.ClientSize = new Size( 1102, 523 );
			this.Controls.Add( this.panel6 );
			this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			this.Margin = new Padding( 3, 4, 3, 4 );
			this.MaximizeBox = false;
			this.Name = "DJHall";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.FormClosed += this.DigitalDJ_FormClosed;
			this.Shown += this.DigitalDJForm_Shown;
			this.panel6.ResumeLayout( false );
			this.panel5.ResumeLayout( false );
			this.panel15.ResumeLayout( false );
			this.panel15.PerformLayout();
			this.panel7.ResumeLayout( false );
			this.panel4.ResumeLayout( false );
			this.panel3.ResumeLayout( false );
			(( System.ComponentModel.ISupportInitialize )this.mediaPlayer).EndInit();
			this.panel2.ResumeLayout( false );
			this.panel20.ResumeLayout( false );
			this.panel20.PerformLayout();
			this.panel1.ResumeLayout( false );
			this.panel9.ResumeLayout( false );
			this.panel16.ResumeLayout( false );
			this.panel14.ResumeLayout( false );
			this.panel14.PerformLayout();
			this.panel11.ResumeLayout( false );
			this.panel21.ResumeLayout( false );
			(( System.ComponentModel.ISupportInitialize )this.DJAudioPbx).EndInit();
			this.panel8.ResumeLayout( false );
			this.panel12.ResumeLayout( false );
			this.panel17.ResumeLayout( false );
			this.panel17.PerformLayout();
			this.panel13.ResumeLayout( false );
			this.panel13.PerformLayout();
			this.ResumeLayout( false );
		}

		#endregion
		private Panel panel6;
		private Panel panel7;
		private Panel panel4;
		private Panel panel3;
		private ListView songsListView;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private Panel panel2;
		private Panel panel20;
		private Panel panel1;
		private Panel panel9;
		private Button nextSongBtn;
		private Button prevSongBtn;
		private Button pauseButton;
		private Panel panel16;
		private Panel panel14;
		private VScrollBar Volume_scrollbar;
		private Panel panel11;
		private Panel panel8;
		private Panel panel5;
		private Panel panel15;
		private Label label3;
		private Panel panel12;
		private Panel panel13;
		private Panel panel17;
		private Label BPM_textLbl;
		private TextBox playingSongLbl;
		private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
		private LinkLabel SignUpLbl;
		private Label label5;
		private Label label1;
		private Panel panel21;
		private PictureBox DJAudioPbx;
		private Label label2;
		private Button BuyBtn;
		private Panel panel10;
	}
}
