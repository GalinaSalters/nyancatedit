using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Renderer planeRenderer;
    public float scrollSpeed = 0.1f;
    private Vector2 offset;

    void Start ()
    {
        planeRenderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        offset.x -= scrollSpeed * Time.deltaTime;

        planeRenderer.material.SetTextureOffset("_BaseMap", offset);
    }
}
