using System.Collections;
using System.Collections.Generic;
using Audio;
using CameraStack;
using Core;
using UnityEngine;

public class DogToTruck : MonoBehaviour
{
	[SerializeField]
	private GolfBallController controller;

	[SerializeField]
	private List<GameObject> Objects;

	[SerializeField]
	private int shotsBeforeWheels = 1;

	[SerializeField]
	private ClipSettingsCollection mySfx;

	private int numShots;

	private int index;

	[SerializeField]
	private GameObject truck;

	[SerializeField]
	private Vector3 ForceOnWheelsAdded;

	[SerializeField]
	private CBFollow FollowCam;

	[SerializeField]
	private CBFollow FollowCamDesktop;

	[SerializeField]
	private ParticleSystem poofParticles;

	[SerializeField]
	private bool AddWheelsOnShoot;

	private void OnEnable()
	{
		if (controller != null)
		{
			controller.OnShoot += Controller_OnShoot;
		}
	}

	private void OnDisable()
	{
		if (controller != null)
		{
			controller.OnShoot -= Controller_OnShoot;
		}
	}

	public void Next()
	{
		if (Objects == null)
		{
			return;
		}
		if (index < Objects.Count - 1)
		{
			StartCoroutine(AddTwoWheels(index));
			index += 2;
		}
		else
		{
			StartCoroutine(ToTruck(Vector3.zero));
		}
	}

	private void Controller_OnShoot(Vector3 obj)
	{
		numShots++;
		if (numShots <= shotsBeforeWheels || Objects == null)
		{
			return;
		}
		if (index < Objects.Count - 1)
		{
			if (AddWheelsOnShoot)
			{
				if (mySfx != null)
				{
					mySfx.Play(null, base.transform.position, 1f, 1f);
				}
				StartCoroutine(AddTwoWheels(index));
				index += 2;
			}
		}
		else
		{
			if (mySfx != null)
			{
				mySfx.Play(null, base.transform.position, 1f, 1f);
			}
			StartCoroutine(ToTruck(obj));
		}
	}

	private IEnumerator AddTwoWheels(int i)
	{
		AddWheel(i);
		yield return new WaitForSeconds(0.2f);
		AddWheel(i + 1);
		if (controller != null && controller.shooter != null)
		{
			controller.shooter.OnShoot(ForceOnWheelsAdded);
		}
		if (poofParticles != null && controller != null)
		{
			poofParticles.transform.position = controller.gameObject.transform.position;
			poofParticles.Play();
		}
	}

	private IEnumerator ToTruck(Vector3 obj)
	{
		if (controller != null)
		{
			controller.enabled = false;
			if (controller.ShootArrow != null)
			{
				controller.ShootArrow.gameObject.SetActive(false);
			}
		}
		yield return new WaitForSeconds(0.4f);
		if (truck != null)
		{
			truck.SetActive(true);
			if (FollowCam != null)
			{
				FollowCam.Target = truck.transform;
			}
			if (FollowCamDesktop != null)
			{
				FollowCamDesktop.Target = truck.transform;
			}
		}
		if (poofParticles != null && controller != null)
		{
			poofParticles.transform.position = controller.gameObject.transform.position;
		}
		if (truck != null && controller != null)
		{
			truck.transform.position = controller.gameObject.transform.position + new Vector3(0f, 3f, 0f);
		}
		if (poofParticles != null)
		{
			poofParticles.Play();
		}
		base.gameObject.SetActive(false);
	}

	private void AddWheel(int i)
	{
		if (Objects == null || i < 0 || i >= Objects.Count || Objects[i] == null)
		{
			return;
		}
		Vector3 targetScale = Objects[i].transform.localScale;
		Objects[i].SetActive(true);
		StartCoroutine(pTween.To(0.2f, 0f, 1f, delegate(float t)
		{
			if (Objects != null && i < Objects.Count && Objects[i] != null)
			{
				Objects[i].transform.localScale = Vector3.Lerp(Vector3.zero, targetScale, t);
			}
		}));
	}
}
