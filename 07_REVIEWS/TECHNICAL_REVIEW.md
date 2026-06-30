ROOTS_DIRECTOR/07_REVIEWS/TECHNICAL_REVIEW.md
ROOTS — TECHNICAL REVIEW
Version: 1.0
Status: Active

PURPOSE
Review every script, system, prefab or technical implementation before it is accepted into the ROOTS project.
This review ensures all code and Unity implementations are clean, stable, maintainable and consistent with the project's technical standards.

REVIEW INFORMATION
Review ID
Reviewer
Date
Unity Programmer / AI Agent
Task ID
System / Script Reviewed
Version

REVIEW CHECKLIST
Code Quality

Follows Coding Standard.
Clear and readable naming.
No duplicated logic.
No dead code.
Proper comments where needed.

PASS / FAIL

Architecture

Follows project structure.
Correct use of Managers.
Correct use of ScriptableObjects.
No unnecessary dependencies.
No tight coupling between unrelated systems.

PASS / FAIL

Functionality

Feature works as intended.
Matches Game Design Document.
Matches System documentation.
No missing edge cases.
No incorrect logic.

PASS / FAIL

Stability

No null reference errors.
No unhandled exceptions.
No race conditions.
No broken references.
Stable across scene reloads.

PASS / FAIL

Save / Load Compatibility

Data serializes correctly.
No save corruption.
Backward compatible (if applicable).
No missing save fields.

PASS / FAIL

Performance

No unnecessary Update() calls.
No expensive operations per frame.
No unnecessary allocations.
Efficient use of Coroutines/Events.
No GC spikes introduced.

PASS / FAIL

Unity Integration

No missing references.
No console errors or warnings.
Correct use of Prefabs.
Correct use of Scenes.
Inspector fields properly exposed.

PASS / FAIL

Folder & Naming Standards

File placed in correct folder.
Naming Standard followed.
Script Standard followed.
Namespace (if used) is consistent.

PASS / FAIL

Documentation

System documented.
Public methods explained.
Dependencies listed.
Known limitations noted.

PASS / FAIL

ISSUES FOUND
Critical
High
Medium
Low
Describe each issue clearly.

IMPROVEMENTS
List optional improvements.
Do not expand project scope.

FINAL RESULT
APPROVED
CHANGES REQUESTED
REJECTED

REVIEW SCORE
Overall Score
__/100

FILES REVIEWED
List all reviewed scripts, systems or prefabs.

REVIEWER NOTES
Additional observations.

APPROVAL
Reviewer
Date
Signature (if applicable)

MASTER RULE
No script, system or technical implementation may be approved unless it is stable, performant, well-structured, properly documented, and fully consistent with the project's technical standards.