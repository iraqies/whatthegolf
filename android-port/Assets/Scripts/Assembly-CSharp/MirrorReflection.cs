using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003F8")]
[ExecuteInEditMode]
public class MirrorReflection : MonoBehaviour
{
	[Token(Token = "0x40015A1")]
	[FieldOffset(Offset = "0x18")]
	public bool m_DisablePixelLights;

	[Token(Token = "0x40015A2")]
	[FieldOffset(Offset = "0x1C")]
	public int m_TextureSize;

	[Token(Token = "0x40015A3")]
	[FieldOffset(Offset = "0x20")]
	public float m_ClipPlaneOffset;

	[Token(Token = "0x40015A4")]
	[FieldOffset(Offset = "0x24")]
	public LayerMask m_ReflectLayers;

	[Token(Token = "0x40015A5")]
	[FieldOffset(Offset = "0x28")]
	private Hashtable m_ReflectionCameras;

	[Token(Token = "0x40015A6")]
	[FieldOffset(Offset = "0x30")]
	private RenderTexture m_ReflectionTexture;

	[Token(Token = "0x40015A7")]
	[FieldOffset(Offset = "0x38")]
	private int m_OldReflectionTextureSize;

	[Token(Token = "0x40015A8")]
	[FieldOffset(Offset = "0x0")]
	private static bool s_InsideRendering;

	[Token(Token = "0x600129B")]
	[Address(RVA = "0x1567938", Offset = "0x1567938", VA = "0x1567938")]
	public void OnWillRenderObject()
	{
	}

	[Token(Token = "0x600129C")]
	[Address(RVA = "0x1568A24", Offset = "0x1568A24", VA = "0x1568A24")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600129D")]
	[Address(RVA = "0x1568370", Offset = "0x1568370", VA = "0x1568370")]
	private void UpdateCameraModes(Camera src, Camera dest)
	{
	}

	[Token(Token = "0x600129E")]
	[Address(RVA = "0x1567E78", Offset = "0x1567E78", VA = "0x1567E78")]
	private void CreateMirrorObjects(Camera currentCamera, out Camera reflectionCamera)
	{
	}

	[Token(Token = "0x600129F")]
	[Address(RVA = "0x1568DDC", Offset = "0x1568DDC", VA = "0x1568DDC")]
	private static float sgn(float a)
	{
		return default;
	}

	[Token(Token = "0x60012A0")]
	[Address(RVA = "0x1568908", Offset = "0x1568908", VA = "0x1568908")]
	private Vector4 CameraSpacePlane(Camera cam, Vector3 pos, Vector3 normal, float sideSign)
	{
		return default;
	}

	[Token(Token = "0x60012A1")]
	[Address(RVA = "0x1568664", Offset = "0x1568664", VA = "0x1568664")]
	private static void CalculateReflectionMatrix(ref Matrix4x4 reflectionMat, Vector4 plane)
	{
	}

	[Token(Token = "0x60012A2")]
	[Address(RVA = "0x1568DF8", Offset = "0x1568DF8", VA = "0x1568DF8")]
	public MirrorReflection()
	{
	}
}
