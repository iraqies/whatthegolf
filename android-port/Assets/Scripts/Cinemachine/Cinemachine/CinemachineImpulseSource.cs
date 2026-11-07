using Il2CppDummyDll;
using UnityEngine;

namespace Cinemachine
{
	[Token(Token = "0x200008C")]
	public class CinemachineImpulseSource : MonoBehaviour
	{
		[Token(Token = "0x400030D")]
		[FieldOffset(Offset = "0x18")]
		public CinemachineImpulseDefinition m_ImpulseDefinition;

		[Token(Token = "0x6000333")]
		[Address(RVA = "0x18F8E10", Offset = "0x18F8E10", VA = "0x18F8E10")]
		private void OnValidate()
		{
		}

		[Token(Token = "0x6000334")]
		[Address(RVA = "0x18F8E64", Offset = "0x18F8E64", VA = "0x18F8E64")]
		public void GenerateImpulseAt(Vector3 position, Vector3 velocity)
		{
		}

		[Token(Token = "0x6000335")]
		[Address(RVA = "0x18F8E74", Offset = "0x18F8E74", VA = "0x18F8E74")]
		public void GenerateImpulse(Vector3 velocity)
		{
		}

		[Token(Token = "0x6000336")]
		[Address(RVA = "0x18F8EEC", Offset = "0x18F8EEC", VA = "0x18F8EEC")]
		public void GenerateImpulse()
		{
		}

		[Token(Token = "0x6000337")]
		[Address(RVA = "0x18F8F70", Offset = "0x18F8F70", VA = "0x18F8F70")]
		public CinemachineImpulseSource()
		{
		}
	}
}
