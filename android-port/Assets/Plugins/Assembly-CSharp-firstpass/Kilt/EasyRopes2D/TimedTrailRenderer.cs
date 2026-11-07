using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Kilt.EasyRopes2D
{
	[Token(Token = "0x20000A6")]
	public class TimedTrailRenderer : MonoBehaviour
	{
		[Token(Token = "0x20000A7")]
		public class Point
		{
			[Token(Token = "0x400030A")]
			[FieldOffset(Offset = "0x10")]
			public float timeCreated;

			[Token(Token = "0x400030B")]
			[FieldOffset(Offset = "0x14")]
			public Vector3 position;

			[Token(Token = "0x400030C")]
			[FieldOffset(Offset = "0x20")]
			public bool lineBreak;

			[Token(Token = "0x60003C9")]
			[Address(RVA = "0x1356ED8", Offset = "0x1356ED8", VA = "0x1356ED8")]
			public Point()
			{
			}
		}

		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x18")]
		public bool emit;

		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x1C")]
		public float emitTime;

		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x20")]
		public Material material;

		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x28")]
		public float lifeTime;

		[Token(Token = "0x40002F8")]
		[FieldOffset(Offset = "0x30")]
		public Color[] colors;

		[Token(Token = "0x40002F9")]
		[FieldOffset(Offset = "0x38")]
		public float[] sizes;

		[Token(Token = "0x40002FA")]
		[FieldOffset(Offset = "0x40")]
		public float uvLengthScale;

		[Token(Token = "0x40002FB")]
		[FieldOffset(Offset = "0x44")]
		public bool higherQualityUVs;

		[Token(Token = "0x40002FC")]
		[FieldOffset(Offset = "0x48")]
		public int movePixelsForRebuild;

		[Token(Token = "0x40002FD")]
		[FieldOffset(Offset = "0x4C")]
		public float maxRebuildTime;

		[Token(Token = "0x40002FE")]
		[FieldOffset(Offset = "0x50")]
		public float minVertexDistance;

		[Token(Token = "0x40002FF")]
		[FieldOffset(Offset = "0x54")]
		public float maxVertexDistance;

		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x58")]
		public float maxAngle;

		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0x5C")]
		public bool ignoreTimeScale;

		[Token(Token = "0x4000302")]
		[FieldOffset(Offset = "0x5D")]
		public bool autoDestruct;

		[Token(Token = "0x4000303")]
		[FieldOffset(Offset = "0x60")]
		private ArrayList points;

		[Token(Token = "0x4000304")]
		[FieldOffset(Offset = "0x68")]
		private GameObject o;

		[Token(Token = "0x4000305")]
		[FieldOffset(Offset = "0x70")]
		private Vector3 lastPosition;

		[Token(Token = "0x4000306")]
		[FieldOffset(Offset = "0x7C")]
		private Vector3 lastCameraPosition1;

		[Token(Token = "0x4000307")]
		[FieldOffset(Offset = "0x88")]
		private Vector3 lastCameraPosition2;

		[Token(Token = "0x4000308")]
		[FieldOffset(Offset = "0x94")]
		private float lastRebuildTime;

		[Token(Token = "0x4000309")]
		[FieldOffset(Offset = "0x98")]
		private bool lastFrameEmit;

		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x131B578", Offset = "0x131B578", VA = "0x131B578", Slot = "4")]
		protected virtual void OnStart()
		{
		}

		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x131B584", Offset = "0x131B584", VA = "0x131B584", Slot = "5")]
		protected virtual void OnEnable()
		{
		}

		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x131B590", Offset = "0x131B590", VA = "0x131B590", Slot = "6")]
		protected virtual void OnDisable()
		{
		}

		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x131B608", Offset = "0x131B608", VA = "0x131B608", Slot = "7")]
		protected virtual void Update()
		{
		}

		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x131D2FC", Offset = "0x131D2FC", VA = "0x131D2FC", Slot = "8")]
		protected virtual void LateUpdate()
		{
		}

		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x131D3BC", Offset = "0x131D3BC", VA = "0x131D3BC", Slot = "9")]
		public virtual void ClearPoints()
		{
		}

		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x131D3E0", Offset = "0x131D3E0", VA = "0x131D3E0", Slot = "10")]
		public virtual void Init()
		{
		}

		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x131D2E4", Offset = "0x131D2E4", VA = "0x131D2E4")]
		public float GetTime()
		{
			return default;
		}

		[Token(Token = "0x60003C7")]
		[Address(RVA = "0x131D2CC", Offset = "0x131D2CC", VA = "0x131D2CC")]
		public float GetDeltaTime()
		{
			return default;
		}

		[Token(Token = "0x60003C8")]
		[Address(RVA = "0x131D68C", Offset = "0x131D68C", VA = "0x131D68C")]
		public TimedTrailRenderer()
		{
		}
	}
}
