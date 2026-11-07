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
		}

		private void OnPackStarted(ContentPack pack)
		{
		}

		private void Update()
		{
		}

		private void Apply(SpecialDayStage currentStage)
		{
		}

		private void ReloadScene()
		{
		}

		public void MarkDoorAsOpened()
		{
		}
	}
}
