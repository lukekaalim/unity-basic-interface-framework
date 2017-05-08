using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UserInterface
{
	public abstract class Display<T> : MonoBehaviour
	{
		public abstract void UpdateValue(T newValue);
	}
}
