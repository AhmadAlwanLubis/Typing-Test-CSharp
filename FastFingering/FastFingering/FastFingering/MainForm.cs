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
//		Kata yang akan di ketik
//			Inggris
		string[] internasional = {"start", "private", "sharp", "else", "where", "public", "void", "system", "class", "compile",
			"new", "database", "select", "number", "input", "output", "multi", "keyboard", "option", "coding",
			"integer", "bool", "string", "decimal", "double", "break", "queue", "word", "char" ,"open", "apple", "beach", "chocolate", "desk", "elephant", "forest", "guitar", "house", "internet", "jungle",
            "kite", "lamp", "mountain", "notebook", "ocean", "pencil", "queen", "river", "sugar", "tree",
            "umbrella", "violin", "waterfall", "xylophone", "yacht", "zebra", "arrow", "balloon", "cloud", "door",
            "eagle", "fire", "globe", "harp", "island", "jacket", "key", "lion", "moon", "nest",
            "owl", "pizza", "quilt", "rainbow", "star", "tiger", "unicorn", "vase", "window", "xylophone",
            "yogurt", "zoo", "airplane", "basketball", "camera", "dolphin", "elephant", "football", "garden", "hamburger",
            "ice cream", "jellyfish", "kangaroo", "laptop", "motorcycle", "note", "orange", "penguin", "quill", "ruler",
            "snake", "turtle", "umbrella", "violin", "whale", "xylophone", "yo-yo", "zeppelin", "ant", "butterfly",
            "crocodile", "dragonfly", "elephant", "flamingo", "gorilla", "hippopotamus", "iguana", "jellyfish", "koala", "lemur",
            "mongoose", "narwhal", "octopus", "peacock", "quail", "rhinoceros", "scorpion", "turtle", "unicorn", "vulture",
            "whale", "yak", "zebra"};
		
//			Indonesia
		string[] bahasa = {"mulai", "angkasa", "balon", "cetek", "dompet", "emosi", "fajar", "galon", "hujan", "ingus", "janggal",
            "kucing", "lampu", "makan", "nasi", "obrolan", "pohon", "quran", "rindu", "sandal", "tangan",
            "unggul", "virus", "warna", "xenon", "yel-yel", "zodiak", "alpukat", "bantal", "cinta", "dinding",
            "esok", "flora", "gajah", "hujung", "ilusi", "jendela", "kabel", "lukisan", "mimpi", "nampan",
            "ongkos", "pempek", "rantai", "selamat", "tulisan", "universitas", "venus", "wakil",
            "yayasan", "zaman", "amuba", "baris", "cangkir", "daster", "empat", "fisika", "gemuk", "hobi",
            "imajinasi", "jagung", "kelapa", "lampiran", "minyak", "novel", "oase", "pedang", "qalbu", "rebung",
            "sepatu", "telur", "undangan", "vokal", "waktu", "xenofobi", "yodium", "zat", "aplikasi", "bengkel",
            "coklat", "diam", "ekonomi", "fokus", "garam", "hari", "iman", "jasa", "kelingking", "logika",
            "mobil", "nomor", "oktober", "panas", "qadha", "resleting", "sapi", "televisi", "usaha", "virus corona",
            "waktu", "zodiak", "masak", "mengetik", "membaca", "lari", "layar", "kucing", "hewan", "kakak", "minum", "menangis",
			"udara", "mobil", "kerja", "hitam", "kenapa", "mudah", "sudah", "tidur", "sakit", "matahari", "kursi", "pasir",
			"meja", "kursi", "burung", "rumah"};
		
//		Variabel untuk menyimpan kata yang akan di ketik
		string[] kata2;
		
//		Tulisan yang muncul pada akhir program
		string lasttext;
		
//		wordI = menampung jumlah index pada string dari kata yang akan di ketik, s = menambah detik menjadi 1 pada timer, 
//		skor 1 = menampung jumlah ketikan kata yang benar.
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
			lasttext = "Waktu habis!";
		}
			//Bahasa Inggris
		void InggrisClick(object sender, EventArgs e)
		{
			kata2 = internasional;
			kata.Text = kata2[0];
			wordI = kata2.Length;
			lasttext = "Times is Up!";
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
                if (s <= 60){
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
        	                  	else if (s == 61){
        	                  		t.Enabled = false;
        	                  		DialogResult dr = MessageBox.Show(lasttext, "Text", MessageBoxButtons.RetryCancel);
        	                  		if(dr == DialogResult.Cancel){
        	                  			Environment.Exit(0);
        	                  			
        	                  		}else{
										skor1 = 1;
        	                  			textBox1.Text = "";
        	                  			mulai();
            							t.Start();
            							s = 0;
            							t.Enabled = true;
        	                  		}
        	                  	}
        	                  }));
        }
	}
}
