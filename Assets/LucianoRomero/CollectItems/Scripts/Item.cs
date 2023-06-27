using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private float speed;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Player":
                switch (tag)
                {
                    case "Good":
                        GameManager.Instance.PlayAudioClip(0);
                        break;
                    case "Bad":
                        GameManager.Instance.PlayAudioClip(1);
                        break;
                }

                IncreaseScore();
                break;
            case "Floor":
                break;
        }

        Destroy(gameObject);
    }

    private void IncreaseScore()
    {
        GameManager.Instance.finalScore += score;
    }
}
