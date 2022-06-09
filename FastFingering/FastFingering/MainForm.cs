/*
 * Created by SharpDevelop.
 * User: ASUS
 * Date: 5/24/2022
 * Time: 9:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using System.Data;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Threading;

namespace FastFingering
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		string[] internasional = {"start", "private", "sharp", "else", "where", "public", "void", "system", "class", "compile",
						"new", "database", "select", "number", "input", "output", "multi", "keyboard", "option", "coding",
						"integer", "bool", "string", "decimal", "double", "break", "queue", "word", "char" ,"open"};
		string[] bahasa = {"mulai", "masak", "mengetik", "membaca", "lari", "layar", "kucing", "hewan", "kakak", "minum", "menangis",
						"udara", "mobil", "kerja", "hitam", "kenapa", "mudah", "sudah", "tidur", "sakit", "matahari", "kursi", "pasir",
						"meja", "kursi", "burung", "rumah"};
		string[] kata2;
		int num = 0;
        int wordI, s ,skor1 = 1;
		
		System.Timers.Timer t;		
        
        public MainForm()
        {
            InitializeComponent();
            
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += OnTimeEvent;
        }
        
        //Membuat pilihan bahasa menggunakan label click
        	//Bahasa Indonesia
        void IndonesiaClick(object sender, EventArgs e)
		{
			kata2 = bahasa;
			kata.Text = kata2[0];
			wordI = kata2.Length;
		}
			//Bahasa Inggris
		void InggrisClick(object sender, EventArgs e)
		{
			kata2 = internasional;
			kata.Text = kata2[0];
			wordI = kata2.Length;
		}
		
		//Merubah label pilihan bahasa jika mouse pada pilihan.
		void EbahasaInd(object sender, EventArgs e)
		{
			indonesia.ForeColor = Color.Purple;
		}
		
		void LbahasaInd(object sender, EventArgs e)
		{
			indonesia.ForeColor = Color.White;
		}
		
		void EbahasaIng(object sender, EventArgs e)
		{
			Inggris.ForeColor = Color.Purple;
		}
		
		void LbahasaIng(object sender, EventArgs e)
		{
			Inggris.ForeColor = Color.White;
		}
 
		//Even pada textBox, jika berubah maka akan memulai even
        private void playGame(object sender, EventArgs e)
        {
            mulai();
            t.Start();
        }
        
        //Membuat label kata.text menampung kata kata yang inggin di ketikan
        public void mulai(){
        	if(kata.Text == textBox1.Text)
            {
            	Random rnd = new Random();
				skor.Text = skor1.ToString();
				skor1 ++;
                if (num == 0){
            		kata.Text = kata2[rnd.Next(0, wordI)];
                	textBox1.Text = "";  	
            	}
            }
        }
        
        //Membuat timer
        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e){
        	Invoke(new Action(() =>{
        	                  	s += 1;
        	                  	if (s <= 60){
        	                  		waktu.Text = s.ToString();
        	                  	}
        	                  	else{
        	                  		Thread.Sleep(5000);
        	                  		Environment.Exit(0);
        	                  	}
        	                  }));
        }
	}
}
