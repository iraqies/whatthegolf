using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20008DC")]
public class PropPlacer : MonoBehaviour
{
	[Token(Token = "0x4003076")]
	[FieldOffset(Offset = "0x18")]
	public float undergroundPct;

	[Token(Token = "0x4003077")]
	[FieldOffset(Offset = "0x1C")]
	public bool includeMeshesInBounds;

	[Token(Token = "0x4003078")]
	[FieldOffset(Offset = "0x1D")]
	public bool isLocked;

	[Token(Token = "0x4003079")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private LayerMask mask;

	[Token(Token = "0x400307A")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform _planet;

	[Token(Token = "0x60028FA")]
	[Address(RVA = "0x1627AA8", Offset = "0x1627AA8", VA = "0x1627AA8")]
	public void Place()
	{
	}

	[Token(Token = "0x60028FB")]
	[Address(RVA = "0x1627D50", Offset = "0x1627D50", VA = "0x1627D50")]
	public void PlaceOrbital()
	{
	}

	[Token(Token = "0x60028FC")]
	[Address(RVA = "0x1628298", Offset = "0x1628298", VA = "0x1628298")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x60028FD")]
	[Address(RVA = "0x1627F20", Offset = "0x1627F20", VA = "0x1627F20")]
	private Vector3 GetBottom()
	{
		return default;
	}

	[Token(Token = "0x60028FE")]
	[Address(RVA = "0x162850C", Offset = "0x162850C", VA = "0x162850C")]
	public PropPlacer()
	{
	}
}
