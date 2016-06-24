using System;
using UnityEngine;
using System.Collections;

public class BubbleComponent :MonoBehaviour
{
	public UISprite bgSprite;
	
	public UILabel label;

	private int _count;
	public int count
	{
		get	{ return _count; }
	}

	private Action _onChange;
	public event Action onChange
	{
		add	{ _onChange += value; }
		remove { _onChange -= value; }
	}

	void Start()
	{
		this._count = 0;
	}

	// Use this for initialization
	
	public string bgUrl
	{
		get { return bgSprite.spriteName; }
		set { bgSprite.spriteName = value; }
	}
	
	public string text
	{
		get { return label.text; }
		set { label.text = value; }
	}

	public void Add(int count = 1)
	{
		this._count += count;
		if(_onChange != null)
			_onChange();
		Refresh();
	}

	public void Set(int count)
	{
		this._count = count;
		if(_onChange != null)
			_onChange();
		Refresh();
	}

	public void Clear()
	{
		this._count = 0;
		if(_onChange != null)
			_onChange();
		Refresh();
	}

	public void Refresh()
	{
		text = this._count.ToString();
	}
}
