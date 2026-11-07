using Il2CppDummyDll;
using UnityEngine.SceneManagement;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[Token(Token = "0x2000052")]
	public struct SceneInstance
	{
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x0")]
		private Scene m_Scene;

		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x8")]
		internal AsyncOperation m_Operation;

		[Token(Token = "0x17000056")]
		public Scene Scene
		{
			[Token(Token = "0x60001EE")]
			[Address(RVA = "0x2A709E8", Offset = "0x2A709E8", VA = "0x2A709E8")]
			get
			{
				return default;
			}
			[Token(Token = "0x60001EF")]
			[Address(RVA = "0x2A709F0", Offset = "0x2A709F0", VA = "0x2A709F0")]
			internal set
			{
			}
		}

		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x2A709F8", Offset = "0x2A709F8", VA = "0x2A709F8")]
		[Attribute(Name = "ObsoleteAttribute", RVA = "0x1B8564", Offset = "0x1B8564")]
		public void Activate()
		{
		}

		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x2A70A18", Offset = "0x2A70A18", VA = "0x2A70A18")]
		public AsyncOperation ActivateAsync()
		{
			return null;
		}

		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x2A70A50", Offset = "0x2A70A50", VA = "0x2A70A50", Slot = "2")]
		public override int GetHashCode()
		{
			return default;
		}

		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x2A70A7C", Offset = "0x2A70A7C", VA = "0x2A70A7C", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default;
		}
	}
}
