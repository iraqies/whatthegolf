using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Audio.Conditions
{
	[Serializable]
	[Token(Token = "0x20013ED")]
	public class ConditionChecker
	{
		[Token(Token = "0x4006B2F")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private List<SerializedAudioCondition> conditions;

		[Token(Token = "0x6005CDD")]
		[Address(RVA = "0x18AACE4", Offset = "0x18AACE4", VA = "0x18AACE4")]
		public bool CheckConditions()
		{
			return default;
		}

		[Token(Token = "0x6005CDE")]
		[Address(RVA = "0x18AAD7C", Offset = "0x18AAD7C", VA = "0x18AAD7C")]
		public ConditionChecker()
		{
		}
	}
}
