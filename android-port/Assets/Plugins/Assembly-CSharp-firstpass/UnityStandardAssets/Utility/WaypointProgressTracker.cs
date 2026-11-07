using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000066")]
	public class WaypointProgressTracker : MonoBehaviour
	{
		[Token(Token = "0x2000067")]
		public enum ProgressStyle
		{
			[Token(Token = "0x40001AC")]
			SmoothAlongRoute = 0,
			[Token(Token = "0x40001AD")]
			PointToPoint = 1
		}

		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private WaypointCircuit circuit;

		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float lookAheadForTargetOffset;

		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float lookAheadForTargetFactor;

		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float lookAheadForSpeedOffset;

		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float lookAheadForSpeedFactor;

		[Token(Token = "0x40001A1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ProgressStyle progressStyle;

		[Token(Token = "0x40001A2")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float pointToPointThreshold;

		[Token(Token = "0x40001A3")]
		[FieldOffset(Offset = "0x38")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x34770", Offset = "0x34770")]
		private WaypointCircuit.RoutePoint targetPoint__BackingField;

		[Token(Token = "0x40001A4")]
		[FieldOffset(Offset = "0x50")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x34780", Offset = "0x34780")]
		private WaypointCircuit.RoutePoint speedPoint__BackingField;

		[Token(Token = "0x40001A5")]
		[FieldOffset(Offset = "0x68")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x34790", Offset = "0x34790")]
		private WaypointCircuit.RoutePoint progressPoint__BackingField;

		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x80")]
		public Transform target;

		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x88")]
		private float progressDistance;

		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x8C")]
		private int progressNum;

		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 lastPosition;

		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x9C")]
		private float speed;

		[Token(Token = "0x17000033")]
		public WaypointCircuit.RoutePoint targetPoint
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x132CBDC", Offset = "0x132CBDC", VA = "0x132CBDC")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37CF0", Offset = "0x37CF0")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x132CBF0", Offset = "0x132CBF0", VA = "0x132CBF0")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37D00", Offset = "0x37D00")]
			private set
			{
			}
		}

		[Token(Token = "0x17000034")]
		public WaypointCircuit.RoutePoint speedPoint
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x132CC04", Offset = "0x132CC04", VA = "0x132CC04")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37D10", Offset = "0x37D10")]
			get
			{
				return default;
			}
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x132CC18", Offset = "0x132CC18", VA = "0x132CC18")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37D20", Offset = "0x37D20")]
			private set
			{
			}
		}

		[Token(Token = "0x17000035")]
		public WaypointCircuit.RoutePoint progressPoint
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x132CC2C", Offset = "0x132CC2C", VA = "0x132CC2C")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37D30", Offset = "0x37D30")]
			get
			{
				return default;
			}
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x132CC40", Offset = "0x132CC40", VA = "0x132CC40")]
			[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x37D40", Offset = "0x37D40")]
			private set
			{
			}
		}

		[Token(Token = "0x600019C")]
		[Address(RVA = "0x132CC54", Offset = "0x132CC54", VA = "0x132CC54")]
		private void Start()
		{
		}

		[Token(Token = "0x600019D")]
		[Address(RVA = "0x132CD50", Offset = "0x132CD50", VA = "0x132CD50")]
		public void Reset()
		{
		}

		[Token(Token = "0x600019E")]
		[Address(RVA = "0x132CE28", Offset = "0x132CE28", VA = "0x132CE28")]
		private void Update()
		{
		}

		[Token(Token = "0x600019F")]
		[Address(RVA = "0x132D430", Offset = "0x132D430", VA = "0x132D430")]
		private void OnDrawGizmos()
		{
		}

		[Token(Token = "0x60001A0")]
		[Address(RVA = "0x132D580", Offset = "0x132D580", VA = "0x132D580")]
		public WaypointProgressTracker()
		{
		}
	}
}
