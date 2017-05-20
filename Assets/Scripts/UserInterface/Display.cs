using System;
using UnityEngine;

namespace UserInterface
{
	/// <summary>
	/// Base Class for displaying Objects. More or less a framework for conditionally doing work based on value changes
	/// </summary>
	/// <typeparam name="T">The Type of object that should be displayed</typeparam>
	public abstract class Display<T> : MonoBehaviour
	{
		/// <summary>
		/// This even is fired every time the Display Succefully Updates, with the new value being it's paramater
		/// </summary>
		public event Action<T> UpdateEvent;

		/// <summary>
		/// A quick precheck to see if we should continue with updating the value and firing off the event.
		/// Allows some preprocessing/tranformation of the value before it is passed through
		/// </summary>
		/// <param name="prospectiveNewValue">The new value that we are checking</param>
		/// <returns>Weather or not we should update the value</returns>
		protected abstract bool ShouldUpdate(ref T prospectiveNewValue);

		/// <summary>
		/// This code is executed when the TDisplayable Updates
		/// </summary>
		/// <param name="newValue"></param>
		protected abstract void OnUpdate(T newValue);

		/// <summary>
		/// The function external code calls when they want to update the object
		/// </summary>
		/// <param name="newValue"></param>
		public virtual void Set(T newValue)
		{
			if (ShouldUpdate(ref newValue))
			{
				OnUpdate(newValue);
				if(UpdateEvent != null)
				{
					UpdateEvent.Invoke(newValue);
				}
			}
		}

		/// <summary>
		/// The function external code calls when they want to check if a mutation has occured on the object
		/// </summary>
		public virtual void CheckForUpdates() { }
	}
}
