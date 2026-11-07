using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace MPuppet
{
	public class ConfigJoint : MonoBehaviour
	{
		public Collider _collider;

		public Rigidbody _rigidbody;

		public ConfigurableJoint _joint;

		public Quaternion idleTargetRotation;

		public Quaternion startingWorldRotation;

		public Quaternion startingLocalRotation;

		[CompilerGenerated]
		private Action<ConfigJoint, Collision> m_OnJointCollision;

		[CompilerGenerated]
		private Action<ConfigJoint, Collider> m_OnJoinTrigger;

		public MPuppetController Puppet { get; set; }

		public event Action<ConfigJoint, Collision> OnJointCollision
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<ConfigJoint, Collider> OnJoinTrigger
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public static ConfigJoint GetOrAdd(GameObject go)
		{
			return null;
		}

		public ConfigJoint(GameObject go)
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}
	}
}
