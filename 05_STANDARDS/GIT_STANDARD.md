# ROOTS_DIRECTOR/05_STANDARDS/GIT_STANDARD.md

# ROOTS — GIT STANDARD

Version: 1.0

---

# PURPOSE

Define the official Git workflow for the ROOTS project.

Every AI Agent and contributor must follow these rules.

---

# VERSION CONTROL

Git is the only official version control system.

Every change must be committed.

Never work outside Git.

---

# DEFAULT BRANCHES

main

Production-ready code only.

develop

Integration branch.

feature/*

New features.

fix/*

Bug fixes.

hotfix/*

Critical production fixes.

docs/*

Documentation only.

---

# BRANCH NAMING

feature/inventory-system

feature/evidence-board

feature/house-level

fix/save-system

docs/master-bible

hotfix/crash-on-load

Use lowercase.

Separate words with hyphens.

---

# COMMIT FORMAT

[TASK-ID] Short Description

Examples

[TASK-0007] Implement interaction system

[TASK-0014] Add hospital documents

[TASK-0023] Optimize house lighting

Maximum 72 characters.

Use imperative tense.

---

# COMMIT RULES

One logical change per commit.

Never mix unrelated work.

Commit frequently.

Keep commits reversible.

---

# PULL REQUEST RULES

Every Pull Request must include:

Title

Task ID

Summary

Files Changed

Testing Performed

Known Issues

Reviewer

---

# MERGE RULES

Merge only after:

QA Approval

Producer Approval

Successful testing

No unresolved conflicts

---

# CONFLICT RULES

If a merge conflict occurs:

Stop.

Resolve manually.

Never overwrite another contributor's work without review.

Document the resolution.

---

# TAGS

Milestone releases:

v0.1.0

v0.2.0

v0.3.0

Release Candidate:

v1.0.0-rc1

Production:

v1.0.0

Follow Semantic Versioning.

---

# IGNORE FILES

Do not commit:

Library/

Temp/

Logs/

Obj/

Build outputs

IDE cache files

Generated caches

User-specific settings

---

# LARGE FILES

Use Git LFS for:

Large audio files

Large textures

Large models

Videos

Do not commit oversized binaries to normal Git history.

---

# ROLLBACK

If a change breaks the project:

Identify the commit.

Revert safely.

Document the reason.

Do not rewrite shared history.

---

# REVIEW CHECKLIST

Before merging verify:

Project builds successfully.

Naming standards followed.

Documentation updated.

No unnecessary files.

No debug artifacts.

No temporary code.

---

# FORBIDDEN

Direct commits to main.

Force push to shared branches.

Unrelated changes in one commit.

Deleting history.

Committing secrets or API keys.

Committing temporary files.

---

# QUALITY CHECK

Every commit must be:

Traceable.

Atomic.

Reviewable.

Reversible.

Documented.

---

# MASTER RULE

If a commit cannot be understood by reading its message and Task ID alone, it is not acceptable for the ROOTS project.
