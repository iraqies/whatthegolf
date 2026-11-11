using CameraStack;
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
		private float healthBarSizeMod = 1f;

		private MogaEntity entity;

		public void SetEntityInfo(MogaEntity entity)
		{
			this.entity = entity;
			UpdateHealthbar();
		}

		public void UpdateHealthbar()
		{
			if (entity == null)
			{
				return;
			}
			if (healthBar != null)
			{
				healthBar.fillAmount = entity.StartHealth > 0f ? Mathf.Clamp01(entity.CurrentHealth / entity.StartHealth) : 0f;
			}
			Camera cam = CameraManager.Instance != null ? CameraManager.Instance.MainCamera : Camera.main;
			if (cam != null && healthBarContainer != null)
			{
				healthBarContainer.position = cam.WorldToScreenPoint(entity.transform.position + Vector3.up * 1.5f);
			}
		}
	}
}
