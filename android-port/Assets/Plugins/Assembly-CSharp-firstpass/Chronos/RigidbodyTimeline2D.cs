using Il2CppDummyDll;
using UnityEngine;

namespace Chronos
{
	[Token(Token = "0x20002BA")]
	public class RigidbodyTimeline2D : RigidbodyTimeline<Rigidbody2D, RigidbodyTimeline2D.Snapshot>
	{
		[Token(Token = "0x20002BB")]
		public struct Snapshot
		{
			[Token(Token = "0x40011A1")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x40011A2")]
			[FieldOffset(Offset = "0xC")]
			public Quaternion rotation;

			[Token(Token = "0x40011A3")]
			[FieldOffset(Offset = "0x1C")]
			public Vector2 velocity;

			[Token(Token = "0x40011A4")]
			[FieldOffset(Offset = "0x24")]
			public float angularVelocity;

			[Token(Token = "0x40011A5")]
			[FieldOffset(Offset = "0x28")]
			public float drag;

			[Token(Token = "0x40011A6")]
			[FieldOffset(Offset = "0x2C")]
			public float angularDrag;

			[Token(Token = "0x40011A7")]
			[FieldOffset(Offset = "0x30")]
			public float lastPositiveTimeScale;

			[Token(Token = "0x600125D")]
			[Address(RVA = "0x13554E4", Offset = "0x13554E4", VA = "0x13554E4")]
			public static Snapshot Lerp(Snapshot from, Snapshot to, float t)
			{
				return default;
			}
		}

		[Token(Token = "0x400119F")]
		[FieldOffset(Offset = "0x12C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37510", Offset = "0x37510")]
		private RigidbodyType2D bodyType__BackingField;

		[Token(Token = "0x40011A0")]
		[FieldOffset(Offset = "0x130")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37520", Offset = "0x37520")]
		private float gravityScale__BackingField;

		[Token(Token = "0x17000257")]
		protected override bool bodyIsManual
		{
			[Token(Token = "0x6001248")]
			[Address(RVA = "0x13DE000", Offset = "0x13DE000", VA = "0x13DE000", Slot = "25")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001249")]
			[Address(RVA = "0x13DE058", Offset = "0x13DE058", VA = "0x13DE058", Slot = "26")]
			set
			{
			}
		}

		[Token(Token = "0x17000258")]
		protected override float bodyMass
		{
			[Token(Token = "0x600124A")]
			[Address(RVA = "0x13DE0CC", Offset = "0x13DE0CC", VA = "0x13DE0CC", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x17000259")]
		protected override Vector3 bodyVelocity
		{
			[Token(Token = "0x600124B")]
			[Address(RVA = "0x13DE128", Offset = "0x13DE128", VA = "0x13DE128", Slot = "28")]
			get
			{
				return default;
			}
			[Token(Token = "0x600124C")]
			[Address(RVA = "0x13DE17C", Offset = "0x13DE17C", VA = "0x13DE17C", Slot = "29")]
			set
			{
			}
		}

		[Token(Token = "0x1700025A")]
		protected override Vector3 bodyAngularVelocity
		{
			[Token(Token = "0x600124D")]
			[Address(RVA = "0x13DE1E0", Offset = "0x13DE1E0", VA = "0x13DE1E0", Slot = "30")]
			get
			{
				return default;
			}
			[Token(Token = "0x600124E")]
			[Address(RVA = "0x13DE250", Offset = "0x13DE250", VA = "0x13DE250", Slot = "31")]
			set
			{
			}
		}

		[Token(Token = "0x1700025B")]
		protected override float bodyDrag
		{
			[Token(Token = "0x600124F")]
			[Address(RVA = "0x13DE2AC", Offset = "0x13DE2AC", VA = "0x13DE2AC", Slot = "32")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001250")]
			[Address(RVA = "0x13DE2F8", Offset = "0x13DE2F8", VA = "0x13DE2F8", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x1700025C")]
		protected override float bodyAngularDrag
		{
			[Token(Token = "0x6001251")]
			[Address(RVA = "0x13DE354", Offset = "0x13DE354", VA = "0x13DE354", Slot = "34")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001252")]
			[Address(RVA = "0x13DE3A0", Offset = "0x13DE3A0", VA = "0x13DE3A0", Slot = "35")]
			set
			{
			}
		}

		[Token(Token = "0x1700025D")]
		public RigidbodyType2D bodyType
		{
			[Token(Token = "0x6001254")]
			[Address(RVA = "0x13DE448", Offset = "0x13DE448", VA = "0x13DE448")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BB3C", Offset = "0x3BB3C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001255")]
			[Address(RVA = "0x13DE450", Offset = "0x13DE450", VA = "0x13DE450")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BB4C", Offset = "0x3BB4C")]
			set
			{
			}
		}

		[Token(Token = "0x1700025E")]
		protected override bool isManual
		{
			[Token(Token = "0x6001256")]
			[Address(RVA = "0x13DE458", Offset = "0x13DE458", VA = "0x13DE458", Slot = "37")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700025F")]
		public float gravityScale
		{
			[Token(Token = "0x6001257")]
			[Address(RVA = "0x13DE468", Offset = "0x13DE468", VA = "0x13DE468")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BB5C", Offset = "0x3BB5C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001258")]
			[Address(RVA = "0x13DE470", Offset = "0x13DE470", VA = "0x13DE470")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BB6C", Offset = "0x3BB6C")]
			set
			{
			}
		}

		[Token(Token = "0x17000260")]
		public Vector2 velocity
		{
			[Token(Token = "0x6001259")]
			[Address(RVA = "0x13DDC24", Offset = "0x13DDC24", VA = "0x13DDC24")]
			get
			{
				return default;
			}
			[Token(Token = "0x600125A")]
			[Address(RVA = "0x13DDC8C", Offset = "0x13DDC8C", VA = "0x13DDC8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000261")]
		public float angularVelocity
		{
			[Token(Token = "0x600125B")]
			[Address(RVA = "0x13DE478", Offset = "0x13DE478", VA = "0x13DE478")]
			set
			{
			}
		}

		[Token(Token = "0x6001242")]
		[Address(RVA = "0x13DD9AC", Offset = "0x13DD9AC", VA = "0x13DD9AC")]
		public RigidbodyTimeline2D(Timeline timeline, Rigidbody2D component)
		{
		}

		[Token(Token = "0x6001243")]
		[Address(RVA = "0x13DDA1C", Offset = "0x13DDA1C", VA = "0x13DDA1C", Slot = "16")]
		public override void CopyProperties(Rigidbody2D source)
		{
		}

		[Token(Token = "0x6001244")]
		[Address(RVA = "0x13DDA70", Offset = "0x13DDA70", VA = "0x13DDA70", Slot = "14")]
		public override void FixedUpdate()
		{
		}

		[Token(Token = "0x6001245")]
		[Address(RVA = "0x13DDD60", Offset = "0x13DDD60", VA = "0x13DDD60", Slot = "21")]
		protected override Snapshot LerpSnapshots(Snapshot from, Snapshot to, float t)
		{
			return default;
		}

		[Token(Token = "0x6001246")]
		[Address(RVA = "0x13DDDB8", Offset = "0x13DDDB8", VA = "0x13DDDB8", Slot = "22")]
		protected override Snapshot CopySnapshot()
		{
			return default;
		}

		[Token(Token = "0x6001247")]
		[Address(RVA = "0x13DDEF4", Offset = "0x13DDEF4", VA = "0x13DDEF4", Slot = "23")]
		protected override void ApplySnapshot(Snapshot snapshot)
		{
		}

		[Token(Token = "0x6001253")]
		[Address(RVA = "0x13DE3FC", Offset = "0x13DE3FC", VA = "0x13DE3FC", Slot = "36")]
		protected override void WakeUp()
		{
		}

		[Token(Token = "0x600125C")]
		[Address(RVA = "0x13DE55C", Offset = "0x13DE55C", VA = "0x13DE55C")]
		public void AddForce(Vector2 force, ForceMode2D mode = ForceMode2D.Force)
		{
		}
	}
}
