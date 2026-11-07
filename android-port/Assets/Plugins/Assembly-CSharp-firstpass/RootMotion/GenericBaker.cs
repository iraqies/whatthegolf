using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion
{
	[Token(Token = "0x20000D5")]
	public class GenericBaker : Baker
	{
		[Token(Token = "0x400046E")]
		[FieldOffset(Offset = "0x74")]
		public bool markAsLegacy;

		[Token(Token = "0x400046F")]
		[FieldOffset(Offset = "0x78")]
		public Transform root;

		[Token(Token = "0x4000470")]
		[FieldOffset(Offset = "0x80")]
		public Transform rootNode;

		[Token(Token = "0x4000471")]
		[FieldOffset(Offset = "0x88")]
		public Transform[] ignoreList;

		[Token(Token = "0x4000472")]
		[FieldOffset(Offset = "0x90")]
		public Transform[] bakePositionList;

		[Token(Token = "0x4000473")]
		[FieldOffset(Offset = "0x98")]
		private BakerTransform[] children;

		[Token(Token = "0x4000474")]
		[FieldOffset(Offset = "0xA0")]
		private BakerTransform rootChild;

		[Token(Token = "0x4000475")]
		[FieldOffset(Offset = "0xA8")]
		private int rootChildIndex;

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x1374B6C", Offset = "0x1374B6C", VA = "0x1374B6C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x1374F7C", Offset = "0x1374F7C", VA = "0x1374F7C", Slot = "4")]
		protected override Transform GetCharacterRoot()
		{
			return null;
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x1374F84", Offset = "0x1374F84", VA = "0x1374F84", Slot = "5")]
		protected override void OnStartBaking()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x137509C", Offset = "0x137509C", VA = "0x137509C", Slot = "6")]
		protected override void OnSetLoopFrame(float time)
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x1375118", Offset = "0x1375118", VA = "0x1375118", Slot = "7")]
		protected override void OnSetCurves(ref AnimationClip clip)
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x1375194", Offset = "0x1375194", VA = "0x1375194", Slot = "8")]
		protected override void OnSetKeyframes(float time, bool lastFrame)
		{
		}

		[Token(Token = "0x6000568")]
		[Address(RVA = "0x1374DCC", Offset = "0x1374DCC", VA = "0x1374DCC")]
		private bool IsIgnored(Transform t)
		{
			return default;
		}

		[Token(Token = "0x6000569")]
		[Address(RVA = "0x1374EA4", Offset = "0x1374EA4", VA = "0x1374EA4")]
		private bool BakePosition(Transform t)
		{
			return default;
		}

		[Token(Token = "0x600056A")]
		[Address(RVA = "0x1375210", Offset = "0x1375210", VA = "0x1375210")]
		public GenericBaker()
		{
		}
	}
}
