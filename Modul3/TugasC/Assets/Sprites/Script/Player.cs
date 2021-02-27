using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
 private PlayerInventoryDisplay playerInventoryDisplay;
 private int totalStars = 0;
 void Start()
 {
 playerInventoryDisplay = GetComponent < PlayerInventoryDisplay >
();
 }
 void OnTriggerEnter2D(Collider2D hit)
 {
 if (hit.CompareTag("Fish"))
 {
 totalStars++;
 playerInventoryDisplay.OnChangeStarTotal(totalStars);
 Destroy(hit.gameObject);
 }
 }
}