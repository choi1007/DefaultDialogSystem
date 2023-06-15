using UnityEngine;
using UnityEngine.UI;

public class TestMainMenu : MonoBehaviour
{
    [SerializeField] private Text DialogSliderCountText;
    [SerializeField] private Slider DialogSlider;

    public void OnClickDialgOpen()
    {
        int SliderCount = (int)DialogSlider.value;

        for(int i = 0; i < SliderCount; ++i)
        {
            TestDialog.DoModal();
        }
    }

    public void SliderCount() => DialogSliderCountText.text = $"DialogCount {DialogSlider.value.ToString()}";
}
