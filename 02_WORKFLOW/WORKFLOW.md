# ROOTS — AI WORKFLOW

Version: 1.1
Status: Draft
Author: ROOTS Project Documentation
Last Updated: 2026-07-01

---

# Purpose

This document defines how every AI agent collaborates without conflicts.

---

# Global Pipeline

Producer

↓

Creates task

↓

Assigns task

↓

Agent reads Master Bible

↓

Agent reads Project Rules

↓

Agent reads task

↓

Agent produces output

↓

QA reviews output

↓

Producer approves

↓

Merge into project

↓

Git commit

---

# Agent Execution Order

1. Producer
2. Story
3. Gameplay
4. Unity
5. Level Design
6. Environment
7. 3D Artist
8. Pixel Artist
9. UI
10. Audio
11. Optimizer
12. QA

---

# Before Starting Any Task

Every agent must:

* Read the Master Bible
* Read Project Rules
* Read its own agent prompt
* Read the assigned task
* Read any referenced files

---

# During Execution

Each agent must:

* Stay within task scope
* Produce deterministic output
* Follow project standards
* Keep naming consistent
* Never edit unrelated files

---

# After Execution

Each agent must return:

* Summary
* Files created
* Files modified
* Issues found
* Suggestions (optional)

---

# QA Workflow

QA verifies:

* Scope is respected
* Rules are respected
* No conflicts exist
* No duplicate work exists
* Naming is correct
* The output is ready for merge

If verification fails, return the task to the original agent.

If verification passes, send the task to the Producer.

---

# Producer Responsibilities

* Create tasks
* Assign agents
* Review output
* Approve changes
* Reject low-quality work
* Maintain project consistency

---

# Conflict Resolution

If two agents modify the same file:

1. Stop the merge.
2. Notify the Producer.
3. Compare outputs.
4. Keep the best solution.
5. Reject conflicting changes.

---

# Version Control

Every completed task must include:

* Task ID
* Agent name
* Version
* Date
* Status
* Changed files

---

# Task Status

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

COMPLETED

---

# Master Rule

No agent is allowed to skip this workflow. Every task follows the same pipeline from assignment to approval.
