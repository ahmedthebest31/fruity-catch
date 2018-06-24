using UnityEngine;

public class playerController : MonoBehaviour{

	[SerializeField] Camera cam;
	// the text for desplay the score 
	[SerializeField] UnityEngine.UI.Text scoretext;
	// the text display the courent level 
	[SerializeField] UnityEngine.UI.Text leveltext;
    // the sound for eating 
    [SerializeField] AudioClip eatcleb;
	// the sound of changing level 
	[SerializeField] AudioClip uplevel;
	AudioSource aud;
	public int score = 0;
    // the level nomper 
    public int level = 1;
    // the clamped value for the movement in the X
    float bozlemet = 5.5f;
    

    int index = 50;  
	 

    Vector3 position;
   
	void Start()
    {
		
		position = transform.position;
		aud = GetComponent<AudioSource> ();
        if (cam == null)
            cam = Camera.main;
	}


    void Update()
    {
		if (Time.timeScale == 1)
          //position.x = cam.ScreenToWorldPoint(Input.mousePosition.x * speed) * Time.deltaTime;
        position = cam.ScreenToWorldPoint(Input.mousePosition)/1.5f;
        position.y = Mathf.Clamp(position.y, -3.1f, -3.1f);		

		position.x = Mathf.Clamp(position.x, -bozlemet, bozlemet);
		        transform.position = position;

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "banana")
        {
			Destroy (col.gameObject);
			score += 10;
			scoretext.text = "score: " + score;
			leveltext.text = "" + level;
			aud.clip = eatcleb;
			aud.Play();
		}

       
		if (score >= index) 
		{
			level++;
			index += score;
			aud.clip = uplevel;
			aud.Play();
		
		}

}
}