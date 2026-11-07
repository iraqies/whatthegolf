using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000296")]
[AttributeAttribute(Name = "RequireComponent", RVA = "0x3E8AC", Offset = "0x3E8AC")]
public class RandomizeMaterial : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x2000297")]
	public struct RandomizableMaterialInfo
	{
		[Token(Token = "0x4000DC5")]
		[FieldOffset(Offset = "0x0")]
		public List<Material> materials;

		[Token(Token = "0x4000DC6")]
		[FieldOffset(Offset = "0x8")]
		public int materialIndex;
	}

	[Token(Token = "0x4000DC4")]
	[FieldOffset(Offset = "0x18")]
	public List<RandomizableMaterialInfo> randMaterialGroups;

	[Token(Token = "0x6000BD8")]
	[Address(RVA = "0x164026C", Offset = "0x164026C", VA = "0x164026C")]
	private void Start()
	{
	}

	[Token(Token = "0x6000BD9")]
	[Address(RVA = "0x16405F4", Offset = "0x16405F4", VA = "0x16405F4")]
	public RandomizeMaterial()
	{
	}
}
