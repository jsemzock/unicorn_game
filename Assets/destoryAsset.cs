using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destoryAsset : MonoBehaviour {
    public GameObject gameEngine;
    public int counter = 0;


	// Use this for initialization
	void Start () {
        //Destroy(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
        //Destroy(this)
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //gameEngine.GetComponent<gameEngine>().counter += 5;
        //Debug.Log(gameEngine.GetComponent<gameEngine>().counter);
        ScoreScript.scoreValue += 5;
        Destroy(gameObject);

    }
}
