/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 5/24/2022
 * Time: 9:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace FastFingering
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.skor = new System.Windows.Forms.Label();
			this.kata = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.waktu = new System.Windows.Forms.Label();
			this.indonesia = new System.Windows.Forms.Label();
			this.Inggris = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(102, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(482, 38);
			this.label1.TabIndex = 0;
			this.label1.Text = "Belajar mengetik akurat selama 60 detik";
			// 
			// skor
			// 
			this.skor.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.skor.ForeColor = System.Drawing.Color.White;
			this.skor.Location = new System.Drawing.Point(180, 19);
			this.skor.Name = "skor";
			this.skor.Size = new System.Drawing.Size(86, 41);
			this.skor.TabIndex = 1;
			// 
			// kata
			// 
			this.kata.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.kata.ForeColor = System.Drawing.Color.White;
			this.kata.Location = new System.Drawing.Point(180, 121);
			this.kata.Name = "kata";
			this.kata.Size = new System.Drawing.Size(277, 56);
			this.kata.TabIndex = 2;
			this.kata.Text = "Ketik";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.Gray;
			this.textBox1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ForeColor = System.Drawing.Color.White;
			this.textBox1.Location = new System.Drawing.Point(180, 194);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(277, 41);
			this.textBox1.TabIndex = 3;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox1.TextChanged += new System.EventHandler(this.playGame);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(16, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(166, 41);
			this.label2.TabIndex = 4;
			this.label2.Text = "Kata selesai :";
			// 
			// waktu
			// 
			this.waktu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.waktu.ForeColor = System.Drawing.Color.Red;
			this.waktu.Location = new System.Drawing.Point(463, 196);
			this.waktu.Name = "waktu";
			this.waktu.Size = new System.Drawing.Size(100, 39);
			this.waktu.TabIndex = 5;
			// 
			// indonesia
			// 
			this.indonesia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.indonesia.ForeColor = System.Drawing.Color.White;
			this.indonesia.Location = new System.Drawing.Point(194, 313);
			this.indonesia.Name = "indonesia";
			this.indonesia.Size = new System.Drawing.Size(116, 36);
			this.indonesia.TabIndex = 8;
			this.indonesia.Text = "Indonesia";
			this.indonesia.Click += new System.EventHandler(this.IndonesiaClick);
			this.indonesia.MouseEnter += new System.EventHandler(this.EbahasaInd);
			this.indonesia.MouseLeave += new System.EventHandler(this.LbahasaInd);
			// 
			// Inggris
			// 
			this.Inggris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Inggris.ForeColor = System.Drawing.Color.White;
			this.Inggris.Location = new System.Drawing.Point(327, 313);
			this.Inggris.Name = "Inggris";
			this.Inggris.Size = new System.Drawing.Size(116, 36);
			this.Inggris.TabIndex = 9;
			this.Inggris.Text = "Inggris";
			this.Inggris.Click += new System.EventHandler(this.InggrisClick);
			this.Inggris.MouseEnter += new System.EventHandler(this.EbahasaIng);
			this.Inggris.MouseLeave += new System.EventHandler(this.LbahasaIng);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(248, 262);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(150, 32);
			this.label5.TabIndex = 10;
			this.label5.Text = "Pilih bahasa :";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.MidnightBlue;
			this.ClientSize = new System.Drawing.Size(632, 400);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.Inggris);
			this.Controls.Add(this.indonesia);
			this.Controls.Add(this.waktu);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.kata);
			this.Controls.Add(this.skor);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "FastFingering";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label Inggris;
		private System.Windows.Forms.Label indonesia;
		private System.Windows.Forms.Label waktu;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label kata;
		private System.Windows.Forms.Label skor;
		private System.Windows.Forms.Label label1;
	}
}
