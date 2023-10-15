using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroudController : MonoBehaviour
{
    public float speed;
    float height;
    private void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        height = spriteRenderer.size.y;
        spriteRenderer.size = new Vector2(spriteRenderer.size.x, height * 3);
    }
    void Update()
    {
        transform.position -= new Vector3(0, speed, 0);
        if (transform.position.y <= -height)
        {
            transform.position += new Vector3(0, height * 2, 0);
        }
    }
}
