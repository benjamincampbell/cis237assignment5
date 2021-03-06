﻿//Author: David Barnes
//CIS 237
//Assignment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection : IWineCollection
    {
        //Private Variables
        FullBeverage[] beverages;
        int wineItemsLength;

        //Constuctor. Must pass the size of the collection.
        public WineItemCollection(int size)
        {
            beverages = new FullBeverage[size];
            wineItemsLength = 0;
        }

        //Add a new item to the collection
        public void AddNewItem(string id, string description, string pack)
        {
            //Add a new WineItem to the collection. Increase the Length variable.
            FullBeverage bevToAdd = new FullBeverage();
            bevToAdd.id = id;
            bevToAdd.name = description;
            bevToAdd.pack = pack;
            beverages[wineItemsLength] = bevToAdd;
            wineItemsLength++;
        }
        
        //Get The Print String Array For All Items
        public string[] GetPrintStringsForAllItems()
        {
            //Create and array to hold all of the printed strings
            string[] allItemStrings = new string[wineItemsLength];
            //set a counter to be used
            int counter = 0;

            //If the wineItemsLength is greater than 0, create the array of strings
            if (wineItemsLength > 0)
            {
                //For each item in the collection
                foreach (Beverage wineItem in beverages)
                {
                    //if the current item is not null.
                    if (wineItem != null)
                    {
                        //Add the results of calling ToString on the item to the string array.
                        allItemStrings[counter] = wineItem.ToString();
                        counter++;
                    }
                }
            }
            //Return the array of item strings
            return allItemStrings;
        }

        //Find an item by it's Id
        public string FindById(string id)
        {
            //Declare return string for the possible found item
            string returnString = null;

            //For each WineItem in wineItems
            foreach (FullBeverage wineItem in beverages)
            {
                //If the wineItem is not null
                if (wineItem != null)
                {
                    //if the wineItem Id is the same as the search id
                    if (wineItem.id == id)
                    {
                        //Set the return string to the result of the wineItem's ToString method
                        returnString = wineItem.ToString();
                    }
                }
            }
            //Return the returnString
            return returnString;
        }

        public void Overwrite(string query, string id, string description, string pack)
        { //Method to overwrite an item at a certain ID
            //Fill out the information for the new item
            FullBeverage replacement = new FullBeverage();
            replacement.id = id;
            replacement.name = description;
            replacement.pack = pack;

            int i = 0;
            bool found = false;

            while (!found)
            {//This method just finds the index of the beverages array that the item to replace is at
                if (beverages[i].id == query)
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }

            //And finally we actually replace the item
            beverages[i] = replacement;
        }

        public void Delete(string query)
        {//Method to delete an item at a certain index
            int i = 0;
            bool found = false;

            while (!found)
            {//This just finds the index the item to delete is at.
                if (beverages[i].id == query)
                {
                    found = true;
                }
                else
                {
                    i++;
                }
            }

            for (int k = i; k < wineItemsLength; k++)
            {//This loop starts at the item we are deleting, and replaces each index with the one that comes after it.
                //So 5 gets replaced by 6, 6 by 7, and so on, if we were deleting 5, leaving 1 2 3 4 6 7
                beverages[k] = beverages[k + 1];
            }
        }

    }
}
