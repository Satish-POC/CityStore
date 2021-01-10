# CityShop

 ### This project is built with few assumptions.
  * Future user stories would be about writing the product or oder objects back to the server.
  * Placing an order might be very different kind of interaction  e.g. writing to a differeent database.


### Desgin consideration
  1. CQRS Pattern - Since read and write may happen on different data store. However code only has query pattern implemented.
  2. MediatR is used to reduce coupling and seperation of concern
  3. Controller is kept as thin as possible.
  4. Angular (v10) app is used for the front end.
  5. There is only one unit test written. More tests can be written based on the requirements.
  6. Unit test is written randomly without setting full framework for brevity.
 
