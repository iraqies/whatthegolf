using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.Dynamics
{
	[Token(Token = "0x200013A")]
	public class RagdollEditor : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200013B")]
		public enum Mode
		{
			[Token(Token = "0x4000790")]
			Colliders = 0,
			[Token(Token = "0x4000791")]
			Joints = 1
		}

		[Token(Token = "0x400078B")]
		[FieldOffset(Offset = "0x18")]
		public Rigidbody selectedRigidbody;

		[Token(Token = "0x400078C")]
		[FieldOffset(Offset = "0x20")]
		public Collider selectedCollider;

		[Token(Token = "0x400078D")]
		[FieldOffset(Offset = "0x28")]
		public bool symmetry;

		[Token(Token = "0x400078E")]
		[FieldOffset(Offset = "0x2C")]
		public Mode mode;

		[Token(Token = "0x6000881")]
		[Address(RVA = "0x13D7988", Offset = "0x13D7988", VA = "0x13D7988")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x38E2C", Offset = "0x38E2C")]
		private void OpenUserManual()
		{
		}

		[Token(Token = "0x6000882")]
		[Address(RVA = "0x13D79D0", Offset = "0x13D79D0", VA = "0x13D79D0")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x38E64", Offset = "0x38E64")]
		private void OpenScriptReference()
		{
		}

		[Token(Token = "0x6000883")]
		[Address(RVA = "0x13D7A18", Offset = "0x13D7A18", VA = "0x13D7A18")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x38E9C", Offset = "0x38E9C")]
		private void OpenTutorial()
		{
		}

		[Token(Token = "0x6000884")]
		[Address(RVA = "0x13D7A60", Offset = "0x13D7A60", VA = "0x13D7A60")]
		public RagdollEditor()
		{
		}
	}
}
