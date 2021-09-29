using UnityEngine;
using UnityEngine.SceneManagement;

namespace Demonics.UI
{
	public class SplashScreen : MonoBehaviour
	{
		public void GoToNextScene()
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}
	}
}
