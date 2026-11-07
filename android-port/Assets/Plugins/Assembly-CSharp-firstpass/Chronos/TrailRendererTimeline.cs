using Il2CppDummyDll;
using UnityEngine;

namespace Chronos
{
	[Token(Token = "0x20002BE")]
	public class TrailRendererTimeline : ComponentTimeline<TrailRenderer>
	{
		[Token(Token = "0x40011B1")]
		[FieldOffset(Offset = "0x20")]
		private float _time;

		[Token(Token = "0x1700026D")]
		public float time
		{
			[Token(Token = "0x600127F")]
			[Address(RVA = "0x1323064", Offset = "0x1323064", VA = "0x1323064")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6001280")]
		[Address(RVA = "0x1321968", Offset = "0x1321968", VA = "0x1321968")]
		public TrailRendererTimeline(Timeline timeline, TrailRenderer component)
		{
		}

		[Token(Token = "0x6001281")]
		[Address(RVA = "0x132306C", Offset = "0x132306C", VA = "0x132306C", Slot = "16")]
		public override void CopyProperties(TrailRenderer source)
		{
		}

		[Token(Token = "0x6001282")]
		[Address(RVA = "0x13230A0", Offset = "0x13230A0", VA = "0x13230A0", Slot = "17")]
		public override void AdjustProperties(float timeScale)
		{
		}
	}
}
