using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000062")]
	public class TimedObjectDestructor : MonoBehaviour
	{
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float m_TimeOut;

		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool m_DetachChildren;

		[Token(Token = "0x6000185")]
		[Address(RVA = "0x131B468", Offset = "0x131B468", VA = "0x131B468")]
		private void Awake()
		{
		}

		[Token(Token = "0x6000186")]
		[Address(RVA = "0x131B4C8", Offset = "0x131B4C8", VA = "0x131B4C8")]
		private void DestroyNow()
		{
		}

		[Token(Token = "0x6000187")]
		[Address(RVA = "0x131B568", Offset = "0x131B568", VA = "0x131B568")]
		public TimedObjectDestructor()
		{
		}
	}
}
