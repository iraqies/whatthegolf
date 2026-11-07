using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Characters.FirstPerson
{
	[Serializable]
	[Token(Token = "0x200007D")]
	public class MouseLook
	{
		[Token(Token = "0x400021D")]
		[FieldOffset(Offset = "0x10")]
		public float XSensitivity;

		[Token(Token = "0x400021E")]
		[FieldOffset(Offset = "0x14")]
		public float YSensitivity;

		[Token(Token = "0x400021F")]
		[FieldOffset(Offset = "0x18")]
		public bool clampVerticalRotation;

		[Token(Token = "0x4000220")]
		[FieldOffset(Offset = "0x1C")]
		public float MinimumX;

		[Token(Token = "0x4000221")]
		[FieldOffset(Offset = "0x20")]
		public float MaximumX;

		[Token(Token = "0x4000222")]
		[FieldOffset(Offset = "0x24")]
		public bool smooth;

		[Token(Token = "0x4000223")]
		[FieldOffset(Offset = "0x28")]
		public float smoothTime;

		[Token(Token = "0x4000224")]
		[FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4000225")]
		[FieldOffset(Offset = "0x30")]
		private Quaternion m_CharacterTargetRot;

		[Token(Token = "0x4000226")]
		[FieldOffset(Offset = "0x40")]
		private Quaternion m_CameraTargetRot;

		[Token(Token = "0x4000227")]
		[FieldOffset(Offset = "0x50")]
		private bool m_cursorIsLocked;

		[Token(Token = "0x6000225")]
		[Address(RVA = "0x13B51EC", Offset = "0x13B51EC", VA = "0x13B51EC")]
		public void Init(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x6000226")]
		[Address(RVA = "0x13B5240", Offset = "0x13B5240", VA = "0x13B5240")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x6000227")]
		[Address(RVA = "0x13B55E8", Offset = "0x13B55E8", VA = "0x13B55E8")]
		public void UpdateCursorLock()
		{
		}

		[Token(Token = "0x6000228")]
		[Address(RVA = "0x13B55FC", Offset = "0x13B55FC", VA = "0x13B55FC")]
		private void InternalLockUpdate()
		{
		}

		[Token(Token = "0x6000229")]
		[Address(RVA = "0x13B5578", Offset = "0x13B5578", VA = "0x13B5578")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default;
		}

		[Token(Token = "0x600022A")]
		[Address(RVA = "0x13B5660", Offset = "0x13B5660", VA = "0x13B5660")]
		public MouseLook()
		{
		}
	}
}
