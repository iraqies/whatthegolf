using System;
using UnityEngine;

namespace Kilt.EasyRopes2D
{
	[Serializable]
	public class BallonObjectToCloneByMass
	{
		[SerializeField]
		private GameObject m_objectContainer;

		[SerializeField]
		private float m_massToAcceptClone;

		public GameObject ObjectContainer => null;

		public float MassToAcceptClone => 0f;
	}
}
