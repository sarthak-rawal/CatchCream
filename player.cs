using UnityEngine;

public class player: MonoBehaviour
{
    public float moveSpeed = 10f;
    private Vector2 direction;

    private void Update()
    {
        direction = Vector2.zero;

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.position.x < Screen.width / 2)
            {
                direction += Vector2.left;
            }
            else
            {
                direction += Vector2.right;
            }
        }

        transform.position = new Vector2
        (
            transform.position.x + direction.x * moveSpeed * Time.deltaTime,
            transform.position.y + direction.y * moveSpeed * Time.deltaTime
        );
    }
}
