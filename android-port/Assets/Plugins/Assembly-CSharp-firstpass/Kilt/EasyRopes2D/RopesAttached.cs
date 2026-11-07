using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kilt.EasyRopes2D
{
	public class RopesAttached : MonoBehaviour
	{
		public Action<Rope2D> OnRopePlugged;

		public Action<Rope2D> OnRopeUnplugged;

		public Action<Rope2D> OnIndirectRopeDestroyed;

		public Action<Rope2D> OnIndirectRopeCreated;

		public Action<Rope2D> OnIndirectRopeBreak;

		public Action<Rope2D, int> OnRopeBreak;

		private List<Rope2D> m_pluggedRopes;

		private List<Rope2D> m_indirectRopes;

		private bool _needRecalcIndirectRopes;

		public List<Rope2D> PluggedRopes
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public List<Rope2D> IndirectRopes
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		protected virtual void LateUpdate()
		{
		}

		protected virtual void HandleOnRopeDestroy(Rope2D p_rope)
		{
		}

		protected virtual void HandleOnRopeBreak(Rope2D p_rope, int p_brokenIndex)
		{
		}

		public List<GameObject> GetAllOtherAttachedObjectsInPluggedRopes()
		{
			return null;
		}

		public List<Rope2D> GetAllIndirectRopes(bool p_includePluggedRopes = true)
		{
			return null;
		}

		public List<GameObject> GetAllIndirectObjects(bool p_includeOtherPluggedObjects = true)
		{
			return null;
		}

		public float GetSelfMass(bool p_includeChildrens = true, bool p_multiplyByGravityScale = true)
		{
			return 0f;
		}

		public virtual float GetSumOfOtherObjectsMass(bool p_includeChildrens = true, bool p_multiplyByGravityScale = true)
		{
			return 0f;
		}

		public float GetPluggedRopesMass(bool p_multiplyByGravityScale = true)
		{
			return 0f;
		}

		public float GetIndirectRopesMass(bool p_includePluggedRopes = true, bool p_multiplyByGravityScale = true)
		{
			return 0f;
		}

		public float GetSumOfIndirectObjectsMass(bool p_includeOtherPluggedObjects = true, bool p_includeChildrens = true, bool p_multiplyByGravityScale = true)
		{
			return 0f;
		}

		protected void IndirectRopeBroke(Rope2D p_destroyedRope)
		{
		}

		protected void IndirectRopeDestroyed(Rope2D p_destroyedRope)
		{
		}

		protected void IndirectRopeCreated(Rope2D p_rope)
		{
		}

		public virtual void AddPluggedRopeInList(Rope2D p_rope)
		{
		}

		public virtual void RemovePluggedRopeFromList(Rope2D p_rope)
		{
		}
	}
}
