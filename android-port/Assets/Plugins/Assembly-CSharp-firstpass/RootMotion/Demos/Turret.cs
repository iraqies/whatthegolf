using System;
using Il2CppDummyDll;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x200021D")]
	public class Turret : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x200021E")]
		public class Part
		{
			[Token(Token = "0x4000E13")]
			[FieldOffset(Offset = "0x10")]
			public Transform transform;

			[Token(Token = "0x4000E14")]
			[FieldOffset(Offset = "0x18")]
			private RotationLimit rotationLimit;

			[Token(Token = "0x6000E84")]
			[Address(RVA = "0x1357DF0", Offset = "0x1357DF0", VA = "0x1357DF0")]
			public void AimAt(Transform target)
			{
			}

			[Token(Token = "0x6000E85")]
			[Address(RVA = "0x1357F24", Offset = "0x1357F24", VA = "0x1357F24")]
			public Part()
			{
			}
		}

		[Token(Token = "0x4000E11")]
		[FieldOffset(Offset = "0x18")]
		public Transform target;

		[Token(Token = "0x4000E12")]
		[FieldOffset(Offset = "0x20")]
		public Part[] parts;

		[Token(Token = "0x6000E82")]
		[Address(RVA = "0x1323754", Offset = "0x1323754", VA = "0x1323754")]
		private void Update()
		{
		}

		[Token(Token = "0x6000E83")]
		[Address(RVA = "0x13237D0", Offset = "0x13237D0", VA = "0x13237D0")]
		public Turret()
		{
		}
	}
}
