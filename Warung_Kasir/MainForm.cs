using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Warung_Kasir{
	
	public partial class MainForm : Form{
		
		public MainForm(){
			
			InitializeComponent();
		}
		
		void Button1Click(object sender, EventArgs e){
			
			double Harga=0,Jumlah=0,Total=0, TotalKeseluruhan=0, pajak=0, jumlahUang=0, kembalian=0, Langganan, pajakLangganan;
			int i;
			
			NumericUpDown[] jumlah = new NumericUpDown[7];
			jumlah[0] = numericUpDown1;
			jumlah[1] = numericUpDown2;
			jumlah[2] = numericUpDown3;
			jumlah[3] = numericUpDown6;
			jumlah[4] = numericUpDown5;
			jumlah[5] = numericUpDown4;
			jumlah[6] = numericUpDown7;
			
			TextBox[] harga = new TextBox[7];
			harga[0] = textBox1;
			harga[1] = textBox2;
			harga[2] = textBox3;
			harga[3] = textBox6;
			harga[4] = textBox5;
			harga[5] = textBox4;
			harga[6] = textBox7;
			
			Label[] total = new Label[7];
			total[0] = label3;
			total[1] = label7;
			total[2] = label10;
			total[3] = label22;
			total[4] = label13;
			total[5] = label16;
			total[6] = label25;
			
			for (i=0; i<7; i++){
				
				Harga = Convert.ToDouble(harga[i].Text);
				Jumlah = Convert.ToDouble(jumlah[i].Value);
				Total = Harga * Jumlah;
				
				total[i].Text = Total.ToString("N");
				TotalKeseluruhan = TotalKeseluruhan + Total;
			}
			
			if(checkBox1.Checked){
				
				pajak = TotalKeseluruhan / 100;
				pajakLangganan = pajak * 10 / 100;
				pajak = pajak - pajakLangganan;
				
				Langganan = TotalKeseluruhan * 10 / 100;
				TotalKeseluruhan = TotalKeseluruhan - Langganan;
				
				label37.Text = pajak.ToString("N");
				label33.Text = TotalKeseluruhan.ToString("N");
			}
			else{
				
				pajak = TotalKeseluruhan / 100;
				
				label37.Text = pajak.ToString("N");
				label33.Text = TotalKeseluruhan.ToString("N");
			}
			
			if(double.TryParse(textBox8.Text,out jumlahUang)){
				
					kembalian = jumlahUang - (TotalKeseluruhan + pajak);
			}
			if(kembalian>0){
				label38.Text = kembalian.ToString("N");
				label39.Text = String.Empty;
			}
			if(kembalian<0){
				label38.Text = String.Empty;
				label39.Text = "UANGNYA KURANG!!!! :(" ;
			}
			if(jumlahUang==0){
				label38.Text = String.Empty;
				label39.Text = String.Empty;
			}
		}
		
		void Button2Click(object sender, EventArgs e){
			
			textBox8.Clear();
			numericUpDown1.Value = 0;
			numericUpDown2.Value = 0;
			numericUpDown3.Value = 0;
			numericUpDown4.Value = 0;
			numericUpDown5.Value = 0;
			numericUpDown6.Value = 0;
			numericUpDown7.Value = 0;
            label3.Text = String.Empty;
            label7.Text = String.Empty;
            label10.Text = String.Empty;
            label22.Text = String.Empty;
            label16.Text = String.Empty;
            label13.Text = String.Empty;
            label25.Text = String.Empty;
            label33.Text = String.Empty;
            label37.Text = String.Empty;
            label38.Text = String.Empty;
            label39.Text = String.Empty;
            checkBox1.Checked  = false ;
		}
	}
}