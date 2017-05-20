using UnityEngine;
using UnityEngine.UI;

namespace UserInterface
{
	public class TextDisplay : Display<string>
	{
		[SerializeField]
		private Text textOutputComponent;

		protected override void OnUpdate(string newValue)
		{
			textOutputComponent.text = newValue;
		}

		protected override bool ShouldUpdate(ref string prospectiveNewValue)
		{
			return textOutputComponent.text == prospectiveNewValue;
		}
	}
}
