using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private PlayerHealth Health;
    [SerializeField] private Image totalhealthBar;
    [SerializeField] private Image CurrenthealthBar;
    void Start()
    {
        totalhealthBar.fillAmount = Health.Currenthealth / 10;
    }

    // Update is called once per frame
    void Update()
    {
        CurrenthealthBar.fillAmount = Health.Currenthealth / 10;
    }
}
