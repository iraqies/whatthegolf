using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Rewired.Demos
{
	[Token(Token = "0x2001169")]
	public class PlayerMouseSpriteExample : MonoBehaviour
	{
		[Token(Token = "0x4005C0C")]
		[FieldOffset(Offset = "0x18")]
		public int playerId;

		[Token(Token = "0x4005C0D")]
		[FieldOffset(Offset = "0x20")]
		public string horizontalAction;

		[Token(Token = "0x4005C0E")]
		[FieldOffset(Offset = "0x28")]
		public string verticalAction;

		[Token(Token = "0x4005C0F")]
		[FieldOffset(Offset = "0x30")]
		public string wheelAction;

		[Token(Token = "0x4005C10")]
		[FieldOffset(Offset = "0x38")]
		public string leftButtonAction;

		[Token(Token = "0x4005C11")]
		[FieldOffset(Offset = "0x40")]
		public string rightButtonAction;

		[Token(Token = "0x4005C12")]
		[FieldOffset(Offset = "0x48")]
		public string middleButtonAction;

		[Token(Token = "0x4005C13")]
		[FieldOffset(Offset = "0x50")]
		public float distanceFromCamera;

		[Token(Token = "0x4005C14")]
		[FieldOffset(Offset = "0x54")]
		public float spriteScale;

		[Token(Token = "0x4005C15")]
		[FieldOffset(Offset = "0x58")]
		public GameObject pointerPrefab;

		[Token(Token = "0x4005C16")]
		[FieldOffset(Offset = "0x60")]
		public GameObject clickEffectPrefab;

		[Token(Token = "0x4005C17")]
		[FieldOffset(Offset = "0x68")]
		public bool hideHardwarePointer;

		[NonSerialized]
		[Token(Token = "0x4005C18")]
		[FieldOffset(Offset = "0x70")]
		private GameObject pointer;

		[NonSerialized]
		[Token(Token = "0x4005C19")]
		[FieldOffset(Offset = "0x78")]
		private PlayerMouse mouse;

		[Token(Token = "0x6004F86")]
		[Address(RVA = "0x15F89CC", Offset = "0x15F89CC", VA = "0x15F89CC")]
		private void Awake()
		{
		}

		[Token(Token = "0x6004F87")]
		[Address(RVA = "0x15F8D0C", Offset = "0x15F8D0C", VA = "0x15F8D0C")]
		private void Update()
		{
		}

		[Token(Token = "0x6004F88")]
		[Address(RVA = "0x15F90D4", Offset = "0x15F90D4", VA = "0x15F90D4")]
		private void OnDestroy()
		{
		}

		[Token(Token = "0x6004F89")]
		[Address(RVA = "0x15F8F40", Offset = "0x15F8F40", VA = "0x15F8F40")]
		private void CreateClickEffect(Color color)
		{
		}

		[Token(Token = "0x6004F8A")]
		[Address(RVA = "0x15F8C84", Offset = "0x15F8C84", VA = "0x15F8C84")]
		private void OnScreenPositionChanged(Vector2 position)
		{
		}

		[Token(Token = "0x6004F8B")]
		[Address(RVA = "0x15F9210", Offset = "0x15F9210", VA = "0x15F9210")]
		public PlayerMouseSpriteExample()
		{
		}
	}
}
