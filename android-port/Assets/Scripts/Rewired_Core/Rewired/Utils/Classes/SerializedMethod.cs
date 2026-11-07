using System;
using System.Collections.Generic;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired.Utils.Classes
{
	[Serializable]
	public abstract class SerializedMethod : ScriptableObject
	{
		private const int SUlQDrwIcmZFfFJVXofSHwGuSqLC = 3;

		[NonSerialized]
		private bool ddfLFhLiJODfDhahYrcCbLnLCiLi;

		[NonSerialized]
		internal List<TypeWrapper> _data;

		[NonSerialized]
		internal TypeWrapper _result;

		[NonSerialized]
		internal bool _resultIsValid;

		internal abstract TypeWrapper.DataType ResultType { get; }

		internal int DataCount => 0;

		internal TypeWrapper Result => default;

		internal bool ResultIsValid => false;

		internal TypeWrapper GetData(int index)
		{
			return default;
		}

		internal void AddData(byte item)
		{
		}

		internal void AddData(sbyte item)
		{
		}

		internal void AddData(char item)
		{
		}

		internal void AddData(int item)
		{
		}

		internal void AddData(uint item)
		{
		}

		internal void AddData(long item)
		{
		}

		internal void AddData(ulong item)
		{
		}

		internal void AddData(float item)
		{
		}

		internal void AddData(double item)
		{
		}

		internal void AddData(bool item)
		{
		}

		internal void AddData(string item)
		{
		}

		internal void AddData(object item)
		{
		}

		internal void AddData(TypeWrapper item)
		{
		}

		internal void ClearData()
		{
		}

		internal void ClearResult()
		{
		}

		internal abstract bool Process();

		private void cAVeQbCddgXrFutcXSGhiEPCUNkhA()
		{
		}
	}
}
