using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Conditions
{
	[Token(Token = "0x20013E8")]
	public abstract class AudioCondition : MonoBehaviour
	{
		[Token(Token = "0x6005CD5")]
		public abstract bool CheckCondition();

		[Token(Token = "0x6005CD6")]
		[Address(RVA = "0x142CE20", Offset = "0x142CE20", VA = "0x142CE20")]
		protected AudioCondition()
		{
		}
	}
}
