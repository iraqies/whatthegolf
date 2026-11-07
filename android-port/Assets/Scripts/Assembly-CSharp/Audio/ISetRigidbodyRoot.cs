using Il2CppDummyDll;
using UnityEngine;

namespace Audio
{
	[Token(Token = "0x20013C4")]
	public interface ISetRigidbodyRoot
	{
		[Token(Token = "0x17000A6D")]
		GameObject GetRoot
		{
			[Token(Token = "0x6005C3F")]
			get;
		}

		[Token(Token = "0x6005C40")]
		void SetRoot(GameObject gameObject);
	}
}
