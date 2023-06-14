using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] List<GameObject> items;
    [SerializeField] GameObject parent;
    public int finalScore = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timeLeftText;
    public TextMeshProUGUI finalScoreText;
    public GameObject finalPanel;
    public float timeLeft;
    private static GameManager sharedInstance;
    
    public static GameManager Instance {
        get {return sharedInstance; }
    }
    
    private void Awake() {
        if(sharedInstance == null){
            sharedInstance = this;
            DontDestroyOnLoad(gameObject);
        }else{
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        InvokeRepeating("SpawnItem", 3f, 2f);
    }

    private void Update()
    {
        scoreText.text = finalScore.ToString("0");
        if(timeLeft > 1f){
            timeLeft -= Time.deltaTime;
            timeLeftText.text = timeLeft.ToString("0");
        }else{
            GameOver();
        }

        scoreText.text = finalScore.ToString("0");
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

    private void GameOver(){
        Time.timeScale = 0;
        CancelInvoke("SpawnItem");
        if(finalPanel != null){
            finalPanel.SetActive(true);
        }

        finalScoreText.text = finalScore.ToString("0");
    }

    public void GoToMenu(){
        SceneManager.LoadScene("Menu");
    }

    public void ShowValue(){
        string valor = GameObject.Find("Input").GetComponent<TMP_InputField>().text;
        GameObject.Find("Output").GetComponent<TMP_Text>().text = valor;
    }
}
