using Microsoft.MixedReality.Toolkit.Core.Definitions.InputSystem;
using Microsoft.MixedReality.Toolkit.Core.EventDatum.Input;
using Microsoft.MixedReality.Toolkit.Core.Interfaces.InputSystem.Handlers;
using Microsoft.MixedReality.Toolkit.SDK.Input.Handlers;
using UnityEngine;

public class TestAirTap : BaseInputHandler, IMixedRealityInputHandler
{
    [SerializeField]
    private MixedRealityInputAction[] listenedActions;

    #region Mixed Reality Inputs

    public void OnInputUp(InputEventData eventData)
    {
    }

    public void OnInputDown(InputEventData eventData)
    {
        foreach (var action in listenedActions)
        {
            if (eventData.MixedRealityInputAction == action)
            {
                Debug.LogFormat("HoloLensInputHandler - OnInputDown: {0} detected", action.Description);
            }
        }
    }

    public void OnInputPressed(InputEventData<float> eventData)
    {
    }

    public void OnPositionInputChanged(InputEventData<Vector2> eventData)
    {
    }

    #endregion
}
