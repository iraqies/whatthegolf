using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x200132D")]
	public class RegisterGlobalParameters : MonoBehaviour, ILocalizationParamsManager
	{
		[Token(Token = "0x6005974")]
		[Address(RVA = "0x16482B0", Offset = "0x16482B0", VA = "0x16482B0", Slot = "5")]
		public virtual void OnEnable()
		{
		}

		[Token(Token = "0x6005975")]
		[Address(RVA = "0x16483AC", Offset = "0x16483AC", VA = "0x16483AC", Slot = "6")]
		public virtual void OnDisable()
		{
		}

		[Token(Token = "0x6005976")]
		[Address(RVA = "0x1648440", Offset = "0x1648440", VA = "0x1648440", Slot = "7")]
		public virtual string GetParameterValue(string ParamName)
		{
			return null;
		}

		[Token(Token = "0x6005977")]
		[Address(RVA = "0x1648448", Offset = "0x1648448", VA = "0x1648448")]
		public RegisterGlobalParameters()
		{
		}
	}
}
