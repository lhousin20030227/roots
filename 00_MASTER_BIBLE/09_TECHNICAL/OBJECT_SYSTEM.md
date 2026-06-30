OBJECT SYSTEM
Purpose
The Object System defines how interactive and static objects exist, behave, and respond inside the world of ROOTS.
Every object should feel grounded, purposeful, and consistent with the world it belongs to.

Object Philosophy
Objects are not decorations only — they are pieces of evidence, story, and atmosphere.
Every object placed in the world must serve at least one purpose:

Story relevance
Evidence
Puzzle requirement
Environmental storytelling
Atmosphere reinforcement

No object exists without reason.

Object Categories
Static Objects
Objects that cannot be interacted with directly.
Examples:

Furniture (non-interactive)
Wall decorations
Background props

They exist purely for realism and atmosphere.

Interactive Objects
Objects the player can interact with in some way.
Examples:

Doors, drawers, cabinets
Light switches
Documents, letters, photographs
Audio devices

Each interactive object must define what interactions are allowed (Inspect, Pick Up, Use, Read, Listen).

Evidence Objects
Objects that are part of the investigation.
Examples:

Letters
Photographs
Personal belongings
Official documents
Audio recordings

Evidence objects are automatically registered in the Evidence Board / Inventory when collected.

Puzzle Objects
Objects required to solve a puzzle.
Examples:

Keys
Codes
Tools
Mechanisms

Puzzle objects only function within their intended logical context.

Container Objects
Objects that can hold other objects.
Examples:

Drawers
Cabinets
Boxes
Safes

Containers may be locked, requiring a key, code, or story progress.

Object States
Every object may have one or more states:

Default
Inspected
Collected
Used
Opened / Closed
Locked / Unlocked

States must persist correctly through Save / Load.

Object Placement Rules

Every object must have a logical reason to exist in its location.
Object scale must be realistic.
Object placement must not block player movement unintentionally.
Objects must not overlap or clip visually.
High-detail objects are prioritized near player interaction points.


Object Metadata
Each object should define:

Object ID
Object Name
Object Type (Static / Interactive / Evidence / Puzzle / Container)
Allowed Interactions
Associated Story Flag (if applicable)


Performance Rules

Static objects use simplified colliders.
Distant objects use LOD or culling.
Interactive objects are checked only when in range.
Object instancing is used for repeated props.


Forbidden Features
Do not include:

Objects with no purpose or context.
Floating or unanchored objects.
Interactive objects that do nothing.
Objects that break realism without narrative reason.
Random loot-style item placement.


Final Rule
Every object in ROOTS exists because it belongs there.
It should either support the story, support gameplay, or reinforce the feeling that this is a real place where real people once lived.