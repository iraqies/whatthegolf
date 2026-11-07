using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace I2.Loc
{
	[Token(Token = "0x2001326")]
	public class LocalizationParamsManager : MonoBehaviour, ILocalizationParamsManager
	{
		[Serializable]
		[Token(Token = "0x2001327")]
		public struct ParamValue
		{
			[Token(Token = "0x400669C")]
			[FieldOffset(Offset = "0x0")]
			public string Name;

			[Token(Token = "0x400669D")]
			[FieldOffset(Offset = "0x8")]
			public string Value;
		}

		[Token(Token = "0x400669A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public List<ParamValue> _Params;

		[Token(Token = "0x400669B")]
		[FieldOffset(Offset = "0x20")]
		public bool _IsGlobalManager;

		[Token(Token = "0x600595F")]
		[Address(RVA = "0x1544298", Offset = "0x1544298", VA = "0x1544298", Slot = "4")]
		public string GetParameterValue(string ParamName)
		{
			return null;
		}

		[Token(Token = "0x6005960")]
		[Address(RVA = "0x1544388", Offset = "0x1544388", VA = "0x1544388")]
		public void SetParameterValue(string ParamName, string ParamValue, bool localize = true)
		{
		}

		[Token(Token = "0x6005961")]
		[Address(RVA = "0x15444F8", Offset = "0x15444F8", VA = "0x15444F8")]
		public void OnLocalize()
		{
		}

		[Token(Token = "0x6005962")]
		[Address(RVA = "0x15445B8", Offset = "0x15445B8", VA = "0x15445B8", Slot = "5")]
		public virtual void OnEnable()
		{
		}

		[Token(Token = "0x6005963")]
		[Address(RVA = "0x15445CC", Offset = "0x15445CC", VA = "0x15445CC")]
		public void DoAutoRegister()
		{
		}

		[Token(Token = "0x6005964")]
		[Address(RVA = "0x15446C4", Offset = "0x15446C4", VA = "0x15446C4")]
		public void OnDisable()
		{
		}

		[Token(Token = "0x6005965")]
		[Address(RVA = "0x1544758", Offset = "0x1544758", VA = "0x1544758")]
		public LocalizationParamsManager()
		{
		}
	}
}
