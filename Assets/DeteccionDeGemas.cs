using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeteccionDeGemas : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI txtScore;

    // Start is called before the first frame update
    void Start()
    {
        txtScore.text = 0.ToString(); ;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Gema")
        {
            score++;
            txtScore.text = score.ToString();
        }
    }
}
