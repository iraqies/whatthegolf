using System;
using Il2CppDummyDll;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.Selectables
{
	[Token(Token = "0x2001274")]
	public abstract class Selectable : MonoBehaviour
	{
		[Token(Token = "0x400632C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Rigidbody m_RigidBody;

		[Token(Token = "0x400632D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Renderer[] m_Renderers;

		[Token(Token = "0x400632E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SelectableUnityEvents m_UnityEvents;

		[Token(Token = "0x400632F")]
		[FieldOffset(Offset = "0x30")]
		private Guid m_Guid;

		[Token(Token = "0x4006330")]
		[FieldOffset(Offset = "0x40")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x58B6C", Offset = "0x58B6C")]
		private float currentYOffset__BackingField;

		[Token(Token = "0x4006331")]
		[FieldOffset(Offset = "0x48")]
		public Coroutine liftDropCoroutine;

		[Token(Token = "0x4006332")]
		[FieldOffset(Offset = "0x50")]
		public Coroutine scaleCoroutine;

		[Token(Token = "0x170009AC")]
		public Rigidbody rBody
		{
			[Token(Token = "0x6005541")]
			[Address(RVA = "0x1685314", Offset = "0x1685314", VA = "0x1685314")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009AD")]
		public Guid guid
		{
			[Token(Token = "0x6005542")]
			[Address(RVA = "0x16853C0", Offset = "0x16853C0", VA = "0x16853C0")]
			get
			{
				return default;
			}
		}

		[Token(Token = "0x170009AE")]
		public Renderer[] renderers
		{
			[Token(Token = "0x6005543")]
			[Address(RVA = "0x16853CC", Offset = "0x16853CC", VA = "0x16853CC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009AF")]
		public virtual Transform rootObject
		{
			[Token(Token = "0x6005544")]
			[Address(RVA = "0x16853D4", Offset = "0x16853D4", VA = "0x16853D4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009B0")]
		public SelectableUnityEvents UnityEvents
		{
			[Token(Token = "0x6005545")]
			[Address(RVA = "0x16853DC", Offset = "0x16853DC", VA = "0x16853DC")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009B1")]
		public abstract SelectableDefinition baseDefinition
		{
			[Token(Token = "0x6005546")]
			get;
		}

		[Token(Token = "0x170009B2")]
		public float currentYOffset
		{
			[Token(Token = "0x6005547")]
			[Address(RVA = "0x16853E4", Offset = "0x16853E4", VA = "0x16853E4")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71670", Offset = "0x71670")]
			get
			{
				return default;
			}
			[Token(Token = "0x6005548")]
			[Address(RVA = "0x16853EC", Offset = "0x16853EC", VA = "0x16853EC")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x71680", Offset = "0x71680")]
			set
			{
			}
		}

		[Token(Token = "0x6005549")]
		[Address(RVA = "0x16853F4", Offset = "0x16853F4", VA = "0x16853F4")]
		public void Init(Guid guid)
		{
		}

		[Token(Token = "0x600554A")]
		[Address(RVA = "0x16853FC", Offset = "0x16853FC", VA = "0x16853FC")]
		protected Selectable()
		{
		}
	}
	[Token(Token = "0x2001275")]
	public abstract class Selectable<T> : Selectable where T : SelectableDefinition
	{
		[Token(Token = "0x4006333")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private T m_Definition;

		[Token(Token = "0x170009B3")]
		public override SelectableDefinition baseDefinition
		{
			[Token(Token = "0x600554C")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170009B4")]
		public T definition
		{
			[Token(Token = "0x600554D")]
			get
			{
				return null;
			}
			[Token(Token = "0x600554E")]
			set
			{
			}
		}

		[Token(Token = "0x600554B")]
		public Selectable()
		{
		}
	}
}
