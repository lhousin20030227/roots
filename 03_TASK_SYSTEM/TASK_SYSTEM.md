# ROOTS — TASK SYSTEM

Version: 1.1
Status: Draft
Author: ROOTS Project Documentation
Last Updated: 2026-07-01

---

# Purpose

Every task must follow the same structure.

Agents execute tasks.

The Producer creates tasks.

QA validates tasks.

---

# Task Lifecycle

BACKLOG

↓

TODO

↓

IN_PROGRESS

↓

REVIEW

↓

APPROVED

↓

MERGED

↓

DONE

---

# Task ID Format

TASK-0001

TASK-0002

TASK-0003

...

---

# Task Priority

P0 = Critical

P1 = High

P2 = Medium

P3 = Low

---

# Task Types

STORY

GAMEPLAY

UNITY

LEVEL

ENVIRONMENT

UI

AUDIO

ART

3D

PIXEL

QA

OPTIMIZATION

DOCUMENTATION

---

# Task Template

Task ID:

Title:

Category:

Priority:

Assigned Agent:

Dependencies:

Estimated Difficulty:

---

## Objective

What must be completed.

---

## Input

Files to read.

Required context.

---

## Output

Files to create.

Files to modify.

Expected deliverables.

---

## Restrictions

Files that cannot be edited.

Rules that cannot be broken.

---

## Acceptance Criteria

Objective completed.

No conflicts.

Naming respected.

Project rules respected.

Ready for QA.

---

## Deliverables

Created Files

Modified Files

Summary

Known Issues

Suggestions (optional)

---

# Agent Limits

One task.

One objective.

One responsibility.

No multitasking.

---

# Task Size

Maximum:

One logical feature.

If larger:

Split into multiple tasks.

---

# Dependencies

A task cannot start until all required tasks are completed.

---

# Producer Rules

Only the Producer may:

* Create tasks
* Assign tasks
* Approve tasks
* Close tasks
* Reopen tasks

---

# QA Rules

QA may:

* Approve
* Reject
* Request changes
* Never modify the implementation directly

---

# Master Rule

Every piece of work in ROOTS must belong to exactly one task.
