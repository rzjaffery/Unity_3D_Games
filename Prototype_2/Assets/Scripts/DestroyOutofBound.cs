using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBound : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject != null)
        {
            if (transform.position.z > topBound)
            {
                DontDestroyOnLoad(gameObject);
            }
            else if (transform.position.z < lowerBound)
            {
                Debug.Log("Game Over !");
                DontDestroyOnLoad(gameObject);
            }
        }
        
    }
}
