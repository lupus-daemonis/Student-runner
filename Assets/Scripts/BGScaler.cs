using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScaler : MonoBehaviour
{
    void Start()
    {
        float height = Camera.main.orthographicSize * 2f;
        float width = height * Screen.width / Screen.height;

        transform.localScale = new Vector3(width, height, 0);

        if (gameObject.name == "Background")
        {
            transform.localScale = new Vector3(width, height, 0);
        }
        else
            transform.localScale = new Vector3(width+3f, 2, 0);
        
    }
}
