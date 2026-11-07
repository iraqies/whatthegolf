using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20002B7")]
public class ObjectsContainer : MonoBehaviour
{
	[Token(Token = "0x20002B8")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EBDC", Offset = "0x3EBDC")]
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		[Token(Token = "0x4000EB9")]
		[FieldOffset(Offset = "0x10")]
		public Collider2D x;

		[Token(Token = "0x6000C81")]
		[Address(RVA = "0x180A45C", Offset = "0x180A45C", VA = "0x180A45C")]
		public _003C_003Ec__DisplayClass23_0()
		{
		}

		[Token(Token = "0x6000C82")]
		[Address(RVA = "0x180A464", Offset = "0x180A464", VA = "0x180A464")]
		internal bool _003CDisableObjectsCheck_003Eb__2(GameObject o)
		{
			return default;
		}
	}

	[Serializable]
	[Token(Token = "0x20002B9")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x3EBEC", Offset = "0x3EBEC")]
	private sealed class _003C_003Ec
	{
		[Token(Token = "0x4000EBA")]
		[FieldOffset(Offset = "0x0")]
		public static readonly _003C_003Ec _003C_003E9;

		[Token(Token = "0x4000EBB")]
		[FieldOffset(Offset = "0x8")]
		public static Predicate<Collider2D> _003C_003E9__23_0;

		[Token(Token = "0x6000C84")]
		[Address(RVA = "0x180A3E4", Offset = "0x180A3E4", VA = "0x180A3E4")]
		public _003C_003Ec()
		{
		}

		[Token(Token = "0x6000C85")]
		[Address(RVA = "0x180A3EC", Offset = "0x180A3EC", VA = "0x180A3EC")]
		internal bool _003CDisableObjectsCheck_003Eb__23_0(Collider2D c)
		{
			return default;
		}
	}

	[Token(Token = "0x4000EAC")]
	[FieldOffset(Offset = "0x18")]
	public List<GameObject> ObjectsToIgnore;

	[Token(Token = "0x4000EAD")]
	[FieldOffset(Offset = "0x0")]
	private static GameObject _ball;

	[Token(Token = "0x4000EAE")]
	[FieldOffset(Offset = "0x8")]
	private static GameObject _islandBall;

	[Token(Token = "0x4000EAF")]
	[FieldOffset(Offset = "0x20")]
	private List<Collider2D> CollidersToCheck;

	[Token(Token = "0x4000EB0")]
	[FieldOffset(Offset = "0x28")]
	private List<Collider2D> DisabledColliders;

	[Token(Token = "0x4000EB1")]
	[FieldOffset(Offset = "0x30")]
	private List<Collider2D> ToRemove;

	[Token(Token = "0x4000EB2")]
	[FieldOffset(Offset = "0x38")]
	private bool[] disabledByCheck;

	[Token(Token = "0x4000EB3")]
	[FieldOffset(Offset = "0x40")]
	private List<Rigidbody2D> RigidbodyToCheck;

	[Token(Token = "0x4000EB4")]
	[FieldOffset(Offset = "0x48")]
	private int checkInterval;

	[Token(Token = "0x4000EB5")]
	[FieldOffset(Offset = "0x4C")]
	private int currentCheck;

	[Token(Token = "0x4000EB6")]
	[FieldOffset(Offset = "0x50")]
	private float currDistance;

	[Token(Token = "0x4000EB7")]
	[FieldOffset(Offset = "0x54")]
	private Vector3 ballPos;

	[Token(Token = "0x4000EB8")]
	[FieldOffset(Offset = "0x10")]
	private static ObjectsContainer _instance;

	[Token(Token = "0x17000182")]
	public static ObjectsContainer Instance
	{
		[Token(Token = "0x6000C6C")]
		[Address(RVA = "0x1592C28", Offset = "0x1592C28", VA = "0x1592C28")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000C6D")]
		[Address(RVA = "0x1592C8C", Offset = "0x1592C8C", VA = "0x1592C8C")]
		private set
		{
		}
	}

	[Token(Token = "0x6000C6E")]
	[Address(RVA = "0x1592CFC", Offset = "0x1592CFC", VA = "0x1592CFC")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000C6F")]
	[Address(RVA = "0x1592D00", Offset = "0x1592D00", VA = "0x1592D00")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000C70")]
	[Address(RVA = "0x1592D04", Offset = "0x1592D04", VA = "0x1592D04")]
	private void Start()
	{
	}

	[Token(Token = "0x6000C71")]
	[Address(RVA = "0x1592D08", Offset = "0x1592D08", VA = "0x1592D08")]
	private void FillCollidersList()
	{
	}

	[Token(Token = "0x6000C72")]
	[Address(RVA = "0x159377C", Offset = "0x159377C", VA = "0x159377C")]
	private bool CheckForNames(string name, string[] names)
	{
		return default;
	}

	[Token(Token = "0x6000C73")]
	[Address(RVA = "0x1593824", Offset = "0x1593824", VA = "0x1593824")]
	private bool CaseInsensitiveContains(string text, string value, StringComparison stringComparison = StringComparison.CurrentCultureIgnoreCase)
	{
		return default;
	}

	[Token(Token = "0x6000C74")]
	[Address(RVA = "0x1593858", Offset = "0x1593858", VA = "0x1593858")]
	private void Update()
	{
	}

	[Token(Token = "0x6000C75")]
	[Address(RVA = "0x159385C", Offset = "0x159385C", VA = "0x159385C")]
	public void DisableObjectsCheck(bool state)
	{
	}

	[Token(Token = "0x6000C76")]
	[Address(RVA = "0x1593BF4", Offset = "0x1593BF4", VA = "0x1593BF4")]
	public void RemoveFromComputing(Collider2D collider)
	{
	}

	[Token(Token = "0x6000C77")]
	[Address(RVA = "0x1593C58", Offset = "0x1593C58", VA = "0x1593C58")]
	public static void SetBall(GameObject ballRef)
	{
	}

	[Token(Token = "0x6000C78")]
	[Address(RVA = "0x1593CC8", Offset = "0x1593CC8", VA = "0x1593CC8")]
	public static void SetIslandBall(GameObject ballRef)
	{
	}

	[Token(Token = "0x6000C79")]
	[Address(RVA = "0x1593D38", Offset = "0x1593D38", VA = "0x1593D38")]
	public static GameObject GetIslandBall()
	{
		return null;
	}

	[Token(Token = "0x6000C7A")]
	[Address(RVA = "0x1593D9C", Offset = "0x1593D9C", VA = "0x1593D9C")]
	private void InvokeCheck()
	{
	}

	[Token(Token = "0x6000C7B")]
	[Address(RVA = "0x1593F10", Offset = "0x1593F10", VA = "0x1593F10")]
	private void CheckCollider(List<Collider2D> toCheck, Vector3 PositionToCheck)
	{
	}

	[Token(Token = "0x6000C7C")]
	[Address(RVA = "0x1594310", Offset = "0x1594310", VA = "0x1594310")]
	private void RemoveFromCheck()
	{
	}

	[Token(Token = "0x6000C7D")]
	[Address(RVA = "0x15943D0", Offset = "0x15943D0", VA = "0x15943D0")]
	private void CheckBodies(Vector3 PositionToCheck)
	{
	}

	[Token(Token = "0x6000C7E")]
	[Address(RVA = "0x15945A8", Offset = "0x15945A8", VA = "0x15945A8")]
	public ObjectsContainer()
	{
	}

	[Token(Token = "0x6000C80")]
	[Address(RVA = "0x15946BC", Offset = "0x15946BC", VA = "0x15946BC")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x6054C", Offset = "0x6054C")]
	private bool _003CDisableObjectsCheck_003Eb__23_1(Collider2D x)
	{
		return default;
	}
}
