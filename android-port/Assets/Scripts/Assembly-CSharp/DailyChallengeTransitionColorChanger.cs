using System.Collections.Generic;
using UnityEngine;

public class DailyChallengeTransitionColorChanger : MonoBehaviour
{
	public List<SpriteRenderer> top1;

	public List<SpriteRenderer> c2;

	public List<SpriteRenderer> c3;

	public List<SpriteRenderer> c4;

	public List<SpriteRenderer> c5;

	public List<SpriteRenderer> c6;

	public List<SpriteRenderer> middel7;

	public List<SpriteRenderer> c8;

	public List<SpriteRenderer> c9;

	public List<SpriteRenderer> c10;

	public List<SpriteRenderer> c11;

	public List<SpriteRenderer> c12;

	public List<SpriteRenderer> bottom13;

	public void ChangeColor(TransitionColorDefinition d)
	{
		if (d == null)
		{
			return;
		}
		Debug.Log("Changing color");
		top1?.ForEach(delegate(SpriteRenderer t)
		{
			if (t != null)
			{
				t.color = GetColor(d.c1);
			}
		});
		c2?.ForEach(delegate(SpriteRenderer t)
		{
			if (t != null)
			{
				t.color = GetColor(d.c2);
			}
		});
		c3?.ForEach(delegate(SpriteRenderer t)
		{
			if (t != null)
			{
				t.color = GetColor(d.c3);
			}
		});
		c4?.ForEach(delegate(SpriteRenderer t)
		{
			if (t != null)
			{
				t.color = GetColor(d.c4);
			}
		});
		c5?.ForEach(delegate(SpriteRenderer t)
		{
			if (t != null)
			{
				t.color = GetColor(d.c5);
			}
		});
		c6?.ForEach(delegate(SpriteRenderer t)
		{
			if (t != null)
			{
				t.color = GetColor(d.c6);
			}
		});
		middel7?.ForEach(delegate(SpriteRenderer t)
		{
			if (t != null)
			{
				t.color = GetColor(d.c7);
			}
		});
		c8?.ForEach(delegate(SpriteRenderer t)
		{
			if (t != null)
			{
				t.color = GetColor(d.c8);
			}
		});
		c9?.ForEach(delegate(SpriteRenderer t)
		{
			if (t != null)
			{
				t.color = GetColor(d.c9);
			}
		});
		c10?.ForEach(delegate(SpriteRenderer t)
		{
			if (t != null)
			{
				t.color = GetColor(d.c10);
			}
		});
		c11?.ForEach(delegate(SpriteRenderer t)
		{
			if (t != null)
			{
				t.color = GetColor(d.c11);
			}
		});
		c12?.ForEach(delegate(SpriteRenderer t)
		{
			if (t != null)
			{
				t.color = GetColor(d.c12);
			}
		});
		bottom13?.ForEach(delegate(SpriteRenderer t)
		{
			if (t != null)
			{
				t.color = GetColor(d.c13);
			}
		});
	}

	private Color GetColor(TransitionColorDefinition.AllowedColors a)
	{
		return TransitionColorDefinition.FromAllowedColor(a);
	}
}
