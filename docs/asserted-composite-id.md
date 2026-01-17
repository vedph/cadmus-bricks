# Asserted Composite ID

🧱 An external or internal identifier coupled with an assertion.

- target (`PinTarget`): pin-based target ID:
  - gid (`string`): global ID.
  - label (`string`): human-friendly label.
  - itemId (`string`): item ID.
  - partId (`string`): part ID.
  - partTypeId (`string`): part type ID.
  - roleId (`string`): part role ID.
  - name (`string`): pin name.
  - value (`string`): pin value.
- scope (`string` 📚 `asserted-id-scopes`): optional ID scope.
- tag (`string` 📚 `asserted-id-tags`): optional tag.
- features (`string[]`, 📚 `asserted-id-features`, hierarchical): optional features of the link.
- note (`string`): optional note about the link.
- assertion (🧱 [Assertion](assertion.md))
