using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spriteSize : MonoBehaviour
{
    public Sprite Bigm;
    public GameObject sm;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            sm.GetComponent<SpriteRenderer>().sprite = Bigm;
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
