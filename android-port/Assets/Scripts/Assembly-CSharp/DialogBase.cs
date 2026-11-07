using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogBase : MonoBehaviour
{
	[SerializeField]
	private GameObject m_DialogContainer;

	[SerializeField]
	protected Selectable m_DefaultFocus;

	protected ButtonSelectInfo currentSelection;

	public List<ButtonSelectInfo> selectables;

	private List<bool> submitButtonPressed;

	private bool requestHide;

	public static bool IsOpen { get; protected set; }

	[RuntimeInitializeOnLoadMethod]
	private static void Init()
	{
	}

	private void Start()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	protected virtual void Update()
	{
	}

	public IEnumerator WaitForDialogToBeClosed()
	{
		return null;
	}
}
