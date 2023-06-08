using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private float speed;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        switch(collision.gameObject.tag){
            case "Player":
                IncreaseScore();
                break;
            case "Floor":
                Debug.Log("Floor");
                break;
        }

        Destroy(gameObject);
    }

    private void IncreaseScore(){
        GameManager.Instance.finalScore += score;
        Debug.Log(GameManager.Instance.finalScore);
    }
}
