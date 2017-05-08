using UnityEngine;

namespace Extensions
{
	static class ComponentExtensions
	{
		public static TComponent GetOrAddComponent<TComponent>(this GameObject targetGameObject) where TComponent : Component
		{
			TComponent component = targetGameObject.GetComponent<TComponent>();
			if(component == null)
			{
				component = targetGameObject.AddComponent<TComponent>();
			}

			return component;
		}
	}
}
