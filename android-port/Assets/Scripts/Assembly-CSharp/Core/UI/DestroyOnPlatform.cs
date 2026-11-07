using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Core.UI
{
	[Token(Token = "0x2001472")]
	public class DestroyOnPlatform : MonoBehaviour
	{
		[Token(Token = "0x2001473")]
		public enum Behaviour
		{
			[Token(Token = "0x400703E")]
			Destroy = 0,
			[Token(Token = "0x400703F")]
			DeactivateComponent = 1
		}

		[Token(Token = "0x400703A")]
		[FieldOffset(Offset = "0x18")]
		public List<EPlatformType> supportedPlatforms;

		[Token(Token = "0x400703B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MonoBehaviour component;

		[Token(Token = "0x400703C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Behaviour behaviour;

		[Token(Token = "0x6006067")]
		[Address(RVA = "0x18DB80C", Offset = "0x18DB80C", VA = "0x18DB80C")]
		private void Awake()
		{
		}

		[Token(Token = "0x6006068")]
		[Address(RVA = "0x18DB934", Offset = "0x18DB934", VA = "0x18DB934")]
		public DestroyOnPlatform()
		{
		}
	}
}
