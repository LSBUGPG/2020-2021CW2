using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Keyboard : MonoBehaviour
{
    public string wordTry = "";
    public bool inputTime = true;
    public Text inputBox;
    public bool continuouslyDisplayed = false;
    public bool displayOnReturn = false;

    // Start is called before the first frame update
    void Start()
    {

    }    // Update is called once per frame

    void Update()
    {
        if (inputTime)
        {


            if (Input.GetKeyDown(KeyCode.A))
            {
                wordTry += "a";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.B))
            {

                wordTry += "b";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.C))
            {

                wordTry += "c";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.D))
            {

                wordTry += "d";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.E))
            {

                wordTry += "e";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.F))
            {

                wordTry += "f";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.G))
            {

                wordTry += "g";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.H))
            {

                wordTry += "h";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.I))
            {

                wordTry += "i";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.J))
            {

                wordTry += "j";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.K))
            {

                wordTry += "k";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.L))
            {

                wordTry += "l";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.M))
            {

                wordTry += "m";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.N))
            {

                wordTry += "n";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.O))
            {

                wordTry += "o";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.P))
            {

                wordTry += "p";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {

                wordTry += "q";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.R))
            {

                wordTry += "r";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.S))
            {

                wordTry += "s";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.T))
            {

                wordTry += "t";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.U))
            {

                wordTry += "u";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.V))
            {

                wordTry += "v";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.W))
            {

                wordTry += "w";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.X))
            {

                wordTry += "x";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.Y))
            {

                wordTry += "y";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.Z))
            {

                wordTry += "z";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {

                wordTry += " ";
                Debug.Log(wordTry);

                if (continuouslyDisplayed)
                { inputBox.text = wordTry; }
            }

            if (Input.GetKeyDown(KeyCode.Backspace))
            {
                wordTry = "";
                Debug.Log(wordTry);

                if (continuouslyDisplayed )
                { inputBox.text = wordTry; }
            }


            /* if (Input.GetKeyDown(KeyCode.Return))
             {
                  if (displayOnReturn && !continuouslyDisplayed)
                   { inputBox.text = WordOutput(); }
                   
             } */
            // You can call the WordOutput function in this script or from another one or from a button
        }
                
    }

    public string WordOutput()
    {
         return wordTry; 

    }
}