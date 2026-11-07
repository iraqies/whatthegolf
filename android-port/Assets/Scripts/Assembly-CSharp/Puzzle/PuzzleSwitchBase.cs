using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Puzzle
{
	[Token(Token = "0x2001046")]
	public abstract class PuzzleSwitchBase : MonoBehaviour
	{
		[Serializable]
		[Token(Token = "0x2001047")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x47704", Offset = "0x47704")]
		private sealed class _003C_003Ec
		{
			[Token(Token = "0x40055D1")]
			[FieldOffset(Offset = "0x0")]
			public static readonly _003C_003Ec _003C_003E9;

			[Token(Token = "0x40055D2")]
			[FieldOffset(Offset = "0x8")]
			public static Action<bool> _003C_003E9__13_0;

			[Token(Token = "0x60048F5")]
			[Address(RVA = "0x182F5CC", Offset = "0x182F5CC", VA = "0x182F5CC")]
			public _003C_003Ec()
			{
			}

			[Token(Token = "0x60048F6")]
			[Address(RVA = "0x182F5D4", Offset = "0x182F5D4", VA = "0x182F5D4")]
			internal void _003C_002Ector_003Eb__13_0(bool _003Cp0_003E)
			{
			}
		}

		[Token(Token = "0x40055CA")]
		[FieldOffset(Offset = "0x18")]
		public SpriteRenderer sprite;

		[Token(Token = "0x40055CB")]
		[FieldOffset(Offset = "0x20")]
		public Sprite onSprite;

		[Token(Token = "0x40055CC")]
		[FieldOffset(Offset = "0x28")]
		public Sprite offSprite;

		[Token(Token = "0x40055CD")]
		[FieldOffset(Offset = "0x30")]
		public SpriteRenderer decorationSprite;

		[Token(Token = "0x40055CE")]
		[FieldOffset(Offset = "0x38")]
		public List<PuzzleObjectBase> objects;

		[Token(Token = "0x40055CF")]
		[FieldOffset(Offset = "0x40")]
		public Action<bool> OnTrigger;

		[Token(Token = "0x40055D0")]
		[FieldOffset(Offset = "0x48")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x555B0", Offset = "0x555B0")]
		private bool Active__BackingField;

		[Token(Token = "0x170007B6")]
		public bool Active
		{
			[Token(Token = "0x60048EE")]
			[Address(RVA = "0x163170C", Offset = "0x163170C", VA = "0x163170C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F164", Offset = "0x6F164")]
			get
			{
				return default;
			}
			[Token(Token = "0x60048EF")]
			[Address(RVA = "0x1631714", Offset = "0x1631714", VA = "0x1631714")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6F174", Offset = "0x6F174")]
			private set
			{
			}
		}

		[Token(Token = "0x60048F0")]
		[Address(RVA = "0x163171C", Offset = "0x163171C", VA = "0x163171C")]
		private void Awake()
		{
		}

		[Token(Token = "0x60048F1")]
		[Address(RVA = "0x162F218", Offset = "0x162F218", VA = "0x162F218")]
		public void TriggerObjects(bool active)
		{
		}

		[Token(Token = "0x60048F2")]
		[Address(RVA = "0x16317C4", Offset = "0x16317C4", VA = "0x16317C4")]
		private void OnDrawGizmosSelected()
		{
		}

		[Token(Token = "0x60048F3")]
		[Address(RVA = "0x162F48C", Offset = "0x162F48C", VA = "0x162F48C")]
		protected PuzzleSwitchBase()
		{
		}
	}
}
