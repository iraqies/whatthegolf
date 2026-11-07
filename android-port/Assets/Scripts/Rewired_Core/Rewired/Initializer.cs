using Il2CppDummyDll;
using UnityEngine;

namespace Rewired
{
	[Token(Token = "0x20000AF")]
	[Attribute(Name = "EditorBrowsableAttribute", RVA = "0x190A50", Offset = "0x190A50")]
	[Attribute(Name = "BrowsableAttribute", RVA = "0x190A50", Offset = "0x190A50")]
	public sealed class Initializer : MonoBehaviour
	{
		[Token(Token = "0x40003C8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _inputManagerPrefab;

		[Token(Token = "0x40003C9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _destroySelf;

		[Token(Token = "0x17000189")]
		public GameObject inputManagerPrefab
		{
			[Token(Token = "0x60003DA")]
			[Address(RVA = "0x23D22A0", Offset = "0x23D22A0", VA = "0x23D22A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003DB")]
			[Address(RVA = "0x23D22A8", Offset = "0x23D22A8", VA = "0x23D22A8")]
			set
			{
			}
		}

		[Token(Token = "0x1700018A")]
		public bool destroySelf
		{
			[Token(Token = "0x60003DC")]
			[Address(RVA = "0x23D22B0", Offset = "0x23D22B0", VA = "0x23D22B0")]
			get
			{
				return default;
			}
			[Token(Token = "0x60003DD")]
			[Address(RVA = "0x23D22B8", Offset = "0x23D22B8", VA = "0x23D22B8")]
			set
			{
			}
		}

		[Token(Token = "0x60003DE")]
		[Address(RVA = "0x23D22C0", Offset = "0x23D22C0", VA = "0x23D22C0")]
		private void Awake()
		{
		}

		[Token(Token = "0x60003DF")]
		[Address(RVA = "0x23D22C4", Offset = "0x23D22C4", VA = "0x23D22C4")]
		public bool Initialize()
		{
			return default;
		}

		[Token(Token = "0x60003E0")]
		[Address(RVA = "0x23D289C", Offset = "0x23D289C", VA = "0x23D289C")]
		public Initializer()
		{
		}
	}
}
