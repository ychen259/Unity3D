using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider col)
    {
        this.GetComponent<AudioSource>().Play();

        Vector3 position = this.transform.position; // position of coins
        this.transform.position = new Vector3(position.x, position.y-1000, position.z); //move coin to button in y direction for 1000
        StartCoroutine(wait());

    }

    IEnumerator wait()
    {
        CoinCounter.CoinsCollected += 1;
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
