using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine.Utility
{
	[Token(Token = "0x2000093")]
	public class PositionPredictor
	{
		[Token(Token = "0x4000315")]
		[FieldOffset(Offset = "0x10")]
		private Vector3 m_Position;

		[Token(Token = "0x4000316")]
		[FieldOffset(Offset = "0x20")]
		private GaussianWindow1D_Vector3 m_Velocity;

		[Token(Token = "0x4000317")]
		[FieldOffset(Offset = "0x28")]
		private GaussianWindow1D_Vector3 m_Accel;

		[Token(Token = "0x4000318")]
		[FieldOffset(Offset = "0x30")]
		private float mLastVelAddedTime;

		[Token(Token = "0x4000319")]
		private const float kSmoothingDefault = 10f;

		[Token(Token = "0x400031A")]
		[FieldOffset(Offset = "0x34")]
		private float mSmoothing;

		[Token(Token = "0x170000D7")]
		public float Smoothing
		{
			[Token(Token = "0x600034D")]
			[Address(RVA = "0x190BC38", Offset = "0x190BC38", VA = "0x190BC38")]
			set
			{
			}
		}

		[Token(Token = "0x170000D8")]
		public bool IsEmpty
		{
			[Token(Token = "0x600034E")]
			[Address(RVA = "0x190BD60", Offset = "0x190BD60", VA = "0x190BD60")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x600034F")]
		[Address(RVA = "0x190BDB4", Offset = "0x190BDB4", VA = "0x190BDB4")]
		public void ApplyTransformDelta(Vector3 positionDelta)
		{
		}

		[Token(Token = "0x6000350")]
		[Address(RVA = "0x190BDD4", Offset = "0x190BDD4", VA = "0x190BDD4")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000351")]
		[Address(RVA = "0x190BE38", Offset = "0x190BE38", VA = "0x190BE38")]
		public void AddPosition(Vector3 pos, float deltaTime, float lookaheadTime)
		{
		}

		[Token(Token = "0x6000352")]
		[Address(RVA = "0x190C0B0", Offset = "0x190C0B0", VA = "0x190C0B0")]
		public Vector3 PredictPositionDelta(float lookaheadTime)
		{
			return default;
		}

		[Token(Token = "0x6000353")]
		[Address(RVA = "0x190C1D4", Offset = "0x190C1D4", VA = "0x190C1D4")]
		public PositionPredictor()
		{
		}
	}
}
