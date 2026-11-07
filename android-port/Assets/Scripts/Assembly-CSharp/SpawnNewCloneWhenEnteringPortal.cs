using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000807")]
public class SpawnNewCloneWhenEnteringPortal : MonoBehaviour
{
	[Token(Token = "0x4002B28")]
	[FieldOffset(Offset = "0x18")]
	public GameObject CloneToSpawn;

	[Token(Token = "0x4002B29")]
	[FieldOffset(Offset = "0x20")]
	public Transform Room;

	[Token(Token = "0x4002B2A")]
	[FieldOffset(Offset = "0x28")]
	public Transform RoomToCopy;

	[Token(Token = "0x4002B2B")]
	[FieldOffset(Offset = "0x30")]
	public SpawnNewCloneWhenEnteringPortal FollowRoom;

	[Token(Token = "0x4002B2C")]
	[FieldOffset(Offset = "0x38")]
	public DestroyCloneWhenEnteringPortal DestroyRoom;

	[Token(Token = "0x4002B2D")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Player;

	[Token(Token = "0x4002B2E")]
	[FieldOffset(Offset = "0x48")]
	private GameObject clone;

	[Token(Token = "0x4002B2F")]
	[FieldOffset(Offset = "0x50")]
	private GameObject followObject;

	[Token(Token = "0x60024E6")]
	[Address(RVA = "0x16C7EE4", Offset = "0x16C7EE4", VA = "0x16C7EE4")]
	public void SpawnClone(GameObject entering)
	{
	}

	[Token(Token = "0x60024E7")]
	[Address(RVA = "0x16C8050", Offset = "0x16C8050", VA = "0x16C8050")]
	public void DeleteClone(GameObject newFollow)
	{
	}

	[Token(Token = "0x60024E8")]
	[Address(RVA = "0x16C8188", Offset = "0x16C8188", VA = "0x16C8188")]
	public void SetFollowTarget(GameObject newFollow)
	{
	}

	[Token(Token = "0x60024E9")]
	[Address(RVA = "0x16C8190", Offset = "0x16C8190", VA = "0x16C8190")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x60024EA")]
	[Address(RVA = "0x16C82F0", Offset = "0x16C82F0", VA = "0x16C82F0")]
	public SpawnNewCloneWhenEnteringPortal()
	{
	}
}
