using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Buoyancy
{
	[Token(Token = "0x20011E9")]
	public class BuoyancyTrigger : MonoBehaviour, IBuoyantWater
	{
		[Token(Token = "0x4006051")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float forceMultiplier;

		[Token(Token = "0x4006052")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private float viscosity;

		[Token(Token = "0x4006053")]
		[FieldOffset(Offset = "0x20")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57AAC", Offset = "0x57AAC")]
		private List<IBuoyant> buoyantsInTrigger__BackingField;

		[Token(Token = "0x4006054")]
		[FieldOffset(Offset = "0x28")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57ABC", Offset = "0x57ABC")]
		private float SurfacePositionY__BackingField;

		[Token(Token = "0x4006055")]
		[FieldOffset(Offset = "0x2C")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57ACC", Offset = "0x57ACC")]
		private float AccumulatedMass__BackingField;

		[Token(Token = "0x4006056")]
		[FieldOffset(Offset = "0x30")]
		private Transform _transform;

		[Token(Token = "0x4006057")]
		[FieldOffset(Offset = "0x38")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57ADC", Offset = "0x57ADC")]
		private Action<IBuoyant> m_OnEnterWater;

		[Token(Token = "0x4006058")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x57AEC", Offset = "0x57AEC")]
		private Action<IBuoyant> m_OnExitWater;

		[Token(Token = "0x4006059")]
		[FieldOffset(Offset = "0x48")]
		private List<IBuoyant> remove;

		[Token(Token = "0x170008F1")]
		public List<IBuoyant> buoyantsInTrigger
		{
			[Token(Token = "0x600521C")]
			[Address(RVA = "0x17D35A4", Offset = "0x17D35A4", VA = "0x17D35A4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70838", Offset = "0x70838")]
			get
			{
				return null;
			}
			[Token(Token = "0x600521D")]
			[Address(RVA = "0x17D35AC", Offset = "0x17D35AC", VA = "0x17D35AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70848", Offset = "0x70848")]
			private set
			{
			}
		}

		[Token(Token = "0x170008F2")]
		public float SurfacePositionY
		{
			[Token(Token = "0x600521E")]
			[Address(RVA = "0x17D35B4", Offset = "0x17D35B4", VA = "0x17D35B4", Slot = "6")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70858", Offset = "0x70858")]
			get
			{
				return default;
			}
			[Token(Token = "0x600521F")]
			[Address(RVA = "0x17D35BC", Offset = "0x17D35BC", VA = "0x17D35BC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70868", Offset = "0x70868")]
			set
			{
			}
		}

		[Token(Token = "0x170008F3")]
		public float Viscosity
		{
			[Token(Token = "0x6005220")]
			[Address(RVA = "0x17D35C4", Offset = "0x17D35C4", VA = "0x17D35C4", Slot = "4")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170008F4")]
		public float WaterForceUp
		{
			[Token(Token = "0x6005221")]
			[Address(RVA = "0x17D35CC", Offset = "0x17D35CC", VA = "0x17D35CC", Slot = "5")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170008F5")]
		public float AccumulatedMass
		{
			[Token(Token = "0x6005222")]
			[Address(RVA = "0x17D35F8", Offset = "0x17D35F8", VA = "0x17D35F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70878", Offset = "0x70878")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005223")]
			[Address(RVA = "0x17D3600", Offset = "0x17D3600", VA = "0x17D3600")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70888", Offset = "0x70888")]
			private set
			{
			}
		}

		[Token(Token = "0x1400008D")]
		public event Action<IBuoyant> OnEnterWater
		{
			[Token(Token = "0x6005224")]
			[Address(RVA = "0x17D3608", Offset = "0x17D3608", VA = "0x17D3608")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70898", Offset = "0x70898")]
			add
			{
			}
			[Token(Token = "0x6005225")]
			[Address(RVA = "0x17D36AC", Offset = "0x17D36AC", VA = "0x17D36AC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708A8", Offset = "0x708A8")]
			remove
			{
			}
		}

		[Token(Token = "0x1400008E")]
		public event Action<IBuoyant> OnExitWater
		{
			[Token(Token = "0x6005226")]
			[Address(RVA = "0x17D3750", Offset = "0x17D3750", VA = "0x17D3750")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708B8", Offset = "0x708B8")]
			add
			{
			}
			[Token(Token = "0x6005227")]
			[Address(RVA = "0x17D37F4", Offset = "0x17D37F4", VA = "0x17D37F4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x708C8", Offset = "0x708C8")]
			remove
			{
			}
		}

		[Token(Token = "0x6005228")]
		[Address(RVA = "0x17D3898", Offset = "0x17D3898", VA = "0x17D3898")]
		private void Awake()
		{
		}

		[Token(Token = "0x6005229")]
		[Address(RVA = "0x17D3994", Offset = "0x17D3994", VA = "0x17D3994")]
		private void FixedUpdate()
		{
		}

		[Token(Token = "0x600522A")]
		[Address(RVA = "0x17D3C44", Offset = "0x17D3C44", VA = "0x17D3C44")]
		private void LateUpdate()
		{
		}

		[Token(Token = "0x600522B")]
		[Address(RVA = "0x17D3DC4", Offset = "0x17D3DC4", VA = "0x17D3DC4")]
		private void OnTriggerEnter(Collider other)
		{
		}

		[Token(Token = "0x600522C")]
		[Address(RVA = "0x17D4000", Offset = "0x17D4000", VA = "0x17D4000")]
		private void OnTriggerExit(Collider other)
		{
		}

		[Token(Token = "0x600522D")]
		[Address(RVA = "0x17D423C", Offset = "0x17D423C", VA = "0x17D423C")]
		public BuoyancyTrigger()
		{
		}
	}
}
