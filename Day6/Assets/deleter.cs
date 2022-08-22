using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class deleter : MonoBehaviour
{
    public int score;
    public Text text1;
    

    public GameObject Enemy;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            score += 1;
            text1.text = score.ToString();
            Destroy(collision.gameObject);

        }

    }
}
