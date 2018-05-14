# DotNet-Homework

###tested in Postman###

### Car: ###

http://localhost:xxxxx/cars/getallars - *show all cars*

http://localhost:19304cars/addcar (id, amount, key)* -  *add new car on the parking lot*

http://localhost:19304/cars/deletecar (id)* - *delete car by id*

http://localhost:19304/cars/getcar/{id} - *show car info by id*

### Parking: ###

http://localhost:19304/Parking/getfreespaces - *show number of free spaces in parking lot*

http://localhost:19304/Parking/getnumberofcars - *show number of cars*

http://localhost:19304/Parking/getparkingbalance - *show Parking earnings*

### Transactions: ###
http://localhost:19304/Transactions/gettransactionlog - *show transactions log file*

http://localhost:19304/Transactions/getlastminutetransactions - *show last minute transactions (all cars)*

http://localhost:19304/Transactions/getLastminuteTransactionsbyId/{id} - *show last minute car transactio(by id)*

http://localhost:19304/Transactions/addcarmoney *(id, value)**

"*" **means keys in a postman**

