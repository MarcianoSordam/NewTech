using UnityEngine;
using System.Collections;

public class sound_sonar : MonoBehaviour
{
    public GameObject sonar;
    public bool automatic = false;
    public bool PulseWait = false;

    private void Update()
    {
        if (Input.GetKeyDown("x"))
        {
            Debug.Log("x");
            GameObject Sonarscan = Instantiate(sonar, transform.position, transform.rotation);
        }

        if (automatic == true & PulseWait == false)
        {
            StartCoroutine(autopulse());
        }
    }

    IEnumerator autopulse()
    {
        PulseWait = true;
        GameObject Sonarscan = Instantiate(sonar, transform.position, transform.rotation);
        yield return new WaitForSeconds(10);
        PulseWait = false;
    }

}
