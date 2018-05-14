# DotNet-Homework

#### Tested in Postman ####

### Car: ###

http://localhost:xxxxx/cars/getallars - *show all cars* **GET**

http://localhost:19304cars/addcar (id, amount, key)* -  *add new car on the parking lot* **POST**

http://localhost:19304/cars/deletecar (id)* - *delete car by id* **DELETE**

http://localhost:19304/cars/getcar/{id} - *show car info by id* **GET**

### Parking: ###

http://localhost:19304/Parking/getfreespaces - *show number of free spaces in parking lot* **GET**

http://localhost:19304/Parking/getnumberofcars - *show number of cars* **GET**

http://localhost:19304/Parking/getparkingbalance - *show Parking earnings* **GET**

### Transactions: ###
http://localhost:19304/Transactions/gettransactionlog - *show transactions log file* **GET**

http://localhost:19304/Transactions/getlastminutetransactions - *show last minute transactions (all cars)* **GET**

http://localhost:19304/Transactions/getLastminuteTransactionsbyId/{id} - *show last minute car transactio(by id)* **GET**

http://localhost:19304/Transactions/addcarmoney *(id, value)** **PUT**

"*" **means keys in a postman**

