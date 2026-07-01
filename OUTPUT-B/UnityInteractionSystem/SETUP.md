# Setup Guide

## Required components

- Add an InteractionManager to the player character.
- Add an InteractionPromptUI to the HUD canvas.
- Add an interactable component such as InspectableInteractable, PickupInteractable, ReadableInteractable, or DoorInteractable to world objects.

## Recommended setup

1. Create a layer for interactable objects.
2. Assign that layer to the InteractionManager detection mask.
3. Make sure the object has a Collider and optionally a Rigidbody.
4. Configure the interaction prompt, range, and priority in the Inspector.

## Notes

This package follows the ROOTS design principles of simple, responsive, story-driven interactions with clear purpose and feedback.
