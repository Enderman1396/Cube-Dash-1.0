using UnityEngine;

public class KameraTakibi : MonoBehaviour
{
    public Transform oyuncu;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = oyuncu.position + offset;
    }
}
