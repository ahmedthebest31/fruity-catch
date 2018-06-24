using UnityEngine;

public class gameload : MonoBehaviour {


    public void Play()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("level");
	}


	public void Menu()
	{

		UnityEngine.SceneManagement.SceneManager.LoadScene("meanmenue");
	}

	public void About()
	{
		//Application.OpenURL("");
	}
	public void Exit()
	{
		Application.Quit();
	}
}
