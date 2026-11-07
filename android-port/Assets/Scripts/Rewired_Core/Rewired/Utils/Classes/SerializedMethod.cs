using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired.Utils.Classes
{
	[Serializable]
	[Token(Token = "0x200035B")]
	public abstract class SerializedMethod : ScriptableObject
	{
		[Token(Token = "0x4001163")]
		private const int SUlQDrwIcmZFfFJVXofSHwGuSqLC = 3;

		[NonSerialized]
		[Token(Token = "0x4001164")]
		[FieldOffset(Offset = "0x18")]
		private bool ddfLFhLiJODfDhahYrcCbLnLCiLi;

		[NonSerialized]
		[Token(Token = "0x4001165")]
		[FieldOffset(Offset = "0x20")]
		internal List<TypeWrapper> _data;

		[NonSerialized]
		[Token(Token = "0x4001166")]
		[FieldOffset(Offset = "0x28")]
		internal TypeWrapper _result;

		[NonSerialized]
		[Token(Token = "0x4001167")]
		[FieldOffset(Offset = "0x48")]
		internal bool _resultIsValid;

		[Token(Token = "0x170006BB")]
		internal abstract TypeWrapper.DataType ResultType
		{
			[Token(Token = "0x60019AE")]
			get;
		}

		[Token(Token = "0x170006BC")]
		internal int DataCount
		{
			[Token(Token = "0x60019AF")]
			[Address(RVA = "0x240DBB0", Offset = "0x240DBB0", VA = "0x240DBB0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170006BD")]
		internal TypeWrapper Result
		{
			[Token(Token = "0x60019B0")]
			[Address(RVA = "0x240DC00", Offset = "0x240DC00", VA = "0x240DC00")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170006BE")]
		internal bool ResultIsValid
		{
			[Token(Token = "0x60019B1")]
			[Address(RVA = "0x240DC10", Offset = "0x240DC10", VA = "0x240DC10")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x60019B2")]
		[Address(RVA = "0x240DC18", Offset = "0x240DC18", VA = "0x240DC18")]
		internal TypeWrapper GetData(int index)
		{
			return default;
		}

		[Token(Token = "0x60019B3")]
		[Address(RVA = "0x240DD0C", Offset = "0x240DD0C", VA = "0x240DD0C")]
		internal void AddData(byte item)
		{
		}

		[Token(Token = "0x60019B4")]
		[Address(RVA = "0x240DE94", Offset = "0x240DE94", VA = "0x240DE94")]
		internal void AddData(sbyte item)
		{
		}

		[Token(Token = "0x60019B5")]
		[Address(RVA = "0x240DF98", Offset = "0x240DF98", VA = "0x240DF98")]
		internal void AddData(char item)
		{
		}

		[Token(Token = "0x60019B6")]
		[Address(RVA = "0x240E09C", Offset = "0x240E09C", VA = "0x240E09C")]
		internal void AddData(int item)
		{
		}

		[Token(Token = "0x60019B7")]
		[Address(RVA = "0x240E1A0", Offset = "0x240E1A0", VA = "0x240E1A0")]
		internal void AddData(uint item)
		{
		}

		[Token(Token = "0x60019B8")]
		[Address(RVA = "0x240E2A4", Offset = "0x240E2A4", VA = "0x240E2A4")]
		internal void AddData(long item)
		{
		}

		[Token(Token = "0x60019B9")]
		[Address(RVA = "0x240E3A8", Offset = "0x240E3A8", VA = "0x240E3A8")]
		internal void AddData(ulong item)
		{
		}

		[Token(Token = "0x60019BA")]
		[Address(RVA = "0x240E4AC", Offset = "0x240E4AC", VA = "0x240E4AC")]
		internal void AddData(float item)
		{
		}

		[Token(Token = "0x60019BB")]
		[Address(RVA = "0x240E5B0", Offset = "0x240E5B0", VA = "0x240E5B0")]
		internal void AddData(double item)
		{
		}

		[Token(Token = "0x60019BC")]
		[Address(RVA = "0x240E6B4", Offset = "0x240E6B4", VA = "0x240E6B4")]
		internal void AddData(bool item)
		{
		}

		[Token(Token = "0x60019BD")]
		[Address(RVA = "0x240E7B8", Offset = "0x240E7B8", VA = "0x240E7B8")]
		internal void AddData(string item)
		{
		}

		[Token(Token = "0x60019BE")]
		[Address(RVA = "0x240E8BC", Offset = "0x240E8BC", VA = "0x240E8BC")]
		internal void AddData(object item)
		{
		}

		[Token(Token = "0x60019BF")]
		[Address(RVA = "0x240E9C0", Offset = "0x240E9C0", VA = "0x240E9C0")]
		internal void AddData(TypeWrapper item)
		{
		}

		[Token(Token = "0x60019C0")]
		[Address(RVA = "0x240EAB8", Offset = "0x240EAB8", VA = "0x240EAB8")]
		internal void ClearData()
		{
		}

		[Token(Token = "0x60019C1")]
		[Address(RVA = "0x240EB24", Offset = "0x240EB24", VA = "0x240EB24")]
		internal void ClearResult()
		{
		}

		[Token(Token = "0x60019C2")]
		internal abstract bool Process();

		[Token(Token = "0x60019C3")]
		[Address(RVA = "0x240DE10", Offset = "0x240DE10", VA = "0x240DE10")]
		private void cAVeQbCddgXrFutcXSGhiEPCUNkhA()
		{
		}

		[Token(Token = "0x60019C4")]
		[Address(RVA = "0x240EB34", Offset = "0x240EB34", VA = "0x240EB34")]
		protected SerializedMethod()
		{
		}
	}
}
