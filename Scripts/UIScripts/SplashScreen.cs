using UnityEngine;
using UnityEngine.SceneManagement;

namespace Demonics
{
	public class SplashScreen : MonoBehaviour
	{
		public void GoToNextScene()
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}
}
