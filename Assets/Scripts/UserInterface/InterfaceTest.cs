using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UserInterface;

public class InterfaceTest : MonoBehaviour
{
	[SerializeField]
	private List<FloatDisplay> floatList;

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
		foreach(FloatDisplay display in floatList)
		{
			display.Set(Random.Range(0f, 1f));
		}
	}
}
