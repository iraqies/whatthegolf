using System;
using System.Collections;
using System.Text;
using TMPro;
using UnityEngine;

public class SpeechBubbleUI : MonoBehaviour
{
	public class Task
	{
		public string text;
		public Vector2 speakerPosition;
		public Vector2? bubblePosition;
		public Camera camera;
		public Vector2? arrowDirection;
		public bool bypassLocalization;
		public Func<string, string> onPreprocess;
		public bool isDone;
	}

	[SerializeField] private Vector2 padding = new Vector2(0.8f, 0.5f);
	[SerializeField] private Vector2 minSize = new Vector2(2f, 1f);
	[SerializeField] private Vector2 maxSize = new Vector2(8f, 4f);
	[SerializeField] private Vector2 arrowOffset;
	[SerializeField] private Vector2 arrowExtraOffset;
	[SerializeField] private float maxArrowScale = 1f;
	[SerializeField] private TextMeshProUGUI bubbleText;
	[SerializeField] private RectTransform bubbleTextTransform;
	[SerializeField] private RectTransform bubbleTransform;
	[SerializeField] private RectTransform arrowTransform;
	[SerializeField] private SpeechBubbleTextEffect textEffect;
	[SerializeField] private bool bypassEnlargeSpeechBubbles;

	private Color textColor = Color.black;
	private Color textColorInvisible = new Color(0f, 0f, 0f, 0f);
	private Color arrowColor = Color.white;
	private Color arrowColorInvisible = new Color(1f, 1f, 1f, 0f);
	private StringBuilder sb;
	private bool isVisible;
	private Task activeTask;
	private Task nextTask;
	private Coroutine coroutine;
	private float enlargeSpeechBubbleScale = 1.4f;
	private float arrowFadeDuration = 0.1f;
	private float resizeDuration = 0.15f;
	private TextMeshProLocalized bubbleTextLocalized;

	private void Awake()
	{
		if (bubbleText != null)
			bubbleTextLocalized = bubbleText.GetComponent<TextMeshProLocalized>();
	}

	private void UpdateScale()
	{
	}

	public Task Show(string text, Vector2 speakerPosition, Vector2? bubblePosition = null, Camera camera = null, Vector2? arrowDirection = null, bool localized = false, Func<string, string> OnPreprocess = null)
	{
		var task = new Task
		{
			text = text,
			speakerPosition = speakerPosition,
			bubblePosition = bubblePosition,
			camera = camera,
			arrowDirection = arrowDirection,
			bypassLocalization = !localized,
			onPreprocess = OnPreprocess,
			isDone = false
		};
		gameObject.SetActive(true);
		transform.position = new Vector3(speakerPosition.x, speakerPosition.y, transform.position.z);
		if (coroutine != null)
			StopCoroutine(coroutine);
		coroutine = StartCoroutine(ShowBubbleCoroutine(task));
		return task;
	}

	private IEnumerator ShowCoroutine()
	{
		yield break;
	}

	private Vector2 ViewportToLocal(Vector3 position_view) => position_view;

	private IEnumerator ShowBubbleCoroutine(Task task)
	{
		if (task == null)
			yield break;
		activeTask = task;
		isVisible = true;
		string display = task.text ?? string.Empty;
		if (!task.bypassLocalization && !string.IsNullOrEmpty(display) && Localization.Instance != null)
		{
			string loc = Localization.Instance.GetString(display);
			if (!string.IsNullOrEmpty(loc))
				display = loc;
		}
		if (task.onPreprocess != null)
			display = task.onPreprocess(display);
		if (bubbleText != null)
			bubbleText.text = display;
		float wait = Mathf.Clamp(1.2f + display.Length * 0.04f, 1.5f, 3.5f);
		float elapsed = 0f;
		while (elapsed < wait && isVisible)
		{
			elapsed += Time.deltaTime;
			yield return null;
		}
		task.isDone = true;
		activeTask = null;
	}

	private Vector2 GetArrowPositionOnBubble(Vector2 arrowPosition_local, Vector2 bubblePosition, Vector2 targetSize) => arrowPosition_local;

	private Vector2 OnUnitBox(Vector2 dir) => dir;

	private float ZeroSign(float f) => Mathf.Sign(f);

	public void Hide(bool showAnimation = true)
	{
		isVisible = false;
		if (activeTask != null)
			activeTask.isDone = true;
		if (coroutine != null)
		{
			StopCoroutine(coroutine);
			coroutine = null;
		}
		gameObject.SetActive(false);
	}
}
