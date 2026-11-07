using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.AI;

namespace Chronos
{
	[Token(Token = "0x20002BC")]
	public class RigidbodyTimeline3D : RigidbodyTimeline<Rigidbody, RigidbodyTimeline3D.Snapshot>
	{
		[Token(Token = "0x20002BD")]
		public struct Snapshot
		{
			[Token(Token = "0x40011AA")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 position;

			[Token(Token = "0x40011AB")]
			[FieldOffset(Offset = "0xC")]
			public Quaternion rotation;

			[Token(Token = "0x40011AC")]
			[FieldOffset(Offset = "0x1C")]
			public Vector3 velocity;

			[Token(Token = "0x40011AD")]
			[FieldOffset(Offset = "0x28")]
			public Vector3 angularVelocity;

			[Token(Token = "0x40011AE")]
			[FieldOffset(Offset = "0x34")]
			public float drag;

			[Token(Token = "0x40011AF")]
			[FieldOffset(Offset = "0x38")]
			public float angularDrag;

			[Token(Token = "0x40011B0")]
			[FieldOffset(Offset = "0x3C")]
			public float lastPositiveTimeScale;

			[Token(Token = "0x600127E")]
			[Address(RVA = "0x1355668", Offset = "0x1355668", VA = "0x1355668")]
			public static Snapshot Lerp(Snapshot from, Snapshot to, float t)
			{
				return default;
			}
		}

		[Token(Token = "0x40011A8")]
		[FieldOffset(Offset = "0x15C")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37530", Offset = "0x37530")]
		private bool isKinematic__BackingField;

		[Token(Token = "0x40011A9")]
		[FieldOffset(Offset = "0x15D")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37540", Offset = "0x37540")]
		private bool useGravity__BackingField;

		[Token(Token = "0x17000262")]
		protected override bool bodyIsManual
		{
			[Token(Token = "0x6001265")]
			[Address(RVA = "0x13DEDE8", Offset = "0x13DEDE8", VA = "0x13DEDE8", Slot = "25")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001266")]
			[Address(RVA = "0x13DEE34", Offset = "0x13DEE34", VA = "0x13DEE34", Slot = "26")]
			set
			{
			}
		}

		[Token(Token = "0x17000263")]
		protected override float bodyMass
		{
			[Token(Token = "0x6001267")]
			[Address(RVA = "0x13DEE90", Offset = "0x13DEE90", VA = "0x13DEE90", Slot = "27")]
			set
			{
			}
		}

		[Token(Token = "0x17000264")]
		protected override Vector3 bodyVelocity
		{
			[Token(Token = "0x6001268")]
			[Address(RVA = "0x13DEEEC", Offset = "0x13DEEEC", VA = "0x13DEEEC", Slot = "28")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001269")]
			[Address(RVA = "0x13DEF38", Offset = "0x13DEF38", VA = "0x13DEF38", Slot = "29")]
			set
			{
			}
		}

		[Token(Token = "0x17000265")]
		protected override Vector3 bodyAngularVelocity
		{
			[Token(Token = "0x600126A")]
			[Address(RVA = "0x13DEFAC", Offset = "0x13DEFAC", VA = "0x13DEFAC", Slot = "30")]
			get
			{
				return default;
			}
			[Token(Token = "0x600126B")]
			[Address(RVA = "0x13DEFF8", Offset = "0x13DEFF8", VA = "0x13DEFF8", Slot = "31")]
			set
			{
			}
		}

		[Token(Token = "0x17000266")]
		protected override float bodyDrag
		{
			[Token(Token = "0x600126C")]
			[Address(RVA = "0x13DF06C", Offset = "0x13DF06C", VA = "0x13DF06C", Slot = "32")]
			get
			{
				return default;
			}
			[Token(Token = "0x600126D")]
			[Address(RVA = "0x13DF0B8", Offset = "0x13DF0B8", VA = "0x13DF0B8", Slot = "33")]
			set
			{
			}
		}

		[Token(Token = "0x17000267")]
		protected override float bodyAngularDrag
		{
			[Token(Token = "0x600126E")]
			[Address(RVA = "0x13DF114", Offset = "0x13DF114", VA = "0x13DF114", Slot = "34")]
			get
			{
				return default;
			}
			[Token(Token = "0x600126F")]
			[Address(RVA = "0x13DF160", Offset = "0x13DF160", VA = "0x13DF160", Slot = "35")]
			set
			{
			}
		}

		[Token(Token = "0x17000268")]
		public bool isKinematic
		{
			[Token(Token = "0x6001271")]
			[Address(RVA = "0x13DF208", Offset = "0x13DF208", VA = "0x13DF208")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BB7C", Offset = "0x3BB7C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001272")]
			[Address(RVA = "0x13DF210", Offset = "0x13DF210", VA = "0x13DF210")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BB8C", Offset = "0x3BB8C")]
			set
			{
			}
		}

		[Token(Token = "0x17000269")]
		protected override bool isManual
		{
			[Token(Token = "0x6001273")]
			[Address(RVA = "0x13DF218", Offset = "0x13DF218", VA = "0x13DF218", Slot = "37")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x1700026A")]
		public bool useGravity
		{
			[Token(Token = "0x6001274")]
			[Address(RVA = "0x13DF220", Offset = "0x13DF220", VA = "0x13DF220")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BB9C", Offset = "0x3BB9C")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001275")]
			[Address(RVA = "0x13DF228", Offset = "0x13DF228", VA = "0x13DF228")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x3BBAC", Offset = "0x3BBAC")]
			set
			{
			}
		}

		[Token(Token = "0x1700026B")]
		public Vector3 velocity
		{
			[Token(Token = "0x6001276")]
			[Address(RVA = "0x13DE814", Offset = "0x13DE814", VA = "0x13DE814")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001277")]
			[Address(RVA = "0x13DE880", Offset = "0x13DE880", VA = "0x13DE880")]
			set
			{
			}
		}

		[Token(Token = "0x1700026C")]
		public Vector3 angularVelocity
		{
			[Token(Token = "0x6001278")]
			[Address(RVA = "0x13DF230", Offset = "0x13DF230", VA = "0x13DF230")]
			get
			{
				return default;
			}
			[Token(Token = "0x6001279")]
			[Address(RVA = "0x13DF29C", Offset = "0x13DF29C", VA = "0x13DF29C")]
			set
			{
			}
		}

		[Token(Token = "0x600125E")]
		[Address(RVA = "0x13DE624", Offset = "0x13DE624", VA = "0x13DE624")]
		public RigidbodyTimeline3D(Timeline timeline, Rigidbody component)
		{
		}

		[Token(Token = "0x600125F")]
		[Address(RVA = "0x13DE694", Offset = "0x13DE694", VA = "0x13DE694", Slot = "16")]
		public override void CopyProperties(Rigidbody source)
		{
		}

		[Token(Token = "0x6001260")]
		[Address(RVA = "0x13DE6E8", Offset = "0x13DE6E8", VA = "0x13DE6E8", Slot = "14")]
		public override void FixedUpdate()
		{
		}

		[Token(Token = "0x6001261")]
		[Address(RVA = "0x13DE964", Offset = "0x13DE964", VA = "0x13DE964", Slot = "21")]
		protected override Snapshot LerpSnapshots(Snapshot from, Snapshot to, float t)
		{
			return default;
		}

		[Token(Token = "0x6001262")]
		[Address(RVA = "0x13DE9AC", Offset = "0x13DE9AC", VA = "0x13DE9AC")]
		private NavMeshAgent GetNavMeshAgentOverride()
		{
			return null;
		}

		[Token(Token = "0x6001263")]
		[Address(RVA = "0x13DEA94", Offset = "0x13DEA94", VA = "0x13DEA94", Slot = "22")]
		protected override Snapshot CopySnapshot()
		{
			return default;
		}

		[Token(Token = "0x6001264")]
		[Address(RVA = "0x13DEC24", Offset = "0x13DEC24", VA = "0x13DEC24", Slot = "23")]
		protected override void ApplySnapshot(Snapshot snapshot)
		{
		}

		[Token(Token = "0x6001270")]
		[Address(RVA = "0x13DF1BC", Offset = "0x13DF1BC", VA = "0x13DF1BC", Slot = "36")]
		protected override void WakeUp()
		{
		}

		[Token(Token = "0x600127A")]
		[Address(RVA = "0x13DF380", Offset = "0x13DF380", VA = "0x13DF380")]
		public void AddForce(Vector3 force, ForceMode mode = ForceMode.Force)
		{
		}

		[Token(Token = "0x600127B")]
		[Address(RVA = "0x13DF45C", Offset = "0x13DF45C", VA = "0x13DF45C")]
		public void AddForceAtPosition(Vector3 force, Vector3 position, ForceMode mode = ForceMode.Force)
		{
		}

		[Token(Token = "0x600127C")]
		[Address(RVA = "0x13DF55C", Offset = "0x13DF55C", VA = "0x13DF55C")]
		public void AddTorque(Vector3 torque, ForceMode mode = ForceMode.Force)
		{
		}

		[Token(Token = "0x600127D")]
		[Address(RVA = "0x13DF638", Offset = "0x13DF638", VA = "0x13DF638")]
		public void AddRelativeTorque(Vector3 torque, ForceMode mode = ForceMode.Force)
		{
		}
	}
}
