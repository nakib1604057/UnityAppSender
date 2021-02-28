using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetInputOnClick : MonoBehaviour
{
    public Button btnClick;
    public InputField inputUser;
    // Start is called before the first frame update
    void Start()
    {
        btnClick.onClick.AddListener(GetInputOnClickHandler);
    }

    // Update is called once per frame
    void Update()
    {
         
    }
      public void GetInputOnClickHandler(){
        Debug.Log("Log Inout" + inputUser.text);
        PluginTest.Instance.SendDataToPocket(inputUser.text);
    }
}
