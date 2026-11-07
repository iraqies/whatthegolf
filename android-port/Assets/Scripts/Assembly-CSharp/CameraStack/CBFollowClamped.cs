using Il2CppDummyDll;
using UnityEngine;

namespace CameraStack
{
	[Token(Token = "0x2001102")]
	public class CBFollowClamped : CBFollow
	{
		[Token(Token = "0x40059BD")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		protected bool clampX;

		[Token(Token = "0x40059BE")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		protected float minX;

		[Token(Token = "0x40059BF")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		protected float maxX;

		[Token(Token = "0x40059C0")]
		[FieldOffset(Offset = "0xDC")]
		[SerializeField]
		protected bool clampY;

		[Token(Token = "0x40059C1")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		protected float minY;

		[Token(Token = "0x40059C2")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		protected float maxY;

		[Token(Token = "0x40059C3")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		protected bool clampZ;

		[Token(Token = "0x40059C4")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		protected float minZ;

		[Token(Token = "0x40059C5")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		protected float maxZ;

		[Token(Token = "0x1700080E")]
		protected override Vector3 ballAtElevation
		{
			[Token(Token = "0x6004C32")]
			[Address(RVA = "0x17DBE7C", Offset = "0x17DBE7C", VA = "0x17DBE7C", Slot = "14")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x6004C33")]
		[Address(RVA = "0x17DBF30", Offset = "0x17DBF30", VA = "0x17DBF30")]
		private Vector3 Clamp(Vector3 position)
		{
			return default;
		}

		[Token(Token = "0x6004C34")]
		[Address(RVA = "0x17DBFCC", Offset = "0x17DBFCC", VA = "0x17DBFCC", Slot = "8")]
		protected override Vector3 CalculatePosition()
		{
			return default;
		}

		[Token(Token = "0x6004C35")]
		[Address(RVA = "0x17DC59C", Offset = "0x17DC59C", VA = "0x17DC59C")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x6004C36")]
		[Address(RVA = "0x17DC744", Offset = "0x17DC744", VA = "0x17DC744")]
		public CBFollowClamped()
		{
		}
	}
}
