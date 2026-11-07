using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C0F")]
[ExecuteInEditMode]
public class OptimizeSceneGameObject : MonoBehaviour
{
	[Token(Token = "0x40042A9")]
	[FieldOffset(Offset = "0x18")]
	public Material CombinedMaterial;

	[Token(Token = "0x40042AA")]
	[FieldOffset(Offset = "0x20")]
	public SetVertexColors Optimizer;

	[Token(Token = "0x40042AB")]
	[FieldOffset(Offset = "0x28")]
	public bool PerformOptimization;

	[Token(Token = "0x60039D2")]
	[Address(RVA = "0x159CEE8", Offset = "0x159CEE8", VA = "0x159CEE8")]
	private void Update()
	{
	}

	[Token(Token = "0x60039D3")]
	[Address(RVA = "0x159D00C", Offset = "0x159D00C", VA = "0x159D00C")]
	public OptimizeSceneGameObject()
	{
	}
}
