using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

namespace UserInterface
{
	public class TextDisplay : Display<string>
	{
		[SerializeField]
		private Text textOutputComponent;

		public override void UpdateValue(string newValue)
		{
			textOutputComponent.text = newValue;
		}
	}
}
