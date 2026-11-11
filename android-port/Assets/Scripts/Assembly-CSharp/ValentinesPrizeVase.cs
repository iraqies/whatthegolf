using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ValentinesPrizeVase : MonoBehaviour
{
	[SerializeField]
	private GameObject BalloonPrefab;

	[SerializeField]
	private List<Material> materials;

	private Rigidbody rigid;

	private List<Balloon> balloons;

	private void Start()
	{
		balloons = base.transform.GetComponentsInChildren<Balloon>().ToList();
		balloons.ForEach(delegate(Balloon b)
		{
			b.OnPopped = (Action<Balloon>)Delegate.Combine(b.OnPopped, new Action<Balloon>(OnBalloonPopped));
		});
		rigid = GetComponent<Rigidbody>();
	}

	private void OnBalloonPopped(Balloon b)
	{
		balloons.Remove(b);
		NewBalloon();
	}

	public void NewBalloon()
	{
		GameObject go = UnityEngine.Object.Instantiate(BalloonPrefab, base.transform);
		Vector3 baseScale = go.transform.localScale;
		StartCoroutine(pTween.To(1f, 0f, 1f, delegate(float t)
		{
			if (go != null)
			{
				go.transform.localScale = Vector3.Lerp(Vector3.zero, baseScale, t);
			}
		}));
		go.GetComponent<Balloon>();
		go.GetComponent<LineRope>().LineEnd = rigid.transform;
		go.GetComponent<SpringJoint>().connectedBody = rigid;
		go.GetComponentInChildren<MeshRenderer>().material = materials[UnityEngine.Random.Range(0, materials.Count)];
		Balloon component = go.GetComponent<Balloon>();
		component.OnPopped = (Action<Balloon>)Delegate.Combine(component.OnPopped, new Action<Balloon>(OnBalloonPopped));
		balloons.Add(component);
		component.isPopped = false;
	}
}
