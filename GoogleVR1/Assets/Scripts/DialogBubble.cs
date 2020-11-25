using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogBubble : MonoBehaviour
{

    public string dialogText;
    public TextMeshProUGUI txtDialogeBubble;
    public GameObject dialogBubble;

    // Start is called before the first frame update
    void Start()
    {
        txtDialogeBubble.text = dialogText;
        Pointer_Exit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pointer_Enter()
    {
        dialogBubble.SetActive(true);

    }


    public void Pointer_Exit()
    {
        dialogBubble.SetActive(false);
    }
}
