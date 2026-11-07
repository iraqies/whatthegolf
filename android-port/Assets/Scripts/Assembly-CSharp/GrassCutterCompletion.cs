using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000246")]
public class GrassCutterCompletion : MonoBehaviour
{
	[Token(Token = "0x4000BA0")]
	[FieldOffset(Offset = "0x18")]
	public TerrainData GrassTerrain;

	[Token(Token = "0x4000BA1")]
	[FieldOffset(Offset = "0x20")]
	public float CheckInterval;

	[Token(Token = "0x4000BA2")]
	[FieldOffset(Offset = "0x24")]
	public Vector2Int CheckRadius;

	[Token(Token = "0x4000BA3")]
	[FieldOffset(Offset = "0x30")]
	public Animator FlagAnimator;

	[Token(Token = "0x4000BA4")]
	[FieldOffset(Offset = "0x38")]
	private float checkTimer;

	[Token(Token = "0x6000A36")]
	[Address(RVA = "0x14B7CA0", Offset = "0x14B7CA0", VA = "0x14B7CA0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000A37")]
	[Address(RVA = "0x14B7F28", Offset = "0x14B7F28", VA = "0x14B7F28")]
	private Vector3 ConvertWorldCor2TerrCor(Vector3 worldCor)
	{
		return default;
	}

	[Token(Token = "0x6000A38")]
	[Address(RVA = "0x14B8024", Offset = "0x14B8024", VA = "0x14B8024")]
	public GrassCutterCompletion()
	{
	}
}
