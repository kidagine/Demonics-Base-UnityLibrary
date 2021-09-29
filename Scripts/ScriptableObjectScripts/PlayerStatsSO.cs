using UnityEngine;

namespace Demonics
{
	[CreateAssetMenu(fileName = "PlayerStats", menuName = "Scriptable Objects/PlayerStats", order = 2)]
	public class PlayerStatsSO : ScriptableObject
	{
		[Header("Main")]
		public float travelDistance;
		public float hitStun;
	}
}