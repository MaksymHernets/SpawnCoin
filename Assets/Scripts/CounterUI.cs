using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounterUI : MonoBehaviour
{
    public Text label;

	private int _value = 0;

    public void Set(int value)
	{
		this._value = value;
		label.text = value.ToString();
	}

	public float Uncrement()
	{
		--_value;
		label.text = _value.ToString();
		return _value;
	}
}
