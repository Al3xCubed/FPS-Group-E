using UnityEngine;
using UnityEngine.UI;

public class ModdedJetpackCounter : MonoBehaviour
{
    [Tooltip("Image component representing jetpack fuel")]
    public Image jetpackFillImage;
    [Tooltip("Canvas group that contains the whole UI for the jetack")]
    public CanvasGroup mainCanvasGroup;
    [Tooltip("Component to animate the color when empty or full")]
    public FillBarColorChange fillBarColorChange;

    ModdedJetpack m_Jetpack;

    void Awake()
    {
        m_Jetpack = FindObjectOfType<ModdedJetpack>();
        DebugUtility.HandleErrorIfNullFindObject<ModdedJetpack, ModdedJetpackCounter>(m_Jetpack, this);

        fillBarColorChange.Initialize(1f, 0f);
    }

    void Update()
    {
        mainCanvasGroup.gameObject.SetActive(m_Jetpack.isJetpackUnlocked);

        if (m_Jetpack.isJetpackUnlocked)
        {
            jetpackFillImage.fillAmount = m_Jetpack.currentFillRatio;
            fillBarColorChange.UpdateVisual(m_Jetpack.currentFillRatio);
        }
    }
}
