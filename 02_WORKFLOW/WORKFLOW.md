# ROOTS_DIRECTOR/02_WORKFLOW/WORKFLOW.md

# ROOTS — AI WORKFLOW

Version: 1.0

---

# PURPOSE

Define how every AI Agent collaborates without conflicts.

---

# GLOBAL PIPELINE

Producer

↓

Creates Task

↓

Assigns Task

↓

Agent Reads MASTER_BIBLE

↓

Agent Reads PROJECT_RULES

↓

Agent Reads Task

↓

Agent Produces Output

↓

QA Reviews Output

↓

Producer Approves

↓

Merge Into Project

↓

Git Commit

---

# AGENT EXECUTION ORDER

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

# BEFORE STARTING ANY TASK

Every Agent must:

* Read MASTER_BIBLE
* Read PROJECT_RULES
* Read its own Agent Prompt
* Read the assigned Task
* Read any referenced files

---

# DURING EXECUTION

Agent must:

* Stay inside task scope
* Produce deterministic output
* Follow project standards
* Keep naming consistent
* Never edit unrelated files

---

# AFTER EXECUTION

Agent must return:

* Summary
* Files Created
* Files Modified
* Issues Found
* Suggestions (optional)

---

# QA WORKFLOW

QA verifies:

* Scope respected
* Rules respected
* No conflicts
* No duplicated work
* Naming correct
* Ready for merge

If failed:

Return to original Agent.

If passed:

Send to Producer.

---

# PRODUCER RESPONSIBILITIES

* Create tasks
* Assign agents
* Review output
* Approve changes
* Reject low-quality work
* Maintain project consistency

---

# CONFLICT RESOLUTION

If two Agents modify the same file:

1. Stop merge.
2. Notify Producer.
3. Compare outputs.
4. Keep the best solution.
5. Reject conflicting changes.

---

# VERSION CONTROL

Every completed task must include:

* Task ID
* Agent Name
* Version
* Date
* Status
* Changed Files

---

# TASK STATUS

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

# MASTER RULE

No Agent is allowed to skip this workflow. Every task follows the same pipeline from assignment to approval.
