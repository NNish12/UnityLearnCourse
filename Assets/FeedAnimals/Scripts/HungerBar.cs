using UnityEngine;
using UnityEngine.UI;

public class HungerBar : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private int hungry = 3;

    private void Start()
    {
        slider = GetComponentInChildren<Slider>();
        slider.maxValue = hungry;
        slider.value = 0;
    }
    public void DecreaseHungry()
    {
        slider.value++;
        if (slider.value >= slider.maxValue)
        {
            GameManager.IncreaseScore();
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Steak")
        {
            DecreaseHungry();
        }
    }

}
