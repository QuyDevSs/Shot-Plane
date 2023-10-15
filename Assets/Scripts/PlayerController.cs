using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : PlaneController
{
    public JoyStickController joyStick;
    Camera mainCamera;
    float minX, maxX, minY, maxY;
    void Start()
    {
        mainCamera = Camera.main;

        float playerHalfWidth = transform.localScale.x / 2f;
        float playerHalfHeight = transform.localScale.y / 2f;

        minX = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).x + playerHalfWidth;
        maxX = mainCamera.ViewportToWorldPoint(new Vector3(1, 0, 0)).x - playerHalfWidth;
        minY = mainCamera.ViewportToWorldPoint(new Vector3(0, 0, 0)).y + playerHalfHeight;
        maxY = mainCamera.ViewportToWorldPoint(new Vector3(0, 1, 0)).y - playerHalfHeight;
    }

    void Update()
    {
        if (joyStick.Direction != Vector3.zero)
        {
            //transform.up = joyStick.Direction;
            Move(joyStick.Direction);
            Vector3 currentPosition = transform.position;

            // Giới hạn vị trí player trong màn hình
            currentPosition.x = Mathf.Clamp(currentPosition.x, minX, maxX);
            currentPosition.y = Mathf.Clamp(currentPosition.y, minY, maxY);

            // Cập nhật vị trí của player
            transform.position = currentPosition;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
}
