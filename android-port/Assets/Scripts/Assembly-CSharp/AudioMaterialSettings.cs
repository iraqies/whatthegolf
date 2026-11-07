using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000382")]
public class AudioMaterialSettings : MonoBehaviour
{
	[Token(Token = "0x4001348")]
	[FieldOffset(Offset = "0x18")]
	public ObjectWeight objectWeight;

	[Token(Token = "0x4001349")]
	[FieldOffset(Offset = "0x20")]
	public AudioMaterial material;

	[Token(Token = "0x400134A")]
	[FieldOffset(Offset = "0x28")]
	public List<AudioMaterial> secondaryMaterials;

	[Token(Token = "0x400134B")]
	[FieldOffset(Offset = "0x30")]
	private List<AudioMaterial> allMaterials;

	[Token(Token = "0x170001FB")]
	public List<AudioMaterial> GetMaterials
	{
		[Token(Token = "0x60010A6")]
		[Address(RVA = "0x150964C", Offset = "0x150964C", VA = "0x150964C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60010A7")]
	[Address(RVA = "0x1509738", Offset = "0x1509738", VA = "0x1509738")]
	public AudioMaterialSettings()
	{
	}
}
