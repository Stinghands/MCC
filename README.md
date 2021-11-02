# MCC

A payment system where a user has an account with a balance, and they can see payment requests.

## Getting Started

These instructions will give you a copy of the project up and running on
your local machine for development and testing purposes

### Prerequisites

Requirements for the software and other tools to build and test
- [Visual Studio](https://visualstudio.microsoft.com/vs/) 
- [Postman](https://www.postman.com/downloads/) or Web Browser


### Installing
Clone the project
 
    git clone https://github.com/Stinghands/MCC.git


You can run the project by using visual studio or in command prompt

Run the project

    By running the solution and click run button in visual studio

Or by using command prompt but make sure you are in the correct project folder "MCC"

    dotnet run


## Testing
I used in memory data store and seeded User and Payment with these id with its balances and list of payments
   
    id:1
    id:2
    id:3
   

### Sample Tests
For this test we will just use "id" to get the required response 
- use your port number
- try changing <id> from id's above



To get the user account balance 

    https://localhost:<port>/api/Users/<id>

Example 

    https://localhost:44342/api/Users/1
    https://localhost:5001/api/Users/1


To get the user payment list

    https://localhost:<port>/api/Payment/<id>

Example 

    https://localhost:44342/api/Payment/1
    https://localhost:5001/api/Payment/1

Or you can use the swaggerUI to test the api



### Security
We can can add more security by

- Validating input types
- Adding authentication 
- Adding token
- Limiting api call per account for ddos
- Remove unnecessary data

### 


## Authors

  - **Roland Roy Manuel** 




