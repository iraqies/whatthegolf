using System;
using UnityEngine;

namespace WhatTheGolf.LevelDesigner.Selectables
{
	public abstract class Selectable : MonoBehaviour
	{
		[SerializeField]
		private Rigidbody m_RigidBody;

		[SerializeField]
		private Renderer[] m_Renderers;

		[SerializeField]
		private SelectableUnityEvents m_UnityEvents;

		private Guid m_Guid;

		public Coroutine liftDropCoroutine;

		public Coroutine scaleCoroutine;

		public Rigidbody rBody => null;

		public Guid guid => default;

		public Renderer[] renderers => null;

		public virtual Transform rootObject => null;

		public SelectableUnityEvents UnityEvents => null;

		public abstract SelectableDefinition baseDefinition { get; }

		public float currentYOffset { get; set; }

		public void Init(Guid guid)
		{
		}
	}
	public abstract class Selectable<T> : Selectable where T : SelectableDefinition
	{
		[SerializeField]
		private T m_Definition;

		public override SelectableDefinition baseDefinition => null;

		public T definition
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Selectable()
		{
		}
	}
}
