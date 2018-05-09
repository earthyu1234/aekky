using UnityEngine;
using UnityEngine.UI;

public class picchange : MonoBehaviour
{
    public Sprite spriteToChangeTo;

    public void ChangeImage(Image myImageToUpdate)
    {
        myImageToUpdate.sprite = spriteToChangeTo;
    }
}
