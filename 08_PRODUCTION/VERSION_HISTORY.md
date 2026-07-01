# ROOTS — VERSION HISTORY

## Purpose

This document records every significant change made during the development of ROOTS. A version should represent a stable snapshot of the project, and the version history provides a complete record of the project's evolution.

---

## Versioning Philosophy

Every important update must be documented. Never modify previous version entries. Always create a new version entry.

---

## Version Format

Use Semantic Versioning:

```text
Major.Minor.Patch
```

Example:

```text
0.1.0
0.2.0
0.2.1
1.0.0
```

---

## Version Types

### Major

Large project milestones.

Examples:

- New Chapter
- Major Gameplay Systems
- Release Candidate
- Version 1.0

### Minor

New features.

Examples:

- Dialogue System
- Inventory Improvements
- New Environment
- Additional NPCs

### Patch

Bug fixes and small improvements.

Examples:

- Fixed Save Bug
- UI Fixes
- Audio Improvements
- Performance Fixes

---

## Version Entry Template

### Version

Example: 0.2.0

### Release Date

YYYY-MM-DD

### Status

- Development
- Testing
- Release Candidate
- Released

### Summary

Brief description of the update.

### Added

List all new features.

Example:

- Inventory System
- Door Interaction
- Dialogue UI

### Improved

List improvements.

Example:

- Better AI Navigation
- Faster Loading
- Cleaner UI

### Fixed

List resolved bugs.

Example:

- Save corruption
- Camera clipping
- Missing dialogue

### Removed

Document removed systems or features.

Example:

- Deprecated interaction logic
- Old inventory prototype

### Known Issues

Document important remaining problems.

Example:

- Minor lighting artifacts
- NPC pathfinding occasionally fails

### Notes

Additional development information.

---

## Milestone Mapping

Each version should reference its milestone.

Example:

- Version: 0.4.0
- Milestone: Vertical Slice

---

## Release Rules

Before creating a new version:

- Project builds successfully.
- Critical bugs resolved.
- Documentation updated.
- Version number increased correctly.
- Backup created.

---

## Example Timeline

```text
0.1.0  Project Setup
0.2.0  Core Gameplay
0.3.0  World Prototype
0.4.0  Vertical Slice
0.5.0  Full Production
0.9.0  Release Candidate
1.0.0  Official Release
```

---

## Final Rule

Every meaningful change should be reflected in the version history. A complete version history makes development traceable, organized, and easier to maintain throughout the entire lifecycle of ROOTS.
