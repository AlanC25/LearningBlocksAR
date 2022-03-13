using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuBtnScript : MonoBehaviour
{
    public bool additionOnlyBool;
    public bool subtractionOnlyBool;
    public bool addAndSubBool;
    public bool multiplicationOnlyBool;
    public bool divisionOnlyBool;
    public bool mulAndDivBool;

    // Start is called before the first frame update
    void Start()
    {
        additionOnlyBool = false;
        subtractionOnlyBool = false;
        addAndSubBool = false;
        multiplicationOnlyBool = false;
        divisionOnlyBool = false;
        mulAndDivBool = false;
    }

    public void menuButtonClicked(Button menuBtn)
    { 
        switch (menuBtn.name)
        {
            case "AdditionBtn":
                additionOnlyBool = true;
                subtractionOnlyBool = false;
                addAndSubBool = false;
                multiplicationOnlyBool = false;
                divisionOnlyBool = false;
                mulAndDivBool = false;
                break;

            case "SubtractionBtn":
                additionOnlyBool = false;
                subtractionOnlyBool = true;
                addAndSubBool = false;
                multiplicationOnlyBool = false;
                divisionOnlyBool = false;
                mulAndDivBool = false;
                break;

            case "AddAndSubBtn":
                additionOnlyBool = false;
                subtractionOnlyBool = false;
                addAndSubBool = true;
                multiplicationOnlyBool = false;
                divisionOnlyBool = false;
                mulAndDivBool = false;
                break;

            case "MultiplicationBtn":
                additionOnlyBool = false;
                subtractionOnlyBool = false;
                addAndSubBool = false;
                multiplicationOnlyBool = true;
                divisionOnlyBool = false;
                mulAndDivBool = false;
                break;

            case "DivisionBtn":
                additionOnlyBool = false;
                subtractionOnlyBool = false;
                addAndSubBool = false;
                multiplicationOnlyBool = false;
                divisionOnlyBool = true;
                mulAndDivBool = false;
                break;

            case "MulAndDivBtn":
                additionOnlyBool = false;
                subtractionOnlyBool = false;
                addAndSubBool = false;
                multiplicationOnlyBool = false;
                divisionOnlyBool = false;
                mulAndDivBool = true;
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
