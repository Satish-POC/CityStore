# CityShop

 ### This project is built with few assumptions.
  * We may need to write more user stories in the future.
  * Future user stories would be about writing the product or oder objects back to the server.
  * Placing an order might be very different kind of interaction  e.g. writing to a differeent database.


### Desgin consideration
  1. CQRS Pattern - Since read and write may happen on different data store. However code only has query pattern implemented.
  2. MediatR is used to reduce coupling and seperation of concern
  3. Controller is kept as thin as possible.
  4. Angular (v10) app is used for the front end.
  5. There is only one unit test written. More tests can be written based on the requirements.
  6. Values have been hardcoded. E.g. API endpoints, api key. In real scenario, those values will come from secure key stores like Azure Key-Vault. On dev environment they can be stored as local user secrets. 
  
#### This codebase was tested successfully on system with the following specifications
  * Visual Studio Community 2019 (v16.5.4)
  * dotnet 3.1

  
