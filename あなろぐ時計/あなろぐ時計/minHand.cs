using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace あなろぐ時計
{
	public class minHand:handObj { 
	
		public minHand( float wx, float wy, float scale ) : base(wx, wy, scale)
		{
			handPic = Properties.Resources.min_hand;
			cx = 91 * scale;        //scale倍して、倍率の補正
			cy = 536 * scale;       //scale倍して、倍率の補正
			SetPos(wx, wy, 0.5F);
		}
		public override void Action ()
		{
			base.Action();
			deg = DateTime.Now.Minute * 6;
			deg += DateTime.Now.Second * 0.6f ;
			SetMatrix();
		}
	}
}
