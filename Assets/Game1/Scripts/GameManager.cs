using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<GameObject> items;
    [SerializeField] GameObject parent;
    public int finalScore = 0;
    public float timeLeft;
    private static GameManager sharedInstance;

    public static GameManager Instance {
        get {return sharedInstance; }
    }
    
    private void Awake() {
        
    }

    private void Start()
    {
        InvokeRepeating("SpawnItem", 3f, 2f);
    }

    private void Update()
    {
        
    }

    private void SpawnItem(){
        var i = Random.Range(0, items.Count - 1);
        var temporalItem = Instantiate(items[i]);

        //change position object
        //-8 y 8 son en el eje X, despues veo si en mi caso son esos valores
        //y 5.5f es Y, tambien ver eso, si quiero desde esa altura o no
        var position = new Vector2(Random.Range(-9.5f, 9.5f), 5.6f);
        temporalItem.transform.position = position;

        //Rename and add object as child of parent
        temporalItem.gameObject.name = items[i].name;
        temporalItem.transform.parent = parent.transform;
    }
}
