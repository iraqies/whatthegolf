using System.Collections;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ReconciliationDialog : DialogBase
{
	public enum Choice
	{
		None = 0,
		Local = 1,
		Cloud = 2
	}

	[SerializeField]
	private Text m_UsedName;

	public Transform selectionHand;

	[SerializeField]
	private TMP_Text m_LocalSave_DeviceModel;

	[SerializeField]
	private TMP_Text m_LocalSave_DeviceName;

	[SerializeField]
	private TMP_Text m_LocalSave_Date;

	[SerializeField]
	private TMP_Text m_LocalSave_Time;

	[SerializeField]
	private TMP_Text m_CloudSave_DeviceModel;

	[SerializeField]
	private TMP_Text m_CloudSave_DeviceName;

	[SerializeField]
	private TMP_Text m_CloudSave_Date;

	[SerializeField]
	private TMP_Text m_CloudSave_Time;

	private Choice m_SelectedSave;

	private int selectedIndex;

	private Vector3 handposition;

	public Choice SelectedSave => Choice.None;

	public IEnumerator WaitForSaveSelection()
	{
		return null;
	}

	public Task<Choice> WaitForSaveSelection_Task()
	{
		return null;
	}

	protected override void Update()
	{
	}

	public void SetDetails(SaveGame.SaveData localSaveData, SaveGame.SaveData cloudSaveData)
	{
	}

	public void ChooseLocalSave()
	{
	}

	public void ChooseCloudSave()
	{
	}
}
