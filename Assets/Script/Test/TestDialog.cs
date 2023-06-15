using UnityEngine;
using UnityEngine.UI;

public class TestDialog : DialogBase
{
    [SerializeField] private Text DialogViewCountText;

    public static TestDialog DoModal()
    {
        TestDialog dialog = Util.GetPrefab<TestDialog>("Prefabs/Dialog/TestDialog");
        dialog.Show();
        return dialog;
    }

    protected override void OnShow()
    {
        DialogViewCountText.text = $"DialogShowCount { (DialogManager.Instance.ShowCount + 1).ToString() }";
    }
}
