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

	[SerializeField]
	private Vector2 padding;

	[SerializeField]
	private Vector2 minSize;

	[SerializeField]
	private Vector2 maxSize;

	[SerializeField]
	private Vector2 arrowOffset;

	[SerializeField]
	private Vector2 arrowExtraOffset;

	[SerializeField]
	private float maxArrowScale;

	[SerializeField]
	private TextMeshProUGUI bubbleText;

	[SerializeField]
	private RectTransform bubbleTextTransform;

	[SerializeField]
	private RectTransform bubbleTransform;

	[SerializeField]
	private RectTransform arrowTransform;

	[SerializeField]
	private SpeechBubbleTextEffect textEffect;

	[SerializeField]
	private bool bypassEnlargeSpeechBubbles;

	private Color textColor;

	private Color textColorInvisible;

	private Color arrowColor;

	private Color arrowColorInvisible;

	private StringBuilder sb;

	private bool isVisible;

	private Task activeTask;

	private Task nextTask;

	private Coroutine coroutine;

	private float enlargeSpeechBubbleScale;

	private float arrowFadeDuration;

	private float resizeDuration;

	private TextMeshProLocalized bubbleTextLocalized;

	private void Awake()
	{
	}

	private void UpdateScale()
	{
	}

	public Task Show(string text, Vector2 speakerPosition, Vector2? bubblePosition = null, Camera camera = null, Vector2? arrowDirection = null, bool localized = false, Func<string, string> OnPreprocess = null)
	{
		return null;
	}

	private IEnumerator ShowCoroutine()
	{
		return null;
	}

	private Vector2 ViewportToLocal(Vector3 position_view)
	{
		return default;
	}

	private IEnumerator ShowBubbleCoroutine(Task task)
	{
		return null;
	}

	private Vector2 GetArrowPositionOnBubble(Vector2 arrowPosition_local, Vector2 bubblePosition, Vector2 targetSize)
	{
		return default;
	}

	private Vector2 OnUnitBox(Vector2 dir)
	{
		return default;
	}

	private float ZeroSign(float f)
	{
		return 0f;
	}

	public void Hide(bool showAnimation = true)
	{
	}
}
