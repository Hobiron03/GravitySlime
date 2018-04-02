using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScripts : MonoBehaviour {

    public GameManager gameManager;
    public TreasureController treasureController;

    public Sprite goalImage2;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            
            GetComponent<SpriteRenderer>().sprite = goalImage2;
            treasureController.GetTreasure();
            gameManager.GetComponent<GameManager>().GameClear();
        }
    }
}
