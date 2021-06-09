using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{
    public void Quit()
	{
		Application.Quit();
	}

	public void Play()
	{
		SceneManager.LoadScene(1);
		Time.timeScale = 1f;
	}

	public void Retry()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene(1);
	}

	public void Menu()
	{
		SceneManager.LoadScene(0);
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Quit();
		}
	}
}
