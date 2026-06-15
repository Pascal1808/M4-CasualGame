using UnityEngine;
using TMPro;

public class Obstacle : MonoBehaviour
{
    private TextMeshProUGUI PointsText;
    public int linesToGive = 1; 
    void Start()
    {
        
    }

    void Update()
    {
       PointsText = GameObject.Find("Points").GetComponent<TextMeshProUGUI>(); 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Die();
        }
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);  
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            PointsText.text = (int.Parse(PointsText.text) + linesToGive).ToString();
        }
    }
    private void Die()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}
