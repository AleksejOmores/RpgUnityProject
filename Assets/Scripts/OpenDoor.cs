using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animator doorAnimator;
    public string playerTag = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(playerTag))
        {
            doorAnimator.SetBool("isOpen", true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(playerTag))
        {
            doorAnimator.SetBool("isOpen", false);
        }
    }
}
