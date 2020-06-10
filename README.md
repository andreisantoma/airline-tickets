# airline-tickets
A small school project for an Airline management application written in C# that uses the MVVM architectural pattern and an ORM framework (EF6). The application has 3 types of users:
* Regular users
* Employees
* Admins

The regular user can perform the following operations:
* Search flights by source, destination, duration

The employee can do CRUD on flights at his own company only

The administrator can perform the following operations:
* CRUD on regular users' information.
* CRUD on companies
* Allocating employees on companies. An employee can only be allocated to a single company
* Generate two types of report files, one in pdf format and one in txt format, with the companies & current flights
