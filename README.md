# Assignment 5 - Update the Assignment 1 with Wines to use a database instead of a CSV

## Due 11-24-2015

## Author
Benjamin M. Campbell

## Description

Either modify what I have in my Asignment1 key, which is included here, or bring in your files and use that to do the work.

You are going to take the Assignment 1 we did with the Wine List .CSV and update it to work with a database in place of the CSV. In addition, the UI must be updated to accomodate some new fields for a Wine Item.

The program should continually run until the user decides to exit (entering a certain character on the keyboard). The program should allow the following functionality:

1. Allow the user to load the wine list from the database.
2. Allow the user to print the entire list of items.
3. Allow the user to search for an item by the item id, and print out the item if found. Error message if not.
4. Allow the user to add a new wine item to the list.
5. Allow the user to update an existing wine item.
6. Allow the user to delete a wine item.

Update the basic class called WineItem to be an Entity Framework Model based on the data in the database. We will do an example of this in class.

Update the WineItemCollection to be an Entity Framework collection based on the data in the database. We will do an example of this in class.

Update the class called User Interface to include any new methods that are required to facilitate the above funcitonality.

CSVProcessor can either be removed or left. It will not be used though.

The old WineItem and WineItemCollection can be removed if desired since the Entity Framework versions will be used instead.

To connect to the database you will use the following information.

Sever address / name: barnesbrothers.homeserver.com,443

Sql Server Authentication (Not Windows Auth):

Username: cis237

Password: password

DatabaseName: Beverage + FirstInital + LastName

********************************************************************************************
*NOTE: There is a database for each person. Use the one that is for you. Don't be a troll. If I hear about you trolling on someone elses database, you will get a zero for the assignment!
********************************************************************************************

Solution Requirements:

* 4 classes (Main, WineItem (EF Version), WineItemCollection (EF Version), and UserInterface. The names can differ, and might due to database names and EF setup.)
* EntityFramework Model and Collection
* Read functionality
* Insert functionality
* Update functionality
* Delete functionality
* UI Class to handle I/O

### Notes


## Outside Resources Used

## Known Problems, Issues, And/Or Errors in the Program


