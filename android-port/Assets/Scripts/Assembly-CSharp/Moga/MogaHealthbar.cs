using UnityEngine;
using UnityEngine.UI;

namespace Moga
{
	public class MogaHealthbar : MonoBehaviour
	{
		[SerializeField]
		private RectTransform healthBarContainer;

		[SerializeField]
		private Image healthBar;

		[SerializeField]
		private float healthBarSizeMod;

		private MogaEntity entity;

		public void SetEntityInfo(MogaEntity entity)
		{
		}

		public void UpdateHealthbar()
		{
		}
	}
}
