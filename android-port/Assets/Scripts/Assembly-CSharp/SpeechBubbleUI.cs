using System;
using System.Collections;
using System.Text;
using Core;
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
		{
			textColor = bubbleText.color;
			if (textColor.a < 0.01f)
				textColor = new Color(textColor.r, textColor.g, textColor.b, 1f);
			textColorInvisible = new Color(textColor.r, textColor.g, textColor.b, 0f);
			bubbleTextLocalized = bubbleText.GetComponent<TextMeshProLocalized>();
		}
		arrowColorInvisible = new Color(arrowColor.r, arrowColor.g, arrowColor.b, 0f);
		UpdateScale();
	}

	private void UpdateScale()
	{
		Vector3 scale = Vector3.one;
		if (!bypassEnlargeSpeechBubbles && PlatformSettings.Instance != null)
		{
			var cur = PlatformSettings.Instance.GetCurrent();
			if (cur != null && cur.ShouldEnlargeSpeechBubble())
				scale *= enlargeSpeechBubbleScale;
		}
		transform.localScale = scale;
	}

	public Task Show(string text, Vector2 speakerPosition, Vector2? bubblePosition = null, Camera camera = null, Vector2? arrowDirection = null, bool localized = false, Func<string, string> OnPreprocess = null)
	{
		UpdateScale();
		var task = new Task
		{
			text = text,
			speakerPosition = speakerPosition,
			bubblePosition = bubblePosition,
			camera = camera,
			arrowDirection = arrowDirection,
			bypassLocalization = localized,
			onPreprocess = OnPreprocess,
			isDone = false
		};
		if (!gameObject.activeSelf)
			gameObject.SetActive(true);
		if (activeTask != null)
			nextTask = task;
		else
			activeTask = task;
		if (coroutine == null)
			coroutine = StartCoroutine(ShowCoroutine());
		return task;
	}

	private IEnumerator ShowCoroutine()
	{
		while (activeTask != null)
		{
			string str = activeTask.bypassLocalization
				? activeTask.text
				: (Localization.Instance != null ? Localization.Instance.GetString(activeTask.text, false, null) : activeTask.text);
			if (string.IsNullOrEmpty(str))
				str = activeTask.text;
			if (activeTask.onPreprocess != null)
				str = activeTask.onPreprocess(str);
			if (string.IsNullOrEmpty(str))
				break;
			if (bubbleTextLocalized != null)
			{
				bubbleTextLocalized.UpdateFont();
				bubbleTextLocalized.UpdateAlignment();
			}
			if (bubbleText != null)
				bubbleText.text = string.Empty;
			yield return ShowBubbleCoroutine(activeTask);
			if (bubbleText != null)
				bubbleText.color = textColor;
			if (textEffect != null)
			{
				yield return textEffect.PlaySequence(str, t =>
				{
					if (bubbleText != null)
						bubbleText.text = t;
				});
			}
			else if (bubbleText != null)
			{
				bubbleText.text = str;
				yield return new WaitForSeconds(Mathf.Clamp(0.6f + str.Length * 0.03f, 0.8f, 2.5f));
			}
			if (activeTask != null)
				activeTask.isDone = true;
			activeTask = nextTask;
			nextTask = null;
		}
		coroutine = null;
	}

	private Vector2 ViewportToLocal(Vector3 position_view)
	{
		if (activeTask == null || activeTask.camera == null)
			return position_view;
		float depth = activeTask.camera.WorldToViewportPoint(transform.position).z;
		Vector3 world = activeTask.camera.ViewportToWorldPoint(new Vector3(position_view.x, position_view.y, depth));
		return transform.InverseTransformPoint(world);
	}

	private IEnumerator ShowBubbleCoroutine(Task task)
	{
		if (task == null)
			yield break;
		if (arrowTransform != null)
			arrowTransform.gameObject.SetActive(false);
		if (bubbleText != null)
			bubbleText.color = textColorInvisible;
		if (bubbleTextTransform != null)
			bubbleTextTransform.sizeDelta = maxSize;

		string str = task.bypassLocalization
			? task.text
			: (Localization.Instance != null ? Localization.Instance.GetString(task.text, false, null) : task.text);
		if (string.IsNullOrEmpty(str))
			str = task.text ?? string.Empty;
		if (task.onPreprocess != null)
			str = task.onPreprocess(str);

		if (bubbleText != null)
		{
			bubbleText.text = str;
			bubbleText.ForceMeshUpdate();
		}

		Vector2 startSize = bubbleTransform != null ? bubbleTransform.sizeDelta : Vector2.zero;
		float prefW = bubbleText != null ? bubbleText.preferredWidth : minSize.x;
		float prefH = bubbleText != null ? bubbleText.preferredHeight : minSize.y;
		float w = Mathf.Max(minSize.x, Mathf.Min(maxSize.x, prefW + 0.1f)) + padding.x * 2f;
		float h = Mathf.Max(minSize.y, Mathf.Min(maxSize.y, prefH)) + padding.y * 2f;
		Vector2 targetSize = new Vector2(w, h);

		Vector2 speakerLocal = transform.InverseTransformPoint(task.speakerPosition);
		Vector2 bubbleTarget;
		if (task.bubblePosition.HasValue)
		{
			bubbleTarget = transform.InverseTransformPoint(task.bubblePosition.Value);
		}
		else
		{
			Vector2 dirLocal = task.arrowDirection.HasValue
				? (Vector2)transform.InverseTransformVector(task.arrowDirection.Value)
				: Vector2.up;
			bubbleTarget = dirLocal + new Vector2(
				speakerLocal.x + ZeroSign(dirLocal.x) * 0.5f * targetSize.x,
				speakerLocal.y + ZeroSign(dirLocal.y) * 0.5f * targetSize.y);
		}

		if (task.camera != null)
		{
			float minX = float.PositiveInfinity;
			float maxX = float.NegativeInfinity;
			float minY = float.PositiveInfinity;
			float maxY = float.NegativeInfinity;

			Vector3[] vpCorners = new Vector3[4]
			{
				new Vector3(0.1f, 0.1f, 0f),
				new Vector3(0.9f, 0.1f, 0f),
				new Vector3(0.9f, 0.9f, 0f),
				new Vector3(0.1f, 0.9f, 0f)
			};

			for (int i = 0; i < 4; i++)
			{
				Vector3 wp = task.camera.ViewportToWorldPoint(vpCorners[i]);
				Vector3 lp = transform.InverseTransformPoint(wp);
				if (lp.x < minX) minX = lp.x;
				if (lp.x > maxX) maxX = lp.x;
				if (lp.y < minY) minY = lp.y;
				if (lp.y > maxY) maxY = lp.y;
			}

			minX += targetSize.x * 0.5f;
			maxX -= targetSize.x * 0.5f;
			minY += targetSize.y * 0.5f;
			maxY -= targetSize.y * 0.5f;

			bubbleTarget.x = (minX <= maxX) ? Mathf.Clamp(bubbleTarget.x, minX, maxX) : (minX + maxX) * 0.5f;
			bubbleTarget.y = (minY <= maxY) ? Mathf.Clamp(bubbleTarget.y, minY, maxY) : (minY + maxY) * 0.5f;
		}

		Vector2 bubbleStart = (!isVisible || bubbleTransform == null) ? bubbleTarget : (Vector2)bubbleTransform.localPosition;
		isVisible = true;

		Vector2 arrowPos = GetArrowPositionOnBubble(speakerLocal, bubbleTarget, targetSize);
		if (arrowTransform != null)
		{
			arrowTransform.localPosition = arrowPos;
			Vector2 toSpeaker = speakerLocal - arrowPos;
			float angle = Mathf.Atan2(toSpeaker.y, toSpeaker.x) * Mathf.Rad2Deg;
			arrowTransform.localRotation = Quaternion.Euler(0f, 0f, angle);
			float dist = Mathf.Clamp(toSpeaker.magnitude, 0f, maxArrowScale);
			arrowTransform.localScale = new Vector3(dist, 1f, 0f);
		}

		yield return pTween.To(resizeDuration, 0f, 1f, t =>
		{
			float s = Mathf.Clamp01(Mathf.SmoothStep(0f, 1f, t));
			if (bubbleTransform != null)
			{
				bubbleTransform.sizeDelta = Vector2.Lerp(startSize, targetSize, s);
				bubbleTransform.localPosition = Vector2.Lerp(bubbleStart, bubbleTarget, s);
			}
		});

		if (arrowTransform != null)
			arrowTransform.gameObject.SetActive(true);
		if (bubbleTextTransform != null)
			bubbleTextTransform.sizeDelta = targetSize - padding * 2f;
	}

	private Vector2 GetArrowPositionOnBubble(Vector2 arrowPosition_local, Vector2 bubblePosition, Vector2 targetSize)
	{
		Vector2 safeSize = new Vector2(Mathf.Max(0.01f, targetSize.x), Mathf.Max(0.01f, targetSize.y));
		Vector2 normalized = (arrowPosition_local - bubblePosition) / safeSize * 2f;
		return OnUnitBox(normalized) * (safeSize * 0.5f - arrowOffset) + bubblePosition;
	}

	private Vector2 OnUnitBox(Vector2 dir)
	{
		float maxAbs = Mathf.Max(Mathf.Abs(dir.x), Mathf.Abs(dir.y));
		if (maxAbs < 1e-5f)
			return Vector2.zero;
		return dir / maxAbs;
	}

	private float ZeroSign(float f)
	{
		if (Mathf.Approximately(f, 0f))
			return 0f;
		return Mathf.Sign(f);
	}

	public void Hide(bool showAnimation = true)
	{
		if (coroutine != null)
		{
			StopCoroutine(coroutine);
			coroutine = null;
		}
		if (showAnimation && gameObject.activeInHierarchy && bubbleTransform != null)
		{
			Vector2 startSize = bubbleTransform.sizeDelta;
			if (arrowTransform != null)
				arrowTransform.gameObject.SetActive(false);
			if (bubbleText != null)
				bubbleText.text = string.Empty;
			StartCoroutine(pTween.To(resizeDuration, 0f, 1f, t =>
			{
				if (bubbleTransform != null)
					bubbleTransform.sizeDelta = Vector2.Lerp(startSize, Vector2.zero, Mathf.SmoothStep(0f, 1f, t));
			}).Then(() => Hide(false)));
		}
		else
		{
			if (bubbleTransform != null)
				bubbleTransform.sizeDelta = Vector2.zero;
			if (arrowTransform != null)
				arrowTransform.gameObject.SetActive(false);
			if (bubbleText != null)
				bubbleText.text = string.Empty;
			isVisible = false;
			if (activeTask != null)
				activeTask.isDone = true;
			activeTask = null;
			nextTask = null;
		}
	}
}
