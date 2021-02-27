using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ArrangeActions : MonoBehaviour
{
    // Start is called before the first frame update
    private RectTransform panelRectTransform;

    void Start()
    {
        panelRectTransform = GetComponent<RectTransform>();
    }
    public void MoveDownOne(){
    	print("(before change)" + gameObject.name + "sibling index" = + panelRectTransform.GetSiblingIndex());
    	int currentSiblingIndex =
    	panelRectTransform.GetSiblingIndex();
    	panelRectTransform.GetSiblingIndex(currentSiblingIndex - 1);
    	print("(after change " + gameObject.name + " sibling index = " + panelRectTransform.GetSiblingIndex());
    }

    public void MoveUpOne(){
    	print("(before change)" + gameObject.name + "sibling index" = + panelRectTransform.GetSiblingIndex());
    	int currentSiblingIndex =
    	panelRectTransform.GetSiblingIndex();
    	panelRectTransform.GetSiblingIndex(currentSiblingIndex + 1);
    	print("(after change " + gameObject.name + " sibling index = " + panelRectTransform.GetSiblingIndex());
    }


}
