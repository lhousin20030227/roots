# ROOTS — BUG TRACKER

## Purpose

This document tracks every bug discovered during the development of ROOTS. A bug should never be fixed without first being documented. Every issue must be reproducible, assigned, and verified before being closed.

---

## Bug Philosophy

A bug is not considered fixed until it has been tested successfully. Temporary fixes should never be marked as completed.

---

## Bug Severity

### Critical

Blocks gameplay or causes crashes.

Examples:

- Game crashes
- Save corruption
- Infinite loading
- Player cannot progress

### High

Major gameplay issue.

Examples:

- Broken dialogue
- Missing objectives
- Inventory failure
- AI not functioning

### Medium

Noticeable but not game-breaking.

Examples:

- Animation glitches
- Audio issues
- UI overlap
- Incorrect interactions

### Low

Minor visual or cosmetic issues.

Examples:

- Texture seams
- Lighting inconsistencies
- Typographical errors
- Small visual artifacts

---

## Bug Status

- New
- Confirmed
- Assigned
- In Progress
- Ready for Testing
- Verified
- Closed
- Reopened

---

## Bug Template

### Bug ID

Example: BUG-001

### Title

Example: Player falls through floor after loading save.

### Severity

Critical

### Status

New

### Assigned To

Example:

- UNITY Agent
- QA Agent
- Developer

### Location

Example:

- Chapter 01
- Family House
- Kitchen

### Description

Describe exactly what happens.

### Steps to Reproduce

1. Load saved game.
2. Enter kitchen.
3. Walk toward the refrigerator.

### Expected Result

Player remains on the floor.

### Actual Result

Player falls below the map.

### Possible Cause

Optional. Known information that may help debugging.

### Fix Notes

Document the solution after implementation.

### Verification

Describe how the fix was tested.

---

## Bug Management Rules

- One report per bug.
- Never combine multiple issues.
- Verify every report before closing.
- Reopen bugs if the issue returns.
- Prioritize by severity, not discovery date.

---

## QA Checklist

Before closing a bug:

- The issue is no longer reproducible.
- Related systems still function correctly.
- No new bugs were introduced.
- Performance remains stable.
- Documentation is updated if necessary.

---

## Reporting Rules

Every bug report should be:

- Clear
- Reproducible
- Concise
- Objective

Avoid assumptions without evidence.

---

## Final Rule

A bug is not finished when it is fixed. A bug is finished only when it has been verified, documented, and confirmed not to affect the stability or quality of ROOTS.
