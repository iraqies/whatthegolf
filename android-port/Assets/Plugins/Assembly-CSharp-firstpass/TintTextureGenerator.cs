using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Tilemaps;

[Token(Token = "0x200003C")]
[ExecuteInEditMode]
public class TintTextureGenerator : MonoBehaviour
{
	[Token(Token = "0x40000EF")]
	[FieldOffset(Offset = "0x18")]
	public int k_TintMapSize;

	[Token(Token = "0x40000F0")]
	[FieldOffset(Offset = "0x20")]
	private Texture2D m_TintTexture;

	[Token(Token = "0x1700001E")]
	private Texture2D tintTexture
	{
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x132205C", Offset = "0x132205C", VA = "0x132205C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000101")]
	[Address(RVA = "0x1321E04", Offset = "0x1321E04", VA = "0x1321E04")]
	public void Start()
	{
	}

	[Token(Token = "0x6000103")]
	[Address(RVA = "0x1321E64", Offset = "0x1321E64", VA = "0x1321E64")]
	public void Refresh(Grid grid)
	{
	}

	[Token(Token = "0x6000104")]
	[Address(RVA = "0x13223D0", Offset = "0x13223D0", VA = "0x13223D0")]
	public void Refresh(Grid grid, Vector3Int position)
	{
	}

	[Token(Token = "0x6000105")]
	[Address(RVA = "0x1322634", Offset = "0x1322634", VA = "0x1322634")]
	public Color GetColor(Grid grid, Vector3Int position)
	{
		return default;
	}

	[Token(Token = "0x6000106")]
	[Address(RVA = "0x1322718", Offset = "0x1322718", VA = "0x1322718")]
	public void SetColor(Grid grid, Vector3Int position, Color color)
	{
	}

	[Token(Token = "0x6000107")]
	[Address(RVA = "0x1322590", Offset = "0x1322590", VA = "0x1322590")]
	private Vector3Int WorldToTexture(Vector3Int world)
	{
		return default;
	}

	[Token(Token = "0x6000108")]
	[Address(RVA = "0x132224C", Offset = "0x132224C", VA = "0x132224C")]
	private Vector3Int TextureToWorld(Vector3Int texpos)
	{
		return default;
	}

	[Token(Token = "0x6000109")]
	[Address(RVA = "0x13222F0", Offset = "0x13222F0", VA = "0x13222F0")]
	private GridInformation GetGridInformation(Grid grid)
	{
		return null;
	}

	[Token(Token = "0x600010A")]
	[Address(RVA = "0x13221CC", Offset = "0x13221CC", VA = "0x13221CC")]
	private void RefreshGlobalShaderValues()
	{
	}

	[Token(Token = "0x600010B")]
	[Address(RVA = "0x132283C", Offset = "0x132283C", VA = "0x132283C")]
	public TintTextureGenerator()
	{
	}
}
