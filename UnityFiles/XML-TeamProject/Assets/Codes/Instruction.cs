using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruction : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("isValid")==1)
        {
            gameObject.GetComponent<UnityEngine.UI.Text>().text = "This is a Valid XML";
            gameObject.GetComponent<UnityEngine.UI.Text>().color = Color.green;

        }
        else
        {
            string error = PlayerPrefs.GetString("Error");
            gameObject.GetComponent<UnityEngine.UI.Text>().text = $"This is not a Valid XML , {error}";
            gameObject.GetComponent<UnityEngine.UI.Text>().color = Color.red;

        }
    }
}
