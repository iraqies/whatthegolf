using System;
using UnityEngine;

public class Arrow : MonoBehaviour
{
	public AudioClip sfxShot;

	public AudioClip sfxShotSoftener;

	public BallShooter shooter;

	private SpriteRenderer sprite;

	private Camera cam;

	[NonSerialized]
	public Vector3 aimDir;

	private void Awake()
	{
		cam = Camera.main;
		sprite = GetComponentInChildren<SpriteRenderer>();
	}

	public void Reset()
	{
		sprite.enabled = true;
	}

	private void Update()
	{
		if (!shooter.didShoot)
		{
			Vector3 position = shooter.transform.position;
			Vector3 vector = cam.ScreenToWorldPoint(Input.mousePosition);
			Vector2 vector2 = new Vector2(vector.x - shooter.transform.position.x, vector.y - shooter.transform.position.y);
			vector2.Normalize();
			aimDir = new Vector3(vector2.x, vector2.y, 0f);
			base.transform.position = new Vector3(position.x + vector2.x * shooter.offsetDistance, position.y + vector2.y * shooter.offsetDistance, 0f);
			base.transform.rotation = Quaternion.LookRotation(new Vector3(vector2.x, vector2.y, 0f), Vector3.forward);
		}
	}
}
