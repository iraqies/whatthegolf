using System.Collections.Generic;
using Core;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000C28")]
public class RollerPatrollingMovement : MonoBehaviour
{
	[Token(Token = "0x4004309")]
	[FieldOffset(Offset = "0x18")]
	public Transform WaypointContainer;

	[Token(Token = "0x400430A")]
	[FieldOffset(Offset = "0x20")]
	private List<Transform> m_wayPoints;

	[Token(Token = "0x400430B")]
	[FieldOffset(Offset = "0x28")]
	private RollingCowShooter m_roller;

	[Token(Token = "0x400430C")]
	[FieldOffset(Offset = "0x30")]
	private int wp_index;

	[Token(Token = "0x6003A20")]
	[Address(RVA = "0x165C170", Offset = "0x165C170", VA = "0x165C170")]
	private void Start()
	{
	}

	[Token(Token = "0x6003A21")]
	[Address(RVA = "0x165C51C", Offset = "0x165C51C", VA = "0x165C51C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6003A22")]
	[Address(RVA = "0x165C6E4", Offset = "0x165C6E4", VA = "0x165C6E4")]
	public RollerPatrollingMovement()
	{
	}
}
