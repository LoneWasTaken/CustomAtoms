using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtomsManager : MonoBehaviour
{

    public GameObject[] atomsArray;

    public GameObject[] atomImageArray;

    private GameObject lastCreatedAtom;

    public GameObject lastShownImage;

    public Text inputText;

    public GameObject errorText;

    public float num1;

    public float num2 = 5;

    public bool bool1;

    // Start is called before the first frame update
    void Start()
    {
        num1 = num2;
    }

    // Update is called once per frame
    void Update()
    {
        string inputString = inputText.text.ToLower();

        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Destroy(lastCreatedAtom);


            switch (inputString)
            {
                case "hydrogen":
                    lastShownImage.SetActive(false);
                    lastCreatedAtom = Instantiate(atomsArray[0]);
                    lastShownImage = atomImageArray[0];
                    lastShownImage.SetActive(true);
                    break;
                case "helium":
                    lastShownImage.SetActive(false);
                    lastCreatedAtom = Instantiate(atomsArray[1]);
                    lastShownImage = atomImageArray[1];
                    lastShownImage.SetActive(true);
                    break;
                case "lithium":
                    lastShownImage.SetActive(false);
                    lastCreatedAtom = Instantiate(atomsArray[2]);
                    lastShownImage = atomImageArray[2];
                    lastShownImage.SetActive(true);
                    break;
                case "carbon":
                    lastShownImage.SetActive(false);
                    lastCreatedAtom = Instantiate(atomsArray[3]);
                    lastShownImage = atomImageArray[3];
                    lastShownImage.SetActive(true);
                    break;
                case "oxygen":
                    lastShownImage.SetActive(false);
                    lastCreatedAtom = Instantiate(atomsArray[4]);
                    lastShownImage = atomImageArray[4];
                    lastShownImage.SetActive(true);
                    break;
                case "neon":
                    lastShownImage.SetActive(false);
                    lastCreatedAtom = Instantiate(atomsArray[5]);
                    lastShownImage = atomImageArray[5];
                    lastShownImage.SetActive(true);
                    break;
                default:
                    bool1 = true;
                    break;
            }
        }
        if(bool1 == true)
        {
            ErrorTimer();
        }
    }

    void ErrorTimer()
    {
        errorText.SetActive(true);
        num1 -= 5 * Time.deltaTime;
        if (num1 <= 0)
        {
            errorText.SetActive(false);
            num1 = num2;
            bool1 = false;
        }
    }
}
