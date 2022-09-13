using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketMvt : MonoBehaviour
{
    public float speed=150;
    public static int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;

    }
}
