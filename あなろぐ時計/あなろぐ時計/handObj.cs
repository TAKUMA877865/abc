using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace あなろぐ時計
{
	public class handObj
	{	
		protected Image handPic;
		protected float cx, cy; //画像の中心位置
		protected float x, y; //画像の表示位置
		protected float deg; //回転角度
		protected Matrix mx;    //マトリクス
		protected float sx, sy;//画像の拡大率
		protected float scale;	//Hi=Dpi対応スケール

		public handObj(float wcx,float wcy, float scale )
		{
			this.scale = scale;
			mx = new Matrix();
			mx.Reset();
		}
		protected void SetMatrix()
		{
			mx.Translate(-(x + cx), -(y + cy));
			mx.Rotate(deg, MatrixOrder.Append);
			mx.Scale(sx, sy, MatrixOrder.Append);
			mx.Translate((x + cx), (y + cy), MatrixOrder.Append);
		}

		protected void SetPos (float wx, float wy, float size)
		{
			//画像の水平位置と垂直位置を計算で求める
			x = (wy * scale) - cx;
			y = (wx * scale) - cy;
			//画像の倍率をセット。小数を表現するのに、Fを付与
			sx = size;
			sy = size;
		}
		//描写処理
		//virtualを付けておく
		virtual public void Draw(Graphics g )
		{
			g.Transform = mx;
			g.DrawImage(handPic, x,y);
			g.ResetTransform();

		}

		virtual public void Action ()
		{
			mx.Reset();

		}
	}
}
