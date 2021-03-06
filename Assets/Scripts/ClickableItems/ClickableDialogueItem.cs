﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableDialogueItem : MonoBehaviour, IClickInteract
{
    private DialogueTrigger _dialogueTrigger;

    private void Awake()
    {
        _dialogueTrigger = GetComponent<DialogueTrigger>();
    }
    public void OnClick()
    {
        _dialogueTrigger.TriggerDialogue();
    }
}
