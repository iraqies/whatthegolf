using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20003D2")]
public class Metronome : MonoBehaviour
{
	[Token(Token = "0x40014F5")]
	[FieldOffset(Offset = "0x18")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4D1D0", Offset = "0x4D1D0")]
	private Action<double> m_Ticked;

	[Token(Token = "0x40014F6")]
	[FieldOffset(Offset = "0x20")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4D1E0", Offset = "0x4D1E0")]
	private Action m_onStart;

	[Token(Token = "0x40014F7")]
	[FieldOffset(Offset = "0x28")]
	[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x4D1F0", Offset = "0x4D1F0")]
	private Action m_onStop;

	[Token(Token = "0x40014F8")]
	[FieldOffset(Offset = "0x30")]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4D200", Offset = "0x4D200")]
	[SerializeField]
	private double _tempo;

	[Token(Token = "0x40014F9")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[AttributeAttribute(Name = "RangeAttribute", RVA = "0x4D244", Offset = "0x4D244")]
	private int _subdivisions;

	[Token(Token = "0x40014FA")]
	[FieldOffset(Offset = "0x40")]
	private double _tickLength;

	[Token(Token = "0x40014FB")]
	[FieldOffset(Offset = "0x48")]
	private double _nextTickTime;

	[Token(Token = "0x40014FC")]
	[FieldOffset(Offset = "0x50")]
	private bool running;

	[Token(Token = "0x17000218")]
	public bool Running
	{
		[Token(Token = "0x60011FD")]
		[Address(RVA = "0x15673C0", Offset = "0x15673C0", VA = "0x15673C0")]
		get
		{
			return default;
		}
	}

	[Token(Token = "0x14000015")]
	public event Action<double> Ticked
	{
		[Token(Token = "0x60011F7")]
		[Address(RVA = "0x1566FE8", Offset = "0x1566FE8", VA = "0x1566FE8")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61ADC", Offset = "0x61ADC")]
		add
		{
		}
		[Token(Token = "0x60011F8")]
		[Address(RVA = "0x156708C", Offset = "0x156708C", VA = "0x156708C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AEC", Offset = "0x61AEC")]
		remove
		{
		}
	}

	[Token(Token = "0x14000016")]
	public event Action onStart
	{
		[Token(Token = "0x60011F9")]
		[Address(RVA = "0x1567130", Offset = "0x1567130", VA = "0x1567130")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61AFC", Offset = "0x61AFC")]
		add
		{
		}
		[Token(Token = "0x60011FA")]
		[Address(RVA = "0x15671D4", Offset = "0x15671D4", VA = "0x15671D4")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B0C", Offset = "0x61B0C")]
		remove
		{
		}
	}

	[Token(Token = "0x14000017")]
	public event Action onStop
	{
		[Token(Token = "0x60011FB")]
		[Address(RVA = "0x1567278", Offset = "0x1567278", VA = "0x1567278")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B1C", Offset = "0x61B1C")]
		add
		{
		}
		[Token(Token = "0x60011FC")]
		[Address(RVA = "0x156731C", Offset = "0x156731C", VA = "0x156731C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x61B2C", Offset = "0x61B2C")]
		remove
		{
		}
	}

	[Token(Token = "0x60011FE")]
	[Address(RVA = "0x15673C8", Offset = "0x15673C8", VA = "0x15673C8")]
	public double GetTempo()
	{
		return default;
	}

	[Token(Token = "0x60011FF")]
	[Address(RVA = "0x15673D0", Offset = "0x15673D0", VA = "0x15673D0")]
	public void SetTempo(double tempo)
	{
	}

	[Token(Token = "0x6001200")]
	[Address(RVA = "0x1567430", Offset = "0x1567430", VA = "0x1567430")]
	public void SetSubdivisions(int sub)
	{
	}

	[Token(Token = "0x6001201")]
	[Address(RVA = "0x156745C", Offset = "0x156745C", VA = "0x156745C")]
	private void Reset()
	{
	}

	[Token(Token = "0x6001202")]
	[Address(RVA = "0x15674B8", Offset = "0x15674B8", VA = "0x15674B8")]
	public void StartMetronome()
	{
	}

	[Token(Token = "0x6001203")]
	[Address(RVA = "0x156752C", Offset = "0x156752C", VA = "0x156752C")]
	public void StopMetronome()
	{
	}

	[Token(Token = "0x6001204")]
	[Address(RVA = "0x1567400", Offset = "0x1567400", VA = "0x1567400")]
	private void Recalculate()
	{
	}

	[Token(Token = "0x6001205")]
	[Address(RVA = "0x1567544", Offset = "0x1567544", VA = "0x1567544")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x6001206")]
	[Address(RVA = "0x1567598", Offset = "0x1567598", VA = "0x1567598")]
	private void Update()
	{
	}

	[Token(Token = "0x6001207")]
	[Address(RVA = "0x1567644", Offset = "0x1567644", VA = "0x1567644")]
	public Metronome()
	{
	}
}
