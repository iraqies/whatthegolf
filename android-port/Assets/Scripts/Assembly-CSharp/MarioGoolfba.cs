using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007DE")]
public class MarioGoolfba : MonoBehaviour
{
	[Serializable]
	[Token(Token = "0x20007DF")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x416C0", Offset = "0x416C0")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x40029DE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x40029DF")]
		[FieldOffset(Offset = "0x8")]
		public static Action<AudioSource> _003C_003E9__20_0;

		[Token(Token = "0x6002421")]
		[Address(RVA = "0x17F35A0", Offset = "0x17F35A0", VA = "0x17F35A0")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6002422")]
		[Address(RVA = "0x17F35A8", Offset = "0x17F35A8", VA = "0x17F35A8")]
		internal void _003CKill_003Eb__20_0(AudioSource s)
		{
		}
	}

	[Token(Token = "0x40029CD")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float activateDistance;

	[Token(Token = "0x40029CE")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private float rotateDistance;

	[Token(Token = "0x40029CF")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private float speed;

	[Token(Token = "0x40029D0")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float deathForce;

	[Token(Token = "0x40029D1")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Transform lookTransform;

	[Token(Token = "0x40029D2")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private float rotateSpeed;

	[Token(Token = "0x40029D3")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	private LayerMask RotateLayers;

	[Token(Token = "0x40029D4")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private AudioClip deathClip;

	[Token(Token = "0x40029D5")]
	[FieldOffset(Offset = "0x40")]
	private Rigidbody rigidbody;

	[Token(Token = "0x40029D6")]
	[FieldOffset(Offset = "0x48")]
	private Transform playerTransform;

	[Token(Token = "0x40029D7")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 startPos;

	[Token(Token = "0x40029D8")]
	[FieldOffset(Offset = "0x5C")]
	private Quaternion startRot;

	[Token(Token = "0x40029D9")]
	[FieldOffset(Offset = "0x70")]
	private Collider[] playerColliders;

	[Token(Token = "0x40029DA")]
	[FieldOffset(Offset = "0x78")]
	private Collider ownCollider;

	[Token(Token = "0x40029DB")]
	[FieldOffset(Offset = "0x80")]
	private Vector3 currentDirection;

	[Token(Token = "0x40029DC")]
	[FieldOffset(Offset = "0x90")]
	private MarioLevelController controller;

	[Token(Token = "0x40029DD")]
	[FieldOffset(Offset = "0x98")]
	private bool dead;

	[Token(Token = "0x600241A")]
	[Address(RVA = "0x155BE24", Offset = "0x155BE24", VA = "0x155BE24")]
	private void Start()
	{
	}

	[Token(Token = "0x600241B")]
	[Address(RVA = "0x155C040", Offset = "0x155C040", VA = "0x155C040")]
	private void OnLevelReset()
	{
	}

	[Token(Token = "0x600241C")]
	[Address(RVA = "0x155C14C", Offset = "0x155C14C", VA = "0x155C14C")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600241D")]
	[Address(RVA = "0x155C37C", Offset = "0x155C37C", VA = "0x155C37C")]
	public void Kill()
	{
	}

	[Token(Token = "0x600241E")]
	[Address(RVA = "0x155C5B0", Offset = "0x155C5B0", VA = "0x155C5B0")]
	public bool IsDead()
	{
		return default;
	}

	[Token(Token = "0x600241F")]
	[Address(RVA = "0x155C5B8", Offset = "0x155C5B8", VA = "0x155C5B8")]
	public MarioGoolfba()
	{
	}
}
