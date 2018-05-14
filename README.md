# DotNet-Homework

#### Tested in Postman ####

### Car: ###

http://localhost:xxxxx/cars/getallcars - *show all cars* **GET**

http://localhost:xxxxx/cars/addcar (id, amount, key)* -  *add new car on the parking lot* **POST**

http://localhost:xxxxx/cars/deletecar (id)* - *delete car by id* **DELETE**

http://localhost:xxxxx/cars/getcar/{id} - *show car info by id* **GET**

### Parking: ###

http://localhost:xxxxx/parking/getfreespaces - *show number of free spaces in parking lot* **GET**

http://localhost:xxxxx/parking/getnumberofcars - *show number of cars* **GET**

http://localhost:xxxxx/parking/getparkingbalance - *show Parking earnings* **GET**

### Transactions: ###
http://localhost:xxxxx/transactions/gettransactionlog - *show transactions log file* **GET**

http://localhost:xxxxx/transactions/getlastminutetransactions - *show last minute transactions (all cars)* **GET**

http://localhost:xxxxx/transactions/getLastminuteTransactionsbyId/{id} - *show last minute car transactio(by id)* **GET**

http://localhost:xxxxx/transactions/addcarmoney *(id, value)** **PUT**

"*" **means keys in a postman**

