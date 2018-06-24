using UnityEngine;

public class menueController : MonoBehaviour {

	
	void Start () 
	{
		
	}
	
	void Update () 
	{
        if (Input.GetButton("Cancel"))
            Application.Quit();
    }
}
