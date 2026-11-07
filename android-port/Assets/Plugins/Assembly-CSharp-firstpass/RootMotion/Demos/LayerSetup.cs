using System.Collections.Generic;
using Il2CppDummyDll;
using RootMotion.Dynamics;
using UnityEngine;

namespace RootMotion.Demos
{
	[Token(Token = "0x2000239")]
	[Attribute(Name = "RequireComponent", RVA = "0x33EFC", Offset = "0x33EFC")]
	public class LayerSetup : MonoBehaviour
	{
		[Token(Token = "0x4000E88")]
		[FieldOffset(Offset = "0x18")]
		public Transform characterController;

		[Token(Token = "0x4000E89")]
		[FieldOffset(Offset = "0x20")]
		public int characterControllerLayer;

		[Token(Token = "0x4000E8A")]
		[FieldOffset(Offset = "0x24")]
		public int ragdollLayer;

		[Token(Token = "0x4000E8B")]
		[FieldOffset(Offset = "0x28")]
		public LayerMask ignoreCollisionWithCharacterController;

		[Token(Token = "0x4000E8C")]
		[FieldOffset(Offset = "0x2C")]
		public LayerMask ignoreCollisionWithRagdoll;

		[Token(Token = "0x4000E8D")]
		[FieldOffset(Offset = "0x30")]
		private PuppetMaster puppetMaster;

		[Token(Token = "0x4000E8E")]
		[FieldOffset(Offset = "0x38")]
		private bool oldRagdollToCharacterControllerValue;

		[Token(Token = "0x4000E8F")]
		[FieldOffset(Offset = "0x39")]
		private bool oldCharacterControllerToCharacterControllerValue;

		[Token(Token = "0x4000E90")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<int, bool> oldCharacterControllerLayers;

		[Token(Token = "0x4000E91")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<int, bool> oldRagdollLayers;

		[Token(Token = "0x6000EED")]
		[Address(RVA = "0x13A8014", Offset = "0x13A8014", VA = "0x13A8014")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000EEE")]
		[Address(RVA = "0x13A8208", Offset = "0x13A8208", VA = "0x13A8208")]
		private void Start()
		{
		}

		[Token(Token = "0x6000EEF")]
		[Address(RVA = "0x13A839C", Offset = "0x13A839C", VA = "0x13A839C")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6000EF0")]
		[Address(RVA = "0x13A85E0", Offset = "0x13A85E0", VA = "0x13A85E0")]
		public LayerSetup()
		{
		}
	}
}
