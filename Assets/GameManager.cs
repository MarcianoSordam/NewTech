using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int count = -1;
    public GameObject cube;
    public GameObject sphere;
    public GameObject cylinder;
    public GameObject environment;
    public GameObject stand;
    public GameObject wirecubestand;
    public ParticleSystem LFeel;
    public ParticleSystem RFeel;
    public GameObject BeOne;
    public ParticleSystem happyparticle;
    public ParticleSystem betterplace;
    public GameObject musicNote;
    public GameObject heart;
    public GameObject movebase;
    public Vector3 MoveTarget;
    public GameObject Road1, road2;
    public GameObject Wheelchair;
    public GameObject sittingOne;
    public AudioSource AU0, AU1, AU2, AU3, AU4, AU5, AU6, AU7, AU8, AU9, AU10, AU11, AU12, AU13, AU14, AU15, AU16, AU17, AU18, AU19, AU41, AU42;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("v"))
        {
            Debug.Log("next");
            StartCoroutine(Progress());
        }
        if (Input.GetKeyDown("j"))
        {
            StartCoroutine(CheckInput(true));
        }
        if (Input.GetKeyDown("n"))
        {
            StartCoroutine(CheckInput(false));
        }
    }

    IEnumerator Progress()
    {
        count++;

        switch (count)
        {
            case 0:
                Debug.Log("0");
                AU0.Play();
                break;
            case 1:
                Debug.Log("1");
                AU1.Play();
                break;

            case 2:
                Debug.Log("2");
                AU2.Play();
                //player can click now
                environment.SetActive(true);
                break;
            case 3:
                Debug.Log("3");
                AU3.Play();
                stand.SetActive(true);
                break;
            case 4:
                Debug.Log("4");
                AU4.Play();
                //cube on
                environment.SetActive(false);
                stand.SetActive(false);
                wirecubestand.SetActive(true);
                cube.SetActive(true);
                LFeel.Play();
                RFeel.Play();
                //cube on
                break;
            case 5:
                sphere.SetActive(true);
                Debug.Log("4.2");
                cube.SetActive(false);
                AU41.Play();
                //sphere on cube off
                break;
            case 6:
                Debug.Log("4.3");
                cylinder.SetActive(true);
                sphere.SetActive(false);
                AU42.Play();
                //cylinder on sphere off
                break;
            case 7:
                cylinder.SetActive(false);
                BeOne.SetActive(true);
                Debug.Log("5");
                AU5.Play();
                break;
            case 8:
                heart.SetActive(true);
                happyparticle.Play();
                musicNote.SetActive(true);
                Debug.Log("6");
                AU6.Play();
                break;
            case 9:
                //move objects
                happyparticle.Stop();
                Debug.Log("7");
                AU7.Play();
                break;
            case 10:
                
                Debug.Log("object move");
                StartCoroutine(Movestuff());
                //move objects out of the way
                break;
            case 11:
                Debug.Log("8");
                AU8.Play();
                break;
            case 12:
                Road1.SetActive(true);
                road2.SetActive(true);
                betterplace.Play();
                Debug.Log("9");
                AU9.Play();
                break;
            case 13:
                LFeel.Stop();
                RFeel.Stop();
                wirecubestand.SetActive(false);
                BeOne.SetActive(false);
                musicNote.SetActive(false);
                road2.SetActive(false);
                Road1.SetActive(false);
                musicNote.SetActive(false);
                heart.SetActive(false);
                betterplace.Stop();
                Debug.Log("10");
                AU10.Play();
                break;
            case 14:
                Debug.Log("11");
                AU11.Play();
                break;
            case 15:
                Debug.Log("12");
                AU12.Play();
                road2.SetActive(true);
                Road1.SetActive(true);
                break;
            case 16:
                Debug.Log("13");
                AU13.Play();
                RFeel.Play();
                LFeel.Play();
                road2.SetActive(false);
                Road1.SetActive(false);
                break;
            case 17:
                Debug.Log("14");
                AU14.Play();
                RFeel.Stop();
                LFeel.Stop();
                betterplace.Play();
                break;
            case 18:
                Debug.Log("15");
                AU15.Play();
                Wheelchair.SetActive(true);
                break;
            case 19:
                Debug.Log("16");
                AU16.Play();
                betterplace.Stop();
                Wheelchair.SetActive(false);
                sittingOne.SetActive(true);
                break;
            case 20:
                Debug.Log("17");
                AU17.Play();
                sittingOne.SetActive(false);
                break;
            case 21:
                Debug.Log("18");
                AU18.Play();
                happyparticle.Play();
                break;
            case 22:
                Debug.Log("19");
                AU19.Play();
                break;
            case 23:
                Debug.Log("20");
                //text 20
                break;



        }


        yield return new WaitForEndOfFrame();
    }

    IEnumerator CheckInput(bool answer)
    {
        switch (count)
        {
            case 2:
                if (answer == true)
                {
                    Debug.Log("2.1");
                    //text 2.1
                }
                else
                {
                    Debug.Log("2.2");
                    //text 2.2
                }
                break;
            case 3:
                if (answer == true)
                {
                    Debug.Log("3.1");
                    //text 3.1
                }
                else
                {
                    Debug.Log("3.2");
                    //text 3.2
                }
                break;
            case 4:
                if(answer == true)
                {
                    Debug.Log("4.5");
                    //text 4.5
                }
                else
                {
                    //text 4.6
                    Debug.Log("4.6");
                }
                break;
            case 5:
                if (answer == true)
                {
                    Debug.Log("4.5");
                    //text 4.5
                }
                else
                {
                    //text 4.6
                    Debug.Log("4.6");
                }
                break;
            case 6:
                if (answer == true)
                {
                    Debug.Log("4.4");
                    //text 4.4
                }
                else
                {
                    //text 4.6
                    Debug.Log("4.6");
                }
                break;
            case 12:
                if (answer == true)
                {
                    //text 9.1 
                    Debug.Log("9.1");
                }
                else
                {
                    //text 9.2
                    Debug.Log("9.2");
                }
                break;
            case 17:
                if (answer == true)
                {
                    //text 14.1
                    Debug.Log("14.1");

                }
                else
                {
                    //text 14.2
                    Debug.Log("14.2");
                }
                break;
            case 19:
                if (answer == true)
                {
                    //text 16.1
                    Debug.Log("16.1");
                    sittingOne.SetActive(false);
                }
                else
                {
                    sittingOne.SetActive(false);
                    //text 16.2
                    Debug.Log("16.2");
                }
                break;
            default:
                Debug.Log("no question");
                break;
        }
        yield return new WaitForEndOfFrame();
    }

    IEnumerator Movestuff()
    {
        movebase.transform.position = MoveTarget;
        yield return new WaitForEndOfFrame();
    }
}
