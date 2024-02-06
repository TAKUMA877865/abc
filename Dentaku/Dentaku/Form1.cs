using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentaku
{
    public partial class Form1 : Form
    {
		private int kazu;
		private int num;	  //num=
							  //0なら何もしない
							  //1なら足し算
							  //2なら引き算
        public Form1()
        {
            InitializeComponent();
			kazu = 0;    //計算用の数字の初期値は０にしておく

			//計算スイッチを初期状態では０にしておく
			num = 0;


			label1.Text = "0";

			button1.Text = "CLR";
			button1.Click += btn_clear;

			button13.Text = "+";
			button18.Text = "=";
			button9.Text = "-";
			button5.Text = "×";
			button4.Text = "÷";

			button13.Click += btn_plus;
			button18.Click += btn_equal;
			button9.Click += btn_minus;
			button5.Click += btn_multiply;
			button4.Click += btn_waru;





			//まずは空っぽの配列をつくって、そこにボタンを収納
			Button[] btns = {button17,
							button16,button15,button14,
							button12,button11,button10,
							button8,button7,button6};
			

			for (var i = 0; i<10; i++)	{	
			
				btns[i].Text = i.ToString();//iの値を文字化して埋め込む

				btns[ i ].Click += ClickBtn;
				
			}
		}

		//ボタンが押されたら、共通で呼び出す
			public void ClickBtn( object sender, EventArgs ev )
		{
			if (label1.Text.Equals("0"))
			{
				//押されたボタンの数字をそのまま記述
				label1.Text = ((Button)sender).Text;
			}else {
				//現在の値を数値化
				var work = Int32.Parse(label1.Text);

				//これ以上桁数が増えたらよくない
				if(work > (Int32.MaxValue /10))
				{		//何もしない

				}else
				{
					//違うならもともとあった数字に追加
					label1.Text += ((Button)sender).Text;
				}
			}

			
				
				
			
		
		}
		public void btn_clear ( object sender, EventArgs ev )
		{
			label1.Text = "0";
			//クリアボタンを押したときは、スイッチを初期状態に戻す
		}
		public void btn_plus(object sender,EventArgs ev)
		{
			
			kazu = Int32.Parse(label1.Text);
			label1.Text = "0";
			num = 1;

		}
		public void btn_equal(object sender,EventArgs ev )
		{
			int work = Int32.Parse(label1.Text);
			

			if (num==1)
			{
				work =work + kazu;
				label1.Text = work.ToString();
			}else  if(num==2)
			{
				work = kazu - work;
				label1.Text = work.ToString();
			}else if(num==3)
			{
				work = kazu * work;
				label1.Text = work.ToString();
			}else if (num == 4)
			{
				if (work != 0)
				{


					work = kazu / work;
					label1.Text = work.ToString();
					Console.WriteLine(label1.Text);
				}


			}
			//計算がおわったら、スイッチを０にする
			num = 0;
			

		


		}
		public void btn_minus(object sender,EventArgs ev)
		{
			kazu = Int32.Parse(label1.Text);
			label1.Text = "0";
			num = 2;
			
		}
		public void btn_multiply ( object sender, EventArgs ev )
		{
			
			 kazu= Int32.Parse(label1.Text);
			label1.Text = "0";
			num = 3;
		}
		public void btn_waru(object sender,EventArgs ev )
		{
			Int32 kazu = Int32.Parse(label1.Text);
			label1.Text = "0";
			num = 4;
		}
			private void Form1_Load(object sender, EventArgs e)
        {

        }

	
	}
}
