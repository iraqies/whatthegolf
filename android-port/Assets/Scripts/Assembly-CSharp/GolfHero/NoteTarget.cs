using Il2CppDummyDll;
using UnityEngine;

namespace GolfHero
{
	[Token(Token = "0x20010DB")]
	public class NoteTarget : MonoBehaviour
	{
		[Token(Token = "0x40058D7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Renderer renderer;

		[Token(Token = "0x170007FD")]
		public Material Material
		{
			[Token(Token = "0x6004B83")]
			[Address(RVA = "0x158DFC0", Offset = "0x158DFC0", VA = "0x158DFC0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004B82")]
			[Address(RVA = "0x158DFA4", Offset = "0x158DFA4", VA = "0x158DFA4")]
			set
			{
			}
		}

		[Token(Token = "0x6004B84")]
		[Address(RVA = "0x158DFDC", Offset = "0x158DFDC", VA = "0x158DFDC")]
		public NoteTarget()
		{
		}
	}
}
