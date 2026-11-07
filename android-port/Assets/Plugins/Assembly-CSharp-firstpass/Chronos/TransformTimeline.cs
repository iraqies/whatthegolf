using Il2CppDummyDll;
using UnityEngine;

namespace Chronos
{
	[Token(Token = "0x20002BF")]
	public class TransformTimeline : RecorderTimeline<Transform, TransformTimeline.Snapshot>
	{
		[Token(Token = "0x20002C0")]
		public struct Snapshot
		{
			[Token(Token = "0x40011B2")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x40011B3")]
			[FieldOffset(Offset = "0xC")]
			public Quaternion rotation;

			[Token(Token = "0x6001287")]
			[Address(RVA = "0x1357D30", Offset = "0x1357D30", VA = "0x1357D30")]
			public static Snapshot Lerp(Snapshot from, Snapshot to, float t)
			{
				return default;
			}
		}

		[Token(Token = "0x6001283")]
		[Address(RVA = "0x13219D8", Offset = "0x13219D8", VA = "0x13219D8")]
		public TransformTimeline(Timeline timeline, Transform component)
		{
		}

		[Token(Token = "0x6001284")]
		[Address(RVA = "0x1323208", Offset = "0x1323208", VA = "0x1323208", Slot = "21")]
		protected override Snapshot LerpSnapshots(Snapshot from, Snapshot to, float t)
		{
			return default;
		}

		[Token(Token = "0x6001285")]
		[Address(RVA = "0x1323250", Offset = "0x1323250", VA = "0x1323250", Slot = "22")]
		protected override Snapshot CopySnapshot()
		{
			return default;
		}

		[Token(Token = "0x6001286")]
		[Address(RVA = "0x13232E8", Offset = "0x13232E8", VA = "0x13232E8", Slot = "23")]
		protected override void ApplySnapshot(Snapshot snapshot)
		{
		}
	}
}
