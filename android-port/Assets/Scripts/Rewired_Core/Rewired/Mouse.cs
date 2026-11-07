using System;
using Il2CppDummyDll;
using Rewired.Interfaces;
using Rewired.Utils.Classes.Utility;
using UnityEngine;

namespace Rewired
{
	[Token(Token = "0x2000048")]
	public sealed class Mouse : ControllerWithAxes
	{
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x158")]
		private TimerAbs fLCCypuZqCpPtgbCnJCjRCIOLhzo;

		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x160")]
		private float[] RppfAfhTSdIchQLnZNhktEnYcfuq;

		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x168")]
		private Vector2 JHlQdvIDknwhbpDkONoyRzgqysDj;

		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x170")]
		private Vector2 NNeHrvYGutiOIXhlhFaJfwMWTlqw;

		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x178")]
		private int bwNXkWpZUjObQdsLBTnYRgEGhqar;

		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x180")]
		private readonly IUnifiedMouseSource eyyVWBZaxsCJCQMmwhCWcagfYfzWA;

		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x0")]
		private static Guid prVaMvCMokqAbWLeJcbpooSHlNBE;

		[Token(Token = "0x170000A8")]
		public Vector2 screenPosition
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x23EC568", Offset = "0x23EC568", VA = "0x23EC568")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000A9")]
		public Vector2 screenPositionPrev
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x23EC628", Offset = "0x23EC628", VA = "0x23EC628")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000AA")]
		public Vector2 screenPositionDelta
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x23EC6E8", Offset = "0x23EC6E8", VA = "0x23EC6E8")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170000AB")]
		public override Guid deviceInstanceGuid
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0x23EC7B8", Offset = "0x23EC7B8", VA = "0x23EC7B8", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6000238")]
		[Address(RVA = "0x23EC8AC", Offset = "0x23EC8AC", VA = "0x23EC8AC")]
		internal Mouse(string P_0, IUnifiedMouseSource P_1)
		{
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x23ECDE4", Offset = "0x23ECDE4", VA = "0x23ECDE4")]
		private Mouse(int P_0, InputSource P_1, string P_2, string P_3, int P_4, int P_5, HardwareControllerMap_Game P_6, Extension P_7, ControllerDataUpdater P_8)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x23ECEE8", Offset = "0x23ECEE8", VA = "0x23ECEE8", Slot = "13")]
		internal override void PwSVyxiNOmkyuuXUHWyuymUyabog(UpdateLoopType P_0)
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x23ED0F0", Offset = "0x23ED0F0", VA = "0x23ED0F0", Slot = "22")]
		protected override bool IsPolledAxisActive(int index, out Pole pole, out int elementIdentifierId)
		{
			return default;
		}

		[Token(Token = "0x600023C")]
		[Address(RVA = "0x23ED454", Offset = "0x23ED454", VA = "0x23ED454", Slot = "15")]
		internal override void SPGTRPyvIslcMdbPTItsewSLRPxx()
		{
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x23ED4A8", Offset = "0x23ED4A8", VA = "0x23ED4A8", Slot = "16")]
		internal override bool RQRRqZiAdoXIQMUtzTIWsndPGdwX(bool P_0)
		{
			return default;
		}

		[Token(Token = "0x600023E")]
		[Address(RVA = "0x23ECFCC", Offset = "0x23ECFCC", VA = "0x23ECFCC")]
		private void iKTboufbDeOsBaqAaWXIhLIsMqxu()
		{
		}
	}
}
