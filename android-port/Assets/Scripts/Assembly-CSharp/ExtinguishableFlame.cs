using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

[Token(Token = "0x2000BE6")]
public class ExtinguishableFlame : MonoBehaviour
{
	[Token(Token = "0x2000BE7")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x43E78", Offset = "0x43E78")]
	private sealed class _003C_003Ec__DisplayClass13_0
	{
		[Token(Token = "0x40041F6")]
		[FieldOffset(Offset = "0x10")]
		public ExtinguishableFlame _003C_003E4__this;

		[Token(Token = "0x40041F7")]
		[FieldOffset(Offset = "0x18")]
		public Vector3 scaleFrom;

		[Token(Token = "0x40041F8")]
		[FieldOffset(Offset = "0x24")]
		public Vector3 scaleTo;

		[Token(Token = "0x6003912")]
		[Address(RVA = "0x17A1B48", Offset = "0x17A1B48", VA = "0x17A1B48")]
		public _003C_003Ec__DisplayClass13_0()
		{
		}

		[Token(Token = "0x6003913")]
		[Address(RVA = "0x17A1B50", Offset = "0x17A1B50", VA = "0x17A1B50")]
		internal void _003CTakeDamage_003Eb__0(float v)
		{
		}

		[Token(Token = "0x6003914")]
		[Address(RVA = "0x17A1C00", Offset = "0x17A1C00", VA = "0x17A1C00")]
		internal void _003CTakeDamage_003Eb__1()
		{
		}

		[Token(Token = "0x6003915")]
		[Address(RVA = "0x17A1C28", Offset = "0x17A1C28", VA = "0x17A1C28")]
		internal void _003CTakeDamage_003Eb__2(float v)
		{
		}
	}

	[Token(Token = "0x40041ED")]
	[FieldOffset(Offset = "0x18")]
	public Transform flameTransform;

	[Token(Token = "0x40041EE")]
	[FieldOffset(Offset = "0x20")]
	public float loseHealthCooldown;

	[Token(Token = "0x40041EF")]
	[FieldOffset(Offset = "0x24")]
	public float flameScaleTime;

	[Token(Token = "0x40041F0")]
	[FieldOffset(Offset = "0x28")]
	public int startingHealth;

	[Token(Token = "0x40041F1")]
	[FieldOffset(Offset = "0x2C")]
	public Vector3 endScale;

	[Token(Token = "0x40041F2")]
	[FieldOffset(Offset = "0x38")]
	public UnityEvent OnFlameExtinguished;

	[Token(Token = "0x40041F3")]
	[FieldOffset(Offset = "0x40")]
	[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x50DF8", Offset = "0x50DF8")]
	private int CurrentHealth__BackingField;

	[Token(Token = "0x40041F4")]
	[FieldOffset(Offset = "0x44")]
	private float m_lastHealthTime;

	[Token(Token = "0x40041F5")]
	[FieldOffset(Offset = "0x48")]
	private Vector3 m_StartScale;

	[Token(Token = "0x170005F4")]
	public int CurrentHealth
	{
		[Token(Token = "0x600390C")]
		[Address(RVA = "0x1454BB8", Offset = "0x1454BB8", VA = "0x1454BB8")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B1E8", Offset = "0x6B1E8")]
		get
		{
			return default;
		}
		[Token(Token = "0x600390D")]
		[Address(RVA = "0x1454BC0", Offset = "0x1454BC0", VA = "0x1454BC0")]
		[Attribute(Name = "CompilerGeneratedAttribute", RVA = "0x6B1F8", Offset = "0x6B1F8")]
		private set
		{
		}
	}

	[Token(Token = "0x600390E")]
	[Address(RVA = "0x1454BC8", Offset = "0x1454BC8", VA = "0x1454BC8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600390F")]
	[Address(RVA = "0x1454C14", Offset = "0x1454C14", VA = "0x1454C14")]
	public void TakeDamage(int damage)
	{
	}

	[Token(Token = "0x6003910")]
	[Address(RVA = "0x1454E98", Offset = "0x1454E98", VA = "0x1454E98")]
	private void Update()
	{
	}

	[Token(Token = "0x6003911")]
	[Address(RVA = "0x1454ED8", Offset = "0x1454ED8", VA = "0x1454ED8")]
	public ExtinguishableFlame()
	{
	}
}
