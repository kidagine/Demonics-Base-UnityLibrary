using UnityEngine;

namespace Demonics
{
	public class DestroyAnimationEvent : MonoBehaviour
	{
		public void Destroy()
		{
			Destroy(gameObject);
		}
	}
}