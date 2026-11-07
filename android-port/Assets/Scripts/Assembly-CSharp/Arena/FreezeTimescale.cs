using Il2CppDummyDll;
using UnityEngine;

namespace Arena
{
	[Token(Token = "0x2001220")]
	public class FreezeTimescale : MonoBehaviour
	{
		[Token(Token = "0x40061F9")]
		[FieldOffset(Offset = "0x18")]
		public float FreezeDuration;

		[Token(Token = "0x40061FA")]
		[FieldOffset(Offset = "0x20")]
		public AnimationCurve FreezeTimeCurve;

		[Token(Token = "0x40061FB")]
		[FieldOffset(Offset = "0x28")]
		public bool ModifyFixedDeltaTime;

		[Token(Token = "0x40061FC")]
		[FieldOffset(Offset = "0x29")]
		private bool doFreeze;

		[Token(Token = "0x40061FD")]
		[FieldOffset(Offset = "0x2C")]
		private float freezeTimer;

		[Token(Token = "0x40061FE")]
		[FieldOffset(Offset = "0x30")]
		private float currentFreezeDuration;

		[Token(Token = "0x40061FF")]
		[FieldOffset(Offset = "0x38")]
		private TimeControl timeController;

		[Token(Token = "0x4006200")]
		[FieldOffset(Offset = "0x40")]
		private float fixedTimeStep;

		[Token(Token = "0x600537F")]
		[Address(RVA = "0x14731F0", Offset = "0x14731F0", VA = "0x14731F0")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005380")]
		[Address(RVA = "0x1473280", Offset = "0x1473280", VA = "0x1473280")]
		public void StartFreeze()
		{
		}

		[Token(Token = "0x6005381")]
		[Address(RVA = "0x1473288", Offset = "0x1473288", VA = "0x1473288")]
		public void StartFreeze(float durationMultiplier)
		{
		}

		[Token(Token = "0x6005382")]
		[Address(RVA = "0x1473360", Offset = "0x1473360", VA = "0x1473360")]
		private void Update()
		{
		}

		[Token(Token = "0x6005383")]
		[Address(RVA = "0x14734A8", Offset = "0x14734A8", VA = "0x14734A8")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6005384")]
		[Address(RVA = "0x14734C4", Offset = "0x14734C4", VA = "0x14734C4")]
		public FreezeTimescale()
		{
		}
	}
}
