using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ScoreController : MonoBehaviour {
    public int Score;
    public AudioClip clip;

	// Use this for initialization
	void Start () {
        Score = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Hit")
        {
            Score++;
            Debug.Log("Collision with: " + collision.collider.name);
            AudioSource.PlayClipAtPoint(clip, collision.transform.position, 1.5f);
        }
    }
}
