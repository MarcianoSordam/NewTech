using UnityEngine;
using System.Collections;

public class self_destroy : MonoBehaviour
{
    public float lifetime = 10;

    private void Awake()
    {
        StartCoroutine(selfdestroy());
    }



    IEnumerator selfdestroy()
    {
        yield return new WaitForSeconds(lifetime);
        Destroy(gameObject);

    }
}
