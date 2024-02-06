using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace あなろぐ時計
{
	class hourHand : handObj
	{
		public hourHand ( float wx, float wy, float scale ) : base(wx, wy, scale)
		{
			handPic = Properties.Resources.hour_hand;
			cx = 112 * scale;        //scale倍して、倍率の補正
			cy = 805 * scale;       //scale倍して、倍率の補正
			SetPos(wx, wy, 0.5F);
		}
		public override void Action ()
		{
			base.Action();
			deg = DateTime.Now.Hour * 30;
			deg += DateTime.Now.Minute *0.3f;
			SetMatrix();
		}
	}
}