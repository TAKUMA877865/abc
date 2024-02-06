using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace あなろぐ時計
{
	public partial class Form1 : Form
		
	{
		private Timer tim;
		private ArrayList objAry;
		private float scale;
		public Form1 ()
		{
			InitializeComponent();
			this.DoubleBuffered = true;
			scale = GetWindowsScaling();

			objAry = new ArrayList();
			objAry.Add(new SecHand(425, 425,scale));
			objAry.Add(new minHand(425, 425, scale));
			objAry.Add(new hourHand(425, 425, scale));


			tim = new Timer();   //タイマ処理
			tim.Tick += tick_proc;
			tim.Interval = 10;	 //100ミリ秒に1回
			tim.Enabled = true;	//タイマ起動

		}
		
		//システムの解像度が、何倍かを調べる	
		public float GetWindowsScaling ()
		{
			float scale = 1.0F;         //まずは1.0倍としておく
			var bpm = new Bitmap(
				this.Width, this.Height, PixelFormat.Format24bppRgb);
			//ダミーのビットマップを使ってグラフィッククラスを作る
			using (var grp = Graphics.FromImage(bpm))
			{
				//グラフィックスクラスに解像度を聞く
				scale = grp.DpiX / 96f;
			}
			return scale;


		} 
		private void tick_proc(object o,EventArgs e )
		{
			foreach(handObj wk in objAry)
			{
				wk.Action();
			}
			
			this.Invalidate();
		}
	

		private void Form1_Load ( object sender, EventArgs e )
		{
			this.Invalidate();

		}
		protected override void OnPaint ( PaintEventArgs e )
		{
			base.OnPaint(e);
			foreach(handObj wk in objAry)
			{
				wk.Draw(e.Graphics);

			}
		}
	}
}
