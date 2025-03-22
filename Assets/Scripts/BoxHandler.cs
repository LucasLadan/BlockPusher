using UnityEditor.PackageManager;
using UnityEngine;

public class BoxHandler : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameObject.tag = "Box";
    }

    public bool MoveBox(Vector2 movement)
    {

        bool moved = false;
        RaycastHit2D hitInfo;

        if (movement.x != 0)
        {
            if (movement.x > 0)
            {
                if (!Physics2D.Raycast((Vector2)transform.position, new Vector2(1, 0), 1f, LayerMask.GetMask("Collider")))
                {
                    moved = true;
                    gameObject.transform.position += new Vector3(1, 0, 0);
                }
            }
            else
            {
                if (!Physics2D.Raycast((Vector2)transform.position, new Vector2(-1, 0), 1f, LayerMask.GetMask("Collider")))
                {
                    moved = true;
                    gameObject.transform.position += new Vector3(-1, 0, 0);
                }
            }
        }

        else if (movement.y != 0)
        {
            if (movement.y > 0)
            {
                if (!Physics2D.Raycast((Vector2)transform.position, new Vector2(0, 1), 1f, LayerMask.GetMask("Collider")))
                {
                    moved = true;
                    gameObject.transform.position += new Vector3(0, 1, 0);
                }
            }
            else
            {
                if (!Physics2D.Raycast((Vector2)transform.position, new Vector2(0, -1), 1f, LayerMask.GetMask("Collider")))
                {
                    moved = true;
                    gameObject.transform.position += new Vector3(0, -1, 0);
                }
            }
        }

        return moved;
    }
}
