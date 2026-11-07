using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000B79")]
public class Skidmarks : MonoBehaviour
{
	[Token(Token = "0x2000B7A")]
	private class MarkSection
	{
		[Token(Token = "0x4003FFD")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 Pos;

		[Token(Token = "0x4003FFE")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 Normal;

		[Token(Token = "0x4003FFF")]
		[FieldOffset(Offset = "0x28")]
		public Vector4 Tangent;

		[Token(Token = "0x4004000")]
		[FieldOffset(Offset = "0x38")]
		public Vector3 Posl;

		[Token(Token = "0x4004001")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 Posr;

		[Token(Token = "0x4004002")]
		[FieldOffset(Offset = "0x50")]
		public byte Intensity;

		[Token(Token = "0x4004003")]
		[FieldOffset(Offset = "0x54")]
		public int LastIndex;

		[Token(Token = "0x6003765")]
		[Address(RVA = "0x1850FF8", Offset = "0x1850FF8", VA = "0x1850FF8")]
		public MarkSection()
		{
		}
	}

	[Token(Token = "0x4003FE8")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private Material skidmarksMaterial;

	[Token(Token = "0x4003FE9")]
	private const int MAX_MARKS = 2048;

	[Token(Token = "0x4003FEA")]
	private const float MARK_WIDTH = 0.6f;

	[Token(Token = "0x4003FEB")]
	private const float GROUND_OFFSET = 0.02f;

	[Token(Token = "0x4003FEC")]
	private const float MIN_DISTANCE = 1f;

	[Token(Token = "0x4003FED")]
	private const float MIN_SQR_DISTANCE = 1f;

	[Token(Token = "0x4003FEE")]
	[FieldOffset(Offset = "0x20")]
	private int markIndex;

	[Token(Token = "0x4003FEF")]
	[FieldOffset(Offset = "0x28")]
	private MarkSection[] skidmarks;

	[Token(Token = "0x4003FF0")]
	[FieldOffset(Offset = "0x30")]
	private Mesh marksMesh;

	[Token(Token = "0x4003FF1")]
	[FieldOffset(Offset = "0x38")]
	private MeshRenderer mr;

	[Token(Token = "0x4003FF2")]
	[FieldOffset(Offset = "0x40")]
	private MeshFilter mf;

	[Token(Token = "0x4003FF3")]
	[FieldOffset(Offset = "0x48")]
	private Vector3[] vertices;

	[Token(Token = "0x4003FF4")]
	[FieldOffset(Offset = "0x50")]
	private Vector3[] normals;

	[Token(Token = "0x4003FF5")]
	[FieldOffset(Offset = "0x58")]
	private Vector4[] tangents;

	[Token(Token = "0x4003FF6")]
	[FieldOffset(Offset = "0x60")]
	private Color32[] colors;

	[Token(Token = "0x4003FF7")]
	[FieldOffset(Offset = "0x68")]
	private Vector2[] uvs;

	[Token(Token = "0x4003FF8")]
	[FieldOffset(Offset = "0x70")]
	private int[] triangles;

	[Token(Token = "0x4003FF9")]
	[FieldOffset(Offset = "0x78")]
	private bool meshUpdated;

	[Token(Token = "0x4003FFA")]
	[FieldOffset(Offset = "0x79")]
	private bool haveSetBounds;

	[Token(Token = "0x4003FFB")]
	[FieldOffset(Offset = "0x7A")]
	private bool initialized;

	[Token(Token = "0x4003FFC")]
	[FieldOffset(Offset = "0x80")]
	public Action<float> OnCreateSkidmark;

	[Token(Token = "0x6003760")]
	[Address(RVA = "0x16B50E4", Offset = "0x16B50E4", VA = "0x16B50E4")]
	protected void Start()
	{
	}

	[Token(Token = "0x6003761")]
	[Address(RVA = "0x16B552C", Offset = "0x16B552C", VA = "0x16B552C")]
	protected void LateUpdate()
	{
	}

	[Token(Token = "0x6003762")]
	[Address(RVA = "0x16B565C", Offset = "0x16B565C", VA = "0x16B565C")]
	public int AddSkidMark(Vector3 pos, Vector3 normal, float intensity, int lastIndex)
	{
		return default;
	}

	[Token(Token = "0x6003763")]
	[Address(RVA = "0x16B5950", Offset = "0x16B5950", VA = "0x16B5950")]
	private void UpdateSkidmarksMesh()
	{
	}

	[Token(Token = "0x6003764")]
	[Address(RVA = "0x16B5DD0", Offset = "0x16B5DD0", VA = "0x16B5DD0")]
	public Skidmarks()
	{
	}
}
