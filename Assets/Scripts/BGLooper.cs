using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGLooper : MonoBehaviour
{
    public float speed = 0.3f;
    public float changeSpeed = 0.005f;

    private Material mat;
    private Vector2 offset = Vector2.zero;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
        offset = mat.GetTextureOffset("_MainTex");
        
    }

    void Update()
    {
        speed += Time.deltaTime * changeSpeed;
        offset.x = offset.x + speed * Time.deltaTime;
        mat.SetTextureOffset("_MainTex", offset);
    }
}
