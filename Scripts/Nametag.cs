using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nametag : MonoBehaviour
{
    public Vector3 offset;
    public Camera cam;
    public Text nametagText;
    public string displayText;

    // Start is called before the first frame update
    void Start()
    {
        if (GameObject.Find("Main Camera").GetComponent<Camera>() != null)
        {
          cam = GameObject.Find("Main Camera").GetComponent<Camera>();
        }

        if (string.Compare(displayText, "") != 0)
        {
          nametagText.text = displayText;
        }
        else
        {
          nametagText.text = transform.parent.name;
        }
    }

    // Update is called once per frame
    void Update()
    {
      nametagText.GetComponent<RectTransform>().position = cam.WorldToScreenPoint(transform.parent.position + offset);
    }

    // use this to change the text displayed by the hovering nametag
    public void setText(string newText)
    {
      nametagText.text = newText;
    }
}
