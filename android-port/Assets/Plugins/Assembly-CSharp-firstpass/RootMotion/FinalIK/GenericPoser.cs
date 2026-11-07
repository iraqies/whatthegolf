using System;
using Il2CppDummyDll;
using UnityEngine;

namespace RootMotion.FinalIK
{
	[Token(Token = "0x20001A3")]
	public class GenericPoser : Poser
	{
		[Serializable]
		[Token(Token = "0x20001A4")]
		public class Map
		{
			[Token(Token = "0x4000B4C")]
			[FieldOffset(Offset = "0x10")]
			public Transform bone;

			[Token(Token = "0x4000B4D")]
			[FieldOffset(Offset = "0x18")]
			public Transform target;

			[Token(Token = "0x4000B4E")]
			[FieldOffset(Offset = "0x20")]
			private Vector3 defaultLocalPosition;

			[Token(Token = "0x4000B4F")]
			[FieldOffset(Offset = "0x2C")]
			private Quaternion defaultLocalRotation;

			[Token(Token = "0x6000C64")]
			[Address(RVA = "0x133AA54", Offset = "0x133AA54", VA = "0x133AA54")]
			public Map(Transform bone, Transform target)
			{
			}

			[Token(Token = "0x6000C65")]
			[Address(RVA = "0x133AAC0", Offset = "0x133AAC0", VA = "0x133AAC0")]
			public void StoreDefaultState()
			{
			}

			[Token(Token = "0x6000C66")]
			[Address(RVA = "0x133AB10", Offset = "0x133AB10", VA = "0x133AB10")]
			public void FixTransform()
			{
			}

			[Token(Token = "0x6000C67")]
			[Address(RVA = "0x133AB5C", Offset = "0x133AB5C", VA = "0x133AB5C")]
			public void Update(float localRotationWeight, float localPositionWeight)
			{
			}
		}

		[Token(Token = "0x4000B4B")]
		[FieldOffset(Offset = "0x50")]
		public Map[] maps;

		[Token(Token = "0x6000C5D")]
		[Address(RVA = "0x137527C", Offset = "0x137527C", VA = "0x137527C", Slot = "7")]
		[AttributeAttribute(Name = "ContextMenu", RVA = "0x3A944", Offset = "0x3A944")]
		public override void AutoMapping()
		{
		}

		[Token(Token = "0x6000C5E")]
		[Address(RVA = "0x1375618", Offset = "0x1375618", VA = "0x1375618", Slot = "8")]
		protected override void InitiatePoser()
		{
		}

		[Token(Token = "0x6000C5F")]
		[Address(RVA = "0x1375684", Offset = "0x1375684", VA = "0x1375684", Slot = "9")]
		protected override void UpdatePoser()
		{
		}

		[Token(Token = "0x6000C60")]
		[Address(RVA = "0x1375794", Offset = "0x1375794", VA = "0x1375794", Slot = "10")]
		protected override void FixPoserTransforms()
		{
		}

		[Token(Token = "0x6000C61")]
		[Address(RVA = "0x13755AC", Offset = "0x13755AC", VA = "0x13755AC")]
		private void StoreDefaultState()
		{
		}

		[Token(Token = "0x6000C62")]
		[Address(RVA = "0x1375510", Offset = "0x1375510", VA = "0x1375510")]
		private Transform GetTargetNamed(string tName, Transform[] array)
		{
			return null;
		}

		[Token(Token = "0x6000C63")]
		[Address(RVA = "0x1375800", Offset = "0x1375800", VA = "0x1375800")]
		public GenericPoser()
		{
		}
	}
}
