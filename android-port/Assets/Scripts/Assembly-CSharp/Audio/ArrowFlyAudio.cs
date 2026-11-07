using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x2001352")]
	public class ArrowFlyAudio : MonoBehaviour
	{
		[Token(Token = "0x4006765")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float minStartVelocity;

		[Token(Token = "0x4006766")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float maxStartVelocity;

		[Token(Token = "0x4006767")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Arrow2D m_arrow;

		[Token(Token = "0x4006768")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ClipSettingsCollection FlyoffSFX;

		[Token(Token = "0x4006769")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ClipSettingsCollection HitSFX;

		[Token(Token = "0x400676A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ClipSettingsCollection HitGoalSFX;

		[Token(Token = "0x400676B")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine m_followRoutine;

		[Token(Token = "0x400676C")]
		[FieldOffset(Offset = "0x48")]
		private bool justEnabled;

		[Token(Token = "0x6005A29")]
		[Address(RVA = "0x1427FEC", Offset = "0x1427FEC", VA = "0x1427FEC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005A2A")]
		[Address(RVA = "0x1428170", Offset = "0x1428170", VA = "0x1428170")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6005A2B")]
		[Address(RVA = "0x142817C", Offset = "0x142817C", VA = "0x142817C")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x6005A2C")]
		[Address(RVA = "0x142827C", Offset = "0x142827C", VA = "0x142827C")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x6005A2D")]
		[Address(RVA = "0x14284F4", Offset = "0x14284F4", VA = "0x14284F4")]
		private void OnHit_MissGoal()
		{
		}

		[Token(Token = "0x6005A2E")]
		[Address(RVA = "0x1428550", Offset = "0x1428550", VA = "0x1428550")]
		private void OnHitGoal()
		{
		}

		[Token(Token = "0x6005A2F")]
		[Address(RVA = "0x14285AC", Offset = "0x14285AC", VA = "0x14285AC")]
		public ArrowFlyAudio()
		{
		}
	}
}
