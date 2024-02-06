using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace あなろぐ時計
{
	public class SecHand:handObj
	{
		//wxとwyｈｓ「時計の中心位置 」
		public SecHand(float wx,float wy, float scale) : base(wx,wy,scale) {
			this.handPic = Properties.Resources.sec_hand;
			//秒針の中心座標をセット（個人ごとに違う）
			cx = 27 * scale;		//scale倍して、倍率の補正
			cy = 648 * scale;       //scale倍して、倍率の補正
			SetPos(wx, wy, 0.5F);
		}
		public override void Action ()
		{
			base.Action();
			//針の角度を求める
			//現在の「秒」を求める
			deg = DateTime.Now.Second * 6;
			deg += DateTime.Now.Millisecond * 0.006f;
			SetMatrix();
		}
	}
}
