using UnityEngine;
using UnityEngine.UI;

class PlayerOverlap : MonoBehaviour
{
    private int Count;
    public Text CountText;
    public Text WinText;

    private void Start()
    {
        Count = 12;
        CountText.text = "Apple: " + Count;
        WinText.text = "";
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pickups"))
        {
            Destroy(collision.gameObject);
            Count--;
            CountText.text = "Apple: " + Count;

            if (Count == 0)
            {
                WinText.text = "You Win!!!";
            }
        }
    }
}
