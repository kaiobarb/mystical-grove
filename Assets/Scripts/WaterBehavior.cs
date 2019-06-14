using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBehavior : MonoBehaviour
{

    Renderer rend;
    //Vector2 offset = new Vector2(0f, 0f);
    float speed = 0.05f;
    float offset = 0;
    // Start is called before the first frame update
    void Start()
    {
        rend = this.GetComponent<Renderer>();        
    }

    // Update is called once per frame
    void Update()
    {
        offset = Time.time * speed;
        rend.material.SetTextureOffset("_BaseColorMap", new Vector2(-offset, 0f));
    }
}
