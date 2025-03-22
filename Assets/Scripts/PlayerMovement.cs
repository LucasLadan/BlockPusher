using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private bool isGhost;
    private void OnMove(InputValue inputMove)
    {

        Vector2 movement = inputMove.Get<Vector2>();

        RaycastHit2D hitInfo;


        if (movement.x != 0)
        {
            if (movement.x > 0)
            {
                if (hitInfo =  Physics2D.Raycast((Vector2)transform.position, new Vector2(1, 0),1f,LayerMask.GetMask("Collider")))
                {
                    if (isGhost)
                    {
                        if (hitInfo.collider.gameObject.CompareTag("Pit"))
                        {
                            gameObject.transform.position += new Vector3(1, 0, 0);
                        }
                    }
                    else
                    {
                        if (hitInfo.collider.gameObject.GetComponent<BoxHandler>())
                        {
                            if (hitInfo.collider.gameObject.GetComponent<BoxHandler>().MoveBox(movement))
                            {
                                gameObject.transform.position += new Vector3(1, 0, 0);
                            }
                        }
                    }
                }
                else
                {
                    gameObject.transform.position += new Vector3(1, 0, 0);
                }
            }
            else
            {
                if (hitInfo = Physics2D.Raycast((Vector2)transform.position, new Vector2(-1,0), 1f,LayerMask.GetMask("Collider")))
                {
                    if (isGhost)
                    {
                        if (hitInfo.collider.gameObject.CompareTag("Pit"))
                        {
                            gameObject.transform.position += new Vector3(-1, 0, 0);
                        }

                    }
                    else
                    {
                        if (hitInfo.collider.gameObject.GetComponent<BoxHandler>())
                        {
                            if (hitInfo.collider.gameObject.GetComponent<BoxHandler>().MoveBox(movement))
                            {
                                gameObject.transform.position += new Vector3(-1, 0, 0);
                            }
                        }
                    }
                }
                else
                {
                    gameObject.transform.position += new Vector3(-1, 0, 0);
                }
            }
        }

        else if (movement.y != 0)
        {
            if (movement.y > 0)
            {
                if (hitInfo = Physics2D.Raycast((Vector2)transform.position, new Vector2(0, 1),1f, LayerMask.GetMask("Collider")))
                {
                    if (isGhost)
                    {
                        if (hitInfo.collider.gameObject.CompareTag("Pit"))
                        {
                            gameObject.transform.position += new Vector3(0, 1, 0);
                        }
                    }
                    else
                    {
                        if (hitInfo.collider.gameObject.GetComponent<BoxHandler>())
                        {
                            if (hitInfo.collider.gameObject.GetComponent<BoxHandler>().MoveBox(movement))
                            {
                                gameObject.transform.position += new Vector3(0, 1, 0);
                            }
                        }
                    }
                }
                else
                {
                    gameObject.transform.position += new Vector3(0,1, 0);
                }
            }
            else
            {
                if (hitInfo = Physics2D.Raycast((Vector2)transform.position, new Vector2(0, -1),1f, LayerMask.GetMask("Collider")))
                {
                    if (isGhost)
                    {
                        if (hitInfo.collider.gameObject.CompareTag("Pit"))
                        {
                            gameObject.transform.position += new Vector3(0, -1, 0);
                        }
                    }
                    else
                    {
                        if (hitInfo.collider.gameObject.GetComponent<BoxHandler>())
                        {
                            if (hitInfo.collider.gameObject.GetComponent<BoxHandler>().MoveBox(movement))
                            {
                                gameObject.transform.position += new Vector3(0, -1, 0);
                            }
                        }
                    }
                }
                else
                {
                    gameObject.transform.position += new Vector3(0,-1, 0);
                }
            }
        }

    }
}
