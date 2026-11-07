using System.Collections.Generic;
using UnityEngine;

namespace Kilt.EasyRopes2D
{
	public class RopesByBalloonsController : MonoBehaviour
	{
		private static RopesByBalloonsController m_instance;

		private List<RopesByBallons> _ropesByBallonsList;

		protected bool _needRemoveNulls;

		public static RopesByBalloonsController Instance
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public List<RopesByBallons> RopesByBallonsList
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

		protected virtual RopesByBallons GetRopeByBallonStructureInternal(Rope2D p_rope, bool p_registerNewIfDontFind = true)
		{
			return null;
		}

		protected virtual List<RopesByBallons> GetAllStructsWithBallonInternal(BalloonProperty p_ballon)
		{
			return null;
		}

		protected virtual void RemoveNullRefs(bool p_force = false)
		{
		}

		public static bool InstanceExists()
		{
			return false;
		}

		public static RopesByBalloonsController GetInstance(bool p_canCreateANewOne = false)
		{
			return null;
		}

		public static RopesByBallons GetRopeByBallonStructure(Rope2D p_rope, bool p_registerNewIfDontFind = true, bool p_canCreateNewControllerIfDontExists = true)
		{
			return null;
		}

		public static List<RopesByBallons> GetAllStructsWithBallon(BalloonProperty p_ballon, bool p_canCreateNewControllerIfDontExists = true)
		{
			return null;
		}
	}
}
