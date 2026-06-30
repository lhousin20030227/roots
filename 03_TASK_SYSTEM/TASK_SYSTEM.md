# ROOTS_DIRECTOR/03_TASK_SYSTEM/TASK_SYSTEM.md

# ROOTS — TASK SYSTEM

Version: 1.0

---

# PURPOSE

Every task must follow the same structure.

Agents execute Tasks.

Producer creates Tasks.

QA validates Tasks.

---

# TASK LIFECYCLE

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

# TASK ID FORMAT

TASK-0001

TASK-0002

TASK-0003

...

---

# TASK PRIORITY

P0 = Critical

P1 = High

P2 = Medium

P3 = Low

---

# TASK TYPES

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

# TASK TEMPLATE

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

Suggestions (Optional)

---

# AGENT LIMITS

One Task.

One Objective.

One Responsibility.

No multitasking.

---

# TASK SIZE

Maximum:

One logical feature.

If larger:

Split into multiple Tasks.

---

# DEPENDENCIES

A Task cannot start until all required Tasks are completed.

---

# PRODUCER RULES

Only Producer may:

Create Tasks.

Assign Tasks.

Approve Tasks.

Close Tasks.

Reopen Tasks.

---

# QA RULES

QA may:

Approve.

Reject.

Request changes.

Never modify the implementation directly.

---

# MASTER RULE

Every piece of work in ROOTS must belong to exactly one Task.
