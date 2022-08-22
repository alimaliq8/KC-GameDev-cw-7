using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class spowner : MonoBehaviour
{
    public Transform leftpos;
    public Transform rightpos;
    public Transform midpos;

    public GameObject Enemy;

    public float delay;

    void Start()
    {
        InvokeRepeating("spawn", 1f, delay);
    }

    
    void Update()
    {
        
    }

    void spawn()
    {
        int randompos = Random.Range(1, 4);
        if (randompos ==1)
        {
            Instantiate(Enemy, midpos);
        
        }
        else if (randompos == 2)
        {
            Instantiate(Enemy, leftpos);
        }
        else
        {
            Instantiate(Enemy, rightpos);
        }

    }



 
}
