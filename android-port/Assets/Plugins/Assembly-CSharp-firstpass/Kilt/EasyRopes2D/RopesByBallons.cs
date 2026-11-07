using System;
using System.Collections.Generic;
using UnityEngine;

namespace Kilt.EasyRopes2D
{
	[Serializable]
	public class RopesByBallons
	{
		[SerializeField]
		private Rope2D m_rope;

		[SerializeField]
		private List<BalloonProperty> m_directBallons;

		[SerializeField]
		private List<BalloonProperty> m_indirectBallons;

		public Rope2D Rope => null;

		public List<BalloonProperty> DirectBallons
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<BalloonProperty> IndirectBallons
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public RopesByBallons()
		{
		}

		public RopesByBallons(Rope2D p_rope)
		{
		}
	}
}
