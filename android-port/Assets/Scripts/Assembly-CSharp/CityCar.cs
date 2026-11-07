using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000281")]
public class CityCar : MonoBehaviour
{
	[Token(Token = "0x4000D2D")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private float speed;

	[Token(Token = "0x4000D2E")]
	[FieldOffset(Offset = "0x1C")]
	[SerializeField]
	private LayerMask crashWithLayer;

	[Token(Token = "0x4000D2F")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool changeLayerOnCrash;

	[Token(Token = "0x4000D30")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	private int changeToLayer;

	[Token(Token = "0x4000D31")]
	[FieldOffset(Offset = "0x28")]
	private Rigidbody _rigidbody;

	[Token(Token = "0x4000D32")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AFC4", Offset = "0x4AFC4")]
	private bool Crashed__BackingField;

	[Token(Token = "0x4000D33")]
	[FieldOffset(Offset = "0x38")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AFD4", Offset = "0x4AFD4")]
	private Action<CityCar> m_OnEnterEnd;

	[Token(Token = "0x4000D34")]
	[FieldOffset(Offset = "0x40")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AFE4", Offset = "0x4AFE4")]
	private Action<CityCar> m_OnCrash;

	[Token(Token = "0x4000D35")]
	[FieldOffset(Offset = "0x48")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4AFF4", Offset = "0x4AFF4")]
	private Collider EnterCollider__BackingField;

	[Token(Token = "0x4000D36")]
	[FieldOffset(Offset = "0x50")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4B004", Offset = "0x4B004")]
	private Collider ExitCollider__BackingField;

	[Token(Token = "0x1700015C")]
	public bool Crashed
	{
		[Token(Token = "0x6000B57")]
		[Address(RVA = "0x189E9E8", Offset = "0x189E9E8", VA = "0x189E9E8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FFDC", Offset = "0x5FFDC")]
		get
		{
			return default;
		}
		[Token(Token = "0x6000B58")]
		[Address(RVA = "0x189E9F0", Offset = "0x189E9F0", VA = "0x189E9F0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FFEC", Offset = "0x5FFEC")]
		private set
		{
		}
	}

	[Token(Token = "0x1700015D")]
	public Collider EnterCollider
	{
		[Token(Token = "0x6000B5D")]
		[Address(RVA = "0x189EC88", Offset = "0x189EC88", VA = "0x189EC88")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6003C", Offset = "0x6003C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B5E")]
		[Address(RVA = "0x189EC90", Offset = "0x189EC90", VA = "0x189EC90")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6004C", Offset = "0x6004C")]
		set
		{
		}
	}

	[Token(Token = "0x1700015E")]
	public Collider ExitCollider
	{
		[Token(Token = "0x6000B5F")]
		[Address(RVA = "0x189EC98", Offset = "0x189EC98", VA = "0x189EC98")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6005C", Offset = "0x6005C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B60")]
		[Address(RVA = "0x189ECA0", Offset = "0x189ECA0", VA = "0x189ECA0")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6006C", Offset = "0x6006C")]
		set
		{
		}
	}

	[Token(Token = "0x14000008")]
	public event Action<CityCar> OnEnterEnd
	{
		[Token(Token = "0x6000B59")]
		[Address(RVA = "0x189E9F8", Offset = "0x189E9F8", VA = "0x189E9F8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5FFFC", Offset = "0x5FFFC")]
		add
		{
		}
		[Token(Token = "0x6000B5A")]
		[Address(RVA = "0x189EA9C", Offset = "0x189EA9C", VA = "0x189EA9C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6000C", Offset = "0x6000C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000009")]
	public event Action<CityCar> OnCrash
	{
		[Token(Token = "0x6000B5B")]
		[Address(RVA = "0x189EB40", Offset = "0x189EB40", VA = "0x189EB40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6001C", Offset = "0x6001C")]
		add
		{
		}
		[Token(Token = "0x6000B5C")]
		[Address(RVA = "0x189EBE4", Offset = "0x189EBE4", VA = "0x189EBE4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6002C", Offset = "0x6002C")]
		remove
		{
		}
	}

	[Token(Token = "0x6000B61")]
	[Address(RVA = "0x189ECA8", Offset = "0x189ECA8", VA = "0x189ECA8")]
	public void Init(Collider enter, Collider exit)
	{
	}

	[Token(Token = "0x6000B62")]
	[Address(RVA = "0x189ED28", Offset = "0x189ED28", VA = "0x189ED28")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x6000B63")]
	[Address(RVA = "0x189EE00", Offset = "0x189EE00", VA = "0x189EE00")]
	private void OnTriggerEnter(Collider other)
	{
	}

	[Token(Token = "0x6000B64")]
	[Address(RVA = "0x189EEB8", Offset = "0x189EEB8", VA = "0x189EEB8")]
	private void OnCollisionEnter(Collision collision)
	{
	}

	[Token(Token = "0x6000B65")]
	[Address(RVA = "0x189F000", Offset = "0x189F000", VA = "0x189F000")]
	public CityCar()
	{
	}
}
