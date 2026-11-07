using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x200133D")]
	public class Arrow3DFlyAudio : MonoBehaviour
	{
		[Token(Token = "0x40066EB")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float minStartVelocity;

		[Token(Token = "0x40066EC")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float maxStartVelocity;

		[Token(Token = "0x40066ED")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Arrow3D m_arrow;

		[Token(Token = "0x40066EE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private ClipSettingsCollection FlyoffSFX;

		[Token(Token = "0x40066EF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ClipSettingsCollection HitSFX;

		[Token(Token = "0x40066F0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ClipSettingsCollection HitGoalSFX;

		[Token(Token = "0x40066F1")]
		[FieldOffset(Offset = "0x40")]
		private Coroutine m_followRoutine;

		[Token(Token = "0x40066F2")]
		[FieldOffset(Offset = "0x48")]
		private bool justEnabled;

		[Token(Token = "0x60059BB")]
		[Address(RVA = "0x1427138", Offset = "0x1427138", VA = "0x1427138")]
		private void Awake()
		{
		}

		[Token(Token = "0x60059BC")]
		[Address(RVA = "0x14272BC", Offset = "0x14272BC", VA = "0x14272BC")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x60059BD")]
		[Address(RVA = "0x14272C8", Offset = "0x14272C8", VA = "0x14272C8")]
		private void OnDisable()
		{
		}

		[Token(Token = "0x60059BE")]
		[Address(RVA = "0x14273C8", Offset = "0x14273C8", VA = "0x14273C8")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x60059BF")]
		[Address(RVA = "0x14276D0", Offset = "0x14276D0", VA = "0x14276D0")]
		private void OnHit_MissGoal()
		{
		}

		[Token(Token = "0x60059C0")]
		[Address(RVA = "0x142772C", Offset = "0x142772C", VA = "0x142772C")]
		private void OnHitGoal()
		{
		}

		[Token(Token = "0x60059C1")]
		[Address(RVA = "0x1427788", Offset = "0x1427788", VA = "0x1427788")]
		public Arrow3DFlyAudio()
		{
		}
	}
}
