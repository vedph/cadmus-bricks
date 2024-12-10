# Historical Date

🧱 A historical datatation expressed as century or year, with the addition of some typical metadata: span years, level of uncertainty, chronological range or point.

The datation is expressed as 1 or 2 points on a timeline: with 1 point you have a punctual datation (whether it's approximate or not); with 2 points you have a range datation, corresponding to an interval, or to a terminus ante or post.

The historical date model contains points A and B, both of type `Datation`:

- when A is defined and B is null, it's a point;
- when A is defined and B undefined, it's a terminus post quem;
- when B is defined and A undefined, it's a terminus ante quem;
- when both A and B are defined, it's an interval.

- a* (🧱 `Datation`):
  - value* (`int`): the numeric value of the point. Its interpretation depends on other points properties: it may represent a year or a century, or a span between two consecutive Gregorian years.
  - isCentury (`boolean`): true if value is a century number; false if it's a Gregorian year.
  - isSpan (`boolean`): true if the value is the first year of a pair of two consecutive years. This is used for calendars which span across two Gregorian years, e.g. 776/5 BC.
  - month (`short`): the month number (1-12) or 0.
  - day (`short`): the day number (1-31) or 0.
  - isApproximate (`boolean`): true if the point is approximate ("about").
  - isDubious (`boolean`): true if the point is dubious ("perhaphs").
  - hint (`string`): a short textual hint used to better explain or motivate the datation point.
- b (🧱 `Datation`)
