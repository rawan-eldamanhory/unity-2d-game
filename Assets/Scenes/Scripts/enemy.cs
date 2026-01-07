using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Transform lblock;
    public Transform rblock;
    public float speed = 3;
    public bool ismovingright = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ismovingright)
        {
            transform.position = Vector2.MoveTowards(transform.position, rblock.position, speed * Time.deltaTime);
            if(transform.position == rblock.position )
            {
                ismovingright = false;
            }
        }
        else
        {
            transform.position = Vector2.MoveTowards(transform.position, lblock.position, speed * Time.deltaTime);
            if (transform.position == lblock.position)
            {
                ismovingright = true;
            }
        }
    }
}
