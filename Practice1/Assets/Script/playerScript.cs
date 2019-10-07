using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{  
    private float startPos;
    private float endPos;
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition.x;
        } else if (Input.GetMouseButtonUp(0))
        {
            endPos = Input.mousePosition.x;
            speed = (endPos - startPos) / 500.0f;
        }

        this.transform.Translate(speed, 0.0f, 0.0f);
        speed *= 0.98f;
    }
}
