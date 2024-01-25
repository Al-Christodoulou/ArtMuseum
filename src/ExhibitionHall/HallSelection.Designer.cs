﻿namespace Ergasia3.src.ExhibitionHall
{
	partial class HallSelection
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new Panel();
			this.panel2 = new Panel();
			this.button4 = new Button();
			this.pictureBox1 = new PictureBox();
			this.label1 = new Label();
			this.button1 = new Button();
			this.button2 = new Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			(( System.ComponentModel.ISupportInitialize )this.pictureBox1).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = Color.SlateBlue;
			this.panel1.Controls.Add( this.panel2 );
			this.panel1.Controls.Add( this.label1 );
			this.panel1.ForeColor = Color.RosyBrown;
			this.panel1.Location = new Point( 2, 3 );
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size( 537, 374 );
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = Color.MediumSlateBlue;
			this.panel2.Controls.Add( this.button2 );
			this.panel2.Controls.Add( this.button1 );
			this.panel2.Controls.Add( this.button4 );
			this.panel2.Controls.Add( this.pictureBox1 );
			this.panel2.Location = new Point( 3, 72 );
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size( 531, 299 );
			this.panel2.TabIndex = 24;
			// 
			// button4
			// 
			this.button4.BackColor = Color.DarkSlateBlue;
			this.button4.Font = new Font( "Lucida Calligraphy", 12F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.button4.ForeColor = Color.Snow;
			this.button4.Location = new Point( 41, 29 );
			this.button4.Name = "button4";
			this.button4.Size = new Size( 147, 51 );
			this.button4.TabIndex = 8;
			this.button4.Text = "Art";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = Color.MediumSlateBlue;
			this.pictureBox1.Image = Properties.Resources.ArtLogo;
			this.pictureBox1.Location = new Point( 233, 29 );
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size( 267, 245 );
			this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 10;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = FlatStyle.Flat;
			this.label1.Font = new Font( "Lucida Bright", 22.2F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.label1.ForeColor = Color.SeaShell;
			this.label1.Location = new Point( 126, 6 );
			this.label1.Name = "label1";
			this.label1.Size = new Size( 300, 42 );
			this.label1.TabIndex = 23;
			this.label1.Text = "Select category";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.BackColor = Color.DarkSlateBlue;
			this.button1.Font = new Font( "Lucida Calligraphy", 12F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.button1.ForeColor = Color.Snow;
			this.button1.Location = new Point( 41, 126 );
			this.button1.Name = "button1";
			this.button1.Size = new Size( 147, 51 );
			this.button1.TabIndex = 11;
			this.button1.Text = "Music";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = Color.DarkSlateBlue;
			this.button2.Font = new Font( "Lucida Calligraphy", 12F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.button2.ForeColor = Color.Snow;
			this.button2.Location = new Point( 41, 223 );
			this.button2.Name = "button2";
			this.button2.Size = new Size( 147, 51 );
			this.button2.TabIndex = 12;
			this.button2.Text = "Movies";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// HallSelection
			// 
			AutoScaleDimensions = new SizeF( 8F, 20F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Snow;
			ClientSize = new Size( 542, 378 );
			Controls.Add( this.panel1 );
			ForeColor = Color.Transparent;
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "HallSelection";
			StartPosition = FormStartPosition.CenterScreen;
			this.panel1.ResumeLayout( false );
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout( false );
			(( System.ComponentModel.ISupportInitialize )this.pictureBox1).EndInit();
			this.ResumeLayout( false );
		}

		#endregion

		private Panel panel1;
		private PictureBox pictureBox1;
		private Button button4;
		private Label label1;
		private Panel panel2;
		private Button button2;
		private Button button1;
	}
}