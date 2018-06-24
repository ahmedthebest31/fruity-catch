using UnityEngine;

public class endgame : MonoBehaviour {

	[SerializeField] UnityEngine.UI.Text scoretext;
	[SerializeField] UnityEngine.UI.Text leveltext;
	
	private void Start () 
	{
        if (PlayerPrefs.HasKey("score"))
        {
            scoretext.text = "SCORE: " + PlayerPrefs.GetInt("score");
            leveltext.text = "" + PlayerPrefs.GetInt("level");
        }

		}
    private void Update()
    {
        if (Input.GetButton("Cancel"))
            UnityEngine.SceneManagement.SceneManager.LoadScene("meanmenue");
    }
}