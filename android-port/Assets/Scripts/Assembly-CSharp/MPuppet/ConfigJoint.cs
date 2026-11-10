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
				m_OnJointCollision = (Action<ConfigJoint, Collision>)Delegate.Combine(m_OnJointCollision, value);
			}
			[CompilerGenerated]
			remove
			{
				m_OnJointCollision = (Action<ConfigJoint, Collision>)Delegate.Remove(m_OnJointCollision, value);
			}
		}

		public event Action<ConfigJoint, Collider> OnJoinTrigger
		{
			[CompilerGenerated]
			add
			{
				m_OnJoinTrigger = (Action<ConfigJoint, Collider>)Delegate.Combine(m_OnJoinTrigger, value);
			}
			[CompilerGenerated]
			remove
			{
				m_OnJoinTrigger = (Action<ConfigJoint, Collider>)Delegate.Remove(m_OnJoinTrigger, value);
			}
		}

		public static ConfigJoint GetOrAdd(GameObject go)
		{
			if (go == null)
			{
				return null;
			}
			ConfigJoint cj = go.GetComponent<ConfigJoint>();
			if (cj == null)
			{
				cj = go.AddComponent<ConfigJoint>();
			}
			cj._collider = go.GetComponent<Collider>();
			cj._rigidbody = go.GetComponent<Rigidbody>();
			cj._joint = go.GetComponent<ConfigurableJoint>();
			cj.startingWorldRotation = go.transform.rotation;
			cj.startingLocalRotation = go.transform.localRotation;
			if (cj._joint != null)
			{
				cj.idleTargetRotation = cj._joint.targetRotation;
			}
			return cj;
		}

		public ConfigJoint(GameObject go)
		{
		}

		private void OnCollisionEnter(Collision collision)
		{
			m_OnJointCollision?.Invoke(this, collision);
		}

		private void OnTriggerEnter(Collider other)
		{
			m_OnJoinTrigger?.Invoke(this, other);
		}
	}
}
