using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class player : MonoBehaviour
{
    public float inc;
    public int minpos;
    public int maxpos;
    public AudioSource src;

    void Start()
    {
        print("i am 3d editor i dont think no one will believe me that i make this charctar from blender i work for this charctar for 3 hours and thx ");  
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }
   void move ()
    {
       if (Input .GetKeyDown (KeyCode.A ))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x - inc, minpos, maxpos), transform.position.y, transform.position.z);

        }
       else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x + inc, minpos, maxpos), transform.position.y, transform.position.z);
                }


    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {

            Invoke("Restart", 1f);
            src.Play();
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(0);


    }

}
