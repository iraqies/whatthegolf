using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace NaughtyAttributes.Test
{
	[Token(Token = "0x200002F")]
	public class ReorderableListTest : MonoBehaviour
	{
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x18")]
		public int[] intArray;

		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x20")]
		public List<Vector3> vectorList;

		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x28")]
		public List<SomeStruct> structList;

		[Token(Token = "0x6000030")]
		[Address(RVA = "0x22ABC64", Offset = "0x22ABC64", VA = "0x22ABC64")]
		public ReorderableListTest()
		{
		}
	}
}
