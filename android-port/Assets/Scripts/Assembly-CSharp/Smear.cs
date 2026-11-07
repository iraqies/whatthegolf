using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000016")]
public class Smear : MonoBehaviour
{
	[Token(Token = "0x4000051")]
	[FieldOffset(Offset = "0x18")]
	private Queue<Vector3> m_recentPositions;

	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x20")]
	public int FramesBufferSize;

	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x28")]
	public Renderer Renderer;

	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x30")]
	private Material m_instancedMaterial;

	[Token(Token = "0x17000012")]
	private Material InstancedMaterial
	{
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x16B7E00", Offset = "0x16B7E00", VA = "0x16B7E00")]
		get
		{
			return null;
		}
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x16B7E08", Offset = "0x16B7E08", VA = "0x16B7E08")]
		set
		{
		}
	}

	[Token(Token = "0x600005B")]
	[Address(RVA = "0x16B7E10", Offset = "0x16B7E10", VA = "0x16B7E10")]
	private void Start()
	{
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x16B7E44", Offset = "0x16B7E44", VA = "0x16B7E44")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600005D")]
	[Address(RVA = "0x16B7F74", Offset = "0x16B7F74", VA = "0x16B7F74")]
	public Smear()
	{
	}
}
