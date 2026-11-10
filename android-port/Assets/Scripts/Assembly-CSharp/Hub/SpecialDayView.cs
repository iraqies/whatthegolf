using TMPro;
using UnityEngine;

namespace Hub
{
	public class SpecialDayView : MonoBehaviour
	{
		[SerializeField]
		private GameObject defaultRoomDressing;

		[SerializeField]
		private SpecialDayCalendar calendar;

		[SerializeField]
		private Transform roomDressingParent;

		[SerializeField]
		private SpecialDayOverworldButton2D door;

		[SerializeField]
		private SpecialDayCountdown countdown;

		[SerializeField]
		private BoxCollider2D boxCollider;

		[SerializeField]
		private TMP_Text debugText;

		[SerializeField]
		private TMP_Text titleText;

		[SerializeField]
		private SpecialDayLockView lockView;

		private SpecialDayStage _stage;

		private GameObject _currentStageDressing;

		private void Start()
		{
			if (PackStarterManager.Instance != null)
			{
				PackStarterManager.Instance.PackStarted += OnPackStarted;
			}
			if (calendar != null)
			{
				Apply(calendar.GetCurrentStage());
			}
			if (debugText != null)
			{
				debugText.gameObject.SetActive(value: false);
			}
		}

		private void OnPackStarted(ContentPack pack)
		{
		}

		private void Update()
		{
			if (calendar == null) return;
			var cur = calendar.GetCurrentStage();
			if (cur == null) return;
			if (countdown != null)
			{
				countdown.Tick(cur);
			}
			if (cur != _stage)
			{
				Apply(cur);
			}
		}

		private void Apply(SpecialDayStage currentStage)
		{
			if (currentStage == null) return;
			bool wasAvailable = _stage != null && _stage.IsAvailable;
			bool isAvailable = currentStage.IsAvailable;
			_stage = currentStage;
			if (titleText != null && Localization.Instance != null)
			{
				string key = isAvailable && _stage.Special != null ? ("ID_MENU_" + _stage.Special.PackName) : "ID_HUB_SPECIAL_EVENT_TITLE";
				titleText.text = Localization.Instance.GetString(key, false, null) ?? "";
			}
			if (_currentStageDressing != null)
			{
				Destroy(_currentStageDressing);
			}
			GameObject prefab = (_stage.RoomDressing != null) ? _stage.RoomDressing : defaultRoomDressing;
			if (prefab != null)
			{
				_currentStageDressing = Instantiate(prefab, roomDressingParent);
			}
			if (wasAvailable && !isAvailable && OverworldManager2d.Instance != null && OverworldManager2d.Instance.ball != null && boxCollider != null)
			{
				if (boxCollider.bounds.Contains(OverworldManager2d.Instance.ball.transform.position))
				{
					ReloadScene();
					return;
				}
			}
			if (wasAvailable != isAvailable || _stage != null)
			{
				bool played = _stage.Special != null && SaveGame.GetIsSpecialPlayed(_stage.Special.PackName);
				if (door != null)
				{
					door.SetState(isAvailable, played);
				}
				if (lockView != null)
				{
					lockView.SetState(isAvailable, played);
				}
			}
		}

		private async void ReloadScene()
		{
			if (RuntimeStoreData.instance != null)
			{
				var hubDef = RuntimeStoreData.instance.TryGetContent("CP_HUB");
				if (hubDef != null && hubDef.pack != null)
				{
					await OverworldSceneLoader.TryLoadOverworld(hubDef.pack, true);
				}
			}
		}

		public void MarkDoorAsOpened()
		{
			if (_stage != null && _stage.Special != null)
			{
				SaveGame.SetIsSpecialPlayed(_stage.Special.PackName);
			}
		}
	}
}
