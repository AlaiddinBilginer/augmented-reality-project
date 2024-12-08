using UnityEngine;

public class ToggleVisibility : MonoBehaviour
{
    // Inspector'da atanacak alanlar
    public GameObject objectToClose; // Kapatýlacak GameObject
    public GameObject objectToOpen;  // Açýlacak GameObject

    // Bu fonksiyon, buton tarafýndan çaðrýlýr
    public void Toggle()
    {
        // Eðer kapatýlacak obje atanmýþsa, kapat
        if (objectToClose != null)
        {
            objectToClose.SetActive(false);
        }

        // Eðer açýlacak obje atanmýþsa, aç
        if (objectToOpen != null)
        {
            objectToOpen.SetActive(true);
        }
    }
}