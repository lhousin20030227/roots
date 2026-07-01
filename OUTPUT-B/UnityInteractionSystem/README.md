# ROOTS Unity Interaction System

This package provides a reusable interaction framework for the ROOTS project.

## Included

- A central interaction manager that detects nearby interactables
- A reusable base interactable component
- UI prompt support for interaction hints
- Example interactable types for pickups, doors, and readable objects
- A minimal example script for wiring the system to a player

## How to use

1. Import the package into Unity.
2. Add the InteractionManager component to the player object.
3. Add the InteractionPromptUI component to your HUD canvas.
4. Attach interactable components to world objects.
5. Configure prompts and behavior in the Inspector.

## Notes

The system is intentionally modular so it can be expanded with inventory, puzzle, and dialogue logic later without changing the core interaction flow.
