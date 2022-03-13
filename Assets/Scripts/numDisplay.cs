using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Vuforia;

public class numDisplay : MonoBehaviour //IVirtualButtonEventHandler
{
    int n1, n2, sumRemainder;
    public static int sum;
    int userAnswer;
    public TextMeshPro n1Text, operatorText, n2Text, sumText;

    // Start is called before the first frame update
    void Start()
    {
        n1Text = n1Text.GetComponent<TextMeshPro>();
        n2Text = n2Text.GetComponent<TextMeshPro>();
        operatorText = operatorText.GetComponent<TextMeshPro>();
        sumText = sumText.GetComponent<TextMeshPro>();
    }

    public void additionSum()
    {
        n1 = Random.Range(0, 50);
        n1Text.text = n1.ToString();

        n2 = Random.Range(0, 50);
        n2Text.text = n2.ToString();

        operatorText.text = ("+");
        sum = n1 + n2;
        sumText.text = sum.ToString();// displays sum number, remove this and replace and display userAnswer.text and checkSum.

        if (!(sum is int) || (sum < 1 || sum > 100))
        {
            additionSum();
        }
    }

    public void subtractionSum()
    {
        n1 = Random.Range(0, 50);
        n1Text.text = n1.ToString();

        n2 = Random.Range(0, 50);
        n2Text.text = n2.ToString();

        operatorText.text = ("-");
        sum = n1 - n2;
        sumText.text = sum.ToString();// displays sum number, remove this and replace and display userAnswer.text and checkSum.

        if (!(sum is int) || (sum < 1 || sum > 100))
        {
            subtractionSum();
        }
    }

    public void addOrSubSum()
    {
        bool cointoss = (Random.value > 0.5f);

        if (cointoss)
        {
            n1 = Random.Range(0, 50);
            n1Text.text = n1.ToString();

            n2 = Random.Range(0, 50);
            n2Text.text = n2.ToString();
            operatorText.text = ("+");
            sum = n1 + n2;

            if (!(sum is int) || (sum < 1 || sum > 100))
            {
                additionSum();
            }
        }
        else if (!cointoss)
        {
            n1 = Random.Range(0, 50);
            n1Text.text = n1.ToString();

            n2 = Random.Range(0, n1);
            n2Text.text = n2.ToString();
            operatorText.text = ("-");
            sum = n1 - n2;

            if (!(sum is int) || (sum < 1 || sum > 100))
            {
                subtractionSum();
            }
        }
        sumText.text = sum.ToString();// displays sum number, remove this and replace and display userAnswer.text and checkSum.
    }

    public void multiplicationSum()
    {
        n1 = Random.Range(1, 20);
        n1Text.text = n1.ToString();

        n2 = Random.Range(1, 20);
        n2Text.text = n2.ToString();

        operatorText.text = ("x");
        sum = n1 * n2;
        sumText.text = sum.ToString();// displays sum number, remove this and replace and display userAnswer.text and checkSum.

        if (!(sum is int) || (sum < 1 || sum > 100))
        {
            multiplicationSum();
        }
    }

    public void divisionSum()
    {
        n1 = Random.Range(1, 50);
        n1Text.text = n1.ToString();

        n2 = Random.Range(1, n1);
        n2Text.text = n2.ToString();

        operatorText.text = ("/");
        sum = n1 / n2;
        sumRemainder = n1 % n2;

        if (sumRemainder != 0 || (sum < 1 || sum > 100))
        {
            divisionSum();
        }
        sumText.text = sum.ToString();// displays sum number, remove this and replace and display userAnswer.text and checkSum.
    }

    public void mulOrDivSum()
    {
        bool cointoss = (Random.value > 0.5f);

        if (cointoss)
        {
            n1 = Random.Range(1, 50);
            n1Text.text = n1.ToString();

            n2 = Random.Range(1, 50);
            n2Text.text = n2.ToString();
            operatorText.text = ("x");
            sum = n1 * n2;

            if (!(sum is int) || (sum < 1 || sum > 100))
            {
                multiplicationSum();
            }
        }
        else if (!cointoss)
        {
            n1 = Random.Range(1, 50);
            n1Text.text = n1.ToString();

            n2 = Random.Range(1, n1);
            n2Text.text = n2.ToString();
            operatorText.text = ("/");
            sum = n1 / n2;
            sumRemainder = n1 % n2;

            if (sumRemainder != 0 || (sum < 1 || sum > 100))
            {
                divisionSum();
            }
        }
        sumText.text = sum.ToString();// displays sum number, remove this and replace and display userAnswer.text and checkSum.
    }

    public void checkAnswer()
    {
        if (sum == userAnswer)
        {
            //Debug.Log("Well done"); // Create UI overlay
        }
    }

    // Update is called once per frame
    void Update()
    {
        checkAnswer();
    }


}
