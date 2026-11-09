using UnityEngine;

public class OverworldPositionSave : MonoBehaviour
{
	public float SaveVelocityThreshold = 0.2f;

	private bool startSaving;

	private Rigidbody2D rigid;

	private OverworldID id;

	private readonly string saveKey = "PROP_POS_{0}";

	private void Awake()
	{
		rigid = GetComponent<Rigidbody2D>();
		id = GetComponent<OverworldID>();
	}

	private void Start()
	{
		if (id != null && !string.IsNullOrEmpty(id.ID))
		{
			string keyX = string.Format(saveKey, id.ID + "_X");
			string keyY = string.Format(saveKey, id.ID + "_Y");
			float sx = SaveGame.GetValue(keyX, 0f);
			float sy = SaveGame.GetValue(keyY, 0f);
			if (Mathf.Abs(sx) > 0.001f || Mathf.Abs(sy) > 0.001f)
				transform.position = new Vector3(sx, sy, transform.position.z);
		}
	}

	private void OnCollisionEnter2D(Collision2D other)
	{
		startSaving = true;
	}

	private void FixedUpdate()
	{
		if (!startSaving || rigid == null)
			return;
		if (rigid.velocity.magnitude <= SaveVelocityThreshold)
		{
			startSaving = false;
			if (id != null && !string.IsNullOrEmpty(id.ID))
			{
				string keyX = string.Format(saveKey, id.ID + "_X");
				string keyY = string.Format(saveKey, id.ID + "_Y");
				SaveGame.SetValue(keyX, transform.position.x, false);
				SaveGame.SetValue(keyY, transform.position.y, true);
			}
		}
	}
}
