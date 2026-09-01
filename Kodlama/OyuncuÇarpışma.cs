using UnityEngine;

public class OyuncuÇarpışma : MonoBehaviour
{
    public OyuncuHareketi hareket;

    void OnCollisionEnter(Collision çarpişma)
    {
        if (çarpişma.collider.tag == "Engel")
        {
            hareket.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
