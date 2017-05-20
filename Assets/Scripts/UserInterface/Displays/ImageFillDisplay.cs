using UnityEngine;
using UnityEngine.UI;

namespace UserInterface.Displays
{
	[RequireComponent(typeof(Image))]
	public class ImageFillDisplay : FloatDisplay
	{
		[SerializeField, HideInInspector]
		Image image;

		float lastValue;

		private void Start()
		{
			SetupRectTransforms();
		}

		private void SetupRectTransforms()
		{
			image = GetComponent<Image>();
		}

		protected override void OnUpdate(float newValue)
		{
			image.fillAmount = newValue;
			lastValue = newValue;
		}

		protected override bool ShouldUpdate(ref float prospectiveNewValue)
		{
			prospectiveNewValue = Mathf.Clamp01(prospectiveNewValue);
			return prospectiveNewValue != lastValue;
		}
	}
}
