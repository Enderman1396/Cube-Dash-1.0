using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Skor : MonoBehaviour
{
    public Transform oyuncu;
    public TextMeshProUGUI skorText;
    public TextMeshProUGUI YuksekSkor;

    // Update is called once per frame
    void Update()
    {
        skorText.text = oyuncu.position.z.ToString("0");

        YuksekSkor.text = PlayerPrefs.GetFloat("YuksekSkor", 0).ToString("0");

        if (oyuncu.position.z > PlayerPrefs.GetFloat("YuksekSkor", 0))
        {
            PlayerPrefs.SetFloat("YuksekSkor", oyuncu.position.z);
        }
    }
}
