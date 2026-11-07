using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.Utility
{
	[Token(Token = "0x2000057")]
	public class PlatformSpecificContent : MonoBehaviour
	{
		[Token(Token = "0x2000058")]
		private enum BuildTargetGroup
		{
			[Token(Token = "0x4000161")]
			Standalone = 0,
			[Token(Token = "0x4000162")]
			Mobile = 1
		}

		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildTargetGroup m_BuildTargetGroup;

		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] m_Content;

		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MonoBehaviour[] m_MonoBehaviours;

		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool m_ChildrenOfThisObject;

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x13C08B4", Offset = "0x13C08B4", VA = "0x13C08B4")]
		private void OnEnable()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x13C08C4", Offset = "0x13C08C4", VA = "0x13C08C4")]
		private void CheckEnableContent()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x13C08D4", Offset = "0x13C08D4", VA = "0x13C08D4")]
		private void EnableContent(bool enabled)
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x13C0CC4", Offset = "0x13C0CC4", VA = "0x13C0CC4")]
		public PlatformSpecificContent()
		{
		}
	}
}
