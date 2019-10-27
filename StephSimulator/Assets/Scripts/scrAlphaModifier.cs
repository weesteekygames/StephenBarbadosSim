using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrAlphaModifier : MonoBehaviour
{
    public float alpha;

    // Start is called before the first frame update
    void Start()
    {
        Color tmp = this.GetComponent<SpriteRenderer>().color;
        tmp.a = alpha;
        this.GetComponent<SpriteRenderer>().color = tmp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
