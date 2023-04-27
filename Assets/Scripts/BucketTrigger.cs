using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BucketTrigger : MonoBehaviour
{
    public int score;
    public List<TMP_Text> scoreTexts;

    private void Start()
    {
        score = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody.CompareTag("Apple"))
        {
            score += 1;
            for (int i = 0; i < scoreTexts.Count; i++)
            {
                // a brutal and easy way to turn numeric to string
                scoreTexts[i].text = "" + score;
            }
            Destroy(collision.gameObject);
        }
    }
}