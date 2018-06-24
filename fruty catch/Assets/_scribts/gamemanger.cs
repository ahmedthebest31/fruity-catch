using UnityEngine;

public class gamemanger : MonoBehaviour {

	public UnityEngine.UI.Image helthimage;
	float helth = 5f;
	playerController pc;

	void Start () 
	{
		pc = FindObjectOfType<playerController> ();
	}
	


	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "banana") 
		{
			Destroy (col.gameObject);
			helth -= 1f;
			helthimage.fillAmount = helth / 5f;
		}
		if (helth == 0f)
			Gameover ();
	}
	
		void Gameover()
		{
		PlayerPrefs.SetInt ("score", pc.score);
		PlayerPrefs.SetInt ("level", pc.level);
        UnityEngine.SceneManagement.SceneManager.LoadScene("game over");	
		}
    
	
	}

