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

		private Dictionary<MogaEntity, MogaHealthbar> healthbars = new Dictionary<MogaEntity, MogaHealthbar>();

		private void Awake()
		{
			healthbars = new Dictionary<MogaEntity, MogaHealthbar>();
		}

		private void Update()
		{
			if (healthbars == null)
			{
				return;
			}
			List<MogaEntity> dead = null;
			foreach (KeyValuePair<MogaEntity, MogaHealthbar> kvp in healthbars)
			{
				if (kvp.Key == null)
				{
					if (kvp.Value != null)
					{
						UnityEngine.Object.Destroy(kvp.Value.gameObject);
					}
					if (dead == null)
					{
						dead = new List<MogaEntity>();
					}
					dead.Add(kvp.Key);
				}
				else if (kvp.Value != null)
				{
					kvp.Value.UpdateHealthbar();
				}
			}
			if (dead != null)
			{
				for (int i = 0; i < dead.Count; i++)
				{
					healthbars.Remove(dead[i]);
				}
			}
		}

		public MogaTeamInfo GetBaseInfoForTeam(int index)
		{
			if (teamInfo == null)
			{
				return null;
			}
			for (int i = 0; i < teamInfo.Count; i++)
			{
				if (teamInfo[i] != null && teamInfo[i].TeamIndex == index)
				{
					return teamInfo[i];
				}
			}
			return null;
		}

		public void RegisterEntity(MogaEntity entity)
		{
			if (entity == null || healtbarTemplate == null || healthbars.ContainsKey(entity))
			{
				return;
			}
			MogaHealthbar hb = UnityEngine.Object.Instantiate(healtbarTemplate, healtbarTemplate.transform.parent);
			hb.gameObject.SetActive(true);
			hb.SetEntityInfo(entity);
			healthbars[entity] = hb;
		}
	}
}
