using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnitySA.Characters.FirstPerson
{
	[Serializable]
	[Token(Token = "0x2000F3F")]
	public class MLook
	{
		[Token(Token = "0x400525B")]
		[FieldOffset(Offset = "0x10")]
		public float XSensitivity;

		[Token(Token = "0x400525C")]
		[FieldOffset(Offset = "0x14")]
		public float YSensitivity;

		[Token(Token = "0x400525D")]
		[FieldOffset(Offset = "0x18")]
		public bool clampVerticalRotation;

		[Token(Token = "0x400525E")]
		[FieldOffset(Offset = "0x1C")]
		public float MinimumX;

		[Token(Token = "0x400525F")]
		[FieldOffset(Offset = "0x20")]
		public float MaximumX;

		[Token(Token = "0x4005260")]
		[FieldOffset(Offset = "0x24")]
		public bool smooth;

		[Token(Token = "0x4005261")]
		[FieldOffset(Offset = "0x28")]
		public float smoothTime;

		[Token(Token = "0x4005262")]
		[FieldOffset(Offset = "0x2C")]
		public bool lockCursor;

		[Token(Token = "0x4005263")]
		[FieldOffset(Offset = "0x30")]
		private Quaternion m_CharacterTargetRot;

		[Token(Token = "0x4005264")]
		[FieldOffset(Offset = "0x40")]
		private Quaternion m_CameraTargetRot;

		[Token(Token = "0x4005265")]
		[FieldOffset(Offset = "0x50")]
		private bool m_cursorIsLocked;

		[Token(Token = "0x6004740")]
		[Address(RVA = "0x154C388", Offset = "0x154C388", VA = "0x154C388")]
		public void Init(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x6004741")]
		[Address(RVA = "0x154C3DC", Offset = "0x154C3DC", VA = "0x154C3DC")]
		public void LookRotation(Transform character, Transform camera)
		{
		}

		[Token(Token = "0x6004742")]
		[Address(RVA = "0x154C758", Offset = "0x154C758", VA = "0x154C758")]
		public void UpdateCursorLock()
		{
		}

		[Token(Token = "0x6004743")]
		[Address(RVA = "0x154C76C", Offset = "0x154C76C", VA = "0x154C76C")]
		private void InternalLockUpdate()
		{
		}

		[Token(Token = "0x6004744")]
		[Address(RVA = "0x154C6E8", Offset = "0x154C6E8", VA = "0x154C6E8")]
		private Quaternion ClampRotationAroundXAxis(Quaternion q)
		{
			return default;
		}

		[Token(Token = "0x6004745")]
		[Address(RVA = "0x154C7D0", Offset = "0x154C7D0", VA = "0x154C7D0")]
		public MLook()
		{
		}
	}
}
