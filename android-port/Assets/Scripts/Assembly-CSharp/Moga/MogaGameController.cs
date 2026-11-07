using System;
using System.Collections.Generic;
using UnityEngine;

namespace Moga
{
	public class MogaGameController : MonoBehaviour
	{
		[Serializable]
		public class MogaTeamInfo
		{
			public int TeamIndex;

			public MogaEntity HomeBase;

			public Color TeamColor;
		}

		[SerializeField]
		private List<MogaTeamInfo> teamInfo;

		[SerializeField]
		private MogaHealthbar healtbarTemplate;

		private Dictionary<MogaEntity, MogaHealthbar> healthbars;

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public MogaTeamInfo GetBaseInfoForTeam(int index)
		{
			return null;
		}

		public void RegisterEntity(MogaEntity entity)
		{
		}
	}
}
