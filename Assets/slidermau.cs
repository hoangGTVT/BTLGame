using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class slidermau : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public GameObject player; // ??t gameobject ch?a thanh m?u v?o ??y

    private void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1f, 0);
    }
    public void setmaxmau(float mau)
    {
        slider.value = mau;
        slider.maxValue = mau;
    }
    public void setmau(float mau)
    {
        slider.value = mau;
        
    }
    


}
