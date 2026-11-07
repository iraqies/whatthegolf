using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MPuppet
{
	[Token(Token = "0x20011D8")]
	public class ConfigJoint : MonoBehaviour
	{
		[Token(Token = "0x4005F9C")]
		[FieldOffset(Offset = "0x18")]
		public Collider _collider;

		[Token(Token = "0x4005F9D")]
		[FieldOffset(Offset = "0x20")]
		public Rigidbody _rigidbody;

		[Token(Token = "0x4005F9E")]
		[FieldOffset(Offset = "0x28")]
		public ConfigurableJoint _joint;

		[Token(Token = "0x4005F9F")]
		[FieldOffset(Offset = "0x30")]
		public Quaternion idleTargetRotation;

		[Token(Token = "0x4005FA0")]
		[FieldOffset(Offset = "0x40")]
		public Quaternion startingWorldRotation;

		[Token(Token = "0x4005FA1")]
		[FieldOffset(Offset = "0x50")]
		public Quaternion startingLocalRotation;

		[Token(Token = "0x4005FA2")]
		[FieldOffset(Offset = "0x60")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x574FC", Offset = "0x574FC")]
		private Action<ConfigJoint, Collision> m_OnJointCollision;

		[Token(Token = "0x4005FA3")]
		[FieldOffset(Offset = "0x68")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5750C", Offset = "0x5750C")]
		private Action<ConfigJoint, Collider> m_OnJoinTrigger;

		[Token(Token = "0x4005FA4")]
		[FieldOffset(Offset = "0x70")]
		[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x5751C", Offset = "0x5751C")]
		private MPuppetController Puppet__BackingField;

		[Token(Token = "0x170008BD")]
		public MPuppetController Puppet
		{
			[Token(Token = "0x6005157")]
			[Address(RVA = "0x18AC1F8", Offset = "0x18AC1F8", VA = "0x18AC1F8")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702C8", Offset = "0x702C8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6005158")]
			[Address(RVA = "0x18AC200", Offset = "0x18AC200", VA = "0x18AC200")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702D8", Offset = "0x702D8")]
			set
			{
			}
		}

		[Token(Token = "0x14000087")]
		public event Action<ConfigJoint, Collision> OnJointCollision
		{
			[Token(Token = "0x6005153")]
			[Address(RVA = "0x18ABF68", Offset = "0x18ABF68", VA = "0x18ABF68")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70288", Offset = "0x70288")]
			add
			{
			}
			[Token(Token = "0x6005154")]
			[Address(RVA = "0x18AC00C", Offset = "0x18AC00C", VA = "0x18AC00C")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x70298", Offset = "0x70298")]
			remove
			{
			}
		}

		[Token(Token = "0x14000088")]
		public event Action<ConfigJoint, Collider> OnJoinTrigger
		{
			[Token(Token = "0x6005155")]
			[Address(RVA = "0x18AC0B0", Offset = "0x18AC0B0", VA = "0x18AC0B0")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702A8", Offset = "0x702A8")]
			add
			{
			}
			[Token(Token = "0x6005156")]
			[Address(RVA = "0x18AC154", Offset = "0x18AC154", VA = "0x18AC154")]
			[AttributeAttribute(Name = "CompilerGeneratedAttribute", RVA = "0x702B8", Offset = "0x702B8")]
			remove
			{
			}
		}

		[Token(Token = "0x6005159")]
		[Address(RVA = "0x18AC208", Offset = "0x18AC208", VA = "0x18AC208")]
		public static ConfigJoint GetOrAdd(GameObject go)
		{
			return null;
		}

		[Token(Token = "0x600515A")]
		[Address(RVA = "0x18AC388", Offset = "0x18AC388", VA = "0x18AC388")]
		public ConfigJoint(GameObject go)
		{
		}

		[Token(Token = "0x600515B")]
		[Address(RVA = "0x18AC490", Offset = "0x18AC490", VA = "0x18AC490")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		[Token(Token = "0x600515C")]
		[Address(RVA = "0x18AC504", Offset = "0x18AC504", VA = "0x18AC504")]
		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
