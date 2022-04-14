using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

namespace CyberBuggy.MenuScreenUtils
{
    public class ButtonColorSwitcher : MonoBehaviour, ISelectHandler, IDeselectHandler
    {
        [SerializeField] private Button _targetButton;
        [SerializeField] private TMP_Text _buttonText;

        [SerializeField] private Color _primaryColor = new Color(255, 255, 255, 255);
        [SerializeField] private Color _secondaryColor;
        public void OnSelect(BaseEventData eventData)
        {
            ApplyButtonColors(_secondaryColor, _primaryColor);
        }

        public void OnDeselect(BaseEventData eventData)
        {
            ApplyButtonColors(_primaryColor, _secondaryColor);
        }

        private void OnDisable()
        {
            ApplyButtonColors(_primaryColor, _secondaryColor);
        }
        private void ApplyButtonColors(Color firstColor, Color secondColor)
        {
            _targetButton.targetGraphic.color = firstColor;
            _buttonText.color = secondColor;
        }

        
    }
}
