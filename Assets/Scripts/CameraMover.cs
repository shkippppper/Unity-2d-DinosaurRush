using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public Camera thisCamera;
    Color blackColour = Color.black;
    Color whiteColour = Color.white;


    private void Start()
    {
        thisCamera = GetComponent<Camera>();
        NewGame();
    }

    public void NewGame()
    {
        print("startedinvokes");
        Invoke(nameof(randomFunctionPicker), 2);
        Invoke(nameof(randomColorPicker), 8);


    }



    public void randomFunctionPicker()
    {
        System.Random funcRandomizer = new System.Random();
        int funcToChoose = funcRandomizer.Next(8);

        switch (funcToChoose)
        {
            case 0:
                StartCoroutine(Flip180());

                break;
            case 1:
                StartCoroutine(MoveCameraLeft());

                break;
            case 2:
                StartCoroutine(Flip360());

                break;
            case 3:
                StartCoroutine(SizeCameraRandom());

                break;
            case 4:
                StartCoroutine(MoveUp());

                break;
            case 5:
                StartCoroutine(FlipRandom());

                break;
            case 6:
                StartCoroutine(FlipRandom());

                break;
            case 7:
                StartCoroutine(FlipRandom());

                break;
        }
        Invoke(nameof(randomFunctionPicker), 10);
    }

    public void randomColorPicker()
    {
        System.Random randomizer = new System.Random();
        int colorfuncToChoose = randomizer.Next(3);
        switch (colorfuncToChoose)
        {
            case 0:
                StartCoroutine(DayMode());

                break;
            case 1:
                StartCoroutine(DawnMode());

                break;
            case 2:
                StartCoroutine(NightMode());

                break;
        }
        Invoke(nameof(randomColorPicker), 27);

    }

    IEnumerator Flip180()
    {
        for (float spinner = 0; spinner<=180.1; spinner+=1f)
        {   
            this.transform.localRotation = Quaternion.Euler(0, 0, spinner);
            yield return null;
        }
        for (float delay =0; delay <=500; delay += 1f)
        {
            yield return null;
        }
        for (float spinner = 180; spinner >= 0; spinner -= 1f)
        {
            this.transform.localRotation = Quaternion.Euler(0, 0, spinner);
            yield return null;
        }

    }

    IEnumerator FlipRandom()
    {
        float random = Random.Range(40, 320);

        for (float spinner = 0; spinner <= random; spinner += 1f)
        {
            this.transform.localRotation = Quaternion.Euler(0, 0, spinner);
            yield return null;
        }
        for (float delay = 0; delay <= 500; delay += 1f)
        {
            yield return null;
        }
        for (float spinner = random; spinner >= 0; spinner -= 1f)
        {
            this.transform.localRotation = Quaternion.Euler(0, 0, spinner);
            yield return null;
        }

    }

    IEnumerator Flip360()
    {
        //float random = Random.Range(40, 320);

        for (float spinner = 0; spinner <= 360; spinner += 1f)
        {
            this.transform.localRotation = Quaternion.Euler(0, 0, spinner);
            yield return null;
        }
        for (float delay = 0; delay <= 500; delay += 1f)
        {
            yield return null;
        }
        for (float spinner = 360; spinner >= 0; spinner -= 1f)
        {
            this.transform.localRotation = Quaternion.Euler(0, 0, spinner);
            yield return null;
        }

    }

    IEnumerator SizeCameraRandom()
    {
        float random = Random.Range(4.8f, 5.5f);

        for (float spinner = 4; spinner <= random; spinner += 0.5f)
        {
            thisCamera.orthographicSize = spinner;
            yield return null;
        }
        for (float delay = 0; delay <= 500; delay += 1f)
        {
            yield return null;
        }
        for (float spinner = random; spinner >= 4; spinner -= 0.5f)
        {
            thisCamera.orthographicSize = spinner;
            yield return null;
        }

    }

    IEnumerator MoveUp()
    {
        float random = Random.Range(10, 20);

        for (float spinner = 0; spinner <= random; spinner += 0.5f)
        {
            this.transform.localRotation = Quaternion.Euler(spinner, 0, 0);
            yield return null;
        }
        for (float delay = 0; delay <= 500; delay += 1f)
        {
            yield return null;
        }
        for (float spinner = random; spinner >= 0; spinner -= 0.5f)
        {
            this.transform.localRotation = Quaternion.Euler(spinner, 0, 0);
            yield return null;
        }

    }

    IEnumerator MoveCameraLeft()
    {
        float random = Random.Range(-2, -5);

        for (float spinner = 0; spinner >= random; spinner -= 0.3f)
        {
            this.transform.position = new Vector3(spinner, 2, -10);
            yield return null;
        }
        for (float delay = 0; delay <= 500; delay += 1f)
        {
            yield return null;
        }
        for (float spinner = random; spinner <= 0; spinner += 0.3f)
        {
            this.transform.position = new Vector3(spinner, 2, -10);
            yield return null;
        }

    }

    IEnumerator NightMode()
    {

        for (float spinner = 1; spinner >= 0; spinner -= 0.01f)
        {
            whiteColour.r = spinner;
            whiteColour.g = spinner;
            whiteColour.b = spinner;
            thisCamera.backgroundColor = whiteColour;
            yield return null;
        }

        for (float delay = 0; delay <= 3000; delay += 1f)
        {
            yield return null;
        }

        for (float spinner = 0; spinner <= 1; spinner += 0.01f)
        {
            blackColour.r = spinner;
            blackColour.g = spinner;
            blackColour.b = spinner;
            thisCamera.backgroundColor = blackColour;
            yield return null;
        }

    }


    IEnumerator DayMode()
    {

        for (float spinner = 1; spinner >= 0; spinner -= 0.01f)
        {
            whiteColour.r = spinner+0.5f;
            whiteColour.g = spinner;
            whiteColour.b = spinner;
            thisCamera.backgroundColor = whiteColour;
            yield return null;
        }

        for (float delay = 0; delay <= 3000; delay += 1f)
        {
            yield return null;
        }

        for (float spinner = 0; spinner <= 1; spinner += 0.01f)
        {
            blackColour.r = spinner+0.5f;
            blackColour.g = spinner;
            blackColour.b = spinner;
            thisCamera.backgroundColor = blackColour;
            yield return null;
        }

    }

    IEnumerator DawnMode()
    {

        for (float spinner = 1; spinner >= 0; spinner -= 0.01f)
        {
            whiteColour.r = spinner;
            whiteColour.g = spinner;
            whiteColour.b = spinner + 0.4f;
            thisCamera.backgroundColor = whiteColour;
            yield return null;
        }

        for (float delay = 0; delay <= 3000; delay += 1f)
        {
            yield return null;
        }

        for (float spinner = 0; spinner <= 1; spinner += 0.01f)
        {
            blackColour.r = spinner;
            blackColour.g = spinner;
            blackColour.b = spinner + 0.4f;
            thisCamera.backgroundColor = blackColour;
            yield return null;
        }

    }

}
